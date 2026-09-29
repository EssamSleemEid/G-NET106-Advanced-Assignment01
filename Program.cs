using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

        public class thestruct<T> where T : struct
        {
            public T value;
        }

        public class theclass<T> where T : class
        {
            public T value;
        }

        public class thenew<T> where T : new()
        {
           public T make(){
                return new T();
            }
        }

        public interface Itypable
        {
            void type();
        }

        public class theinterface<T> where T : Itypable
        {
            public void typeing(T value)
            {
                value.type();
            }
        }

        public class thetype : Itypable
        {
            public void type()
            {
                Console.WriteLine("hello essam");
            }
        }

        public class car
        {
            public void sound()
            {
                Console.WriteLine("beeb beeb");
            }
        }

        public class road<T> where T: car
        {
            public void drive(T car01)
            {
                car01.sound();
            }
        }

        //public class hi<T> where T : car, Itypable, new()
        //{
               //not used, only for applying the Q12
        //} 

        public class safeList<T>
        {
            public List<T> list=new List<T>();

            public void add(T item)
            {
               list.Add(item);
            }
            public T get(int index)
            {
                if(index<0 || index >= list.Count)
                {
                    return default(T);
                }
                return list[index];
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

            #region Question07
            //Q7: What is the 'struct' constraint? Write an example.

            // constraint specifies that the type should not be null value type

            //thestruct<int> number= new thestruct<int>();             //for example it will work with int bc its non-nullable value type
            //number.value = 1;

            //thestruct<string> name = new thestruct<string>();        // here it will not work bc its a sting that can be null 
            //name.value = " ";
            #endregion

            #region Question08
            //Q8: What is the 'class' constraint? Write an example.

            // constraint specifies that the type should be a reference type

            //theclass<string> name = new theclass<string>();
            //name.value = " ";
            //Console.WriteLine(name.value);
            #endregion

            #region Question09
            //Q9: What is the 'new()' constraint? Write an example.

            // constraint require the type to have a parameter less constructor

            thenew<StringBuilder> builder = new thenew<StringBuilder>();
            StringBuilder mynew = builder.make();
            #endregion

            #region Question10
            //Q10:  What is the interface constraint? Write an example.

            // require the type to implement a  specified interface 

            //theinterface<thetype> word = new theinterface<thetype>();
            //word.typeing(new thetype());
            #endregion

            #region Question11
            //Q11: What is the base class constraint? Write an example.

            // require the type to be specified base class or class derived from it 

            //road<car> BMW=new road<car>();
            //BMW.drive(new car());
            #endregion

            #region Question12
            //Q12: How do you apply multiple constraints? Write an example. 

            // it can be applied to one generic type parameter using a comma-seprated after where
            #endregion

            #region Question13
            //Q13: What does the 'default' keyword do in generics?

            // it returns the default value of a type 0 for int and null for string and false for bool
            #endregion

            #region Question14
            //Q14: Write a SafeList<T> that returns default when the index is invalid.

            //safeList<int> mylist= new safeList<int>();
            //mylist.add(11);
            //mylist.add(22);
            //mylist.add(33);
            //Console.WriteLine("index 0 : "+mylist.get(0));
            //Console.WriteLine("index 2 : "+mylist.get(2));
            //Console.WriteLine("out of range : "+ mylist.get(5));
            #endregion

            #region Question15
            //Q15: What is covariance? Explain the 'out' keyword.

            //it allow the generic type to use more derived type where a less derived type is expected and the out key is used for generic type parameter that are returned
            #endregion

            #region Question16
            //Q16: What is contravariance? Explain the 'in' keyword.

            // it allow the generic type to use less derived type where more derived type is expected and the in key is used for generic type parameter that are consumed
            #endregion

            #region Question17
            //Q17: What is the difference between covariance and contravariance?

            /*
             covariance : produce value , allow more derived types , support conversion from derived to base 
             
             contravariance :  consumes value , allow less derived types , support conversion from base to derived 
            */
            #endregion

            #region Question18
            //Q18: How do static members work in generic types?

            // its belong to each constructed generic type separately each type has its own static field
            #endregion

            #region Question19
            //Q19: How can you inherit from a generic class?

            // by specifying its type or it can remain generic and pass its type parameter to the base class
            #endregion
        }
    }
}
