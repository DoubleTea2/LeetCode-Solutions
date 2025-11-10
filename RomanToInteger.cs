public class Solution
{
    static Dictionary<char, int> numeralValueDict = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},


    };
    public static int RomanToInt(string s)
    {
        int result = 0;
        
        for(int i = 0; i < s.Length; i++) {
           if(i + 1 < s.Length && numeralValueDict[s[i]] < numeralValueDict[s[i+1]])
            {
                result += (numeralValueDict[s[i + 1]] - numeralValueDict[s[i]]);
                i++;
            }else
            {
                result += numeralValueDict[s[i]];
            }
           
        }
        return result;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine(RomanToInt("MCMXCIV"));
        Console.ReadKey();
    }

}