Console.WriteLine("Welcome to day one");

// Part 1
var file = File.ReadAllLines("C:\\dev\\AoC 2022\\Day1\\Day1\\input.txt");
var list = new List<string>(file);
var dir = new List<int>();
var id = 0;
var tempcalcount = 0;

for (var i = 0; i < list.Count; i++)
{
    try
    {
        tempcalcount = tempcalcount + Convert.ToInt32(list[i]);
    }
    catch { 
        id = id + 1;
        dir.Add(tempcalcount);
        tempcalcount = 0;
    }
}

var answer1 = dir.MaxBy(x => x);
Console.WriteLine("Part 1: " + answer1);

//Part 2
var top1 = answer1;
var top2 = (from number in dir orderby number descending select number).Distinct().Skip(1).First();
var top3 = (from number in dir orderby number descending select number).Distinct().Skip(2).First();

var answer2 = top1 + top2 + top3;

Console.WriteLine("Part 1: " + answer2);