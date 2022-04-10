// write a function to check if an array af numbers
// contains a certain value

int[] data = {-43, 23, -76, 0, 33, -98, 61};
int numberIncluded = 23;
int numberNotIncluded = -22;

bool Includes (int[] data, int number) {
    foreach (int n in data)
        if(n == number) return true;
    return false;
}

Console.WriteLine("Testing the includes function:");
Console.WriteLine($"Is {numberIncluded} in {string.Join(' ', data)}: {Includes(data, numberIncluded)}");
Console.WriteLine($"Is {numberNotIncluded} in {string.Join(' ', data)}: {Includes(data, numberNotIncluded)}");
Console.WriteLine("");

bool IncludesGeneric<Type>(Type[] data, Type value) {
    foreach(Type val in data)
        if(EqualityComparer<Type>.Default.Equals(val, value))
            return true;
    return false;
}

Console.WriteLine("Testing the IncludesGeneric function:");
Console.WriteLine($"Is {numberIncluded} in {string.Join(' ', data)}: {IncludesGeneric<int>(data, numberIncluded)}");
Console.WriteLine($"Is {numberNotIncluded} in {string.Join(' ', data)}: {IncludesGeneric<int>(data, numberNotIncluded)}");