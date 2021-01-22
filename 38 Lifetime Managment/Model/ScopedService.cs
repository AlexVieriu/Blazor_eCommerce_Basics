using System;

namespace _38_Lifetime_Managment.Model
{
    public class ScopedService : IScopedService
    {
        private string _guid;
        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
