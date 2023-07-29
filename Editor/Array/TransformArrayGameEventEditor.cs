using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Transform[]>), editorForChildClasses: true)]
    public class TransformArrayGameEventEditor : GameEventEditor<Transform[]>
    {
        public Object source;

        protected override Transform[] GetValue()
        {
            return new Transform[] {EditorGUILayout.ObjectField(source, typeof(Object), true) as Transform};
        }
    }
}
