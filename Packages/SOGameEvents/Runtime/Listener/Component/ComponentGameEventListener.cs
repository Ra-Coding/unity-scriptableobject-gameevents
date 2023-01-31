using UnityEngine;

namespace RaCoding.GameEvents
{
    public abstract class ComponentGameEventListener<L, T> : MonoBehaviour where L : GameEventListener<T>, new()
    {
        [SerializeField] private L listener = new();

        private void Awake()
        {
            listener.ParentGameObject = gameObject;
        }

        public void OnEnable()
        {
            listener.Register();
        }

        public void OnDisable()
        {
            listener.Unregister();
        }
    }
}
