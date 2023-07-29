using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<byte>), editorForChildClasses: true)]
    public class ByteGameEventEditor : GameEventEditor<byte>
    {
        protected override byte GetValue()
        {
            return (byte)EditorGUILayout.IntField(1);
        }
    }
}