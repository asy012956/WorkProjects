using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery
{
    public class MStack<T> : IEnumerable<T>
    {
        private T[] container;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.container.Length;
            }
        }

        public MStack()
        {
            this.container = new T[2];
            this.count = 0;
        }

        public void Push(T item)
        {
            count++;

            if (this.count > this.container.Length)
            {
                ExpandContainer();
            }

            this.container[count - 1] = item;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new ArgumentException("The stack is already empty!");
            }

            var result = this.container[count - 1];

            count--;
            if (this.count <= this.container.Length / 2)
            {
                ReduceContainer();
            }

            return result;
        }

        public T Peek()
        {
            return this.container[count - 1];
        }

        private void ExpandContainer()
        {
            int size = this.container.Length * 2;
            if (size == 0)
            {
                size = 2;
            }

            var tempArray = new T[size * 2];

            for (int i = 0; i < this.container.Length; i++)
            {
                tempArray[i] = this.container[i];
            }

            this.container = tempArray;
        }

        private void ReduceContainer()
        {
            var tempArray = new T[this.container.Length / 2];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = this.container[i];
            }

            this.container = tempArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (count > 0)
            {
                yield return this.Pop();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
