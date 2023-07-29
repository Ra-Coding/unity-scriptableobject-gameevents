using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class SpriteArrayGameEventListener : GameEventListener<Sprite[]>
    {
        public SpriteArrayGameEventListener() : base() {}

        public SpriteArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private SpriteArrayGameEvent spriteArrayEvent;
        [SerializeField] private SpriteArrayUnityEvent spriteArrayResponse;

        public override GameEvent<Sprite[]> Event => spriteArrayEvent; 
        public override UnityEvent<Sprite[]> Response => spriteArrayResponse; 
    }
}
