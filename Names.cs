using System.Collections;

namespace EnumrableClass
{
    public class Names : IEnumerable
    {
        string[] names = { "Amin", "Rebecca", "Ghorme Sabzi", "Pishol" };

        public IEnumerator GetEnumerator()
        {
            Enumerator enumerator = new Enumerator(names);
            return enumerator;
        }
    }

    public class Enumerator : IEnumerator
    {
        string[] collection;

        public Enumerator(string[] collection)
        {
            this.collection = collection;
        }

        int index = -1;
        public object Current => collection[index];

        public bool MoveNext()
        {
            if (index < collection.Length - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}

