using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T> : IEnumerable
    {
        public T[] objects = new T[0];
        public int size { get; private set; }
        
        public MyList()
        {
            size = 0;
        }
        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                //error
            }
            else
            {
                objects = new T[capacity];
            }
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < objects.Length; i++)
            {
                yield return objects[i];
            } 
        }
        public void Add (T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size + 1];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = objects[i];
                }
                tempArray[size] = value;
                size++;
                objects = tempArray;
            }
            else
            {
                try
                {
                    //no try
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public  void Remove(T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size - 1];
                bool placeHolder = true;
                for (int i = 0; i < size; i++)
                {
                    if (!objects[i].Equals(value) && placeHolder)
                    {
                        tempArray[i] = objects[i];
                    }
                    else if (i != size - 1)
                    {
                        placeHolder = false;
                        tempArray[i] = objects[i + 1];
                    }
                }
                size--;
                objects = tempArray;
            }
        }
        public int Count
        {
            get
            {
                return size;
            }
        }
        public static MyList<T> operator +(MyList<T> listA, MyList<T> listB)
        {
            MyList<T> list = new MyList<T>();
            foreach(T item in listA)
            {
                list.Add(item);
            }
            foreach(T item in listB)
            {
                list.Add(item);
            }
            return list;
        }
        public override string ToString()
        {
            string value = "";
            for (int i = 0; i < size; i++)
            {
                value = objects[i].ToString();
            }
            return value;
        }
        public MyList<T> Zip (MyList<T> listA, MyList<T> listB)
        {
            MyList<T> list = new MyList<T>();
            for (int i = 0; i < size; i++)
            {
                list.Add(listA.objects[i]);
                list.Add(listB.objects[i]);
            }
            return list;
        }
        public static MyList<T> operator -(MyList<T> listA, MyList<T> listB)
        {
            MyList<T> list = new MyList<T>();
            foreach (T item in listA)
            {
                list.Remove(item);
            }
            foreach (T item in listB)
            {
                list.Remove(item);
            }
            return list;
        }
    }
}
