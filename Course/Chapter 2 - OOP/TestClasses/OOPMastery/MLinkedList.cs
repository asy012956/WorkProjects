using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPMastery.ExtensionMethods;

namespace OOPMastery
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Value { get; set; }
    }

    public class MLinkedList<T> : IEnumerable<T>
    {
        //fields
        private Node<T> firstElement;

        //properties
        public int Count { get; private set; }

        //methods
        //Add method
        public void Add(T value)
        {
            if (this.Count == 0)
            {
                this.firstElement = new Node<T>();
                this.firstElement.Value = value;
            }
            else
            {
                Node<T> newElement = new Node<T>();
                newElement.Value = value;
                Node<T> currentLastElement = GetLastElement();
                newElement.Previous = currentLastElement;
                currentLastElement.Next = newElement;
            }

            this.Count++;
        }

        public bool Remove(T value)
        {
            Node<T> elementFound = firstElement;
            while (elementFound.Value.Equals(value) == false)
            {
                elementFound = elementFound.Next;
                if (elementFound == null)
                {
                    break;
                }
            }

            if (elementFound == null)
            {
                return false;
            }

            if (elementFound.Next != null)
            {
                elementFound.Next.Previous = elementFound.Previous;
            }

            if (elementFound.Previous != null)
            {
                elementFound.Previous.Next = elementFound.Next;
            }
            else
            {
                firstElement = firstElement.Next;
            }

            this.Count--;

            return true;
        }

        public void Insert(T value, int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException("Position cannot be a negative number!");
            }

            Node<T> newElement = new Node<T>();
            newElement.Value = value;

            Node<T> currentElement = firstElement;

            while (position > 0)
            {
                currentElement = currentElement.Next;
                if (currentElement == null)
                {
                    throw new ArgumentOutOfRangeException("Position out of list range!");
                }
                position--;
            }

            if (currentElement.Previous != null)
            {
                currentElement.Previous.Next = newElement;
                newElement.Previous = currentElement.Previous;
                newElement.Next = currentElement;
                currentElement.Previous = newElement;
            }
            else
            {
                newElement.Next = currentElement;
                currentElement.Previous = newElement;
                firstElement = newElement;
            }

            this.Count++;
        }

        private Node<T> GetLastElement()
        {
            Node<T> lastElement = firstElement;
            while (lastElement.Next != null)
            {
                lastElement = lastElement.Next;
            }

            return lastElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentElement = this.firstElement;
            int counter = this.Count;
            while (counter > 0)
            {
                yield return currentElement.Value;
                currentElement = currentElement.Next;
                counter--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T this[int i]
        {
            get
            {
                if (i >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }

                Node<T> newElement = firstElement;
                while (i > 0)
                {
                    newElement = newElement.Next;
                    i--;
                }
                return newElement.Value;
            }
            set
            {
                if (i >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }

                Node<T> newElement = firstElement;
                while (i > 0)
                {
                    newElement = newElement.Next;
                    i--;
                }
                newElement.Value = value;
            }
        }


    }
}
