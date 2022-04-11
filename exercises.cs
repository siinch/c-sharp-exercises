namespace exercises {
    class Program {
        public delegate bool Callback(int value);
        public static void Main(string[] args) { 

            int[] data = {-43, 23, -76, 0, 33, -98, 61};
            List<int> list = new List<int>{-43, 23, -76, 0, 33, -98, 61};
            string dataText = string.Join(" ", data);
            int numberIncluded = 23;
            int numberNotIncluded = -22;

            // write a function to calculate the sum of the values in an array
            int sum(int[] data) {
                int result = 0;
                foreach(int value in data)
                    result += value;
                return result;
            }
            Console.WriteLine($"The sum of {dataText} is {sum(data)}");
            Console.WriteLine("");

            // write a function to check if a value exists in an array or not
            bool IncludesGeneric<Type>(Type[] data, Type value) {
                foreach(Type val in data)
                    if(EqualityComparer<Type>.Default.Equals(val, value))
                        return true;
                return false;
            }

            Console.WriteLine("Testing the IncludesGeneric function:");
            Console.WriteLine($"Is {numberIncluded} in {dataText}: {IncludesGeneric<int>(data, numberIncluded)}");
            Console.WriteLine($"Is {numberNotIncluded} in {dataText}: {IncludesGeneric<int>(data, numberNotIncluded)}");
            Console.WriteLine(" ");
            // write a function to check if an array af numbers
            // contains a certain value

            bool Includes (int[] data, int number) {
                foreach (int n in data)
                    if(n == number) return true;
                return false;
            }

            Console.WriteLine("Testing the includes function:");
            Console.WriteLine($"Is {numberIncluded} in {dataText}: {Includes(data, numberIncluded)}");
            Console.WriteLine($"Is {numberNotIncluded} in {dataText}: {Includes(data, numberNotIncluded)}");
            Console.WriteLine("");

            // write a function to filter values from a list based on a callback
            List<int> Filter(List<int> data, Callback callback) {
                List<int> valuesToFilter = new List<int>();

                foreach(int value in data)
                    if(callback(value))
                        valuesToFilter.Add(value);

                foreach(int value in valuesToFilter)
                    data.Remove(value);

                return data;
            }
            
            Console.WriteLine($"Filter all values below 0 in {string.Join(" ", list)}:");
            Console.WriteLine(string.Join(" ", Filter(list, (value) => {return value < 0;})));
            Console.WriteLine("");
        }
    }
}