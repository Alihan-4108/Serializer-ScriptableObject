using System;
using UnityEngine;

namespace Alihan4108.SerializeScriptableObject
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SerializeSOAttribute : PropertyAttribute
    {
        public string color;
        public string label;
        public TextAnchor titleAlignment;

        public SerializeSOAttribute(string label = "", TextAnchor titleAlignment = TextAnchor.MiddleLeft, string color = "#E05555")
        {
            this.label = label;
            this.titleAlignment = titleAlignment;
            this.color = color;
        }
    }
}
