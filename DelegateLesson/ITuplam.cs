using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public interface ITuplam<T>
    {
        public int ElementlariSoni { get;}
        void Qushish(T item);
        void HammasiniUchirish();
        bool BittaElementniUchirish(T item);
        void BittaElementniUchirishIndex(int index);
        void TuplamniUchirish(int index, int count);

    }
}
