using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsInRange(this int value, Vector2Int range)
        {
            return value >= range.x && value <= range.y;
        }
    }
}