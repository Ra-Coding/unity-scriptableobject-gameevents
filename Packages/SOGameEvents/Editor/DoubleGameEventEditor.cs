using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<double>), editorForChildClasses: true)]
    public class DoubleGameEventEditor : GameEventEditor<double>
    {
        protected override double GetValue()
        {
            return EditorGUILayout.DoubleField(1);
        }
    }
}
