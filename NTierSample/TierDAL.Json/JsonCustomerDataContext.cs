
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace NTierDAL.Json
{
    internal class JsonCustomerDataContext : IDisposable
    {
        private string _jsonFilePath = @"C:\Temp\JsonCustomerData.json";

        public IList<ICustomerDTO> Customers { get; set; }

        public JsonCustomerDataContext()
        {
            if (File.Exists(_jsonFilePath))
            {
                string json = File.ReadAllText(_jsonFilePath);
                Customers = JsonConvert.DeserializeObject<List<ICustomerDTO>>(json);
            }
            else
                Customers = new List<ICustomerDTO>();
        }

        public void SaveChanges()
        {
            string json = JsonConvert.SerializeObject(Customers, Formatting.Indented);
            File.WriteAllText(_jsonFilePath, json);
        }

        public void Dispose()
        {
            if (null != Customers)
                Customers = null;
        }
    }
}
