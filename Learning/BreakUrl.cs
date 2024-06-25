public class BreakUrl
{
    public string Break(string url)
    {
        string www = "www.";
        int count = 0;
        for (int i = 0; i < 4; i++)
        {
            if (url[i] == www[i])
            {
                count++;
            }
        }
        if (count == 4)
        {
            url = url.Remove(0, 4);
        }
        return url;
    }
}