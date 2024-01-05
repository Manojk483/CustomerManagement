using CustomerAPI.Models;

namespace CustomerAPI.Services;
public interface ICustomerService
{
    Task<List<Customer>> GetCustomersAsync();

    Task<Customer> GetCustomerAsync(int customerId);
    Task SaveCustomersAsync(Customer customer);
    Task UpdateCustomersAsync(Customer customer);
    Task DeteleCustomersAsync(int customerId);
    Task<List<Customer>> SearchCustomersAsync(string customerName);
}
