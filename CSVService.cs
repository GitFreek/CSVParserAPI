using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using CSVParserAPI.Services;

namespace CSVParserAPI
{
    public class CSVService : ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(Stream file)

        {
            var reader = new StreamReader(file);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<T>();
            return records;
        }


}

}