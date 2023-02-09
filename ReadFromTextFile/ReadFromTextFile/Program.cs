using System;
using System.Collections.Generic;

namespace ReadFromTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable declaration
            FileIO fileIO = new FileIO();
            Dictionary<int, Part> partsList = new Dictionary<int, Part>();
            Dictionary<int, Part> newPrices = new Dictionary<int, Part>();
            UserInteraction input = new UserInteraction();
            #endregion

            try
            {
                string partsFilename = input.GetUserPartsFilename();
                string priceFilename = input.GetUserNewPriceFilename();

                partsList = fileIO.ReadPartsTextFile(partsFilename);
                newPrices = fileIO.ReadPartsTextFile(priceFilename);
                partsList = PartRecordOperations.UpdatePrices(newPrices, partsList);

                fileIO.CreateOutputFile(partsList);
                Console.WriteLine("Success!  The updated pricing file can be found at ...ReadFromTextFile\\ReadFromTextFile\\bin\\Debug\\net5.0\\OutputFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("We've encountered an error.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please make sure the input and output files are closed before trying again.");
            }
        }
    }
}
