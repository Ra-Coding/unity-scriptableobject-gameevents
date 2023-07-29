using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector3>), editorForChildClasses: true)]
    public class Vector3GameEventEditor : GameEventEditor<Vector3>
    {
        protected override Vector3 GetValue()
        {
            return EditorGUILayout.Vector3Field("Vector3", new Vector3(1, 1, 1));
        }
    }
}