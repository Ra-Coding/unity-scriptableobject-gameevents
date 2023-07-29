using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector3Int[]>), editorForChildClasses: true)]
    public class Vector3IntArrayGameEventEditor : GameEventEditor<Vector3Int[]>
    {
        protected override Vector3Int[] GetValue()
        {
            return new Vector3Int[] {EditorGUILayout.Vector3IntField("Vector3Int", new Vector3Int(1, 1, 1))};
        }
    }
}
