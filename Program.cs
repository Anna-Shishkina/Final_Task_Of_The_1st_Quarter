/* Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


string[] StringValidation(string[] array)
{
    string[] new_massive = new string[array.Length];
    int new_massive_index = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if (array[index].Length <= 3)
        {
            new_massive[new_massive_index] = array[index];
            new_massive_index++;
        }
    }
    return new_massive;
}

void PrintArray (string[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        Console.WriteLine (array[index]);
    } 
}

string[] array = {"hello","2","world",":-)"};
string[] res = StringValidation(array);
PrintArray(res);