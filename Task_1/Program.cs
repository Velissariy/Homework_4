// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("1 - Программа для вывода числа A, возведенное в натуральную степень B.");
Console.WriteLine("2 - Программа для вывода суммы цифр в числе N.");
Console.WriteLine("3 - Программа для вывода массива из 8 элементов и показа его на экране.");
int numberOfTask = Prompt("Введите номер задачи");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_25();
                break;

                case 2:
                Console.Clear();
                Task_27();
                break;

                case 3:
                Console.Clear();
                Task_29();
                break;

                default:
                Console.WriteLine("Номер задачи введен некорректно.");
                break;
            }
static int Prompt(string message)// Метод запроса числа.
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}


void Task_25()// Метод возведения числа в степень.
{
    int x = Prompt("Введите число А для возведения его в степень B.");
    int b = Prompt("Введите число B, которое будет степенью числа A.");
    if (Valid(b))
    {
        Console.WriteLine($"Число {x} в степени {b} равно {Degree(x, b)}");
    }
}

int Degree(int x, int b)
{
   int a1 = 1;
   for (int i = 0; i < b; i++)
   {
    a1 *= x;
   }
   return a1;
}

bool Valid( int b)
{
if (b < 0)
 {
   Console.WriteLine("показатель не должен быть меньше нуля");
   return false;
 }

return true;
}



static void Task_27()// Метод нахождения суммы цифр в числе N.
{
    int number = Prompt("Введите число для суммирования его цифр.");
    int result = SumAllDigit(number);
    Console.WriteLine($"Сумма всех чисел равна {number} = {SumAllDigit(number)}.");
}

static int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
          result += number % 10;
          number = number / 10;
    }
    return result;
}

static void Task_29() // Метод заполнения массива из 8 элементов и показа его на экране.
{
int[] Array(int Length, int minValue,int maxValue)
{
  int[] arr = new int[Length];
  Random random = new Random();
  for (int i = 0; i < Length; i++)
  {
    arr[i] = random.Next(minValue, maxValue + 1);
  }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
      System.Console.Write($"{arr[i]}, ");
    }
    System.Console.Write($"{arr[arr.Length - 1]}");
    System.Console.Write("]");
}

int length = Prompt ("Длина массива: ");
int min = Prompt ("Начальное значение, для диапазона случайного числа: ");
int max = Prompt ("Конечное значение, для диапазона случайного числа: ");
int[] arr = Array(length, min, max);
PrintArray(arr);
}