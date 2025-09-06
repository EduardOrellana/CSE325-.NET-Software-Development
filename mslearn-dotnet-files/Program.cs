using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Diagnostics;

var salesFiles = Findf("stores");
//Create file SalesSummary.txt

var summaryFile = Path.Combine(Directory.GetCurrentDirectory(), "SalesSummary.txt");

//Start the report:
File.WriteAllText(summaryFile, "Sales Summary Report\n====================\n");

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

IEnumerable<string> Findf(string folderName)
{
    List<string> salesFilesFolders = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        Debug.WriteLine(file);

        if (file.EndsWith("sales.json"))
        {
            salesFilesFolders.Add(file);
        }
    }

    return salesFilesFolders; // ✅ corregido
}
