using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class TransformGameEventListener : GameEventListener<Transform> 
    {
        public TransformGameEventListener() : base() {}
        
        public TransformGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private TransformGameEvent transformEvent;
        [SerializeField] private TransformUnityEvent transformResponse;

        public override GameEvent<Transform> Event => transformEvent;
        public override UnityEvent<Transform> Response => transformResponse;
    }
}