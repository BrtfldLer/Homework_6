// пользователь вводит с клавиатуры М чисел
// посчитать, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите целые числа через пробел: ");
string numb = Convert.ToString(Console.ReadLine());
string[] numbarray = numb.Split(" ");
int [] ConvertNumb = new int [numbarray.Length];
for (int i = 0; i < numbarray.Length; i++)
{
ConvertNumb[i] = Convert.ToInt32(numbarray[i]);
}
int CountNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}
System.Console.Write("Количество чисел больше 0 равно ");
System.Console.Write(CountNumb(ConvertNumb));