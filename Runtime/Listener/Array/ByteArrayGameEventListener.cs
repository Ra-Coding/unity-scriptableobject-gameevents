using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class ByteArrayGameEventListener : GameEventListener<byte[]>
    {
        public ByteArrayGameEventListener() : base() {}

        public ByteArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private ByteArrayGameEvent byteArrayEvent;
        [SerializeField] private ByteArrayUnityEvent byteArrayResponse;

        public override GameEvent<byte[]> Event => byteArrayEvent; 
        public override UnityEvent<byte[]> Response => byteArrayResponse; 
    }
}
