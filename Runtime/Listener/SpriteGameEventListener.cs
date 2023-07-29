using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class SpriteGameEventListener : GameEventListener<Sprite>
    {
        public SpriteGameEventListener() : base() {}

        public SpriteGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private SpriteGameEvent spriteEvent;
        [SerializeField] private SpriteUnityEvent spriteResponse;

        public override GameEvent<Sprite> Event => spriteEvent; 
        public override UnityEvent<Sprite> Response => spriteResponse; 
    }
}
