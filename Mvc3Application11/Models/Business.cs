using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;

namespace Mvc3Application11.Models
{
    public class Business
    {
        List<Customer> customers = GetCustomerList();
        List<Order> orders = GetOrderList();
        List<Product> products = GetProductList();

        public void Main()
        {
            //creates a sequence of the names of all products:
            IEnumerable<string> productNames = products.Select(p => p.Name);

        }
        

        private static List<Customer> GetCustomerList()
        {
            //throw new NotImplementedException();            
            return new List<Customer>();
        }
        private static List<Order> GetOrderList()
        {
            return new List<Order>();
        }
        private static List<Product> GetProductList()
        {
            return new List<Product>();
        }
       
    }

    public class Customer
    {
        public int CustomerID;
        public string Name;
        public string Address;
        public string City;
        public string Region;
        public string PostalCode;
        public string Country;
        public string Phone;
        public List<Order> Orders;
    }
    public class Order
    {
        public int OrderID;
        public int CustomerID;
        public Customer Customer;
        public DateTime OrderDate;
        public decimal Total;
    }
    public class Product
    {
        public int ProductID {get; set;}
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        
    }

    public class ComicBook
    {
        public string Title {get; set;}
        public string Publisher { get; set; }
    }

    public class ImageDataUrl
    {
        public ImageDataUrl(string dataUrl)
        {
            var match = _regex.Match(dataUrl);
            MimeType = match.Groups["mimeType"].Value;
            Format = match.Groups["mimeSubType"].Value;
            Bytes = Convert.FromBase64String(match.Groups["data"].Value);
        }

        public byte[] Bytes { get; protected set; }
        public string MimeType { get; set; }
        public string Format { get; protected set; }

        public string SaveTo(string folder)
        {
            var fileName = Guid.NewGuid().ToString() + "." + Format;
            var fullPath = Path.Combine(folder, fileName);

            using (var file = File.OpenWrite(fullPath))
            {
                file.Write(Bytes, 0, Bytes.Length);
            }
            return fileName;
        }

        private static readonly Regex _regex = new Regex(
            @"data:(?<mimeType>[\w]+)/(?<mimeSubType>[\w]+);\w+,(?<data>.*)",
            RegexOptions.Compiled
        );
    }   
}