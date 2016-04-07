using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsSMB
{
    public class Unicoll<T> : IEnumerable<T> where T : IComparable
    {
        private T[] innerArray;


        public void Add(T item)
        {

            int newLength = innerArray.Length + 1;
            T[] newArray = new T[newLength];
            for (int i = 0; i < innerArray.Length; i++)
            {
                newArray[i] = innerArray[i];
            }
            newArray[newLength - 1] = item;
            innerArray = newArray;

        }

        public bool Remove(T item)
        {
            int newLength;
            int matchIndex=-1;
            T[] newArray;
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (innerArray[i].CompareTo(item)==0)
                {
                    matchIndex = i;
                    newLength = innerArray.Length - 1;
                    newArray = new T[newLength];
                    for (int j = 0; j < innerArray.Length - 1; j++)
                    {
                        if (j < matchIndex)
                        {
                            newArray[j] = innerArray[j];
                        }
                        else /*j>=matchIndex*/
                        {
                            newArray[j] = innerArray[j + 1];
                        }

                    }
                    innerArray = newArray;
                    return true;

                }
            }


            return false;
        }
        public bool RemoveAt(int index)
        {
            if (index<innerArray.Length)
            {
                T[] newArray = new T[innerArray.Length - 1];
                for (int i = 0; i < innerArray.Length-1; i++)
                {
                    if (i<index)
                    {
                        newArray[i] = innerArray[i];

                    }
                    else
                    {
                        newArray[i] = innerArray[i+1];
                    }
                }
                innerArray = newArray;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (innerArray[i].CompareTo(item)==0)
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }
        public void Sort()
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                for (int j = 0; j < innerArray.Length; j++)
                {
                    if (innerArray[i].CompareTo(innerArray[j]) < 0)
                    {
                        T temp = innerArray[i];
                        innerArray[i] = innerArray[j];
                        innerArray[j] = temp;
                    }
                }
            }

        }
        public T this[int index]
        {
            get
            {
                return innerArray[index];
            }
            set
            {
                innerArray[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return innerArray.Length;
            }

        }
        public Unicoll()
        {
            this.innerArray = new T[0];
            

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(innerArray[i].ToString()+"\n");

            }
            return result.ToString();
        }

        #region Interface Implementation


        public IEnumerator<T> GetEnumerator()
        {
            return new UnicollEnumerator(this);
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        #endregion

        class UnicollEnumerator : IEnumerator<T>
        {
            private Unicoll<T> uc;
            public UnicollEnumerator(Unicoll<T> uc)
            {
                this.uc = uc;
            }

            int index = -1;
            public T Current
            {
                get
                {
                    return uc.innerArray[index];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                index++;
                return index < uc.innerArray.Length;
            }

            public void Reset()
            {
                index = -1;
            }
        }

    }
}
