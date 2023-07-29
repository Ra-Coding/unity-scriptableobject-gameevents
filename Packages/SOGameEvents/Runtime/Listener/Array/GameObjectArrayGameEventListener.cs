using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class GameObjectArrayGameEventListener : GameEventListener<GameObject[]>
    {
        public GameObjectArrayGameEventListener() : base() {}

        public GameObjectArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private GameObjectArrayGameEvent gameObjectArrayEvent;
        [SerializeField] private GameObjectArrayUnityEvent gameObjectArrayResponse;

        public override GameEvent<GameObject[]> Event => gameObjectArrayEvent; 
        public override UnityEvent<GameObject[]> Response => gameObjectArrayResponse; 
    }
}
