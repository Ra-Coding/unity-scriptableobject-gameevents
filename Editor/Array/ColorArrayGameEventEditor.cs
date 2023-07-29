using UnityEditor;
using UnityEngine;

namespace RaCoding.GameEvents
{
    [CustomEditor(typeof(GameEvent<Color[]>), editorForChildClasses: true)]
    public class ColorArrayGameEventEditor : GameEventEditor<Color[]>
    {
        protected override Color[] GetValue()
        {
            Vector4 colorVector4 = EditorGUILayout.Vector4Field("Color", new Vector4(1, 1, 1, 1));
            return new Color[] { new Color(colorVector4.x, colorVector4.y, colorVector4.z, colorVector4.w)};
        }
    }
}
