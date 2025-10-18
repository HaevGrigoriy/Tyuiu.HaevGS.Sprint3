using Tyuiu.HaevGS.Sprint3.Task2.V18.Lib;

DataService ds = new DataService();

int value = 1;
int startValue = 1;
int stopValue = 14;

Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();