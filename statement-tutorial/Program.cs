
int[] nbrs = {
   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561
};
int highestNbr = nbrs[0];
int lowestNbr = nbrs[0];
foreach (int nbr in nbrs)
{
    if (nbr < lowestNbr)
    {
        lowestNbr = nbr;
    }
    if (nbr > highestNbr)
    {
        highestNbr = nbr;
    }
}
Console.WriteLine($"lowest number is {lowestNbr} and the highest number is {highestNbr}");

/*
string[] names = { "rob", "trever", "jacob", "jason", "skyler", "jake", "jace", "lynn", "tim"};
foreach(var fred in names)
{
    Console.WriteLine(fred);
}


int sum = 0;
for (int i = 1; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
        sum = sum + i;
        Console.WriteLine($"i={i}, sum={sum}");
}


int sum = 0;
for (int i = 0; i < 100; i++)
{
    sum = sum + i;
    Console.WriteLine($"i={i}, sum={sum}");
}



int i = 0;
int sum = 0;
while(i < 10)
{
    sum = sum + i;
    i = i +1;
    Console.WriteLine($"i is {i}, sum is {sum}");
}
8?
/*

Console.Write("Enter and integer: ");
string? answerString = Console.ReadLine();

int answer = Convert.ToInt32(answerString);

string evenOdd = "";

if (answer % 2 == 0)
{
    evenOdd = "Even";
}
else
{
    evenOdd = "Odd";
}

Console.WriteLine($"The number {answer} is {evenOdd}");
*/