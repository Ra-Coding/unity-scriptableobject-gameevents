using UnityEditor;

namespace RaCoding.GameEvents 
{
    [CustomEditor(typeof(GameEvent<int>), editorForChildClasses: true)]
    public class IntGameEventEditor : GameEventEditor<int>
    {
        protected override int GetValue()
        {
            return EditorGUILayout.IntField(1);
        }
    }
}