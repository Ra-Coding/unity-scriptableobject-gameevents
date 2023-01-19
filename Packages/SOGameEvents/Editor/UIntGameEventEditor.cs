using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<uint>), editorForChildClasses: true)]
    public class UIntGameEventEditor : GameEventEditor<uint>
    {
        protected override uint GetValue()
        {
            return (uint)EditorGUILayout.IntField(1);
        }
    }
}