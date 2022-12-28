using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class IntGameEventListener : GameEventListener<int> 
    {
        [SerializeField] private IntGameEvent intEvent;
        [SerializeField] private IntUnityEvent intResponse;

        public override GameEvent<int> Event => intEvent;
        public override UnityEvent<int> Response => intResponse;
    }
}