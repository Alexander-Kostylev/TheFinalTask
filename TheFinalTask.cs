// Итоговая работа по основному блоку
// Создание нового массива строк, из имеющегося,
// длинна строки которого меньше или равна 3 символам.

string [] ReadData(string mes)
{
    Console.WriteLine(mes);

    int countArr = int.Parse(Console.ReadLine() ?? "0");
    string[] arr = new string [countArr];
    
    for (int i = 0; i < countArr; i++)
    {
        arr[i] = Console.ReadLine();
    }

    return arr;
}


string [] startArr = ReadData("Укажите количество строк в массиве");
