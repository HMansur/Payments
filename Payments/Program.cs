using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;


namespace PortfolioPayments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter CSV download path..");
            //string path = Console.ReadLine();
            string path = @"C:\Users\hasan\Downloads\payments.csv";
            PaymentCollection paymentCollection;

            if (File.Exists(path)) File.Delete(path);
            using (WebClient webClient = new WebClient())
            {
                var rawJSON = webClient.DownloadString(@"https://focus.interview/api/v1.0/payments/{100,110,155}");
                paymentCollection = JsonConvert.DeserializeObject<PaymentCollection>(rawJSON);
            }

            WriteToCSVFile(paymentCollection, path);
            Console.WriteLine(paymentCollection.Payments.Count + " Payments downloaded...");
            Console.ReadLine();
        }
        private static void WriteToCSVFile(PaymentCollection list, string path)
        {
            Type itemType = typeof(Payment);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(",", props.Select(p => p.Name)));

                foreach (var item in list.Payments)
                {
                    writer.WriteLine(string.Join(",", props.Select(p => p.GetValue(item, null))));
                }
            }

        }
    }
}

