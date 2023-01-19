using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<ushort>), editorForChildClasses: true)]
    public class UShortGameEventEditor : GameEventEditor<ushort>
    {
        protected override ushort GetValue()
        {
            return (ushort)EditorGUILayout.IntField(1);
        }
    }
}