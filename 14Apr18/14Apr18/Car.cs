using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Apr18
{
    class Car
    {
        private double _fuelCapacity;
        private double _fuelUsage;
        private double _currentFuel;
        private double driveUsage;
        private double TripKm;
        private double _odometerKm;

        public Car(int capacity, int fuelUsage)
        {
            this._fuelCapacity = capacity;
            this._fuelUsage = fuelUsage;
            this._currentFuel = 70;
        }

        public double FuelCapacity
        {
            get
            {
                return this._fuelCapacity;
            }
        }
        public double FuelUsage
        {
            get
            {
                return this._fuelUsage;
            }
        }
        public double CurrentFuel
        {
            get
            {
                return this._currentFuel;
            }
        }

        private double OdometerKm
        {
            get
            {
                return this._odometerKm;
            }
        }

        public double Drive(double km)
        {
            this.driveUsage = (km * this.FuelUsage) / 100;
            if (this.driveUsage < this._currentFuel)
            {
                this._currentFuel -= this.driveUsage;
                this._odometerKm += km;
                this.TripKm += km;
                //return km + " kilometr yol qet edildi. " + this._currentFuel + " litr yanacaq qaldi.";
                return this._currentFuel;
            }
            else
            {
                //return "Sizin hazirki yanacaginiz " + this._currentFuel + " litrdir. Lakin getmek istediyiniz yol " + this.driveUsage + " litr yanacaq isteyir.";
                return this.driveUsage;
            }
        }
        
        public void AddFuel(double litr)
        {
            this._currentFuel += litr;
        }

        public void resetTripKm()
        {
            this.TripKm = 0;
        }

    }
}
