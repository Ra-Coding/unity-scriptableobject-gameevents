using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector3Int>), editorForChildClasses: true)]
    public class Vector3IntGameEventEditor : GameEventEditor<Vector3Int>
    {
        public Object source;

        protected override Vector3Int GetValue()
        {
            return EditorGUILayout.Vector3IntField("Vector3Int", new Vector3Int(1, 1, 1));
        }
    }
}