// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа массива через пробел");
int[] arr_user = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < arr_user.Length; i++)
{
    if(arr_user[i] > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество элементов > 0 = {count}");



