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



