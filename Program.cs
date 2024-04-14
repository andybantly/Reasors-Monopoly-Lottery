Random Rnd = new Random((int)DateTime.Today.Ticks & 0x0000FFFF);
Console.WriteLine(string.Format("Today is {0}", DateTime.Now.ToLongDateString()));
Console.WriteLine();
Console.WriteLine("Hello Reasors Monopoly!");
bool bAgain;
do
{
    Console.WriteLine();
    Console.WriteLine("Here are your pick 3 numbers!");
    int iLast = -1, iThis;
    for (int iRoll = 0; iRoll < 3; ++iRoll)
    {
        do
        {
            iThis = Rnd.Next(1, 26);
        }
        while (iThis == iLast);
        if (iRoll > 0)
            Console.Write(" ");
        Console.Write(iThis);
        iLast = iThis;
    }

    Console.WriteLine();
    Console.WriteLine();

    do
    {
        Console.Write("Roll again (Y/N)? ");
        string? str = Console.ReadLine();
        if (string.IsNullOrEmpty(str))
            continue;
        if (string.Compare(str, "Y", true) == 0)
        {
            bAgain = true;
            break;
        }
        if (string.Compare(str, "N", true) == 0)
        {
            bAgain = false;
            break;
        }
    } while (true);
} while (bAgain);


