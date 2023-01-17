using UnityEditor;

namespace RaCoding.GameEvents 
{
    [CustomEditor(typeof(GameEvent<float>), editorForChildClasses: true)]
    public class FloatGameEventEditor : GameEventEditor<float>
    {
        protected override float GetValue()
        {
            return EditorGUILayout.FloatField(1);
        }
    }
}
