using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<string>), editorForChildClasses: true)]
    public class StringGameEventEditor : GameEventEditor<string>
    {
        protected override string GetValue()
        {
            return EditorGUILayout.TextField("string");
        }
    }
}