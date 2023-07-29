using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<bool[]>), editorForChildClasses: true)]
    public class BoolArrayGameEventEditor : GameEventEditor<bool[]>
    {
        protected override bool[] GetValue()
        {
            return new bool[] {EditorGUILayout.Toggle(false)};
        }
    }
}
