using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<AudioClip[]>), editorForChildClasses: true)]
    public class AudioClipArrayGameEventEditor : GameEventEditor<AudioClip[]>
    {
        public Object source;

        protected override AudioClip[] GetValue()
        {
            return new AudioClip[] {EditorGUILayout.ObjectField(source, typeof(Object), true) as AudioClip};
        }
    }
}
