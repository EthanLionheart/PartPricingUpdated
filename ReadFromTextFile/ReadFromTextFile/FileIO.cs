using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ReadFromTextFile
{
    public class FileIO
    {
        public CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = "*!*",
            HeaderValidated = null,
            MissingFieldFound = null
        };
        string outputfile = "OutputFile.txt";

        public Dictionary<int, Part> ReadPartsTextFile(string partsFile)
        {
            Dictionary<int, Part> results = new Dictionary<int, Part>();
            using (var reader = new StreamReader(partsFile))
            using (var csv = new CsvReader(reader, configuration))
            {
                var parts = csv.GetRecords<Part>();
                results = parts.ToDictionary(kvp => kvp.PartID, kvp => kvp);
            };
            return results;
        }


        public void CreateOutputFile(Dictionary<int, Part> recordsToWrite)
        {
            using (var writer = new StreamWriter(outputfile))
            using (var csv = new CsvWriter(writer, configuration))
            {
                csv.WriteRecords(recordsToWrite.Values);
            };
        }
    }
}
