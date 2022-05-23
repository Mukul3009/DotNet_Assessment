using GeneralKnowledge.Test.App.Models;
using LINQtoCSV;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// CSV processing test
    /// </summary>
    public class CsvProcessingTest : ITest
    {
        public void Run()
        {
            // TODO
            // Create a domain model via POCO classes to store the data available in the CSV file below
            // Objects to be present in the domain model: Asset, Country and Mime type
            // Process the file in the most robust way possible
            // The use of 3rd party plugins is permitted

            AssetDBModel db = new AssetDBModel();

            var csvFile = Resources.AssetImport;

            CsvFileDescription csvFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };
            CsvContext csvContext = new CsvContext();
            byte[] byteArray = Encoding.UTF8.GetBytes(csvFile);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader streamReader = new StreamReader(stream);
            IEnumerable<AssetDetails> list = csvContext.Read<AssetDetails>(streamReader, csvFileDescription);
            db.AssetDetails.AddRange(list);
            db.SaveChanges();
        }
    }

}
