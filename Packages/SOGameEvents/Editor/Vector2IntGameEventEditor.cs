using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector2Int>), editorForChildClasses: true)]
    public class Vector2IntGameEventEditor : GameEventEditor<Vector2Int>
    {
        public Object source;

        protected override Vector2Int GetValue()
        {
            return EditorGUILayout.Vector2IntField("Vector2Int", new Vector2Int(1, 1));
        }
    }
}