using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> where T : IComparable // We need to implement IComparable, because of Min<T> and Max<T>
    {
        private T[] collectedElements; 
        private int capacity; // The size of the list
        private int count = 0; //
        private bool[] isNull; //It's a check if the position we're trying to operate with is empty or not.
        private int lastSequence = -1;

        public GenericList(int capacity)
        {
            collectedElements = new T[capacity];
            this.capacity = capacity;
            this.isNull = new bool[capacity];
        }

        //public GenericList()
        //    : this(capacity)
        //{
        //}
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= capacity)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
                }
                T result = collectedElements[index];
                return result;
            }
        }

        public void Add(T elements) //Add element
        {
            if (Full() == false) // Full checks if the list is full or not
            {
                int index = lastSequence + 1;
                while (index < capacity && isNull[index] == true)
                {
                    index++;
                }
                if (index < capacity)
                {
                    collectedElements[index] = elements;
                    isNull[index] = true; 
                    this.lastSequence = index; 
                    this.count++;
                }
            }
            else
            {
                Resize();
                Add(elements);
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 || index >= capacity)
            {
                throw new ArgumentException("Index is outside the boundaries of the array");
            }
            this.isNull[index] = false;
            if (IsBeforeIndex(index) == true)
            {
                this.lastSequence = index - 1;
            }

            this.count--;
        }

        private void Move(int insertionIndex, int firstEmptyIndex)
        {
            for (int i = firstEmptyIndex; i > insertionIndex; i--)
            {
                this.collectedElements[i] = this.collectedElements[i - 1];
                this.isNull[i] = this.isNull[i - 1];
            }
        }
       
        public void InsertAtPosition(T value, int index)
        {
            if (index < 0 || index >= this.capacity)
            {
                throw new ArgumentException("Index is outside the boundaries of the array");
            }

            if (this.isNull[index] == false)
            {
                this.collectedElements[index] = value;
                this.isNull[index] = true;
                this.count++;
            }
            else
            {
                if (Full() == true || FullAfter(index) == -1)
                {
                    Resize();
                }

                int emptyIndexAfter = FullAfter(index);
                Move(index, emptyIndexAfter);
                this.collectedElements[index] = value;
                this.isNull[index] = true;
                count++;
            }
        }

        bool Full()
        {
            if (this.count > this.capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(capacity * 2);
            for (int i = 0; i < capacity; i++)
            {
                sb.Append(collectedElements[i].ToString());
            }
            return sb.ToString();
        }

        private void Resize()
        {
            T[] temp = new T[this.capacity];
            bool[] empty = new bool[this.capacity];
            for (int i = 0; i < capacity; i++)
            {
                temp[i] = this.collectedElements[i];
                empty[i] = this.isNull[i];
            }

            this.capacity = this.capacity * 2;
            this.collectedElements = new T[this.capacity];
            this.isNull = new bool[this.capacity];
            for (int i = 0; i < temp.Length; i++)
            {
                this.collectedElements[i] = temp[i];
                this.isNull[i] = empty[i];
            }
        }

        public void Clear()
        {
            this.collectedElements = new T[this.capacity];
            this.count = 0;
        }

        private bool IsBeforeIndex(int beforeIndex) 
        {
            for (int i = beforeIndex - 1; i >= 0; i--)
            {
                if (this.isNull[i] == false)
                {
                    return false;
                }
            }
            return true;
        }

        private int FullAfter(int index) // makes a check if it is needed to resize the array,after inserting a new element
        {
            for (int i = index + 1; i < capacity; i++)
            {
                if (isNull[i] == false)
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min()
        {
            T minValue = this.collectedElements[0];
            for (int i = 1; i < capacity; i++)
            {
                if (this.collectedElements[i].CompareTo(minValue) < 0)
                {
                    minValue = this.collectedElements[i];
                }
            }

            return minValue;
        }

        public T Max()
        {
            T maxValue = this.collectedElements[0];
            for (int i = 1; i < capacity; i++)
            {
                if (this.collectedElements[i].CompareTo(maxValue) > 0)
                {
                    maxValue = this.collectedElements[i];
                }
            }

            return maxValue;
        }
    }
}