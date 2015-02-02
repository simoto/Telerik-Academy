//Define a class InvalidRangeException<T> that holds information about an error condition
//    related to invalid range. It should hold error message and a range definition [start … end].

namespace ExerciseThree
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        public T Start
        {
            get { return this.start; }
        }

        public T End
        {
            get { return this.end; }
        }

        public override string Message
        {
            get
            {
                return string.Format("The value is out of range {0} - {1}.", this.start, this.end);
            }
        }
    }
}