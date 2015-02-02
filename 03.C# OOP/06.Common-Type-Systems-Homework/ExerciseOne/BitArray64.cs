//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//    Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong[] arr;
        private int position;

        public BitArray64(int length)
        {
            arr = new ulong[length];
            this.position = 0;
        }

        public void Add(ulong value)
        {
            if (this.position < this.arr.Length)
            {
                arr[position] = value;
                position++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        public ulong this[int i]
        {
            get { return this.arr[i]; }
            set { this.arr[i] = value; }
        }

        public override bool Equals(object obj)
        {
            BitArray64 lala = (BitArray64)obj;
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != lala[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {

            ulong hash = 1;
            foreach (var item in this.arr)
            {
                hash += (ulong)item.GetHashCode();
                hash *= 23;
            }

            hash += (ulong)this.arr.Length.GetHashCode();
            return (int)hash;

        }

        public int Length
        {
            get { return this.arr.Length; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }
        public BitArray64Enum GetEnumerator()
        {
            return new BitArray64Enum(arr);
        }
    }   
}