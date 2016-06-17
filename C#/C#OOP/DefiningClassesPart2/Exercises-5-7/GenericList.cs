using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_5_7
{
    public class GenericList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
        where T : IComparable<T>
    {
        private const int InitialCapacity = 5;
        private T[] array;
        private int capacity;
        private int count;

        public GenericList()
        {
            this.array = new T[InitialCapacity];
            this.Capacity = InitialCapacity;
            this.Count = 0;
        }

        public GenericList(int size)
        {
            this.array = new T[size];
            this.Capacity = size;
            this.Count = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The capacity should be more than 0 or 0(not recommended)!");
                }
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The count of the list can't be less than 0!");
                }
                this.count=value;
            }

        }


        public T this[int index]
        {
            get
            {
                if(index < 0 || index > this.Count)
                {
                    throw new IndexOutOfRangeException("The index is outside of the boundries of he array!");
                }
                return this.array[index];
            }

            set
            {
                if (index < 0 || index > this.Count)
                {
                    throw new IndexOutOfRangeException("The index is outside of the boundries of he array!");
                }
                this.array[index] = value;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            if (count > capacity)
            {
                this.EnsureCapacity();
            }
            
            this.array[this.Count] = item;
            this.Count++;
        }

        private void EnsureCapacity()
        {
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;

                T[] oldArray = this.array;
                this.array = new T[this.Capacity];

                for (int i = 0; i < oldArray.Length; i++)
                {
                    this.array[i] = oldArray[i];
                }
            }
        }

        public void Clear()
        {
            this.array = new T[capacity];
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            bool contains = false;
            foreach (var Item in this.array)
            {
                if (Item.Equals(item))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new NullReferenceException("The array cannot be copied to Not instanced one");
            }
            Array.Copy(this.array, array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var item = this.array[i];
                yield return item;
            }
        }

        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Insert(int index, T item)
        {
            if (0 > index)
            {
                throw new IndexOutOfRangeException("The index is outisde of the boundries!");
            }

            if (index == this.array.Length)
            {
                this.EnsureCapacity();
            }

            T temp = this.array[index];
            this.array[index] = item;
            for (int i = index+1; i < this.array.Length-1; i++)
            {
                var tempValue = this.array[i];
                this.array[i] = temp;
                temp = tempValue;
            }
        }

        public bool Remove(T item)
        {
            bool isRemoved = false;
            bool consists = this.Contains(item);
            if (consists)
            {
                var temp = this.array;
                this.array = new T[this.array.Length - 1];
                this.Count = 0;

                var index = Array.IndexOf(temp, item);

                for (int i = 0; i < index; i++)
                {
                    this.Add(temp[i]);
                }

                for (int i = index; i < temp.Length - index; i++)
                {
                    this.Add(temp[i + 1]);
                }

                isRemoved = true;
            }

            return isRemoved;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.array.Length)
            {
                throw new IndexOutOfRangeException("The index is outside of the boundries of the array!");
            }

            var temp = this.array;
            this.array = new T[InitialCapacity];
            this.Capacity = InitialCapacity;
            this.Count = 0;

            for (int i = 0; i < index; i++)
            {
                this.Add(temp[i]);
            }

            for (int i = index; i < temp.Length - index; i++)
            {
                this.Add(temp[i + 1]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this[i] + ", ");
            }

            return builder.ToString().Trim(new char[] { ',', ' ' });

        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("There are no elements in the list!");
            }

            T min = this.array[0];

            for (int i = 0; i <=this.Count; i++)
            {
                T currentItem = this[i];
                if (min.CompareTo(currentItem) > 0)
                {
                    min = currentItem;
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("There are no elements in the list!");
            }

            T max = this.array[0];

            for (int i = 0; i <= this.Count; i++)
            {
                T currentItem = this[i];
                if (max.CompareTo(currentItem) < 0)
                {
                    max = currentItem;
                }
            }

            return max;
        }
    }
}
