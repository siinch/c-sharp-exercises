using System.Numerics;

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

            // write a function to concatinate two arrays
            Type[] concatinate<Type>(Type[] first, Type[] second) {
                Type[] result = new Type[first.Length + second.Length];

                for(int i = 0; i < first.Length; i++)
                    result[i] = first[i];

                for(int i = 0; i < second.Length; i++)
                    result[i + first.Length] = second[i];

                return result;
            }

            Console.WriteLine($"{dataText} concatinated with itself: {string.Join(" ", concatinate(data, data))}");

            // write a function to find the highest and lowest value in some data

            Extremes GetExtremes(int[] data) {
                Extremes result = new Extremes();
                result.minimum = data[0];
                result.maximum = data[0];
                foreach(int value in data) {
                    if(value < result.minimum)
                        result.minimum = value;
                    else if (value > result.maximum)
                        result.maximum = value;
                }
                return result;
            }
            Extremes extremes = GetExtremes(data);
            Console.WriteLine($"The extremes of {dataText} are {extremes.minimum} and {extremes.maximum}");

            int[] symmetrical = {1, 2, 3, 4, 3, 2, 1};

            // write a function to check if an array is symmetrical
            bool isSymmetrical<Type>(Type[] data) {
                for(int i = 0; i < data.Length/2; i++)
                    if(!EqualityComparer<Type>.Default.Equals(data[i], data[data.Length-1-i]))
                        return false;
                return true;
            }
            
            Console.WriteLine($"{dataText} is symmetrical: {isSymmetrical(data)}");
            Console.WriteLine($"{string.Join(" ", symmetrical)} is symmetrical: {isSymmetrical(symmetrical)}");
        
            // write a function to determine the frequency of values in an array
            Dictionary<int, int> frequency(int[] data) {
                Dictionary<int, int> result = new Dictionary<int, int>();
                foreach(int value in data)
                    if(!result.ContainsKey(value))
                        result.Add(value, 1);
                    else
                        result[value]++;
                return result;
            }

            Console.WriteLine($"frequency of each value in {symmetrical}:");
            foreach(KeyValuePair<int, int> kvp in frequency(symmetrical))
                Console.WriteLine($"Value: {kvp.Key} Frequency: {kvp.Value}");
        
             // make a function to generate an array of random numbers
            int[] genRandom(int count, int minimum, int maximum) {
                Random random = new Random();
                int[] result = new int[count];
                for(int i = 0; i < count; i++)
                    result[i] = random.Next(minimum, maximum);
                return result;
            }

            Console.WriteLine($"randomly generated array: {string.Join(" ", genRandom(10, -10, 10))}");

            // write a function to reverse an array
            int[] reverse (int[] data) {
                int[] result = new int[data.Length];
                for(int i = 0; i < data.Length; i++)
                    result[i] = data[data.Length-1-i];
                return result;
            }

            Console.WriteLine($"{dataText} reversed: {string.Join(" ", reverse(data))}");
        
            // write a function to calculate the factorial of a number
            BigInteger factorial(int number) {
                BigInteger result = 1;
                for(int i = 2; i <= number; i++)
                    result *= i;
                return result;
            }
            int number = 30;
            Console.WriteLine($"The factioal of {number}: {factorial(number)}");
        
            // write a function to calculate the hypotenuse of a right angled triangle
            double hypotenuse(double a, double b) {
                return Math.Sqrt(a*a+b*b);
            }
            double a = 4;
            double b = 3;
            Console.WriteLine($"The hypotenuse of triangle with adjacents {a} and {b}: {hypotenuse(a, b)}");

            // write a function to check if all elements in an array are identical
            int[] homogenous = {5, 5, 5, 5, 5};
            bool isHomogenous<Type>(Type[] data) {
                foreach(Type value in data)
                    if(!EqualityComparer<Type>.Default.Equals(value, data[0]))
                        return false;
                return true;
            }
            Console.WriteLine($"{string.Join(" ", homogenous)} is homogenous: {isHomogenous(homogenous)}");
            Console.WriteLine($"{dataText} is homogenous: {isHomogenous(data)}");
        }
    }

    struct Extremes {
        public int minimum;
        public int maximum;
    }
}