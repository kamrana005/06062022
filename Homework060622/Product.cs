using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622
{
    internal class Product : IStore
    {

        public string No;
        public string Name;
        public double Price;
        public int Count;

        private Product[] _products;
        private double _totalIncome;
        public Product[] Products { get => _products; }
        
        public int ProductLimit { get; set; }
        public double TotalIncome { get => _totalIncome; }


      
        
        

        void AddProduct(Product Products)
        {

            Array.Resize(ref _products, 1);
        }

        void SellProduct(Product Products)
        {
            
            
            _totalIncome += Products[i].Price;
            count--;
        }
    }
}
