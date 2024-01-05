using CustomerAPI.Context;
using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Services;
public class CustomerService : ICustomerService
{
    private readonly CustomerContext _dbContext;
    public CustomerService(CustomerContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task DeteleCustomersAsync(int customerId)
    {
        var customer = await _dbContext.Customers.FirstOrDefaultAsync(x=>x.Id == customerId);
        if(customer != null)
        {
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }
        
    }

    public async Task<List<Customer>> GetCustomersAsync()
    {
        return await _dbContext.Customers.OrderByDescending(x=>x.Id).ToListAsync();
    }

    public async Task SaveCustomersAsync(Customer customer)
    {
        _dbContext.Customers.Add(customer);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Customer>> SearchCustomersAsync(string customerName)
    {
        if (string.IsNullOrEmpty(customerName))
        {
            return await _dbContext.Customers.ToListAsync();
        }

        return await _dbContext.Customers.Where(x=>x.LastName.Contains(customerName)).ToListAsync();
    }

    public async Task UpdateCustomersAsync(Customer customer)
    {
        _dbContext.Customers.Update(customer);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Customer> GetCustomerAsync(int customerId)
    {
        return await _dbContext.Customers.FirstOrDefaultAsync(x=>x.Id == customerId);
    }
}
