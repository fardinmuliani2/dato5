using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Software objects
        List<Software> softwareList = new List<Software>
        {
            new Free("LibreOffice", "The Document Foundation", new DateTime(2019, 4, 5)),
            new Trial("Photoshop Trial", "Adobe", new DateTime(2022, 1, 15), new DateTime(2023, 3, 1), 3),
            new Commercial("Microsoft Office", "Microsoft", new DateTime(2021, 10, 15), 150.0, new DateTime(2022, 5, 1), 12)
        };

        // Display all software information
        Console.WriteLine("All Software Information:");
        foreach (var software in softwareList)
        {
            software.DisplayInfo();
        }

        // Display usable software as of the current date
        Console.WriteLine("\nUsable Software as of Today:");
        foreach (var software in softwareList)
        {
            if (software.IsUsable())
            {
                software.DisplayInfo();
            }
        }
    }
}
