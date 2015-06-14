using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion
{
    class Room
    {
        //Private Variables
        private string title;
        private string description;
        private List<string> exits;
        private List<Item> items;
        private Boolean isOffWorld = false;

        
        /// Room Constructor
        public Room() 
        {
            exits = new List<string>();
            items = new List<Item>();
        }

        //Properties For Room Class       
        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Boolean IsOffWorld
        {
            get { return isOffWorld; }
            set { isOffWorld = value; }
        }
        #endregion

        #region Public Methods
                //Public Methods

        public void Describe()
        {
           // TextBuffer.Add(this.GetCoordinates()); implement getcoordinates
            TextBuffer.Add(this.description);
            TextBuffer.Add(this.GetItemList());
            TextBuffer.Add(this.GetExitList());
        }

        public void  ShowTitle()
        {
            TextBuffer.Add(this.title);
        }

        public Item GetItem(String itemName)
        {
            foreach (Item item in this.items)
            {
                if (item.Title.ToLower() == itemName.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public void AddExit(string direction)
        {
            if (this.exits.IndexOf(direction) == -1)
                this.exits.Add(direction);
            
        }
        public void RemoveExit(string direction)
        {
            if (this.exits.IndexOf(direction) != -1)
                this.exits.Remove(direction);
        }
        public bool CanExit(string direction)
        {
            foreach (string validExit in this.exits)
            {
                if (direction == validExit)
                    return true;
            }
            return false;
        }
        #endregion
        //Private Methods
        #region Private Methods
        private string GetItemList()
        {
            string itemString = string.Empty;
            string message = "Items in Room:";
            string underline = string.Empty;
            underline =  underline.PadLeft(message.Length, '-');

            if (this.items.Count > 0)
            {
                foreach (Item item in this.items)
                {
                    itemString += "\n[" + item.Title + "]";
                }
            }
            else
            {
                itemString = "\n<none>";
            }

            return "\n" + message + "\n" + underline + itemString;
        }

        private string GetExitList()
        {
            string exitString = string.Empty;
            string message = "Possible Directions:";
            string underline = string.Empty;
            underline = underline.PadLeft(message.Length, '-');

            if (this.exits.Count > 0)
            {
                foreach (string exitDirection in this.exits)
                {
                    exitString += "\n[" + exitDirection + "]";
                }
            }
            else
            {
                exitString = "\n<none>";
            }

            return "\n" + message + "\n" + underline + exitString;
        }
        
        //Use for debug purposes
        private string GetCoordinates()
        {

            for (int y = 0; y < Level.Rooms.GetLength(1); y++)
            {
                for (int x = 0; x < Level.Rooms.GetLength(0); x++)
                {
                    if (this == Level.Rooms[x, y])
                        return "[" + x.ToString() + "," + y.ToString() + "]";
                }
            }
            return "This is not within the Rooms grid";
        }
    }
        #endregion
}
