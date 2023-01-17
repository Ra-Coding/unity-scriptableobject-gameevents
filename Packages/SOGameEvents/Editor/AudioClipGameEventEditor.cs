using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<AudioClip>), editorForChildClasses: true)]
    public class AudioClipGameEventEditor : GameEventEditor<AudioClip>
    {
        public Object source;

        protected override AudioClip GetValue()
        {
            return EditorGUILayout.ObjectField(source, typeof(Object), true) as AudioClip;
        }
    }
}