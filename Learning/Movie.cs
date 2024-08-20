namespace HelloWorld.Learning
{
    public class Movie(string title, string review, int score)
    {
        private string title_ = title, review_ = review;
        private int score_ = score;
        private bool Fresh { get { return Score > 75; } }

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
}