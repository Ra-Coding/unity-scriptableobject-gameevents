using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class GameObjectGameEventListener : GameEventListener<GameObject> 
    {
        [SerializeField] private GameObjectGameEvent gameObjectEvent;
        [SerializeField] private GameObjectUnityEvent gameObjectResponse;

        public override GameEvent<GameObject> Event => gameObjectEvent;
        public override UnityEvent<GameObject> Response => gameObjectResponse;
    }
}