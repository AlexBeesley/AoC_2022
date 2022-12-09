Console.WriteLine("Welcome to day two");

// Part 1

// Rock, A, X, 1
// Paper, B, Y, 2
// Scissors, C, Z, 3
// W = 6, D = 3, L = 0

var file = File.ReadAllLines("C:\\dev\\AoC 2022\\Day1\\Day2\\input.txt");
var list = new List<string>(file);
int score = 0;
foreach (var item in list)
{
    string ElfTry = item.Substring(0, 1);
    string YourTry = item.Substring(2, 1);
    switch (ElfTry)
    {
        case "A":
            switch (YourTry)
            {
                case "X":
                    score = score + (1 + 3);
                    break;
                case "Y":
                    score = score + (2 + 6);
                    break;
                case "Z":
                    score = score + (3);
                    break;
            }
            break;
        case "B":
            switch (YourTry)
            {
                case "X":
                    score = score + (1);
                    break;
                case "Y":
                    score = score + (2 + 3);
                    break;
                case "Z":
                    score = score + (3 + 6);
                    break;
            }
            break;
        case "C":
            switch (YourTry)
            {
                case "X":
                    score = score + (1 + 6);
                    break;
                case "Y":
                    score = score + (2);
                    break;
                case "Z":
                    score = score + (3 + 3);
                    break;
            }
            break;
    }
}
Console.WriteLine(score);


// Part 2

// X = L, Y = D, Z = W 

score = 0;
foreach (var item in list)
{
    string ElfTry = item.Substring(0, 1);
    string YourTry = item.Substring(2, 1);
    switch (ElfTry)
    {
        case "A":
            switch (YourTry)
            {
                case "X":
                    score = score + (3);
                    break;
                case "Y":
                    score = score + (1 + 3);
                    break;
                case "Z":
                    score = score + (2 + 6);
                    break;
            }
            break;
        case "B":
            switch (YourTry)
            {
                case "X":
                    score = score + (1);
                    break;
                case "Y":
                    score = score + (2 + 3);
                    break;
                case "Z":
                    score = score + (3 + 6);
                    break;
            }
            break;
        case "C":
            switch (YourTry)
            {
                case "X":
                    score = score + (2);
                    break;
                case "Y":
                    score = score + (3 + 3);
                    break;
                case "Z":
                    score = score + (1 + 6);
                    break;
            }
            break;
    }
}
Console.WriteLine(score);