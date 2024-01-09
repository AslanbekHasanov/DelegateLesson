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
        //uy ishi
        public void BittaElementniUchirishIndex(int index)
        {

        }

        public void HammasiniUchirish()
        {
            elementlarSoni = 0;
            T[] values = new T[0];
            elementlar = values;
        }
       
        //uy ishi 
        public void TuplamniUchirish(int index, int count)
        {
            T[] _elementlar = new T[count];
            int sanagich = 1;
            for(int i = index; i < count; i++)
            {
                _elementlar[i] = elementlar[i];

            }
            elementlarSoni = elementlarSoni - count;
            for (int i = 0; i < elementlarSoni; i++)
            {
                if (_elementlar[i]?.ToString() == elementlar[i]?.ToString())
                {

                }

            }
        }

        public T ElementOlish(int index)
        {
            return elementlar[index];
        }

        public void Sort()
        {
            for (int i = 0; i < elementlarSoni - 1 ; i++)
            {
                for (int j = 0; j < elementlarSoni  - 1; j++)
                {
                    if (elementlar[j]?.ToString()?.CompareTo(elementlar[j  + 1]?.ToString()) >= 0)
                    {
                        T element = elementlar[j  +1];
                        elementlar[j + 1] = elementlar[j];
                        elementlar[j] = element;
                    }

                }

            }
        }
    }
}
