using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class DoubleArrayGameEventListener : GameEventListener<double[]>
    {
        public DoubleArrayGameEventListener() : base() {}

        public DoubleArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private DoubleArrayGameEvent doubleArrayEvent;
        [SerializeField] private DoubleArrayUnityEvent doubleArrayResponse;

        public override GameEvent<double[]> Event => doubleArrayEvent; 
        public override UnityEvent<double[]> Response => doubleArrayResponse; 
    }
}
