using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class QuaternionGameEventListener : GameEventListener<Quaternion>
    {
        public QuaternionGameEventListener() : base() { }

        public QuaternionGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private QuaternionGameEvent quaternionEvent;
        [SerializeField] private QuaternionUnityEvent quaternionResponse;

        public override GameEvent<Quaternion> Event => quaternionEvent;
        public override UnityEvent<Quaternion> Response => quaternionResponse;
    }
}