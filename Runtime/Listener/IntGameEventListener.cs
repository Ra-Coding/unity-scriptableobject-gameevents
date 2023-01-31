using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class IntGameEventListener : GameEventListener<int> 
    {
        public IntGameEventListener() : base() {}
        
        public IntGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private IntGameEvent intEvent;
        [SerializeField] private IntUnityEvent intResponse;

        public override GameEvent<int> Event => intEvent;
        public override UnityEvent<int> Response => intResponse;
    }
}