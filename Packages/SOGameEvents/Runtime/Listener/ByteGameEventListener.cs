using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class ByteGameEventListener : GameEventListener<byte> 
    {
        public ByteGameEventListener() : base() {}
        
        public ByteGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private ByteGameEvent byteEvent;
        [SerializeField] private ByteUnityEvent byteResponse;

        public override GameEvent<byte> Event => byteEvent;
        public override UnityEvent<byte> Response => byteResponse;
    }
}