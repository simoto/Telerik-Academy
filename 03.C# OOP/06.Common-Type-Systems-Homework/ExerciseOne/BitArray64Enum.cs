namespace Exercises
{
    using System;
    using System.Collections;

    public class BitArray64Enum : IEnumerator
    {
        int position = -1;
        public ulong[] values;

        public BitArray64Enum(ulong[] values)
        {
            this.values = values;
        }

        public bool MoveNext()
        {
            position++;
            return (position < values.LongLength);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return values[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}