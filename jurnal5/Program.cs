using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class SimpleDataBase<T>
    {
        List<T> storeData { get; set; }
        List<DateTime> inputDates { get; set; }

        public SimpleDataBase()
        {
            storeData = new List<T>();  
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T List)
        {
            storeData.Add(List);
            inputDates.Add(DateTime.Now);
        }
        public void printAllData()
        {
            for (int i =0; i < storeData.Count; i++)
            {
                Console.WriteLine("Data" + i + "berisi: " + storedData[i] + "yang disimpan pada waktu" + inputDates[i]);
            }
        }
    }
}
