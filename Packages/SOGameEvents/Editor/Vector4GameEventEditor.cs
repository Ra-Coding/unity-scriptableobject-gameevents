using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector4>), editorForChildClasses: true)]
    public class Vector4GameEventEditor : GameEventEditor<Vector4>
    {
        protected override Vector4 GetValue()
        {
            return EditorGUILayout.Vector4Field("Vector4", new Vector4(1, 1, 1, 1));
        }
    }
}