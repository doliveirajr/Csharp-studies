namespace Testing
{
    public class New(string name_)
    {
        private readonly string name_ = name_;

        public override string ToString() => $"The new son! {name_}";

        public override int GetHashCode() => base.GetHashCode();
    }
}