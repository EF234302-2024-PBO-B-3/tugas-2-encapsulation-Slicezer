using System;

namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;

        public Invoice(string partNumber, string partDescription, int quantity, double price)
        {
            _partNumber = partNumber;
            _partDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public string PartNumber
        {
            get { return _partNumber; }
            set { _partNumber = value; }
        }

        public string PartDescription
        {
            get { return _partDescription; }
            set { _partDescription = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    _quantity = 0;
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0.0;
                }
            }
        }

        public double GetInvoiceAmount()
        {
            return _quantity * _price;
        }
    }
}