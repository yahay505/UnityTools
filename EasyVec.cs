using UnityEngine;

namespace UnityTools
{
    public static class EasyVec
    {
        public  static Vector2 vec(float x, float y) => new (x, y);
        public static Vector3 vec(float x, float y,float z) => new (x, y,z);
    }
}