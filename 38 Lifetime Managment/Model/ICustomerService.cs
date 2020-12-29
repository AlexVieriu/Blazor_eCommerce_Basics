namespace Lifetime_Managment.Model
{
    public interface ICustomerService
    {
        public string UniqueId { get; set; }
        public Customer GetCustomerById(int id);
    }
}
