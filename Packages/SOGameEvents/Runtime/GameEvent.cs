using System.Collections.Generic;
using UnityEngine;

namespace RaCoding.GameEvents
{
    public class GameEvent<T> : ScriptableObject 
    {
        private readonly List<IGameEventListener<T>> eventListeners = new();

        public void Raise(T t)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(t);
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}