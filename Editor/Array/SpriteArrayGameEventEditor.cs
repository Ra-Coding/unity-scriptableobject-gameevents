using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Sprite[]>), editorForChildClasses: true)]
    public class SpriteArrayGameEventEditor : GameEventEditor<Sprite[]>
    {
        public Object source;

        protected override Sprite[] GetValue()
        {
            return new Sprite[] {EditorGUILayout.ObjectField(source, typeof(Object), true) as Sprite};
        }
    }
}
