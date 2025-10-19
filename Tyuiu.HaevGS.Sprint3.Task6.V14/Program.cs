using Tyuiu.HaevGS.Sprint3.Task6.V14.Lib;

DataService ds = new DataService();


int startValue = 7;
int stopValue = 16;
Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();