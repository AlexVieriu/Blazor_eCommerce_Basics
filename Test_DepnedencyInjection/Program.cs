using System;

namespace Test_DepnedencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.add("This is some data");

            var userIoC = new User_Ioc(new OracleDatabase());
            userIoC.Add("This is some data");

            Console.ReadLine();
        }
    }
    // Bussiness Layer 
   
    // Procedural Programming
    public class User
    {
        SqlDataBase database;
        public User()
        {
            database = new SqlDataBase();
        }

        public void add(string data)
        {
            database.Persistent(data);
        }
    }

    // Inversion of Control(IoC)

    public class User_Ioc
    {
        private readonly IOracleDatabase _data;

        public User_Ioc(IOracleDatabase data)
        {
            _data = data;
        }

        public void Add(string data)
        {
            _data.Persistent(data);
        }
    }

    // Database Layer

    public class SqlDataBase
    {
        public void Persistent(string data)
        {
            Console.WriteLine("SqlServer: " + data);
        }
    }

    public class OracleDatabase : IOracleDatabase
    {
        public void Persistent(string data)
        {
            Console.WriteLine("SqlOracle: " + data);
        }
    }

    public interface IOracleDatabase
    {
        public void Persistent(string data);
    }
}
