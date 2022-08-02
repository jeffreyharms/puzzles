static int[] RandomArray() {
    Random rand = new Random();
    int[] randArray = new int[10];
    int min = 25;
    int max = 0;
    int total = 0;
    for(int i = 0; i < randArray.Length; i++) {
        randArray[i] = rand.Next(5, 25);
        Console.WriteLine(randArray[i]);
        total += randArray[i];
        if(randArray[i] > max) {
            max = randArray[i];
        }
        if(randArray[i] < min) {
            min = randArray[i];
        }
    }
    Console.WriteLine("min value: " + min);
    Console.WriteLine("max value: " + max);
    Console.WriteLine("total value: " + total);
    return randArray;
}

RandomArray();

static double TossCoin(int num) {
    int headsCount = 0;
    int tailsCount = 0;
    double ratio = 0;
    Random coin = new Random();
    for (int z = 0; z <= num; z++) {
        Console.WriteLine("Tossing a Coin!");
        int flip = coin.Next(1, 3);
        if(flip == 1) {
            Console.WriteLine("Heads!");
            headsCount += 1;
        }
        else {
            Console.WriteLine("Tails!");
            tailsCount += 1;
        }
    }
    ratio = headsCount/(headsCount + tailsCount);
    Console.WriteLine("The ratio of heads flips to total flips is: " + ratio);
    return ratio;
}

TossCoin(11);

static List<string> Names() {
    Random rand = new Random();
    List<string> newNames = new List<string>() {};
    List<string> names = new List<string>() {
        "Todd",
        "Tiffany",
        "Charlie",
        "Geneva",
        "Sydney"
    };
    for (int x = 0; x < names.Count; x++) {
        if (names[x].Length <= 5) {
            names.RemoveAt(x);
        }
    }
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
    while (names.Count > 0) {
        int randIdx = rand.Next(0, names.Count);
        Console.WriteLine(names[randIdx]);
        newNames.Add(names[randIdx]);
        names.RemoveAt(randIdx);
    }
    foreach (string name in newNames)
    {
        Console.WriteLine(name);
    }
    return newNames;
}

Names();