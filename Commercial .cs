using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Commercial : Software
{
    public double Price { get; set; }
    public DateTime InstallDate { get; set; }
    public int ExpirationMonths { get; set; }

    public Commercial(string name, string manufacturer, DateTime releaseDate, double price, DateTime installDate, int expirationMonths)
        : base(name, manufacturer, releaseDate)
    {
        Price = price;
        InstallDate = installDate;
        ExpirationMonths = expirationMonths;
    }

    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Commercial Software: {Name}, Manufacturer: {Manufacturer}, Release Date: {ReleaseDate.ToShortDateString()}, " +
                          $"Price: {Price}, Install Date: {InstallDate.ToShortDateString()}, Expiration Period: {ExpirationMonths} months");
    }

    
    public override bool IsUsable()
    {
        DateTime expirationDate = InstallDate.AddMonths(ExpirationMonths);
        return DateTime.Now < expirationDate;
    }
}
