using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<double[]>), editorForChildClasses: true)]
    public class DoubleArrayGameEventEditor : GameEventEditor<double[]>
    {
        protected override double[] GetValue()
        {
            return new double[] {EditorGUILayout.DoubleField(1)};
        }
    }
}
