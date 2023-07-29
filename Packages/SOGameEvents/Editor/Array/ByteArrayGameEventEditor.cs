using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<byte[]>), editorForChildClasses: true)]
    public class ByteArrayGameEventEditor : GameEventEditor<byte[]>
    {
        protected override byte[] GetValue()
        {
            return new byte[] {(byte)EditorGUILayout.IntField(1)};
        }
    }
}
