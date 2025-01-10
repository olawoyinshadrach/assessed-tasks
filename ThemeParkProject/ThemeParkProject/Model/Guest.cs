using System;
using System.Collections.Generic;
using ThemeParkProject.Model;
using ThemeParkProject.Forms;
using System.Linq;
using System.Text;

namespace ThemeParkProject.Model{
    public class Guest{
        //a guest name can be created and read
        public string GuestName{
            get;
            set;
        }
        //the fund attributed to each guest at queue start, can be created and read
        public float GuestFund{
            get;
            set;
        }

        //Constructor:  the Guest object shall have both name and fund attributes
        public Guest(string GuestName, float GuestFund){
            //the name of each guest shall be of type GuestName
            GuestName = guestname;
            //the fund attributed to each guest shall be of type GuestFund
            GuestFund = guestfund;
        }

        public override string MergeNameFund(){
            //to merge the name of each guest with the fund attributed to him/her
            return $"{GuestName} has ${GuestFund} in wallet"
        }
    }
}
