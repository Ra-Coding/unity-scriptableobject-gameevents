using UnityEngine;

namespace RaCoding.GameEvents
{
    public class ExampleGameEvent : MonoBehaviour
    {
        [SerializeField] private EmptyGameEvent gameEvent;
        [SerializeField] private GameObject text;
        [SerializeField] private GameObjectGameEventListener listener = new();
 
        void Start()
        {
            gameEvent.Raise();
            listener.ToString();
        }

        public void ShowText() 
        {
            text.SetActive(true);
        }
    }
}
