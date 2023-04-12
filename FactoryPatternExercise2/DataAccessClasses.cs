using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
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
}
