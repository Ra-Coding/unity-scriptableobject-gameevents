using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Quaternion[]>), editorForChildClasses: true)]
    public class QuaternionArrayGameEventEditor : GameEventEditor<Quaternion[]>
    {
        protected override Quaternion[] GetValue()
        {
            Vector4 quaternionVector4 = EditorGUILayout.Vector4Field("Quaternion", new Vector4(1, 1, 1, 1));
            return new Quaternion[] {new Quaternion(quaternionVector4.x, quaternionVector4.y, quaternionVector4.z, quaternionVector4.w)};
        }
    }
}
