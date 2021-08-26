using System;
//using Math;
                    
public class Program
{
    public static void Main() {
		Random random = new Random();
		int num = random.Next(10); 
		Console.WriteLine("Guess a number between 1 to 10");
		string user_input = Console.ReadLine();
		int user_input_int = Convert.ToInt32(user_input);
		if (user_input_int == num) {
			Console.WriteLine("You win!");
			Console.ReadLine();
		}
		else {
			Console.WriteLine("Oops it was actually " + num);
			Console.ReadLine();
		}
	}
}
