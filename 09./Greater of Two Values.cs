namespace _09_;
class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        switch(type)
        {
            case "int":
                int firstInt = int.Parse(a);
                int secondInt = int.Parse(b);

                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
                break;
            case "char":
                char firstChar = char.Parse(a);
                char secondChar = char.Parse(b);

                char resultChar = GetMax(firstChar, secondChar);
                Console.WriteLine(resultChar);
                break;
            case "string":
                string resultString = GetMax(a, b);
                Console.WriteLine(resultString);

                break;


                


        }
            
    }

    static string GetMax(string a, string b)
    {

        int sumA = 0;
        int sumB = 0;

        for(int i=0;i<a.Length;i++)
        {
            sumA += a[i];
        }
        for(int i=0;i<b.Length;i++)
        {
            sumB += b[i];
        }

        if(sumA>sumB)
        {
            return a;
        }
        else
        {
            return b;
        }

    }

    static char GetMax(char firstChar, char secondChar)
    {
        if(firstChar>secondChar)
        {
            return firstChar;
        }
        else
        {
            return secondChar;
        }
    }


     static int GetMax(int firstInt, int secondInt)
    {
        if(firstInt>secondInt)
        {
            return firstInt;
        }
        else
        {
            return secondInt;
        }
    }
}

