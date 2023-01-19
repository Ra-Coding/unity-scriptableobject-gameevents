using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<sbyte>), editorForChildClasses: true)]
    public class SByteGameEventEditor : GameEventEditor<sbyte>
    {
        protected override sbyte GetValue()
        {
            return (sbyte)EditorGUILayout.IntField(1);
        }
    }
}