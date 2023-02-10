using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class GameObjectGameEventListener : GameEventListener<GameObject> 
    {
        public GameObjectGameEventListener() : base() {}
        
        public GameObjectGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private GameObjectGameEvent gameObjectEvent;
        [SerializeField] private GameObjectUnityEvent gameObjectResponse;

        public override GameEvent<GameObject> Event => gameObjectEvent;
        public override UnityEvent<GameObject> Response => gameObjectResponse;
    }
}