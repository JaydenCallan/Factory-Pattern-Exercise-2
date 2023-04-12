namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("Enter a database type (list, sql, or mongo) or 'exit' to exit: ");
                string userInput = Console.ReadLine();

                if (userInput == "exit") { break; }

                IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(userInput);

                dataAccess.LoadData();
                dataAccess.SaveData();

                Console.WriteLine("\n\n");
            }
        }
    }
}
