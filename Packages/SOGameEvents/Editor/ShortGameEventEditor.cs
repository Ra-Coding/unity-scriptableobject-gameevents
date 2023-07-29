using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<short>), editorForChildClasses: true)]
    public class ShortGameEventEditor : GameEventEditor<short>
    {
        protected override short GetValue()
        {
            return (short)EditorGUILayout.IntField(1);
        }
    }
}