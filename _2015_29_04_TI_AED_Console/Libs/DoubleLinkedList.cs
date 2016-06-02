using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Libs
{
    public class Cell<T>
    {
        public T value;
        public Cell<T> next;
        public Cell<T> prev;

        public Cell()
        {
            this.Initialize(default(T));
        }

        public Cell(T element)
        {
            this.Initialize(element);
        }

        private void Initialize(T element)
        {
            this.value = element;
            this.next = this.prev = null;
        }
    }

    class DoubleLinkedList<T> : IEnumerator<T>, IEnumerable<T>
    {
        private int length;
        private Cell<T> start;
        private Cell<T> end;
        private Cell<T> current;

        public DoubleLinkedList()
        {
            this.start = new Cell<T>();
            this.end = start;
            this.length = 0;
            this.current = null;
        }

        public bool IsEmpty()
        {
            return this.length == 0;
        }

        public int Length
        {
            get { return length; }
        }

        private void ResetCurrent()
        {
            this.current = new Cell<T>();
            this.current.next = this.start;
        }

        public void Add(T value)
        {
            Cell<T> element = new Cell<T>(value);
            if (this.IsEmpty())
            {
                this.start = element;
                this.end = element;
                this.ResetCurrent();
            }
            else
            {
                Cell<T> aux = this.end;
                aux.next = element;
                this.end = element;
                this.end.prev = aux;
            }
            this.length++;
        }

        public void AddRange(DoubleLinkedList<T> list)
        {
            foreach (T value in list)
                this.Add(value);
        }

        private Cell<T> FindCell(int index)
        {
            if (!this.IsEmpty() && index < this.length)
            {
                if (index == 0)
                    return this.start;
                else if (index == (this.length - 1))
                    return this.end;
                else
                {
                    Cell<T> aux = this.start.next;
                    int count = 1;
                    while (aux != this.end)
                    {
                        if (count == index)
                            return aux;
                        aux = aux.next;
                        count++;
                    }
                }
            }
            return null;
        }

        public DoubleLinkedList<T> Find(Predicate<T> match)
        {
            DoubleLinkedList<T> found = new DoubleLinkedList<T>();
            if (!this.IsEmpty())
            {
                Cell<T> aux = this.start;
                while (aux != this.end)
                {
                    if (match.Invoke(aux.value))
                        found.Add(aux.value);
                    aux = aux.next;
                }
                if (match.Invoke(aux.value))
                    found.Add(aux.value);
            }
            return found;
        }

        public T ElementAt(int index)
        {
            Cell<T> element = this.FindCell(index);
            if (element != null)
                return element.value;
            throw new IndexOutOfRangeException("Index not exists.");
        }

        public T this[int index] {
            get { return this.ElementAt(index); }
        }

        public T RemoveAt(int index)
        {
            Cell<T> aux = this.FindCell(index);
            if (aux == null)
                return default(T);

            T value = default(T);
            if (aux == this.start)
            {
                value = aux.value;
                if (this.start == this.end)
                {
                    this.start = new Cell<T>();
                    this.end = start;
                    this.ResetCurrent();
                }
                else
                {
                    this.start = aux.next;
                    this.start.prev = null;
                }
            }
            else if (aux == this.end)
            {
                value = aux.value;
                end = aux.prev;
                end.next = null;
            }
            else
            {
                Cell<T> previous = aux.prev;
                Cell<T> next = aux.next;
                value = aux.value;
                previous.next = next;
                next.prev = previous;
            }
            aux.next = aux.prev = null;
            length--;
            return value;
        }

        public T[] ToArray()
        {
            T[] arrayList = new T[this.length];
            int i = 0;
            foreach(T item in this){
                arrayList[i] = item;
                i++;
            }
            return arrayList;
        }

        public void Print()
        {
            if (!this.IsEmpty())
            {
                Cell<T> aux = this.start;

                while (aux != this.end)
                {
                    Console.WriteLine(aux.value.ToString());
                    aux = aux.next;
                }
                Console.Write(this.end.value.ToString());
            }
            else
                Console.WriteLine("\nEmpty list!");
        }

        public T Current
        {
            get { return (this.current == null) ? default(T) : this.current.value; }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return (this.current == null) ? default(T) : this.current.value; }
        }

        public void Dispose()
        {
            this.ResetCurrent();
        }

        public void Reset()
        {
            this.ResetCurrent();
        }

        public bool MoveNext()
        {
            if (this.current != null)
                this.current = this.current.next;
            return this.current != null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (IEnumerator<T>)this;
        }
    }
}
