using Tyuiu.HaevGS.Sprint3.Task0.V29.Lib;

DataService ds = new DataService();

double value = 0.5;
int startValue = 1;
int endValue = 10;

Console.WriteLine(ds.GetSumSeries(value, startValue, endValue));
Console.ReadKey();