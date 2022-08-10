using System.Text;

namespace LeetCodeСhallenge.LeetCode;

public class IntegerToRomanTask
{
    public string IntToRoman(int num)
    {
        var listConnections = ConnectionsListInit()
            .OrderByDescending(r=>r.integer)
            .ToList();

        var stackOfNumberDigits = PrepareStackOfNumberDigits(num);

        StringBuilder result = new StringBuilder();

        var countNumbers = stackOfNumberDigits.Count;

        for (int i = 0; i < countNumbers; i++)
        {
            var digit = stackOfNumberDigits.Pop();
            result.Append( DecodeIntegerToRoman(listConnections, digit) );
        }

        return result.ToString();
    }

    private static string DecodeIntegerToRoman(List<(string roman, int integer)> listConnections, int digit)
    {
        string result = string.Empty;
        
        while (digit > 0)
        {
            for (int i = 0; i < listConnections.Count; i++)
            {
                if (digit - listConnections[i].integer >= 0)
                {
                    digit -= listConnections[i].integer;
                    result += listConnections[i].roman;
                    i = -1;
                }

                if (digit.Equals(0))
                {
                    break;
                }
            }
        }

        return result;
    }

    private static Stack<int> PrepareStackOfNumberDigits(int num)
    {
        Stack<int> resultNumberDigit = new Stack<int>();
        var numberDigit = 1;
        while (num > 0)
        {
            var lastDigit = num % 10;
            if (lastDigit > 0)
                resultNumberDigit.Push(lastDigit * numberDigit);
            
            num /= 10;
            numberDigit *= 10;
        }

        return resultNumberDigit;
    }
    
    private static List<(string roman, int integer)> ConnectionsListInit()
    {
        return new List<(string roman, int integer)>()
        {
            ( "I", 1 ),
            ( "IV", 4 ),
            ( "V", 5 ),
            ( "IX", 9 ),
            ( "X", 10 ),
            ( "XL", 40 ),
            ( "L", 50 ),
            ( "XC", 90 ),
            ( "C", 100),
            ( "CD", 400),
            ( "D", 500),
            ( "CM", 900),
            ( "M", 1000 )
        };
    }
}