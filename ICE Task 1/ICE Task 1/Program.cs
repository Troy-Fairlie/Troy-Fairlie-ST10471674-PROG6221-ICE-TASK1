namespace ICE_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Student Grade Calculator **");

            Console.Write("Enter the student's name: ");
            var FullName = Console.ReadLine();

            Console.Write("Enter score 1 (out of 100): ");
            var score1 = double.Parse(Console.ReadLine());

            Console.Write("Enter score 2 (out of 100): ");
            var score2 = double.Parse(Console.ReadLine());

            Console.Write("Enter score 3 (out of 100): ");
            var score3 = double.Parse(Console.ReadLine());

            if (string.IsNullOrWhiteSpace(FullName))
                throw new ArgumentException("Student name is required.", nameof(FullName));

            // Capitalize the first letter of each word (title case)
            FullName = System.Globalization.CultureInfo
                .CurrentCulture
                .TextInfo
                .ToTitleCase(FullName.Trim().ToLowerInvariant());


            // This is where i used this website and i also used Co-Pilot to help me refine it and make it suited for this application
        //https://stackoverflow.com/questions/4135317/make-first-letter-of-a-string-upper-case-with-maximum-performance



            var averageScore = (score1 + score2 + score3) / 3;

            string grade;
            if (averageScore >= 90) grade = "A";
            else if (averageScore >= 80) grade = "B";
            else if (averageScore >= 70) grade = "C";
            else if (averageScore >= 60) grade = "D";
            else grade = "F";

            Console.WriteLine("\n Grade Report **");
            Console.WriteLine($"Student Name: " + FullName);

            Console.WriteLine($"Scores: {score1}, {score2}, {score3}%");

            Console.WriteLine($"Average Score: {averageScore:F2}%");
            Console.WriteLine($"Final Grade: {grade}");

        }
    }
}
