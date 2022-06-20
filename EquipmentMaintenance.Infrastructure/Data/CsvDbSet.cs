using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Infrastructure.Data
{
    internal class CsvDbSet<T>
    {
        public IList<T> List { get; set; }

        private string _path;
        private CsvConfiguration Configuration { get; }

        public CsvDbSet(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));

            _path = path;

            Configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, Configuration))
            {
                var records = csv.GetRecords<T>();
                List = records.ToList();
            }
        }

        public void SaveChanges()
        {
            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, Configuration))
            {
                csv.WriteHeader<T>();
                csv.NextRecord();

                csv.WriteRecords(List);
            }
        }

        public async void SaveChangesAcync()
        {
            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, Configuration))
            {
                csv.WriteHeader<T>();
                csv.NextRecord();

                await csv.WriteRecordsAsync(List);
            }
        }
    }
}
