using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<GameObject[]>), editorForChildClasses: true)]
    public class GameObjectArrayGameEventEditor : GameEventEditor<GameObject[]>
    {
        public Object source;

        protected override GameObject[] GetValue()
        {
            return new GameObject[] {EditorGUILayout.ObjectField(source, typeof(Object), true) as GameObject};
        }
    }
}
