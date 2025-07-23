// See https://aka.ms/new-console-template for more information

loop:

string input = "";
input = Console.ReadLine();
int output = 0;

for (int i = 0; i < input.Length; i++)
{
    int currentNum = Convert.ToInt32(Enum.Parse<Roman>(input[i].ToString()));

    if (input.Length - 1 == i)
    {
        output += currentNum;
        break;
    }
    int nextNum = Convert.ToInt32(Enum.Parse<Roman>(input[i + 1].ToString()));

    
    if (currentNum >= nextNum) output += currentNum;

    else output -= currentNum;
}


Console.WriteLine(output);

goto loop;
public enum Roman
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000,
}
