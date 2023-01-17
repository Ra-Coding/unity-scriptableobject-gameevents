using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<GameObject>), editorForChildClasses: true)]
    public class GameObjectGameEventEditor : GameEventEditor<GameObject>
    {
        public Object source;

        protected override GameObject GetValue()
        {
            return EditorGUILayout.ObjectField(source, typeof(Object), true) as GameObject;
        }
    }
}