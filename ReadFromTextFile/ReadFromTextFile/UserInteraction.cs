using System;

namespace ReadFromTextFile
{
    class UserInteraction
    {
        public string GetUserPartsFilename()
        {
            string partsFile = "PartDataFile.txt";
            Console.WriteLine("Welcome to the parts repricing program.  Please provide the name of the Parts Data File text file.  If none selected, will default to PartDataFile.txt");
            string userNewPartsFile = Console.ReadLine();
            return  userNewPartsFile == string.Empty ? partsFile : userNewPartsFile;
        }

        public string GetUserNewPriceFilename()
        {
            string priceUpdateFile = "PartRepriceFile.txt"; 
            Console.WriteLine("Please provide the name of the new pricing file.  If none selected, will default to PartRepriceFile.txt");
            string userNewPricesFilename = Console.ReadLine();
            return userNewPricesFilename == string.Empty ? priceUpdateFile : userNewPricesFilename;
        }
    }
}
