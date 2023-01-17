using UnityEngine;

namespace RaCoding.GameEvents
{
    public class ExampleGameEvent : MonoBehaviour, IRegisterListener
    {
        public OnEnableGameEventListener onEnableGameEventListener { get; set; }
        public OnDisableGameEventListener onDisableGameEventListener { get; set; }

        [SerializeField] private EmptyGameEvent gameEvent;
        [SerializeField] private GameObject text;
        [SerializeField] private EmptyGameEventListener listener;

        public ExampleGameEvent()
        {
            listener = new(this);
        }
 
        void Start()
        {
            Debug.Log("GameEvent Raised!");
            gameEvent.Raise();
        }

        private void OnEnable()
        {
            onEnableGameEventListener();
        }

        private void OnDisable()
        {
            onDisableGameEventListener();
        }

        public void ShowText() 
        {
            Debug.Log("Show Text!");
            text.SetActive(true);
        }
    }
}
