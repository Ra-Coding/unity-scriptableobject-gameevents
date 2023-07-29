using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<int[]>), editorForChildClasses: true)]
    public class IntArrayGameEventEditor : GameEventEditor<int[]>
    {
        protected override int[] GetValue()
        {
            return new int[] {EditorGUILayout.IntField(1)};
        }
    }
}
