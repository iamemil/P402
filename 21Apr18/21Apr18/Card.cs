using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Apr18
{
    class Card
    {
        private string _cardOwner;        
        private string _paymentProcessor;
        private string _cardNumber;
        private string _expireDate;
        private int _cvv;
        private double _balance;

        public Card(string Owner, string cardNum, string PaymentProcessor, int expireMonth, int expireYear, int cvv, double balance)
        {
            this._cardOwner = Owner.ToUpper();
            if (cardNum.Length == 19)
            {
                this._cardNumber = cardNum;
            }
            this._paymentProcessor = PaymentProcessor;
            this._expireDate = expireMonth + "/" + expireYear;
            if (cvv.ToString().Length==3)
            {
                this._cvv = cvv;
            }
            this._balance = balance;
        }
        public string CardOwner
        {
            get
            {
                return this._cardOwner;
            }
        }
        public string PaymentProcessor
        {
            get
            {
                return this._paymentProcessor;
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
        public double Balance
        {
            get
            {
                return this._balance;
            }
        }

    }
}
