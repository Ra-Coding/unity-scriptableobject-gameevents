using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector2Int[]>), editorForChildClasses: true)]
    public class Vector2IntArrayGameEventEditor : GameEventEditor<Vector2Int[]>
    {
        protected override Vector2Int[] GetValue()
        {
            return new Vector2Int[] {EditorGUILayout.Vector2IntField("Vector2Int", new Vector2Int(1, 1))};
        }
    }
}
