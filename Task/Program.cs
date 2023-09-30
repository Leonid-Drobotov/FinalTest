Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine();
    string[] inputArray = input.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

    int count = 0; 
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0; 
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    string inputOutput = string.Join("\", \"", inputArray);
    string resultOutput = string.Join("\", \"", resultArray);
    Console.WriteLine($"[\"{inputOutput}\"] -> [\"{resultOutput}\"]");