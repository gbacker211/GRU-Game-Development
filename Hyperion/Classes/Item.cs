using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion
{
    class Item //Not a Static Class
    {
        //Private Variables
        private string title;
        private string pickupText;
        private int weight = 1;
        //Item Properties
        #region properties
        public string Title //Item title Property
        {
            get { return title; }
            set { title = value; }
        }
        public string PickupText  //Item pickupText Property
        {
            get { return pickupText; }
            set { pickupText = value; }
        }
        public int Weight  // Item weight property
        {
            get { return weight; }
            set { weight = value; }
        }
        #endregion
    }
}
