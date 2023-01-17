using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    public abstract class GameEventEditor<T> : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUI.enabled = Application.isPlaying;
            GameEvent<T> e = target as GameEvent<T>;
            T t = GetValue();
            if (GUILayout.Button("Raise"))
            {
                e.Raise(t);
            }
        }

        protected abstract T GetValue();
    }
}