using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class DoubleGameEventListener : GameEventListener<double>
    {
        public DoubleGameEventListener() : base() { }

        public DoubleGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private DoubleGameEvent doubleEvent;
        [SerializeField] private DoubleUnityEvent doubleResponse;

        public override GameEvent<double> Event => doubleEvent;
        public override UnityEvent<double> Response => doubleResponse;
    }
}