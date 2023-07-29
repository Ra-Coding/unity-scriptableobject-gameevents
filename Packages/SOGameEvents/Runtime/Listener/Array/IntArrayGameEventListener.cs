using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class IntArrayGameEventListener : GameEventListener<int[]>
    {
        public IntArrayGameEventListener() : base() {}

        public IntArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private IntArrayGameEvent intArrayEvent;
        [SerializeField] private IntArrayUnityEvent intArrayResponse;

        public override GameEvent<int[]> Event => intArrayEvent; 
        public override UnityEvent<int[]> Response => intArrayResponse; 
    }
}
