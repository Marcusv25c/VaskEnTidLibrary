using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Laundromat
    {
        private int _laundromatID;
        private string _adress;
        private string _zipcode;
        private string _city;

        public int LaundromatID
        {
            get { return _laundromatID; }
            set { _laundromatID = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public Laundromat(int laundromatID, string adress, string zipcode, string city)
        {
            _laundromatID = laundromatID;
            _adress = adress;
            _zipcode = zipcode;
            _city = city;
        }

    }
}
