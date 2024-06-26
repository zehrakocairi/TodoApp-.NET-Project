using TodoApp.Dtos;

namespace TodoApp.Models;

public class Company: BaseEntity
{
    public Company()
    {
        
    } 
    public Company(CreateCompanyDto dto)
    {
        Name = dto.Name;
        Address = dto.Address;
    }
    public string Name { get; set; }
    public string Address { get; set; }
    public IEnumerable<Car> Cars { get; set; }
    
    public IEnumerable<Customer> Customers { get; set; }
}