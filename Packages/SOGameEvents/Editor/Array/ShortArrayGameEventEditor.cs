using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<short[]>), editorForChildClasses: true)]
    public class ShortArrayGameEventEditor : GameEventEditor<short[]>
    {
        protected override short[] GetValue()
        {
            return new short[] {(short)EditorGUILayout.IntField(1)};
        }
    }
}
