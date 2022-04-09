// write a function to check if an array af numbers
// contains a certain value

int[] data = {-43, 23, -76, 0, 33, -98, 61};
int numberIncluded = 23;
int numberNotIncluded = -22;

bool includes (int[] data, int number) {
    foreach (int n in data)
        if(n == number) return true;
    return false;
}

Console.WriteLine($"Is {numberIncluded} in {string.Join(' ', data)}: {includes(data, numberIncluded)}");

Console.WriteLine($"Is {numberNotIncluded} in {string.Join(' ', data)}: {includes(data, numberNotIncluded)}");