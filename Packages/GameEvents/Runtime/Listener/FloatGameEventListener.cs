using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class FloatGameEventListener : GameEventListener<float> 
    {
        [SerializeField] private FloatGameEvent floatEvent;
        [SerializeField] private FloatUnityEvent floatResponse;

        public override GameEvent<float> Event => floatEvent;
        public override UnityEvent<float> Response => floatResponse;
    }
}