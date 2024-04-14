Random Rnd = new Random((int)DateTime.Today.Ticks & 0x0000FFFF);
Console.WriteLine(string.Format("Today is {0}", DateTime.Now.ToLongDateString()));
Console.WriteLine();
Console.WriteLine("Hello Reasors Monopoly!");
bool bAgain;
do
{
    Console.WriteLine();
    Console.WriteLine("Here are your pick 3 numbers!");
    int iLastBall = int.MinValue;
    Dictionary<int, int> Balls = new Dictionary<int, int>();
    for (int iRoll = 0; iRoll < 3; ++iRoll)
    {
        bool bBall = false;
        do
        {
            int iBall = Rnd.Next(1, 26);
            if (!Balls.ContainsValue(iBall))
            {
                if (Math.Abs(iBall - iLastBall) > 6)
                {
                    iLastBall = iBall;
                    Balls[iRoll] = iBall;
                    bBall = true;
                }
            }
        }
        while (!bBall);
    }
    foreach (KeyValuePair<int, int> Ball in Balls)
        Console.Write(Ball.Value + " ");
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


