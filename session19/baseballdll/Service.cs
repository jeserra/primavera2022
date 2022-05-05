namespace baseballdll;
public class Service
{
    public string GetLastWord (List<String> words)
    {
        if (words.Count == 0)
        {
            return "";
        }
        else
            return words.Last();
    }

    public int SumaNormal (int x, int y) => x + y;
}
