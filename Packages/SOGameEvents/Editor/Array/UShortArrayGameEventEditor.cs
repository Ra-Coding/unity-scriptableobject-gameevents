using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<ushort[]>), editorForChildClasses: true)]
    public class UShortArrayGameEventEditor : GameEventEditor<ushort[]>
    {
        protected override ushort[] GetValue()
        {
            return new ushort[] {(ushort)EditorGUILayout.IntField(1)};
        }
    }
}
