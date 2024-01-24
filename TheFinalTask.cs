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

string [] Filter(string [] tempArr)
{
    int count = 0;
    
    for(int i = 0; i < tempArr.Length; i++)
    {
        if(tempArr[i].Length <= 3)
        {
            count++;
        }
    }

    string [] resultArr = new string [count];
    int tempIndex = 0;

    for(int i = 0; i < tempArr.Length; i++)
    {
        if(tempArr[i].Length <= 3)
        {
            resultArr[tempIndex] = tempArr[i];
            tempIndex++;
        }
    }
    
    return resultArr;
}

void PrintData(string [] array)
{   
    if(array.Length == 0)
    {
        Console.Write("[]");
    }
    else if(array.Length == 1)
    {
        Console.Write("[" + array[0] + "]");
    }
    else{
        Console.Write("[ ");
        for( int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1] + "]");
    }
}

string [] startArr = ReadData("Укажите количество строк в массиве");
string [] endArr = Filter(startArr);
PrintData(endArr);

