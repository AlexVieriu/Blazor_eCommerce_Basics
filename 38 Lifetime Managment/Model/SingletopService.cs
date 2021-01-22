using System;

namespace _38_Lifetime_Managment.Model
{
    public class SingletopService : ISingletopService
    {
        private string _guid;
        public SingletopService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
