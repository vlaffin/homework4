//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
   //   Console.WriteLine("Введите числа a и b а программа возведёт число a в степень b");
   //  int deegre()
   //  {
   //  Console.Write("Введите число a : ");
   //  int a = int.Parse(Console.ReadLine());
   //  Console.Write("Введите число b : ");
   //  int b = int.Parse(Console.ReadLine());
   //  int i = 1;
   //  int result = 1;
   //  while(i<=b)
   //     {
   //     result= result*a;
   //     i++;
   //     }
   //  if(i>=b)
   //  {
   //     Console.WriteLine(result);
   //   }
   //   return result;
   //  }
    
   //  int result = deegre();

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//  int Sum(int number)
// {
//    if (number < 10)
//       return number;

//       return number % 10 + Sum(number / 10);
// }
//    Console.Write("Введите число, а программа покажет сумму всех чисел(извините за тафтологию)) : ");
//    int a =int.Parse (Console.ReadLine());
//     int result = Sum(a);
//     Console.WriteLine(result);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// void NewArray(int n = 8)
// {
// int[] Array = new int[n];
//        Random rand = new Random();
//         for (int i = 0; i < Array.Length; i++)
//      {
//       Array[i] = rand.Next(-20, 20); //цифры взяты сугубо для примера
//         Console.Write(Array[i] + "," );
//      }
    
// return;
// } 
// NewArray(); Console.WriteLine();

// Console.WriteLine("Вот и всё массив из 8 рандомных элементов выведен, спасибо за участие в тестировании нашего проекта)");

// Console.WriteLine("но это ещё не всё, попробуйте сами ввести числа массива)");
// void NewArray2(int n = 8)
// {
// int[] Array = new int[n];
//       for (int i = 0; i < Array.Length; i++)
//      {
//       Console.Write($"Введите элемент массива по индексом {i} : ");
//         Array[i]= int.Parse(Console.ReadLine());
//      }
//      Console.Write("Ваш массив :");
//      for (int i = 0; i < Array.Length; i++)
//     {
//       Console.Write($"{Array[i]},");
//     }
//     return;
// }
// NewArray2();  Console.WriteLine();
// Console.WriteLine(" Вот и всё массив из 8 ваших элементов выведен, спасибо за участие в тестировании нашего проекта)");