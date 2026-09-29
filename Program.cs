using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace G_NET106_Advanced_Assignment01
{
    internal class Program
    {
        public class Container<T>
        {
            private T value;

            public void add(T value){
               this.value = value;
            }
            public T getValue() { 
               return this.value;
            }
        }

        public class pair<Tkey, Tvalue>
        {
            public Tkey key { get; set; }
            public Tvalue value { get; set; }

            public pair(Tkey Key, Tvalue Value)
            {
                key = Key;
                value = Value;
            }
        }

        public static void Swap<T>(ref T value01,ref T value02)
        {
            T value03 = value01;
              value01 = value02;
              value02 = value03;
        }

        public static T findmax<T>(T a,T b) where T : IComparable<T>
        {
            if (a.CompareTo(b)> 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public interface IRepository<T>
        {
            void add(T value);
            T get();
        }
        public class repository<T> : IRepository<T> {

            private T Value;

            public void add(T value)
            {
                Value = value;
            }
            public T get()
            {
                return Value;
            }
        }
        static void Main(string[] args)
        {
            #region Question01
            //Q1: What is a generic class? Why use generics?

            // its a class that works with different data type using a type parameter like T
            // we use it bc code reusability and less code duplication and type safety
            #endregion

            #region Question02
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Container<int> adding = new Container<int>();
            //adding.add(1);
            //Console.WriteLine("add method : " + adding.getValue());
            #endregion

            #region Question03
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.

            //its allow the generic class to work with more than one type

            //pair<int, string> pair = new pair<int, string>(21, "essam");
            //Console.WriteLine("key : "+ pair.key);
            //Console.WriteLine("value : "+ pair.value);
            #endregion

            #region Question04
            //Q4: What is a generic method? Write Swap<T> method.

            // its method that define its own parameter type allow it to work with different data type

            //int a = 1;
            //Console.WriteLine("a before : "+a);
            //int b = 2;
            //Swap(ref a, ref b);
            //Console.WriteLine("a after : "+a);
            #endregion

            #region Question05
            //Q5: Write a generic method FindMax<T> that finds maximum value

            //Console.WriteLine(findmax(10,20));
            #endregion

            #region Question06
            //Q6: What is a generic interface? Write IRepository<T>. 

            // interface that use type parameter to define methods that work with different data type

            //repository<string> name=new repository<string>();
            //name.add("essam sleem");
            //Console.WriteLine("the name is : "+name.get());
            #endregion
        }
    }
}
