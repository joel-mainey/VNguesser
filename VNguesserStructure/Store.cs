using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNguesserStructure
{
    internal class Store
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Buy { get; set; }
        public string Price { get; set; }

        public Store()
        {
            Name = "";
            ImageName = "";
            Buy = "";
            Price = "";
        }

        public Store(string inputName, string inputImageName, string inputBuy, string inputPrice)
        {
            Name = inputName;
            ImageName = inputImageName;
            Buy = inputBuy;
            Price = inputPrice;
        }

    }
}
