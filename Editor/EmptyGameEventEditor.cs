using UnityEditor;

namespace RaCoding.GameEvents 
{
    [CustomEditor(typeof(GameEvent<EmptyType>), editorForChildClasses: true)]
    public class EmptyGameEventEditor : GameEventEditor<EmptyType>
    {
        protected override EmptyType GetValue()
        {
            return EmptyType.Instance;
        }
    }
}
