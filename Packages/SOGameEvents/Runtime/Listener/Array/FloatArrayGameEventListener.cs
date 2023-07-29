using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class FloatArrayGameEventListener : GameEventListener<float[]>
    {
        public FloatArrayGameEventListener() : base() {}

        public FloatArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private FloatArrayGameEvent floatArrayEvent;
        [SerializeField] private FloatArrayUnityEvent floatArrayResponse;

        public override GameEvent<float[]> Event => floatArrayEvent; 
        public override UnityEvent<float[]> Response => floatArrayResponse; 
    }
}
