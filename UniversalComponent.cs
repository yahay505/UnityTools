using UnityEngine;

namespace UnityTools
{
    public class UniversalComponent<T>: MonoBehaviour where T:MonoBehaviour
    {
        public static T main
        {
            get
            {
                if (_main)
                {
                    return _main;
                }

                if (GameObject.FindObjectOfType<T>())
                {
                    _main = FindObjectOfType<T>();
                    return _main;
                }

                var holder = new GameObject($"{nameof(T)} Holder", typeof(T));
                DontDestroyOnLoad(holder);
                _main = holder.GetComponent<T>();
                return _main;
            }
        }
        private static T _main;

    }
}