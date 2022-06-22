using CsvHelper;
using CsvHelper.Configuration;
using EquipmentMaintenance.Core.Interfaces.Entities;
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
    public class CsvDbSet<T> : IList<T>
        where T : class, IEntity
    {
        private IList<T> List { get; set; }

        private int _id;

        private string _path;
        private CsvConfiguration Configuration { get; }

        public int Count => List.Count;

        public bool IsReadOnly => List.IsReadOnly;

        public T this[int index] { get => List[index]; set => List[index] = value; }

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

            _id = List.Count == 0 ? 1 : List.Max(x => x.Id) + 1;
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

        public async Task SaveChangesAcync()
        {
            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, Configuration))
            {
                csv.WriteHeader<T>();
                csv.NextRecord();

                await csv.WriteRecordsAsync(List);
            }
        }

        public int IndexOf(T item) => List.IndexOf(item);

        public void Insert(int index, T item)
        {
            item.Id = _id++;
            List.Insert(index, item);
        }

        public void RemoveAt(int index) => List.RemoveAt(index);

        public void Add(T item)
        {
            item.Id = _id++;
            List.Add(item);
        }

        public void Clear() => List.Clear();

        public bool Contains(T item) => List.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => List.CopyTo(array, arrayIndex);

        public bool Remove(T item) => List.Remove(item);

        public IEnumerator<T> GetEnumerator() => List.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)this.GetEnumerator();
    }
}
