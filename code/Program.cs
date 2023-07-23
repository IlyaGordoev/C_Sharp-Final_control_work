// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = {"Hello", "2", "world", ":-)"};                               // Варант решения с Resize()
// string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};

System.Console.WriteLine($"[{string.Join(", ", array)}]");

string[] newArray = new string[array.Length];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count ++;
    }
}

Array.Resize(ref newArray, count);
System.Console.WriteLine($"[{string.Join(", ", newArray)}]");


// string[] array = {"Hello", "2", "world", ":-)"};                            // Второй вариант решения c двумя циклами for
// // string[] array = {"1234", "1567", "-2", "computer science"};
// // string[] array = {"Russia", "Denmark", "Kazan"};

// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// int count = 0;

// for (int i = 0; i < array.Length; i++)                                      // Цикл for для определения размера массива
// {
//     if (array[i].Length <= 3)
//     {
//         count ++;
//     }
// }

// string[] newArray = new string[count];                                      // Выделение памяти под новый массив размера count

// count = 0;

// for (int i = 0; i < array.Length; i++)                                      // Цикл for для заполнения нового массива
// {
    
//     if (array[i].Length <= 3)
//     {
//         newArray[count] = array[i];
//         count++;
//     }
// }

// System.Console.WriteLine($"[{string.Join(", ", newArray)}]");