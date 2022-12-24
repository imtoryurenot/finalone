// Написать программу, которая из имеющегося массива 
// строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
// Пример: 
// [hello, 2, world, :-)] -> [2, :-)] 
// ["1234","1567","-2","computer science"] -> ["-2"] 
// ["Russia","Denmark","Kazan"] -> [] 
 
void PrintArray(string[] array, string message) // метод для выводв массива 
{ 
    string result = message; 
    if (array.Length == 0) result += "There are no elements in array"; 
    for (int i = 0; i < array.Length; i++) 
    { 
        result += $"{array[i]}, "; 
    } 
    System.Console.WriteLine(result.TrimEnd(' ', ',')); // убираем разделители 
} 
 
