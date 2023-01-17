using UnityEngine;

namespace RaCoding.GameEvents 
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "RaCoding/GameEvent/Create new game event")]
    public class EmptyGameEvent : GameEvent<EmptyType> 
    {
        public void Raise()
        {
            Raise(EmptyType.Instance);
        }
    }
}
