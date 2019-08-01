using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactionsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faction name, Faction Leader , Faction Tier 
            Faction Wakanda = new Faction("Wakanda", "t'challa", 3);
            Console.WriteLine(Wakanda.Hello());
            Console.WriteLine(Wakanda.Get_Res());
            Console.ReadLine();
        }
    }

    //Object Class for our factions 
    class Faction
    {
        public string Name;
        public string Leader;
        //Territory Name, Income , Troops
        public List<Object> Territories;
        // Gold, Silver , Iron
        public int[] Resources;
        //Allies, Neutral , Enemies
        public List<Object> Alliances;
        public List<Object> Neutral;
        public List<Object> Enemies;
        //Unit name , Unit Health , Unit Type
        public List<Object> Units;
        // Items
        public List<Object> Items;

        //Constructor 
        public Faction(string nm , string ldr, int n)
        {
            //Set the name of the faction
            Name = nm;
            //Set the Leader of the faction
            Leader = ldr;
            Resources = new int[3];


            Allocate(n);
        }
        //Allocate Resources 
        public void Allocate(int n)
        {
            //Set Starting resources Gold > Silver > Iron 
            Resources[0] = 100 * n;
            Resources[1] = 500 * n;
            Resources[2] = 1000 * n;
        }

        //Test
        public string Hello()
        {
            return "The Leader of " + Name +" is " + Leader;
        }
        //Add Territory 
        public void Add_Terri(Object Territory)
        {
            //Add the territory
            Territories.Add(Territory);
        }

        //Remove Territory
        public void Rmv_Terri(Object Territory)
        {
            //Remove the territory
            Territories.Remove(Territory);
        }

        //Get Resource 
        public string Get_Res()
        {
            return "Gold : " + Resources[0] + "\nSilver : " + Resources[1] + "\nIron : " + Resources[2];
        }
        //Add Resources
        public void Add_Res(int Gold, int Silver, int Iron)
        {
            //Gold 
            Resources[0] = Resources[0] + Gold;
            //Silver
            Resources[1] = Resources[1] + Silver;
            //Iron
            Resources[2] = Resources[2] + Iron;
        }

        //Remove Resources
        public void Rmv_Res(int Gold, int Silver, int Iron)
        {
            //Gold 
            Resources[0] = Resources[0] - Gold;
            //Silver
            Resources[1] = Resources[1] - Silver;
            //Iron
            Resources[2] = Resources[2] - Iron;
        }

        //Set Ally
        public void Add_Ally(Object Faction)
        {
            //Add Ally
            Alliances.Add(Faction);
            //Remove From Neutral 
            Neutral.Remove(Faction);
        }

        //Set Neutral 
        public void Rmv_Ally(Object Faction)
        {
            //Remove Ally
            Alliances.Remove(Faction);
            //Remove As Enemy 
            Enemies.Remove(Faction);
            //Set Neutral
            Neutral.Add(Faction);
        }

        //Set Enemy
        public void Add_Enemy(Object Faction)
        {
            //Add Ally
            Enemies.Add(Faction);
            //Set Neutral
            Neutral.Remove(Faction);
        }

        //Add Unit 
        public void Add_unit(Object Unit, int n)
        {
            //Check if unit already exists
            //Add Unit
            Units.Add(Unit);
        }

        //Remove Unit 
        public void Rmv_unit(Object Unit, int n)
        {
            //Check if unit already exists
            //Add Unit
            Units.Remove(Unit);
        }

        //Add Item
        public void Add_Item(Object Item, int n)
        {
            //Check if item already exists and is greater than 1
            //Add n amount of items
            //Else add item by n 
            Items.Add(Item);
        }
        //Remove Item
        public void Rmv_Item(Object Item, int n)
        {
            //Check if Item already exists and quantity is greater than 1
            //If it does remove n amount of quantity 

            //else remove item
            Items.Remove(Item);
        }
    }
}
