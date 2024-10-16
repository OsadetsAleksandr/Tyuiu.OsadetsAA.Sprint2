using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.OsadetsAA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                    }
                    break;
                case 2:
                    if (n < 29)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < 30)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                    }
                    break;
                case 12:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                        m = 1;
                        g++;
                    }
                    break;
            }
            string y = Convert.ToString(g);
            string z = Convert.ToString(m);
            string x = Convert.ToString(n);
            if (n < 10 && m < 10)
            {
                return "0" + x + "." + "0" + z + "." + y;
            }
            else
            {
                if (n < 10)
                {
                    return "0" + x + "." + z + "." + y;
                }
                else
                {
                    if (m < 10)
                    {
                        return x + "." + "0" + z + "." + y;
                    }
                    else
                    {
                        return x + "." + z + "." + y;
                    }
                }
            }
        }
    }
}
