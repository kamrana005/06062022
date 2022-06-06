using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622
{
    internal class Market : Product
    {
        
        public void ShowInfo()
        {
            Console.WriteLine($"Product Names: {Name} - Prices: {Price} - Product No: {No} - Count: {Count}");
        }


    }

}
