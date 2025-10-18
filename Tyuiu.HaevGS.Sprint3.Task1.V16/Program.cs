using Tyuiu.HaevGS.Sprint3.Task1.V16.Lib;

DataService ds = new DataService();

double value = 0.7;
int startValue = 1;
int stopValue = 15;

Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();