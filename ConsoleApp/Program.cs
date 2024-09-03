using BaseProblems.Solutions;
using BaseProblems.HelperClasses;
using BaseProblems.Solutions.EasySolution;
using BaseProblems.Solutions.MediumSolution;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp;
using System.Linq.Expressions;



var filterParam = new List<int> { 1, 2, 3, 4 };
var test1 = new List<int> { };
var test2 = new List<int> { 1 };
var test3 = new List<int> { 1, 2, 3, 4 };
var test4 = new List<int> { 1, 2, 3, 4, 5 };
var test5 = new List<int> { 5 };

Console.WriteLine(test1.All(x => filterParam.Contains(x)));
Console.WriteLine(test2.All(x => filterParam.Contains(x)));
Console.WriteLine(test3.All(x => filterParam.Contains(x)));
Console.WriteLine(test4.All(x => filterParam.Contains(x)));


var a = new HashSet<int>(test1);
var b = new HashSet<int>(test2);
var c = new HashSet<int>(test3);
var d = new HashSet<int>(test4);
var e = new HashSet<int>(test5);

var f = new List<string>() { "ssss", "ssss", "eeeee", "ffff" };
Expression<Func<Car, bool>> g = (x) => f.Count == 0 || new HashSet<string>(f).SetEquals(x.BodyTypes.Select(x => x.Name));
Expression<Func<Car, bool>> ef = (x) => !f.Except(x.BodyTypes.Select(x => x.Name)).Any() && !(x.BodyTypes.Select(x => x.Name)).Except(f).Any();
Console.WriteLine(a.SetEquals(filterParam));
Console.WriteLine(b.SetEquals(filterParam));
Console.WriteLine(c.SetEquals(filterParam));
Console.WriteLine(d.SetEquals(filterParam));

Console.WriteLine($"{!test1.Except(filterParam).Any()}{!filterParam.Except(test1).Any()}");
Console.WriteLine($"{!test2.Except(filterParam).Any()}{!filterParam.Except(test2).Any()}");
Console.WriteLine($"{!test3.Except(filterParam).Any()}{!filterParam.Except(test3).Any()}");
Console.WriteLine($"{!test4.Except(filterParam).Any()}{!filterParam.Except(test4).Any()}");