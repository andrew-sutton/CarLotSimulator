using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
    }
}
