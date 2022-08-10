namespace LeetCodeСhallenge.LeetCode;

public class RomanToIntTask
{
    public int RomanToInt(string s) {
        var lastCharIndex = s.Length - 1;
        int charIndex = 0;
        var result = 0;
        var sum = 0;
        
        while(charIndex < lastCharIndex){
            sum = DecodeRomanToInt(s[charIndex] + s[charIndex + 1].ToString());
            
            if(sum == 0){
                sum = DecodeRomanToInt(s[charIndex].ToString());
                charIndex++;
            }
            else{
                charIndex += 2;
            }
            
            result += sum;
        }
       
        if(charIndex == lastCharIndex){
            result += DecodeRomanToInt(s[charIndex].ToString());
        }
        
        return result;
    }
    
    private static int DecodeRomanToInt(string romanChar)
    {
        Console.WriteLine(romanChar);
        switch(romanChar)
        {
            case "I":
                return 1;
            case "V":
                return 5;
            case "X":
                return 10;
            case "L":
                return 50;
            case "C":
                return 100;
            case "D":
                return 500;
            case "M":
                return 1000;
            case "IV":
                return 4;
            case "IX":
                return 9;
            case "XL":
                return 40;
            case "XC":
                return 90;
            case "CD":
                return 400;
            case "CM":
                return 900;
            default:
                return 0;  
        }
    }
}