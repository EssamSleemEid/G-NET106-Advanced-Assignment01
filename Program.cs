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
        }
    }
}
