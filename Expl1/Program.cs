//void Method1()
//{
//   System.Console.WriteLine("Автор ФИО");
//}

//Method1();

// Method 2

//void Method2(string msg)
//{
//   Console.WriteLine(msg);
//}
//Method2(msg: "Текст сообщения");

//void Method21(string msg, int count)
//   int i = 0;
//   while (i < count)
// {
//    Console.WriteLine(msg);
//    i++;
// }
//}
//Method21(msg:"Текст", 4);
//Method21(count:"Новый Текст", 4);

//int Method3()
//{
//    return DateTime.Now.Year;
//}

//int year = Method3();
//Console.WriteLine(year);

//string Method4(int count, string c)
//{
//int i = 0;
//string result = String.Empty;

//while (i < count)
//{
// result = result + c;
// i++;
// }
//return result;
//}

//string res = Method4(10, "ASDF ");
//Console.WriteLine(res);

// for 

//string Method4(int count, string c)
//{
// string result = String.Empty;
// for (int i = 0; i < count; i++ )

//{
//   result = result + c;
//}
//return result;
//}



//string res = Method4(10, "ASDF ");
//Console.WriteLine(res);

// Таблица умножения

//for (int i = 2; i <= 10; i++)
//{
// for (int j = 2; j <= 10; j++)
// {
//   Console.WriteLine($"{i} * {j} = {i*j}");
//}
//Console.WriteLine();

//}

// Заменить буквы большие на маленькие и черточки на тире


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//               012345
// s[3]  // r


//using static System.Net.Mime.MediaTypeNames;
///{

//string Replace (string text, char oldValue, char newValue )
//{
  //  string result = String.Empty;

    //int length = text.Length;
    //for ( int i = 0; i < length; i++)
    //{
      //  if(text[i] == oldValue) result = result + $"{newValue}";
        //else result = result + $"{text[i]}";
    //}



    //return result;
//}


//string newText = Replace (text,' ','|');

//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);


// Функции в программирование Массивы

int[] arr = {1, 5, 6, 7, 8, 9, 0, 3, 3, 4, 5, 6, 6};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    { 
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }



        int temporary = array[i];
        array[i] = array [minPosition]; 
        array[minPosition] = temporary;
        }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);  // домашнее задание сделать сортировку наоборот от меньшего к большему
