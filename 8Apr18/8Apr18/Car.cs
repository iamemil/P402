using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Apr18
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string BanNovu { get; set; }
        public string Color { get; set; }
        public double MotorVolume { get; set; }
        public int MotorPower { get; set; }
        public string FuelType { get; set; }
        public int Kilometer { get; set; }
        public string TransmissionType { get; set; }

        public void DriveForward()
        {

        }
        public void Brake()
        {

        }
        public void DriveReverse()
        {

        }
        public void TurnLeft()
        {

        }
        public void TurnRight()
        {

        }

    }
    class Bmw : Car
    {
        public void AirBag()
        {

        }
        public void ABS()
        {

        }
        public void Lyuk()
        {

        }
    }
    class Lada:Car
    {

    }
}
