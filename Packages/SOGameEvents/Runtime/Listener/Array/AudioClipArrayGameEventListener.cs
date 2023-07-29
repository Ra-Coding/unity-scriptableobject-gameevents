using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class AudioClipArrayGameEventListener : GameEventListener<AudioClip[]>
    {
        public AudioClipArrayGameEventListener() : base() {}

        public AudioClipArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private AudioClipArrayGameEvent audioClipArrayEvent;
        [SerializeField] private AudioClipArrayUnityEvent audioClipArrayResponse;

        public override GameEvent<AudioClip[]> Event => audioClipArrayEvent; 
        public override UnityEvent<AudioClip[]> Response => audioClipArrayResponse; 
    }
}
