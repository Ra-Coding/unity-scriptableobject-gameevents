using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<float[]>), editorForChildClasses: true)]
    public class FloatArrayGameEventEditor : GameEventEditor<float[]>
    {
        protected override float[] GetValue()
        {
            return new float[] {EditorGUILayout.FloatField(1)};
        }
    }
}
