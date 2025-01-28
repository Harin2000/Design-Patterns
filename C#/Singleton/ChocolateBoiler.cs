using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        //private static readonly object SyncRoot = new();
        //private static ChocolateBoiler? _instance = null;

        //// For testing purposes
        //public static int counter = 0;

        // option 1: Make the method synchronized, not a good practice since this takes lock on this or typeof(Foo).
        // Also not good in terms of Singleton since it takes lock each time
        // [MethodImpl(MethodImplOptions.Synchronized)]

        // option 3: Part 1: Lazy<T>
        // COMMENT OUT the lines of lock, _instace, getInstance()
        private static readonly Lazy<ChocolateBoiler> _lazy = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        public static ChocolateBoiler getInstance()
        {
            //// option 2:
            //if (_instance == null)
            //{
            //    lock (SyncRoot)
            //    {
            //        if (_instance == null)
            //        {
            //            _instance = new ChocolateBoiler();
            //            Interlocked.Increment(ref counter);
            //            return _instance;
            //        }
            //        else return _instance;
            //    }
            //}
            //else return _instance;

            // option 3: Part 2:
            return _lazy.Value;
        }
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public bool IsEmpty()
        {
            return empty;
        }
        public bool IsBoiled()
        {
            return boiled;
        }
        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
            }
        }
        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
            }
        }
    }
}
