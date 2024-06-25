public class VoteForPresident
{
	public void Vote4President(int age)
	{
		int firstVote;
		int voteTimes;
		if (age < 18)
		{

			Console.WriteLine("Can't vote, age under 18!");
		}
		else
		{
			firstVote = age - 18;
			if (firstVote <= 4)
			{
				Console.WriteLine("Voted 1 time!");

			}
			else
			{
				voteTimes = 1 + (firstVote / 4);
				Console.WriteLine($"Voted {voteTimes} times!");
			}

		}
	}
}
