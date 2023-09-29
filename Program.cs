int[] inputBuffer = { };

void showHelp()
{
    string action = inputBuffer.Length > 0 ? "продолжить" : "начать";
    Console.WriteLine($"Нажмите 1 + Enter, для выполнения команды 1: {action} ввод элементов массива");
    if (inputBuffer.Length > 0)
    {
        Console.WriteLine("Нажмите 2 + Enter, для выполнения команды 2: завершить ввод элементов массива и вывести результат");
        Console.WriteLine("Нажмите 3 + Enter, для выполнения команды 3: очистить массив");
    }
    Console.WriteLine("Нажмите 4 + Enter, для выполнения команды 4: задать параметры генерации массива случайных чисел и вывести результат");
    Console.WriteLine("Нажмите 5 + Enter, для выхода из программы");
}
int[] filterEvens(int[] array)
{
    int[] result = { };
    int[] tmpArray = new int[10];
    int tal = 0;
  for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            continue;
        }
        tmpArray[tal++] = array[i];
        if (tal >= tmpArray.Length)
        {
            int oldSize = result.Length;
            Array.Resize(ref result, oldSize + tal);
            Array.ConstrainedCopy(tmpArray, 0, result, oldSize, tal);
            tal = 0;
        }
    }

    if (tal > 0)
    {
        int oldSize = result.Length;
        Array.Resize(ref result, oldSize + tal);
        Array.ConstrainedCopy(tmpArray, 0, result, oldSize, tal);
    }

    return result;
}



