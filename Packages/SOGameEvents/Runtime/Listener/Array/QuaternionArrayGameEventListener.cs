using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class QuaternionArrayGameEventListener : GameEventListener<Quaternion[]>
    {
        public QuaternionArrayGameEventListener() : base() {}

        public QuaternionArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private QuaternionArrayGameEvent quaternionArrayEvent;
        [SerializeField] private QuaternionArrayUnityEvent quaternionArrayResponse;

        public override GameEvent<Quaternion[]> Event => quaternionArrayEvent; 
        public override UnityEvent<Quaternion[]> Response => quaternionArrayResponse; 
    }
}
