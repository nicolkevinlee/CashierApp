using Microsoft.VisualBasic.FileIO;

namespace CashierApp.DataAccessor;

internal class CsvAccessor : IDataAccessor
{
    public List<string[]> Read(string filePath)
    {

        var csvData = new List<string[]>();
        using (TextFieldParser parser = new TextFieldParser(filePath))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[]? fields = parser.ReadFields();
                if (fields is not null) csvData.Add(fields);
            }
        }
        return csvData;
    }
}
