using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<sbyte[]>), editorForChildClasses: true)]
    public class SByteArrayGameEventEditor : GameEventEditor<sbyte[]>
    {
        protected override sbyte[] GetValue()
        {
            return new sbyte[] {(sbyte)EditorGUILayout.IntField(1)};
        }
    }
}
