using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class SByteGameEventListener : GameEventListener<sbyte>
    {
        public SByteGameEventListener() : base() { }

        public SByteGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private SByteGameEvent sbyteEvent;
        [SerializeField] private SByteUnityEvent sbyteResponse;

        public override GameEvent<sbyte> Event => sbyteEvent;
        public override UnityEvent<sbyte> Response => sbyteResponse;
    }
}