using UnityEngine;

namespace UnityTools
{
    public class AutoFind<T> where T:Component
    {
        public T value
        {
            get
            {
                if (!_x)
                {
                    _x = Object.FindObjectOfType<T>();
                }
                return _x;
            }
        }

        private T _x;
        public T get() => value;
        public static implicit operator T(AutoFind<T> t) => t.value;
    }

 
    public class AutoGet<T> where T:Component
    {


        private Component owner;

        public AutoGet(MonoBehaviour owner)
        {
            this.owner = owner;
        }

        public T value
        {
            get
            {
                if (!_x)
                {
                    _x = owner.GetComponent<T>();
                }
                return _x;
            }
        }
        public T get() => value;

        private T _x;
        public static implicit operator T(AutoGet<T> t) => t.value;
    }

    class AutoFindOrCreate<T> where T:Component
    {
        
    }

    class AutoGetOrAdd<T> where T:Component
    {
        
    }
}