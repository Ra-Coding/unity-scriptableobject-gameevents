using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector3IntGameEventListener : GameEventListener<Vector3Int>
    {
        public Vector3IntGameEventListener() : base() { }

        public Vector3IntGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private Vector3IntGameEvent vector3intEvent;
        [SerializeField] private Vector3IntUnityEvent vector3intResponse;

        public override GameEvent<Vector3Int> Event => vector3intEvent;
        public override UnityEvent<Vector3Int> Response => vector3intResponse;
    }
}