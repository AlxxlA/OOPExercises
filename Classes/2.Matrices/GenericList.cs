using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Matrices
{
    public class GenericList<T>
    {
        private T[] elements;
        private int capacity;
        private int nextIndex;

        public GenericList(int capacity = 4)
        {
            this.Capacity = capacity;
            this.Count = 0;
            this.elements = new T[capacity];
            this.nextIndex = 0;
        }

        public GenericList(params T[] array)
        {
            this.elements = CopyElementsFromArray(array);
            this.Count = this.elements.Length;
            this.Capacity = this.elements.Length;
            this.nextIndex = this.Count;
        }

        public GenericList(List<T> list) : this(list.ToArray())
        {
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get { return this.capacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity shoud be positive number.");
                }

                this.capacity = value;
            }
        }

        public T this[int i]
        {
            get
            {
                this.ValidateIndex(i);
                return this.elements[i];
            }
            set
            {
                this.ValidateIndex(i);
                this.elements[i] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.IncreaseCapacity();
            }

            this.elements[this.nextIndex] = element;

            this.nextIndex++;
            this.Count++;
        }

        public void Clear()
        {
            this.elements = new T[this.Capacity];

            this.Count = 0;
            this.nextIndex = 0;
        }

        public T Find(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return this.elements[i];
                }
            }

            throw new ArgumentException("Element not found.");
        }

        public void InsertAt(T element, int elementIndex)
        {
            this.ValidateIndex(elementIndex);

            if (this.Count == this.Capacity)
            {
                this.IncreaseCapacity();
            }

            var tempArray = new T[this.Capacity];

            for (int i = 0; i < elementIndex; i++)
            {
                tempArray[i] = this.elements[i];
            }

            tempArray[elementIndex] = element;

            for (int i = elementIndex; i < this.Count; i++)
            {
                tempArray[i + 1] = this.elements[i];
            }

            this.elements = tempArray;

            this.nextIndex++;
            this.Count++;
        }

        public void Remove(T element)
        {
            int elementIndex = Array.IndexOf(this.elements, element);

            if (elementIndex == -1)
            {
                return;  // cannot remove unexisting element
            }

            this.RemoveAt(elementIndex);
        }

        public void RemoveAt(int elementIndex)
        {
            this.ValidateIndex(elementIndex);

            var tempArray = new T[this.Capacity];

            int currentIndex = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (i == elementIndex)
                {
                    continue;
                }
                tempArray[currentIndex] = this.elements[i];
                currentIndex++;
            }

            this.elements = tempArray;

            this.nextIndex--;
            this.Count--;
        }
   
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                sb.Append($"{this.elements[i]}, ");
            }

            string result = sb.ToString();
            result = result.Trim(',', ' ');

            return result;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.nextIndex)
            {
                throw new IndexOutOfRangeException("Index is out of range of the list.");
            }
        }

        private void IncreaseCapacity()
        {
            this.Capacity *= 2;
            var tempArray = CopyElementsFromArray(this.elements);
            this.elements = new T[this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                this.elements[i] = tempArray[i];
            }
        }

        private static T[] CopyElementsFromArray(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array shoud not be null");
            }

            var result = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            return result;
        }
    }
}