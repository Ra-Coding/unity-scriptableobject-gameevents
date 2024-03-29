using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    public class GameEventWindow : EditorWindow
    {
        private static readonly string TAB = "    ";
        private static readonly string PACKAGE_NAMESPACE = "RaCoding.GameEvents";
        private static readonly string UNITYEVENT_CLASS_SUFFIX = "UnityEvent";
        private static readonly string GAMEEVENT_CLASS_SUFFIX = "GameEvent";
        private static readonly string GAMEEVENTLISTENER_CLASS_SUFFIX = "GameEventListener";
        private static readonly string COMPONENTGAMEEVENTLISTENER_CLASS_SUFFIX = "ComponentGameEventListener";
        private static readonly string GAMEEVENTEDITOR_CLASS_SUFFIX = "GameEventEditor";

        private string _newNamespace = "RaCoding.GameEvents";
        private string _newType = "Sprite";
        private string _newTypeNamespace = "UnityEngine";
        private bool _isArray = false;

        private bool _groupEnabled;
        private bool _overrideExistingFiles = false;

        [MenuItem("Window/RaCoding/SO Game Event Creator")]
        static void Init()
        {
            // Get existing open window or if none, make a new one:
            var window = (GameEventWindow)EditorWindow.GetWindow(typeof(GameEventWindow));
            window.Show();
        }

        void OnGUI()
        {
            GUILayout.Label("Base Settings", EditorStyles.boldLabel);
            _newNamespace = EditorGUILayout.TextField("Namespace", _newNamespace);
            _newType = EditorGUILayout.TextField("Type", _newType);
            _newTypeNamespace = EditorGUILayout.TextField("Type Namespace", _newTypeNamespace);
            _isArray = EditorGUILayout.Toggle("Is Array", _isArray);

            _groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", _groupEnabled);
            _overrideExistingFiles = EditorGUILayout.Toggle("Override existing files", _overrideExistingFiles);
            EditorGUILayout.EndToggleGroup();

            GUILayout.Space(10);

            if (GUILayout.Button("Generate"))
            {
                GenerateScripts();
            }
        }

        private string GenerateClassNames(string suffix, bool isArray)
        {
            if (string.IsNullOrEmpty(_newType))
            {
                throw new ArgumentException("Type can not be null or empty!");
            }

            string className = _newType.First().ToString().ToUpper() + _newType[1..];

            if (isArray)
            {
                return className + "Array" + suffix;
            }
            else
            {
                return className + suffix;

            }
        }

        private string GenerateVariableNamesPrefix(string type, bool isArray)
        {
            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentException("Type can not be null or empty!");
            }

            string variablePrefix = type.First().ToString().ToLower() + type[1..];

            if (isArray)
            {
                return variablePrefix + "Array";
            }
            else
            {
                return variablePrefix;

            }
        }

        private string GenerateClassPath(string className)
        {
            return "Assets/" + className + ".cs";
        }

        private void GenerateScripts()
        {
            Debug.Log("Generating scripts...");

            // class names
            string unityEventClassName = GenerateClassNames(UNITYEVENT_CLASS_SUFFIX, _isArray);
            string gameeventClassName = GenerateClassNames(GAMEEVENT_CLASS_SUFFIX, _isArray);
            string eventListenerClassName = GenerateClassNames(GAMEEVENTLISTENER_CLASS_SUFFIX, _isArray);
            string componentEventListenerClassName = GenerateClassNames(COMPONENTGAMEEVENTLISTENER_CLASS_SUFFIX, _isArray);
            string gameeventEditorClassName = GenerateClassNames(GAMEEVENTEDITOR_CLASS_SUFFIX, _isArray);

            // class paths
            string unityEventClassPath = GenerateClassPath(unityEventClassName);
            string gameeventClassPath = GenerateClassPath(gameeventClassName);
            string eventListenerClassPath = GenerateClassPath(eventListenerClassName);
            string componentEventListenerClassPath = GenerateClassPath(componentEventListenerClassName);
            string gameeventEditorClassPath = GenerateClassPath(gameeventEditorClassName);

            if (CheckFilesGeneration(new string[] {unityEventClassPath, gameeventClassPath, eventListenerClassPath,
                                    componentEventListenerClassPath, gameeventEditorClassPath}))
            {
                string type = _newType;
                if (_isArray)
                {
                    type += "[]";
                }

                GenerateUnityEvent(unityEventClassName, type, unityEventClassPath);
                GenerateGameEvent(gameeventClassName, type, gameeventClassPath);
                GenerateGameEventListener(eventListenerClassName, type, GenerateVariableNamesPrefix(_newType, _isArray),
                                        unityEventClassName, gameeventClassName, eventListenerClassPath);
                GenerateComponentGameEventListener(componentEventListenerClassName, type,
                                                eventListenerClassName, componentEventListenerClassPath);
                GenerateGameEventEditor(gameeventEditorClassName, type, gameeventEditorClassPath, _isArray);
            }
            else
            {
                Debug.LogError("Could not generate files because they already exist!");
            }

            AssetDatabase.Refresh();
        }

        // returns true if files can be generated
        private bool CheckFilesGeneration(string[] classPath)
        {
            bool doesFileExist;
            for (int i = 0; i < classPath.Length; i++)
            {
                doesFileExist = File.Exists(classPath[i]);
                if (doesFileExist == true && _overrideExistingFiles == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void GenerateUnityEvent(string className, string type, string classPath)
        {
            Debug.Log("Writing UnityEvent classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine.Events;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false)
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[System.Serializable]");
            outfile.WriteLine(TAB + "public class " + className + " : UnityEvent<" + type + "> {}");
            outfile.WriteLine("}");
        }

        private void GenerateGameEvent(string className, string type, string classPath)
        {
            Debug.Log("Writing GameEvent classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.GameEvents;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[CreateAssetMenu(fileName = \"" + className + "\"," +
                                " menuName = \"RaCoding/GameEvent/" + AddArrayPath(_isArray) + "Create new " + type + " game event\")]");
            outfile.WriteLine(TAB + "public class " + className + " : GameEvent<" + type + "> {}");
            outfile.WriteLine("}");
        }

        private void GenerateGameEventListener(string className, string type, string variableNamePrefix, 
                                            string unityeventName, string gameeventName, string classPath)
        {
            Debug.Log("Writing GameEventListener classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine;");
            outfile.WriteLine("using UnityEngine.Events;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.GameEvents;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[System.Serializable]");
            outfile.WriteLine(TAB + "public class " + className + " : GameEventListener<" + type + ">");
            outfile.WriteLine(TAB + "{");
            outfile.WriteLine(TAB + TAB + "public " + className + "() : base() {}");
            outfile.WriteLine("");
            outfile.WriteLine(TAB + TAB + "public " + className + "(IRegisterListener registerListener) : base(registerListener) {}");
            outfile.WriteLine("");
            outfile.WriteLine(TAB + TAB + "[SerializeField] private " + gameeventName + " " + variableNamePrefix + "Event;");
            outfile.WriteLine(TAB + TAB + "[SerializeField] private " + unityeventName + " " + variableNamePrefix + "Response;");
            outfile.WriteLine("");
            outfile.WriteLine(TAB + TAB + "public override GameEvent<" + type + "> Event => " + variableNamePrefix + "Event; ");
            outfile.WriteLine(TAB + TAB + "public override UnityEvent<" + type + "> Response => " + variableNamePrefix + "Response; ");
            outfile.WriteLine(TAB + "}");
            outfile.WriteLine("}");
        }

        private void GenerateComponentGameEventListener(string className, string type, string eventListenerClassName, string classPath)
        {
            Debug.Log("Writing ComponentGameEventListener classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.GameEvents;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[AddComponentMenu(\"RaCoding/GameEvents/" + AddArrayPath(_isArray) + eventListenerClassName + "\")]");
            outfile.WriteLine(TAB + "public class " + className + " : ComponentGameEventListener<" + eventListenerClassName + ", " + type + "> {}");
            outfile.WriteLine("}");
        }

        private void GenerateGameEventEditor(string className, string type, string classPath, bool isArray)
        {
            Debug.Log("Writing GameEventEditor classfile...");

            using StreamWriter outfile = new(classPath);
            outfile.WriteLine("using UnityEditor;");
            outfile.WriteLine("using UnityEngine;");
            if (string.IsNullOrEmpty(_newTypeNamespace) == false
                && _newTypeNamespace != "UnityEngine")
            {
                outfile.WriteLine("using " + _newTypeNamespace + ";");
            }
            if (_newNamespace != PACKAGE_NAMESPACE)
            {
                outfile.WriteLine("using RaCoding.GameEvents;");
            }
            outfile.WriteLine("");
            outfile.WriteLine("namespace " + _newNamespace);
            outfile.WriteLine("{");
            outfile.WriteLine(TAB + "[CustomEditor(typeof(GameEvent<" + type + ">), editorForChildClasses: true)]");
            outfile.WriteLine(TAB + "public class " + className + " : GameEventEditor<" + type + ">");
            outfile.WriteLine(TAB + "{");
            outfile.WriteLine(TAB + TAB + "public Object source;");
            outfile.WriteLine("");
            outfile.WriteLine(TAB + TAB + "protected override " + type + " GetValue()");
            outfile.WriteLine(TAB + TAB + "{");

            if (isArray)
            {
                outfile.WriteLine(TAB + TAB + TAB + "return new " + type + " {EditorGUILayout.ObjectField(source, typeof(Object), true) as " + _newType + "};");
            }
            else
            {
                outfile.WriteLine(TAB + TAB + TAB + "return EditorGUILayout.ObjectField(source, typeof(Object), true) as " + _newType + ";");
            }
            
            outfile.WriteLine(TAB + TAB + "}");
            outfile.WriteLine(TAB + "}");
            outfile.WriteLine("}");
        }

        private string AddArrayPath(bool isArray)
        {
            if (isArray)
            {
                return "Array/";
            }
            return "";
        }
    }
}
