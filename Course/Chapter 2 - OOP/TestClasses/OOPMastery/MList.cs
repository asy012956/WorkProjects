using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPMastery.ExtensionMethods;

namespace OOPMastery
{
    public class MList<T>
    {
        //fields
        private T[] array;

        //properties
        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        //constructors
        public MList()
        {
            this.array = new T[0];
        }

        //methods
        public void Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }

            T[] arrayNew = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i];
            } 

            arrayNew[arrayNew.Length - 1] = element;

            array = arrayNew;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            T[] arrayNew = new T[array.Length - 1];
            int stepback = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    stepback++;
                    continue;
                }

                arrayNew[i - stepback] = array[i];
            }

            array = arrayNew;
        }

        public void Remove(T element)
        { 
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                this.RemoveAt(index);
            }
        }

        public void Insert(T element, int index)
        {
            if (element == null)
            {
                throw new Exception("Element cannot be null.");
            }
            if (index < 0 || index > array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T[] arrayNew = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    arrayNew[i] = array[i];
                }
                else 
                {
                    arrayNew[i + 1] = array[i];
                }
            }

            arrayNew[index] = element;

            array = arrayNew;
        }

        public T this[int i]
        {
            get
            {
                return this.array[i];
            }
            set
            {
                this.array[i] = value;
            }
        }
        
    }
}
