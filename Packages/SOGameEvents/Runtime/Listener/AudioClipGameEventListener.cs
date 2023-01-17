using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class AudioClipGameEventListener : GameEventListener<AudioClip> 
    {
        public AudioClipGameEventListener() : base() {}
        
        public AudioClipGameEventListener(IRegisterListener registerListener)  : base(registerListener) {}

        [SerializeField] private AudioClipGameEvent audioClipEvent;
        [SerializeField] private AudioClipUnityEvent audioClipResponse;

        public override GameEvent<AudioClip> Event => audioClipEvent;
        public override UnityEvent<AudioClip> Response => audioClipResponse;
    }
}