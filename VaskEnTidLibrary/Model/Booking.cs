using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Booking
    {
        private int _bookingID;
        private int _machineID;
        private string _phoneNumber;
        private dateOnly _bookingDate;
        private timeOnly _bookingTime;

        public int BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }

        public int MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber; = value; }
        }

        public dateOnly BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate; = value; }
        }

        public timeOnly BookingTime
        {
            get { return _bookingTime; }
            set { _bookingTime; = value; }
        }

        public Laundromat(int bookingID, int machineID, string phoneNumber, dateOnly bookingDate, timeOnly bookingTime)
        {
            _bookingID = bookingID;
            _machineID = machineID;
            _phoneNumber = phoneNumber;
            _bookingDate = bookingDate;
            _bookingTime = bookingTime;
        }

    }
}
