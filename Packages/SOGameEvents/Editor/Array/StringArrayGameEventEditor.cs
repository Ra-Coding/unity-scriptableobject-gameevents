using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<string[]>), editorForChildClasses: true)]
    public class StringArrayGameEventEditor : GameEventEditor<string[]>
    {
        protected override string[] GetValue()
        {
            return new string[] {EditorGUILayout.TextField("string")};
        }
    }
}
