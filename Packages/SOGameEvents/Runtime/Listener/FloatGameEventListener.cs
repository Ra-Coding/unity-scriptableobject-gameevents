using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class FloatGameEventListener : GameEventListener<float> 
    {
        public FloatGameEventListener() : base() {}
        
        public FloatGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private FloatGameEvent floatEvent;
        [SerializeField] private FloatUnityEvent floatResponse;

        public override GameEvent<float> Event => floatEvent;
        public override UnityEvent<float> Response => floatResponse;
    }
}