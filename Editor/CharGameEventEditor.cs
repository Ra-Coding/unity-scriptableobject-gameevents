using UnityEditor;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<char>), editorForChildClasses: true)]
    public class CharGameEventEditor : GameEventEditor<char>
    {
        protected override char GetValue()
        {
            return (char)EditorGUILayout.IntField(1);
        }
    }
}