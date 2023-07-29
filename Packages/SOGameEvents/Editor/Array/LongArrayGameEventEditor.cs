using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<long[]>), editorForChildClasses: true)]
    public class LongArrayGameEventEditor : GameEventEditor<long[]>
    {
        protected override long[] GetValue()
        {
            return new long[] {EditorGUILayout.IntField(1)};
        }
    }
}
