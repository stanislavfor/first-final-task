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
    
    Console.WriteLine("Вывод массива: ");
    var strings = myArray.ToArray();
    string separator = "', '";
    Console.Write("myArray = ['");
    Console.Write(string.Join(separator, strings));
    Console.Write("']");

    Console.WriteLine("\nРезультат: ");    
    var result = myArray.Where(elem => elem.Length <= 3).ToArray();

    void Quote()
    {      
      Console.Write("'");    
    }

    Console.Write("-> [");
    Quote();
    Console.Write(string.Join(separator, result!));
    Quote();
    Console.Write("]");
    
    Console.WriteLine();
    Console.WriteLine();
    
  }

  

}
