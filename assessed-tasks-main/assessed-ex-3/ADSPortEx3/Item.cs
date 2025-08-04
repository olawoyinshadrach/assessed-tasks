using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    //Item class implementation for Assessed Exercise 3

    //For use as part of EX.3C

    //Use slides from Week 8A regarding the knapsack algorithm example to aid with implementation

    class Item : IComparable
    {
        private string name;
        private int value;
        private double weight;
        public Item(string name, int value, int weight)
        {
            //throw new NotImplementedException();
            this.name = name;
            this.value = value;
            this.weight = weight;
        }

        public string Name
        {
            get
            {
                return name;
            } //{ throw new NotImplementedException(); }
            set
            {
                name = value;
            } //{ throw new NotImplementedException(); }
        }

        public int Value
        {
            get
            {
                return this.value
            } //{ throw new NotImplementedException(); }
            set
            {
                this.value = value
            } //{ throw new NotImplementedException(); }
        }

        public double Weight
        {
            get
            {
                return weight;
            } //{ throw new NotImplementedException(); }
            set
            {
                weight = value;
            } //{ throw new NotImplementedException(); }
        }

        public double ValRatio
        {
            get
            {
                return value / weight;
            } //{ throw new NotImplementedException(); }
        }

        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();
            Item other = obj as Item;
            if (other == null) return 1;
            return other.ValRatio.CompareTo(this.ValRatio);
        }
    }
}
