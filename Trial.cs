using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trial : Software
{
    public DateTime InstallDate { get; set; }
    public int TrialPeriodMonths { get; set; }

    public Trial(string name, string manufacturer, DateTime releaseDate, DateTime installDate, int trialPeriodMonths)
        : base(name, manufacturer, releaseDate)
    {
        InstallDate = installDate;
        TrialPeriodMonths = trialPeriodMonths;
    }

    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Trial Software: {Name}, Manufacturer: {Manufacturer}, Release Date: {ReleaseDate.ToShortDateString()}, " +
                          $"Install Date: {InstallDate.ToShortDateString()}, Trial Period: {TrialPeriodMonths} months");
    }

    
    public override bool IsUsable()
    {
        DateTime expirationDate = InstallDate.AddMonths(TrialPeriodMonths);
        return DateTime.Now < expirationDate;
    }
}
