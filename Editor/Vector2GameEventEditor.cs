using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Vector2>), editorForChildClasses: true)]
    public class Vector2GameEventEditor : GameEventEditor<Vector2>
    {
        protected override Vector2 GetValue()
        {
            return EditorGUILayout.Vector2Field("Vector2", new Vector2(1, 1));
        }
    }
}