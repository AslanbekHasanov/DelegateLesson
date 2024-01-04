using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Tuplam<T> : ITuplam<T>
    {
        private T[] elementlar;
        private int elementlarSoni;

        public Tuplam()
        {
            elementlarSoni = 0;
            elementlar = new T[0];

        }
        public void Qushish(T item)
        {
            T[] yangiElementlar = new T[elementlarSoni + 1];
            for(int i = 0; i < elementlarSoni; i++)
            {
                yangiElementlar[i] = elementlar[i];

            }
            yangiElementlar[elementlarSoni] = item;
            elementlar = yangiElementlar;
            elementlarSoni++;
        }
        public int ElementlariSoni{ get => elementlarSoni; }

        public bool BittaElementniUchirish(T item)
        {
            bool res = false;
            T[] yangiElementlar = new T[elementlarSoni - 1];
            for(int i = 0; i < elementlarSoni; i++)
            {
                if (elementlar[i]?.ToString() == item?.ToString())
                {
                    res = true;
                }

            }
            return true;
        }

        public void BittaElementniUchirishIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void HammasiniUchirish()
        {
            elementlarSoni = 0;
            T[] values = new T[0];
            elementlar = values;
        }
       

        public void TuplamniUchirish(int index, int count)
        {
            throw new NotImplementedException();
        }
    }
}
