using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace NaughtyAttributes.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(NaughtyScriptableObject), true)]
    public class NaughtyScriptableObjectInspector : NaughtyInspector {}
}
