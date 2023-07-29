using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<uint[]>), editorForChildClasses: true)]
    public class UIntArrayGameEventEditor : GameEventEditor<uint[]>
    {
        protected override uint[] GetValue()
        {
            return new uint[] {(uint)EditorGUILayout.IntField(1)};
        }
    }
}
