// Exercise 5.2.3

using System.Diagnostics;

const int maxValue = 5000000;

Stopwatch sw = Stopwatch.StartNew();
List<int> primes = new() { 2 };

for (int i = 3; i <= maxValue; i += 2)
{
    bool isPrime = true;
    var sqrt = Math.Sqrt(i);

    foreach (var j in primes)
    {
        if (j > sqrt)
        {
            break;
        }

        if (i / j * j == i)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        primes.Add(i);
    }
}

Console.WriteLine($"Took {sw.ElapsedMilliseconds:N0} ms");

//foreach (var i in primes)
//{
//    Console.WriteLine(i);
//}
