using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<char[]>), editorForChildClasses: true)]
    public class CharArrayGameEventEditor : GameEventEditor<char[]>
    {
        protected override char[] GetValue()
        {
            return new char[] {(char)EditorGUILayout.IntField(1)};
        }
    }
}
