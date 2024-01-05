using CustomerAPI.Models;
using CustomerAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<List<Customer>> GetCustomers()
    {
        var customersList = await _customerService.GetCustomersAsync();

        return customersList;
    }

    [HttpGet("search")]
    public async Task<List<Customer>> GetCustomer(string lastName = null)
    {
        var customersList = await _customerService.SearchCustomersAsync(lastName);

        return customersList;
    }

    [HttpGet("details")]
    public async Task<Customer> GetCustomerById(int customerId)
    {
        var customersList = await _customerService.GetCustomerAsync(customerId);

        return customersList;
    }

    [HttpPost]
    public async Task<IActionResult> SaveCustomer([FromBody] Customer customer)
    {
        if(customer == null)
        {
            return new BadRequestObjectResult("Bad request");
        }
        
        await _customerService.SaveCustomersAsync(customer);

        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateCustomer([FromBody] Customer customer)
    {
        if (customer == null)
        {
            return new BadRequestObjectResult("Bad request");
        }

        await _customerService.UpdateCustomersAsync(customer);

        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCustomer(int customerId)
    {
        await _customerService.DeteleCustomersAsync(customerId);

        return Ok();
    }
}
