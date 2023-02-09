using CsvHelper.Configuration;

namespace ReadFromTextFile
{
    class PartMap : ClassMap<Part>
    {
        public PartMap()
        {
            Map(p => p.PartID).Index(0);
            Map(p => p.PartDesc).Index(1);
            Map(p => p.Price).Index(2);
        }
    }
}
