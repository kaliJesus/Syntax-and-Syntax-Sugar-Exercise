namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = "";
            if (answer < 9) 
            {
                response = $"{answer} is less than nine";
            }
            else
            {
                response = $"{answer} is greater than or equal to 9";
            }
            Console.WriteLine(response);

            var response1 = (answer < 9)? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response1);
       
        }
    }
}
