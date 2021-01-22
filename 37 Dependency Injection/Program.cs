using System;

namespace _37_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Add();

            var user_IoC = new User_IoC(new MySqlDabase());
            user_IoC.Add();

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
        public void Add()
        {
            database.Persist();
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
        public void Add()
        {
            _database.Persist();
        }
    }

    // Database Access Layer
    public class SqlServerDatabase          // Bad way
    {
        public void Persist()
        {
            Console.WriteLine("SqlServer Database");
        }
    }

    public class OracleDatabase : Database  // Good way
    {
        public void Persist()
        {
            Console.WriteLine("Oracle Database");
        }
    }

    public class MySqlDabase : Database
    {
        public void Persist()
        {
            Console.WriteLine("MySql Database");
        }
    }

    public interface Database
    {
        public void Persist();
    }





}
