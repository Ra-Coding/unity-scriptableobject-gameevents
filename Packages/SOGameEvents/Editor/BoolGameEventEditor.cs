using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<bool>), editorForChildClasses: true)]
    public class BoolGameEventEditor : GameEventEditor<bool>
    {
        protected override bool GetValue()
        {
            return EditorGUILayout.Toggle(false);
        }
    }
}