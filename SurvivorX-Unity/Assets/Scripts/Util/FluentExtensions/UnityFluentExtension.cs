using UnityEngine;

namespace SurvivorX.Util.FluentExtensions
{
    public static class UnityFluentExtension
    {
        public static T Instantiate<T>(this T obj) where T : Object
        {
            return Object.Instantiate(obj);
        }

        public static T SetPosition<T>(this T component, Vector3 position) where T : Component
        {
            component.transform.position = position;
            return component;
        }

        public static GameObject SetPosition(this GameObject go, Vector3 position)
        {
            go.transform.position = position;
            return go;
        }
    }
}