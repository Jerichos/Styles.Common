using UnityEngine;

namespace Styles.Common
{
public static class LogExtensions
{
    public static void Log(this GameObject gameObject, string message)
    {
        Debug.Log(message, gameObject);
    }
    
    public static void Log(this Transform transform, string message)
    {
        Debug.Log(message, transform);
    }
}
}