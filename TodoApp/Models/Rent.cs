namespace TodoApp.Models;

public class Rent:BaseEntity
{
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public Boolean DayPrice { get; set; }

    public long ClientId { get; set; }
    
    public long CarId { get; set; }
    
    public Car Car { get; set; }
    public Client Client { get; set; }

}