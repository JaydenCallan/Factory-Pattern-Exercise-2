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

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public interface IDataAccess
    {
        List<Product> LoadData();
        void SaveData();
    }

    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from list");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a list");
        }
    }

    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }

    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }

    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    throw new ArgumentException("Invalid database type");
            }
        }
    }
}
