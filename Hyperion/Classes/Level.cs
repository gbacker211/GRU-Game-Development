using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion
{
    static class Level
    {
        private static Room[,] rooms;

        #region properties
        public static Room[,] Rooms
        {
            get { return rooms; }
        }
        #endregion


        public static void Initialize()
        {
            BuildLevel();
        }

        private static void BuildLevel()
        {
            //Could add file look up from xml files, for save games and so forth here

            //Construct level using grid system

            #region First Iteration of Text Game

            //rooms = new Room[2, 1];

            //Room room;
            //Item item;

            ///////////////////////////////////////////////////////////

            //// Create new room
            //room = new Room();

            //// Assign this room to location 0,0
            //rooms[0, 0] = room;

            //// Setup the room 

            //room.Title = "Red Room";
            //room.Description = "You have entered the red room";
            //room.AddExit(Direction.East);

            ////Create a new item
            //item = new Item();

            ////Setup the item
            //item.Title = "Blue Ball";
            //item.PickupText = "You just picked up the blue ball";

            //// add item to the current room
            //room.Items.Add(item);


            ///////////////////////////////////////////////////////////


            //// Create new room
            //room = new Room();

            //// Assign this room to location 0,0
            //rooms[1, 0] = room;

            //// Setup the room 

            //room.Title = "Blue Room";
            //room.Description = "You have entered the blue room";
            //room.AddExit(Direction.West);

            ////Create a new item
            //item = new Item();

            ////Setup the item
            //item.Title = "Anvil";
            //item.PickupText = "You struggle to pickup the anvil";
            //item.Weight = 6;
            //// add item to the current room
            //room.Items.Add(item);


            ////////////////////////////////////////////////////////////////////

            #endregion

            #region Second Iteration of Text Game

            rooms = new Room[2, 2];

            Room room;
            Item item;

            /////////////////////////////////////////////////////////

            // Create red room
            room = new Room();

            // Assign this room to location 0,0
            rooms[0, 0] = room;

            // Setup the room 

            room.Title = "Red Room";
            room.Description = "You have entered the red room, there is a locked door the south";
            room.AddExit(Direction.East);

            //Create a new item
            item = new Item();

            //Setup the item
            item.Title = "Blue Ball";
            item.PickupText = "You just picked up the blue ball";

            // add item to the current room
            room.Items.Add(item);


            /////////////////////////////////////////////////////////


            // Create blue room
            room = new Room();

            // Assign this room to location 1,0
            rooms[1, 0] = room;

            // Setup the room 

            room.Title = "Blue Room";
            room.Description = "You have entered the blue room";
            room.AddExit(Direction.West);
            room.AddExit(Direction.South);

            //Create a new item
            item = new Item();

            //Setup the KEY
            item.Title = "Key";
            item.PickupText = "You picked up a key";

            // add item to the current room
            room.Items.Add(item);


            //Create a GREEN BALL
            item = new Item();

            //Setup the item
            item.Title = "Green Ball";
            item.PickupText = "You just picked up the green ball";

            // add item to the current room
            room.Items.Add(item);

            //////////////////////////////////////////////////////////////////


            // Create yellow room
            room = new Room();

            // Assign this room to location 1,1
            rooms[1, 1] = room;

            // Setup the room 

            room.Title = "Yellow Room";
            room.Description = "You have entered the yellow room";
            room.AddExit(Direction.West);
            room.AddExit(Direction.North);

            //Create a RED BALL
            item = new Item();

            //Setup the item
            item.Title = "Red Ball";
            item.PickupText = "You just picked up the red ball";

            // add item to the current room
            room.Items.Add(item);

            //////////////////////////////////////////////////////////////////////////

            // Create green room
            room = new Room();

            // Assign this room to location 0,1
            rooms[0, 1] = room;

            // Setup the room 

            room.Title = "Green Room";
            room.Description = "You have entered the Green room, the is a locked door to the north";
            room.AddExit(Direction.East);

            //Create a RED BALL
            item = new Item();

            //Setup the item
            item.Title = "Yellow Ball";
            item.PickupText = "You just picked up the yellow ball";

            // add item to the current room
            room.Items.Add(item);

            #endregion

            // place the player in the starting room
            Player.PosX = 0;
            Player.PosY = 0;


        }
    }
}
