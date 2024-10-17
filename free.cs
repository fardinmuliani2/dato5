using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Free : Software
{
    public Free(string name, string manufacturer, DateTime releaseDate)
        : base(name, manufacturer, releaseDate)
    {
    }

    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Free Software: {Name}, Manufacturer: {Manufacturer}, Release Date: {ReleaseDate.ToShortDateString()}");
    }

    
    public override bool IsUsable()
    {
        return true;
    }
}
