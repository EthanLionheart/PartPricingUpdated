using System.Collections.Generic;

namespace ReadFromTextFile
{
    public class PartRecordOperations
    {
        public static Dictionary<int, Part> UpdatePrices(Dictionary<int, Part> newPrices, Dictionary<int, Part> partsList)
        {
            foreach (KeyValuePair<int, Part> kvp in newPrices)
            {
                if (partsList.ContainsKey(kvp.Key))
                {
                    partsList[kvp.Key].Price = kvp.Value.Price;
                };
            };
            return partsList;
        }
    }
}
