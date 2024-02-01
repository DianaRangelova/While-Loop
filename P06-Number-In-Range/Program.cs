int n = int.Parse(Console.ReadLine());
bool isInRange = n >= 1 && n <= 100;

while (!isInRange)
{
    n = int.Parse(Console.ReadLine());
    isInRange = n >= 1 && n <= 100;
}
Console.WriteLine(n);

//Version2:
//while (true)
//{ 
//   if (n >= 1 && n <= 100)
//{
//break;
//}
//n = int.Parse(Console.ReadLine());
//}
//Console.WriteLine(n);