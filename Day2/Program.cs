void Step1()
{
    var input = $"655-1102,2949-4331,885300-1098691,1867-2844,20-43,4382100-4484893,781681037-781860439,647601-734894,2-16,180-238,195135887-195258082,47-64,4392-6414,6470-10044,345-600,5353503564-5353567532,124142-198665,1151882036-1151931750,6666551471-6666743820,207368-302426,5457772-5654349,72969293-73018196,71-109,46428150-46507525,15955-26536,65620-107801,1255-1813,427058-455196,333968-391876,482446-514820,45504-61820,36235767-36468253,23249929-23312800,5210718-5346163,648632326-648673051,116-173,752508-837824";

    long total = 0;

    foreach (var item in input.Split(','))
    {
        long firstNumber = long.Parse(item.Split('-')[0]);
        long lastNumber = long.Parse(item.Split('-')[1]);
        for (long i = firstNumber; i <= lastNumber; i++)
        {
            long step = i.ToString().Length;
            if (step % 2 == 0)
            {
                int split = int.Parse(step.ToString()) / 2;
                long part1 = long.Parse(i.ToString().Substring(0, split));
                long part2 = long.Parse(i.ToString().Substring(split));
                if (part1 == part2)
                {
                    total += i;
                }
            }
        }
    }

    Console.WriteLine(total);
}

bool IsRepeatedPattern(long n)
{
    string s = n.ToString();
    int len = s.Length;

    if (len < 2)
        return false;

    for (int patLen = 1; patLen <= len / 2; patLen++)
    {
        if (len % patLen != 0)
            continue;

        string pattern = s.Substring(0, patLen);
        bool allMatch = true;

        for (int i = patLen; i < len; i += patLen)
        {
            if (s.Substring(i, patLen) != pattern)
            {
                allMatch = false;
                break;
            }
        }

        if (allMatch)
        {
            return true;
        }
    }

    return false;
}


void Step2()
{
    var input = $"655-1102,2949-4331,885300-1098691,1867-2844,20-43,4382100-4484893,781681037-781860439,647601-734894,2-16,180-238,195135887-195258082,47-64,4392-6414,6470-10044,345-600,5353503564-5353567532,124142-198665,1151882036-1151931750,6666551471-6666743820,207368-302426,5457772-5654349,72969293-73018196,71-109,46428150-46507525,15955-26536,65620-107801,1255-1813,427058-455196,333968-391876,482446-514820,45504-61820,36235767-36468253,23249929-23312800,5210718-5346163,648632326-648673051,116-173,752508-837824";

    long total = 0;

    foreach (var item in input.Split(','))
    {
        long firstNumber = long.Parse(item.Split('-')[0]);
        long lastNumber = long.Parse(item.Split('-')[1]);

        for (long i = firstNumber; i <= lastNumber; i++)
        {
            if (IsRepeatedPattern(i))
            {
                total += i;
            }
        }
    }

    Console.WriteLine(total);
}

Console.WriteLine("Step 1:");
Step1();
Console.WriteLine("Step 2:");
Step2();

Console.ReadKey();