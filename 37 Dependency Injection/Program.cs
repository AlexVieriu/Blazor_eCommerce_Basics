using System;

namespace _37_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.add("This is some data");

            var user_IoC = new User_IoC(new OracleDatabase());
            user_IoC.add("This is some data");

            Console.ReadLine();
        }
    }
    // Business Layer Logic

    // 1.Procedural Programming Flow of Control(Concrete implementation -> BAD)
    public class User
    {
        SqlServerDatabase database;
        public User()
        {
            database = new SqlServerDatabase();
        }
        public void add(string data)
        {
            database.Persist(data);
        }
    }

    // 2.Structured IoC(Abstract implementation -> GOOD)
    public class User_IoC
    {
        private readonly Database _database;

        public User_IoC(Database database)
        {
            _database = database;
        }
        public void add(string data)
        {
            _database.Persist(data);
        }
    }

    // Database Access Layer
    public class SqlServerDatabase          // Bad way
    {
        public void Persist(string data)
        {
            Console.WriteLine("SqlServer has persisted: " + data);
        }
    }

    public class OracleDatabase : Database  // Good way
    {
        public void Persist(string data)
        {
            Console.WriteLine("Oracle has persisted: " + data);
        }
    }

    public interface Database
    {
        public void Persist(string data);
    }





}
