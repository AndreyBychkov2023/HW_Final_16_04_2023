// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr_1 = {"Hello", "2", "world", ":-)"};
string[] arr_2 = {"1234", "1567", "-2", "computer science"};
string[] arr_3 = {"Russia", "Denmark", "Kazan"};
        
int symbol_lenght = 3;
        
string[] NewArray(string[] array)
{
    int length = array.Length;          
    string[] result = new string[length];
    int count = 0;
            
    for (int i = 0; i < length; i++)
    {
        if(array[i].Length <= symbol_lenght)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}
        
void PrintArray(string[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("В массиве отсутствуют строки, длина которых меньше, либо равна 3 символам");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($" *{str}*, ")); // ($" "{str}", "));  ($"{str} ")); « » » «
        Console.WriteLine();
    }
}
        
void PrintTask(string[] array)
{
    Console.WriteLine("Первоначальный массив:");
    PrintArray(array);
    string[] shortArray = NewArray(array);
    Console.WriteLine($"Новый массив:");
    PrintArray(shortArray);
    Console.WriteLine();
}
        
PrintTask(arr_1);
PrintTask(arr_2);
PrintTask(arr_3);