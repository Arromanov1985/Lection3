﻿//void Method1()
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
///{
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

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
}