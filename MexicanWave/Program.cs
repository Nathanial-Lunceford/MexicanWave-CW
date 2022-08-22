
internal class Program
{
    public static List<string> wave(string str)
    {
        List<string> list = new List<string>();

        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] != ' ')
            {
                char upperCase = char.ToUpper(str[i]);
                string add = str.Substring(0, i) + upperCase + str.Substring(i + 1);
                list.Add(add);
            }
        }
        return list;
    }

    static void Main(string[] args)
    {
        string s = "two words";
        List<string> l = wave(s);
        l.ForEach(Console.WriteLine);
    }
}