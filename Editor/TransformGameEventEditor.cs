using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Transform>), editorForChildClasses: true)]
    public class TransformGameEventEditor : GameEventEditor<Transform>
    {
        public Object source;

        protected override Transform GetValue()
        {
            return EditorGUILayout.ObjectField(source, typeof(Object), true) as Transform;
        }
    }
}