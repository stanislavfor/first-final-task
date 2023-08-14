// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

class Program
{
  static void Main(string?[] args)
  {   

    Console.Write("Укажите длину одномерного массива (количество элементов): ");
    int eCount = Convert.ToInt32(Console.ReadLine());

    string[] myArray = new string[eCount];
    
    for (int i = 0; i < myArray.Length; i++)
    {
      Console.WriteLine($"Введите элемент массива {i+1} и нажмите Enter: ");
      string e = myArray[i];
      myArray[i] = Console.ReadLine()!;        
    }

    string separator = "', '";

    void Quote()
    {
      Console.Write("'");
    }

    void stringArray(string[] strings)
    {
      Quote();
      Console.Write(string.Join(separator, strings));
      Quote();
      Console.Write("]");
    }

    void printArray(string[] result)
    {
      Quote();
      Console.Write(string.Join(separator, result));
      Quote();
      Console.Write("]");
    }


    Console.WriteLine("Вывод массива: ");
    var strings = myArray.ToArray();    
    Console.Write("myArray = [");
    stringArray(strings);


    Console.WriteLine("\nРезультат: ");    
    var result = myArray.Where(elem => elem.Length <= 3).ToArray();    
    Console.Write("-> [");
    printArray(result);    

    Console.WriteLine();
    Console.WriteLine();
    
  }


}
