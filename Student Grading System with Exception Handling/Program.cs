namespace Student_Grading_System_with_Exception_Handling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the name of the student: ");
                string name = Console.ReadLine();

                Console.Write("\nEnter the number of grade to be entred: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] grade = new double[n];

                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        Console.Write($"\nEnter the Grade {i + 1}: ");
                        grade[i] = Convert.ToInt32(Console.ReadLine());
                        if (grade[i] > 100 || grade[i] < 0)
                        {
                            throw new ArgumentException(message: "Invalid input! Grade must be between 0 to 100");
                        }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Invalid Input: Please Enter the Valid Value");
                        i--;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input: Please Enter the numaric Value");
                        i--;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        i--;
                    }
                }

                double average = 0;
                for (int i = 0; i < n; i++)
                {
                    average += grade[i];
                }

                Console.WriteLine($"\nStudent Name: {name}");
                Console.Write("Grades: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(grade[i] + ", ");
                }
                Console.WriteLine($"\nAverage Grade: {average / n}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}:{ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}