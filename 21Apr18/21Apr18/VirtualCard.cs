using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Apr18
{
    class VirtualCard
    {
        private int _parentCard;
        private string _cardNumber;
        private string _expireDate;
        private int _cvv;
        private double _limit;
        private double _balance;

        public VirtualCard(int ParentCard, string expireMonth, string expireYear, double limit)
        {

            this._parentCard = ParentCard;
            this._expireDate = expireMonth + "/" + expireYear;

            Random random = new Random();

            int cvv = random.Next(100,999);
            this._cvv = cvv;

            int first = random.Next(10000);
            int second = random.Next(10000);
            int third = random.Next(10000);
            int fourth = random.Next(10000);
            this._cardNumber = first + "-" + second + "-" + third + "-" + fourth;
            this._limit = limit;
            this._balance = limit;
        }

        public int ParentCard
        {
            get
            {
                return this._parentCard;
            }
        }
        public string CardNumber
        {
            get
            {
                return this._cardNumber;
            }
        }
        public string ExpireDate
        {
            get
            {
                return this._expireDate;
            }
        }
        public int VCC
        {
            get
            {
                return this._cvv;
            }
        }
        public double Limit
        {
            get
            {
                return this._limit;
            }
        }
        public double Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
    }
}
