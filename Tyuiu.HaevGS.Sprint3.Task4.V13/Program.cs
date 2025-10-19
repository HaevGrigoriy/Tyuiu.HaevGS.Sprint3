using Tyuiu.HaevGS.Sprint3.Task4.V13;
using Tyuiu.HaevGS.Sprint3.Task4.V13.Lib;

DataService ds = new DataService();

int startValue = -5;
int stopValue = 5;

Console.WriteLine(ds.Calculate(startValue, stopValue));
Console.ReadKey();