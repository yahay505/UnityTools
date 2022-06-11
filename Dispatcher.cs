using System;

namespace UnityTools
{
    public class Dispatcher
    {
        private Action a =()=>{};
        public void Add(Action action)
        {
            a += action;
        }

        public void Dispatch()
        {
            var b = a;
            a = () => { };
            b.Invoke();
    
        }
    }
}