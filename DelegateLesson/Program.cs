using DelegateLesson;
using System;
using System.Timers;

namespace Delegate
{
    public delegate T add<T>(T param1, T param2);

    class Program
    {
        static void Main(string[] args)
        {
            Tuplam<int> tuplam = new Tuplam<int>();
            tuplam.Qushish(10);
            tuplam.Qushish(11);
            tuplam.Qushish(12);
            tuplam.Qushish(13);

            tuplam.HammasiniUchirish();

        }
    }
}
