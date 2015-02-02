namespace SomeExercises
{
    using System.Collections.Generic;
    using System.Linq;

    public class GenericList<T>
    {
        private List<T> list;

        public GenericList(int capacity)
        {
            this.list = new List<T>(capacity);
        }

        public void AddElement(T element)
        {
            this.list.Add(element);
        }

        public T AccesingElement(int index)
        {
            return this.list[index];
        }

        public void RemoveElement(int index)
        {
            this.list.RemoveAt(index);
        }

        public void InsertElementByPosition(T element, int position)
        {
            this.list.Insert(position, element);
        }

        public void ClearTheList()
        {
            this.list.Clear();
        }

        public T Min()
        {
            return this.list.Min();
        }

        public T Max()
        {
            return this.list.Max();
        }
    }
}