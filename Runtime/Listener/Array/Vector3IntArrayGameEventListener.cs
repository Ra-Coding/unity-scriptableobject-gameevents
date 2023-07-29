using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector3IntArrayGameEventListener : GameEventListener<Vector3Int[]>
    {
        public Vector3IntArrayGameEventListener() : base() {}

        public Vector3IntArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private Vector3IntArrayGameEvent vector3IntArrayEvent;
        [SerializeField] private Vector3IntArrayUnityEvent vector3IntArrayResponse;

        public override GameEvent<Vector3Int[]> Event => vector3IntArrayEvent; 
        public override UnityEvent<Vector3Int[]> Response => vector3IntArrayResponse; 
    }
}
