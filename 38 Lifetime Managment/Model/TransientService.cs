using System;

namespace _38_Lifetime_Managment.Model
{
    public class TransientService : ITransientService
    {
        private string _guid;
        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
