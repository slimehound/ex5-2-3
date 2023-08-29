// Exercise 5.2.3

using System.Diagnostics;

const int maxValue = 300000;

Stopwatch sw = Stopwatch.StartNew();
List<int> primes = new List<int>() { 2 };

for (int i = 3; i <= maxValue; i += 2)
{
    bool isPrime = true;

    foreach (var j in primes)
    {
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


