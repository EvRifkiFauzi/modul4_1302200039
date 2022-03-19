// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200039
{
    public class ClassMain
    {
        static void Main(string[] args)
        {
            Penjumlahan<long> first = new Penjumlahan <long>();
            first.value = 13;
            
            Penjumlahan<long> second = new Penjumlahan<long>();
            second.value = 02;
            
            Penjumlahan<long> third = new Penjumlahan<long>();
            third.value = 20;

            Penjumlahan<long> equals = new Penjumlahan<long>();
            equals.value = first.value + second.value + third.value;
            equals.JumlahTigaAngka();

            storedData<long> satu = new storedData<long>();
            satu.SimpleDataBase = 13;
            satu.PrintAllData();
           
            storedData<long> dua = new storedData<long>();
            dua.SimpleDataBase = 02;
            dua.PrintAllData();
            
            storedData<long> tiga = new storedData<long>();
            tiga.SimpleDataBase = 20;
            tiga.PrintAllData();

            DateTime DOB = Convert.ToDateTime(Console.ReadLine());
            
        }
    }

    public class Penjumlahan<T>
    {
      public T value { get; set; }
        public void JumlahTigaAngka() => Console.WriteLine($"HASIL PENJUMLAHAN 3 ANGKA : {value}");

    }
    public class storedData<T>
    {
        public T SimpleDataBase { get; set; }
        public void AddNewData(T Data) => SimpleDataBase = Data;
        
        public void PrintAllData() => Console.WriteLine("Data yang tersimpan adalah " + SimpleDataBase);
        
    }
    public class inputDates<Dates>{
        public DateTime Date { get; set; }
        public void setTime(DateTime Time) => Date = Time;
       
    }
}

    