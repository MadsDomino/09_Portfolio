using System;

namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        private string id;
        public string ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        double value;
        public double Value
        {
            set
            {
                this.value = value;
            }
            get
            {
                return value;
            }
        }

        double interestrate;
        public double InterestRate
        {
            set
            {
                interestrate = value;
            }
            get
            {
                return interestrate;
            }
        }

        public double GetValue()
        {
            return Value;
        }

        public override string ToString()
        {
            return "SavingsAccount[value="+Value.ToString("#.0")+",interestRate="+InterestRate+"]";
        }

        public void ApplyInterest()
        {
            Value = Value * (1 + (InterestRate/100));
        }

        public SavingsAccount () { }

        public SavingsAccount (string nid, double nvalue, double nirate)
        {
            ID = nid;
            Value = nvalue;
            InterestRate = nirate;
        }
    }
}