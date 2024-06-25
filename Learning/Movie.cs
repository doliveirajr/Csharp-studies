public class Movie
{
    private string title_, review_;
    private int score_;
    private bool Fresh { get { return Score > 75; } }
    public Movie(string title, string review, int score)
    {
        title_ = title;
        review_ = review;
        score_ = score;
    }

    public string Tittle
    {
        set => title_ = value;
        get => title_;
    }

    public string Review
    {
        set => review_ = value;
        get => review_;
    }

    public int Score
    {
        set => score_ = value;
        get => score_;
    }

    public override string ToString()
    {
        string description = $"-> {Tittle}\n\tRated {Review}\n\t{Score}% on RT ";

        if (Fresh)
        {
            description += "- Certified Fresh!";
        }
        return description;
    }


}