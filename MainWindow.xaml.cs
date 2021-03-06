﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MosterGenWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<RoomNumber> RoomList = new List<RoomNumber>();
        public List<Biom> BiomList = new List<Biom>();
        public List<Event> EventList = new List<Event>();
        public List<MonsterCR> CRList = new List<MonsterCR>();
        public List<Monster> MonsterList = new List<Monster>();
        public List<Monster> CurrentMonsterList = new List<Monster>();
        public List<Monster> TempMonsterList = new List<Monster>();
        public List<String> PlayerLevelList = new List<String>();
        public List<RoomEvent> RoomEventList = new List<RoomEvent>();
        public List<Item> ItemsList = new List<Item>();

        public string RoomRoll;
        public string BiomRoll;
        public string EventRoll;
        public string CRRoll;
        public string MonsterRoll1 = "";
        public string MonsterRoll2 = "";
        public string CurrentMonsterCR = "";
        public string CurrentRoomRoll = "";

        public string PlayerLVL = "";
        public MainWindow()
        {
            InitializeComponent();
            CreateList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        tbxCurrentRoom.Text = "0";
            lblPlayerLevel.Content = PlayerLVL;
            //Add CR Levels
            if (PlayerLVL == "2 x lvl 14")
            {
                //2 lvl 14 Characters
                CRList.Add(new MonsterCR("1", "12"));
                CRList.Add(new MonsterCR("2", "11"));
                CRList.Add(new MonsterCR("3", "13"));
                CRList.Add(new MonsterCR("4", "14"));
                CRList.Add(new MonsterCR("5", "15"));
                CRList.Add(new MonsterCR("6", "16"));
                CRList.Add(new MonsterCR("7", "17"));
                CRList.Add(new MonsterCR("8", "11"));
                CRList.Add(new MonsterCR("9", "14"));
                CRList.Add(new MonsterCR("10", "15"));
                CRList.Add(new MonsterCR("11", "12"));
                CRList.Add(new MonsterCR("12", "13"));
            }
            else if (PlayerLVL == "3 x lvl 14")
            {
                //3 lvl 14 Characters
                CRList.Add(new MonsterCR("1", "18"));
                CRList.Add(new MonsterCR("2", "11"));
                CRList.Add(new MonsterCR("3", "13"));
                CRList.Add(new MonsterCR("4", "9"));
                CRList.Add(new MonsterCR("5", "15"));
                CRList.Add(new MonsterCR("6", "16"));
                CRList.Add(new MonsterCR("7", "17"));
                CRList.Add(new MonsterCR("8", "11"));
                CRList.Add(new MonsterCR("9", "10"));
                CRList.Add(new MonsterCR("10", "14"));
                CRList.Add(new MonsterCR("11", "9"));
                CRList.Add(new MonsterCR("12", "13"));
                CRList.Add(new MonsterCR("13", "16"));
                CRList.Add(new MonsterCR("14", "10"));
                CRList.Add(new MonsterCR("15", "15"));
                CRList.Add(new MonsterCR("16", "17"));
                CRList.Add(new MonsterCR("17", "12"));
                CRList.Add(new MonsterCR("18", "6"));
                CRList.Add(new MonsterCR("19", "7"));
                CRList.Add(new MonsterCR("20", "18"));

                lblMonsterRoll.Content = "Monter Lvl - D20:";
            }
            else if (PlayerLVL == "4 x lvl 14")
            {
                //4 lvl 14 Characters
                CRList.Add(new MonsterCR("1", "21"));
                CRList.Add(new MonsterCR("2", "15"));
                CRList.Add(new MonsterCR("3", "13"));
                CRList.Add(new MonsterCR("4", "14"));
                CRList.Add(new MonsterCR("5", "15"));
                CRList.Add(new MonsterCR("6", "16"));
                CRList.Add(new MonsterCR("7", "17"));
                CRList.Add(new MonsterCR("8", "14"));
                CRList.Add(new MonsterCR("9", "19"));
                CRList.Add(new MonsterCR("10", "18"));
                CRList.Add(new MonsterCR("11", "17"));
                CRList.Add(new MonsterCR("12", "20"));
                CRList.Add(new MonsterCR("13", "16"));
                CRList.Add(new MonsterCR("14", "20"));
                CRList.Add(new MonsterCR("15", "15"));
                CRList.Add(new MonsterCR("16", "17"));
                CRList.Add(new MonsterCR("17", "16"));
                CRList.Add(new MonsterCR("18", "19"));
                CRList.Add(new MonsterCR("19", "18"));
                CRList.Add(new MonsterCR("20", "20"));

                lblMonsterRoll.Content = "Monter Lvl - D20:";
            }
            else if (PlayerLVL == "2 x lvl 10")
            {
                //2 lvl 10 characters
                CRList.Add(new MonsterCR("1", "8 + 1 + 1"));
                CRList.Add(new MonsterCR("2", "11"));
                CRList.Add(new MonsterCR("3", "6 + 4 + 2"));
                CRList.Add(new MonsterCR("4", "6 + 3 + 3"));
                CRList.Add(new MonsterCR("5", "9 + 3"));
                CRList.Add(new MonsterCR("6", "7 + 3 + 2"));
                CRList.Add(new MonsterCR("7", "7 + 1 + 1 + 1 + 1 + 1"));
                CRList.Add(new MonsterCR("8", "7 + 7"));
                CRList.Add(new MonsterCR("9", "4 + 4 + 4 + 4"));
                CRList.Add(new MonsterCR("10", "10 + 1 + 1"));
                CRList.Add(new MonsterCR("11", "12"));
                CRList.Add(new MonsterCR("12", "8 + 3"));

            }
        }

        public void CreateList()
        {
            //Add Rooms
            RoomList.Add(new RoomNumber("1", "-6"));
            RoomList.Add(new RoomNumber("2", "-5"));
            RoomList.Add(new RoomNumber("3", "-4"));
            RoomList.Add(new RoomNumber("4", "-3"));
            RoomList.Add(new RoomNumber("5", "-2"));
            RoomList.Add(new RoomNumber("6", "-1"));
            RoomList.Add(new RoomNumber("7", "+1"));
            RoomList.Add(new RoomNumber("8", "+2"));
            RoomList.Add(new RoomNumber("9", "+3"));
            RoomList.Add(new RoomNumber("10", "+4"));
            RoomList.Add(new RoomNumber("11", "+5"));
            RoomList.Add(new RoomNumber("12", "+6"));

            //Add Bioms
            BiomList.Add(new Biom("1", "Moster Biom (DM Choice)"));
            BiomList.Add(new Biom("2", "Cave"));
            BiomList.Add(new Biom("3", "Empty Room"));
            BiomList.Add(new Biom("4", "Swamp"));
            BiomList.Add(new Biom("5", "Desert"));
            BiomList.Add(new Biom("6", "Aquatic"));
            BiomList.Add(new Biom("7", "Underdark"));
            BiomList.Add(new Biom("8", "Jungle"));
            BiomList.Add(new Biom("9", "10x10 Room"));
            BiomList.Add(new Biom("10", "Urban"));
            BiomList.Add(new Biom("11", "Arctic"));
            BiomList.Add(new Biom("12", "Monster Biom (DM Choice)"));
            BiomList.Add(new Biom("1", "Arctic"));


            //Add Random Events
            EventList.Add(new Event("1", "DEX Save Stepping out of Elevator"));
            EventList.Add(new Event("2", "DEX Save Poison Arrow + 2 round restrained"));
            EventList.Add(new Event("3", "Change Enemy Size - O=Large, E=Small"));
            EventList.Add(new Event("4", "Walls Open up to reveal an audience watching the fight"));
            EventList.Add(new Event("5", "STR 16 to open the elevator"));
            EventList.Add(new Event("6", "10 ft gap between elevator and room"));
            EventList.Add(new Event("7", "Reverse Gravity"));
            EventList.Add(new Event("8", "ASK DM"));
            EventList.Add(new Event("9", "Giant Magnet, Anything Metal will be pulled to the ground. Str Save to pick back up."));
            EventList.Add(new Event("10", "1d10 Random Floors Electrified"));
            EventList.Add(new Event("11", "Gain 20 Temp HP"));
            EventList.Add(new Event("12", "Change Player Size  - O=Large, E=Small"));


            //Add Player Levels
            PlayerLevelList.Add("2 x lvl 14");
            PlayerLevelList.Add("3 x lvl 14");
            PlayerLevelList.Add("4 x lvl 14");
            PlayerLevelList.Add("2 x lvl 10");
            PlayerLevelList.Add("3 x lvl 10");
            PlayerLevelList.Add("2 x lvl 10");
            PlayerLevelList.Add("4 x lvl 7");
            PlayerLevelList.Add("5 x lvl 7");
            PlayerLevelList.Add("3 x lvl 20");
            /*
             * 
             * DEFAULT VALUES
             * 
             */
            //Set the default to 2 lvl 14 Characters. 
            if (PlayerLVL == "")
            {
                //4 lvl 14 Characters
                CRList.Add(new MonsterCR("1", "21"));
                CRList.Add(new MonsterCR("2", "15"));
                CRList.Add(new MonsterCR("3", "13"));
                CRList.Add(new MonsterCR("4", "14"));
                CRList.Add(new MonsterCR("5", "15"));
                CRList.Add(new MonsterCR("6", "16"));
                CRList.Add(new MonsterCR("7", "17"));
                CRList.Add(new MonsterCR("8", "14"));
                CRList.Add(new MonsterCR("9", "19"));
                CRList.Add(new MonsterCR("10", "18"));
                CRList.Add(new MonsterCR("11", "17"));
                CRList.Add(new MonsterCR("12", "20"));
                CRList.Add(new MonsterCR("13", "16"));
                CRList.Add(new MonsterCR("14", "20"));
                CRList.Add(new MonsterCR("15", "15"));
                CRList.Add(new MonsterCR("16", "17"));
                CRList.Add(new MonsterCR("17", "16"));
                CRList.Add(new MonsterCR("18", "19"));
                CRList.Add(new MonsterCR("19", "18"));
                CRList.Add(new MonsterCR("20", "20"));
            }


            //Add Items
            //Merchant
            ItemsList.Add(new Item("Feather Token", "10 Gems", "Merchant"));
            ItemsList.Add(new Item("Breathing Bubble", "30 Gems", "Merchant"));
            ItemsList.Add(new Item("Clockwork Dog", "1 Gems", "Merchant"));
            ItemsList.Add(new Item("Staff If Birdcalls", "10 Gems", "Merchant"));
            ItemsList.Add(new Item("Wand of Smiles", "6 Gems", "Merchant"));
            ItemsList.Add(new Item("Dark Shard Amulet", "17 Gems", "Merchant"));
            ItemsList.Add(new Item("Dust of Dissapearance", "30 Gems", "Merchant"));
            ItemsList.Add(new Item("Quiver of Ehlonna", "25 Gems", "Merchant"));

            //Blacksmith
            ItemsList.Add(new Item("Spiked Armor", "30 Gems", "Blacksmith"));
            ItemsList.Add(new Item("Moon Touched Sword", "15 Gems", "Blacksmith"));

            //Alchemist
            ItemsList.Add(new Item("Potion of Healing", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Growth", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Acid)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Cold)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Fire)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Force)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Lightning)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Necrotic)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Poison)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Radiant)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Psychic)", "20 Gems", "Alchemist"));
            ItemsList.Add(new Item("Potion of Resistance (Thunder)", "20 Gems", "Alchemist"));



            //Add Monster
            MonsterList.Add(new Monster("1", "Animated Armor", "19", "1"));
            MonsterList.Add(new Monster("1", "Quasit", "63", "2"));
            MonsterList.Add(new Monster("1", "BugBear", "33", "3"));
            MonsterList.Add(new Monster("1", "Death Dog", "321", "4"));

            MonsterList.Add(new Monster("2", "PlesioSaurus", "80", "1"));
            MonsterList.Add(new Monster("2", "Grick", "173", "2"));
            MonsterList.Add(new Monster("2", "Priest", "0", "3"));
            MonsterList.Add(new Monster("2", "Ochre Jelly", "243", "4"));

            MonsterList.Add(new Monster("3", "Veteran", "350", "1"));
            MonsterList.Add(new Monster("3", "Knight", "347", "2"));
            MonsterList.Add(new Monster("3", "Minotaur", "223", "3"));
            MonsterList.Add(new Monster("3", "Displaced Beast", "0", "4"));

            MonsterList.Add(new Monster("4", "Shadow Demon", "64", "1"));
            MonsterList.Add(new Monster("4", "Chuul", "40", "2"));
            MonsterList.Add(new Monster("4", "Red Dragon Wyrmling", "98", "3"));
            MonsterList.Add(new Monster("4", "Weretiger", "0", "4"));

            MonsterList.Add(new Monster("5", "Night Hag", "178", "1"));
            MonsterList.Add(new Monster("5", "Flesh Golem", "169", "2"));
            MonsterList.Add(new Monster("5", "Unicorn", "294", "3"));
            MonsterList.Add(new Monster("5", "Gorgon", "171", "4"));

            MonsterList.Add(new Monster("6", "Chimera", "60", "1"));
            MonsterList.Add(new Monster("6", "Drider", "120", "2"));
            MonsterList.Add(new Monster("6", "Vrock", "64", "3"));
            MonsterList.Add(new Monster("6", "Mammoth", "332", "4"));

            MonsterList.Add(new Monster("7", "Yuan-Ti Abomination", "308", "1"));
            MonsterList.Add(new Monster("7", "Shield Golem", "271", "2"));
            MonsterList.Add(new Monster("7", "Mind Flayer", "222", "3"));
            MonsterList.Add(new Monster("7", "Giant Ape", "0", "4"));

            MonsterList.Add(new Monster("8", "Hydra", "190", "1"));
            MonsterList.Add(new Monster("8", "Assassin", "343", "2"));
            MonsterList.Add(new Monster("8", "Green Slaad", "277", "3"));
            MonsterList.Add(new Monster("8", "Fomorian", "136", "4"));

            MonsterList.Add(new Monster("9", "Bone Devil", "71", "1"));
            MonsterList.Add(new Monster("9", "Abominable Yeti", "306", "2"));
            MonsterList.Add(new Monster("9", "Clay Golem", "168", "3"));
            MonsterList.Add(new Monster("9", "Nycaloth", "134", "4"));

            MonsterList.Add(new Monster("10", "Deva", "16", "1"));
            MonsterList.Add(new Monster("10", "Guardian Naga", "234", "2"));
            MonsterList.Add(new Monster("10", "Stone Golem", "170", "3"));
            MonsterList.Add(new Monster("10", "Young Red Dragon", "98", "4"));

            MonsterList.Add(new Monster("11", "Roc", "260", "1"));
            MonsterList.Add(new Monster("11", "Gynosphinx", "282", "5"));
            MonsterList.Add(new Monster("11", "Horned Devil", "74", "3"));
            MonsterList.Add(new Monster("11", "Remorhaz", "258", "4"));
            MonsterList.Add(new Monster("11", "Doomwake Giant", "MOT 224", "2"));

            MonsterList.Add(new Monster("12", "Arcanaloth", "313", "1"));
            MonsterList.Add(new Monster("12", "Archmage", "243", "2"));
            MonsterList.Add(new Monster("12", "Erinyes", "73", "3"));
            MonsterList.Add(new Monster("12", "Ironscale Hydra", "MOT 231", "4"));

            MonsterList.Add(new Monster("13", "Adult Brass Dragon", "105", "1"));
            MonsterList.Add(new Monster("13", "Beholder", "28", "2"));
            MonsterList.Add(new Monster("13", "Young Red Shadow Dragon", "85", "3"));
            MonsterList.Add(new Monster("13", "Adult White Dragon", "101", "4"));

            MonsterList.Add(new Monster("14", "Adult Black Dragon", "87", "1"));
            MonsterList.Add(new Monster("14", "Ice Devil", "75", "2"));
            MonsterList.Add(new Monster("14", "Death Tyrant", "29", "3"));
            MonsterList.Add(new Monster("14", "Adult Copper Dragon", "88", "4"));

            MonsterList.Add(new Monster("15", "Purple Worm", "255", "1"));
            MonsterList.Add(new Monster("15", "Mummy Lord", "229", "5"));
            MonsterList.Add(new Monster("15", "Adult Bronze Dragon", "108", "3"));
            MonsterList.Add(new Monster("15", "Adult Green Dragon", "0", "6"));
            MonsterList.Add(new Monster("15", "Hundred-Handed One", "MOT 225", "2"));
            MonsterList.Add(new Monster("15", "Typhon", "MOT 246", "4"));

            MonsterList.Add(new Monster("16", "Iron Golem", "170", "1"));
            MonsterList.Add(new Monster("16", "Marilith", "61", "2"));
            MonsterList.Add(new Monster("16", "Planetar", "17", "3"));
            MonsterList.Add(new Monster("16", "Adult Silver Dragon", "117", "4"));

            MonsterList.Add(new Monster("17", "Dragon Turtle", "MM 119", "1"));
            MonsterList.Add(new Monster("17", "Death Knight", "MM 47", "2"));
            MonsterList.Add(new Monster("17", "Goristro", "MM 59", "3"));
            MonsterList.Add(new Monster("17", "Androsphinx", "MM 281", "4"));

            MonsterList.Add(new Monster("18", "Demilich", "MM 48", "1"));
            MonsterList.Add(new Monster("18", "Borborygmos", "GGR 238", "2"));
            MonsterList.Add(new Monster("18", "Amnizu", "MTF 164", "3"));
            MonsterList.Add(new Monster("18", "Walking Statue of Waterdeep", "WDH 219", "4"));

            MonsterList.Add(new Monster("19", "Balor", "MM 55", "1"));
            MonsterList.Add(new Monster("19", "Bael", "MTF 170", "2"));
            MonsterList.Add(new Monster("19", "Red Abishai", "MTF 160", "5"));
            MonsterList.Add(new Monster("19", "Imix", "PoTA 214", "4"));
            MonsterList.Add(new Monster("19", "Polukranos", "MOT 231", "3"));

            //MonsterList.Add(new Monster("20", "Leviathan", "MTF 198", "1"));
            MonsterList.Add(new Monster("20", "Nightwalker", "MTF 216", "2"));
            MonsterList.Add(new Monster("20", "Pit Fiend", "MM 77", "3"));
            MonsterList.Add(new Monster("20", "Ogrémoch", "PoTA 216", "4"));
            MonsterList.Add(new Monster("20", "Ancient White Dragon", "MM 100", "5"));
            MonsterList.Add(new Monster("20", "Ancient Brass Dragon", "MM 104", "6"));

            //Homebrew Monsters
            MonsterList.Add(new Monster("17", "Abysswalker", "Homebrew", "0"));
            MonsterList.Add(new Monster("12", "Alpha Minotaur", "Homebrew", "0"));
            MonsterList.Add(new Monster("9", "Baku", "Homebrew", "0"));
            MonsterList.Add(new Monster("14", "Balewing", "Homebrew", "0"));
            MonsterList.Add(new Monster("16", "Black Root", "Homebrew", "0"));
            MonsterList.Add(new Monster("17", "Brachydios", "Homebrew", "0"));
            MonsterList.Add(new Monster("16", "Cenokian Wraith", "Homebrew", "0"));
            MonsterList.Add(new Monster("14", "Cerynitis", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Chosen of Baphomet", "Homebrew", "0"));
            MonsterList.Add(new Monster("17", "Colossal Undead", "Homebrew", "0"));
            MonsterList.Add(new Monster("17", "Crypt Horror", "Homebrew", "0"));
            MonsterList.Add(new Monster("18", "Crystalline Dragon", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Dolgotha", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Fusion Elemental", "Homebrew", "0"));
            MonsterList.Add(new Monster("16", "Gargolem", "Homebrew", "0"));
            MonsterList.Add(new Monster("19", "Ghoul Regent", "Homebrew", "0"));
            MonsterList.Add(new Monster("30", "Godzilla", "Homebrew", "0"));
            MonsterList.Add(new Monster("10", "Greater Basilisk", "Homebrew", "0"));
            MonsterList.Add(new Monster("14", "Green Enchantress", "Homebrew", "0"));
            MonsterList.Add(new Monster("16", "Implacable Assassin", "Homebrew", "0"));
            MonsterList.Add(new Monster("13", "Krampus", "Homebrew", "0"));
            MonsterList.Add(new Monster("17", "Megalodon", "Homebrew", "0"));
            MonsterList.Add(new Monster("14", "Morvudd", "Homebrew", "0"));
            MonsterList.Add(new Monster("14", "Mula", "Homebrew", "0"));
            MonsterList.Add(new Monster("10", "Nightblade", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Pesta", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Plated Behir", "Homebrew", "0"));
            MonsterList.Add(new Monster("14", "Royal Griffin", "Homebrew", "0"));
            MonsterList.Add(new Monster("1", "Sea Rex", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Shadow Dragon", "Homebrew", "0"));
            MonsterList.Add(new Monster("12", "Soul of Ember", "Homebrew", "0"));
            MonsterList.Add(new Monster("15", "Spawn of Orcus", "Homebrew", "0"));
            MonsterList.Add(new Monster("11", "Spriggan", "Homebrew", "0"));
            MonsterList.Add(new Monster("10", "The Rock Golem", "Homebrew", "0"));
            MonsterList.Add(new Monster("20", "Thunderbird", "Homebrew", "0"));
            MonsterList.Add(new Monster("12", "Tormentor", "Homebrew", "0"));
            MonsterList.Add(new Monster("16", "Ulfhedinn", "Homebrew", "0"));
            MonsterList.Add(new Monster("19", "Varghulf", "Homebrew", "0"));
            MonsterList.Add(new Monster("16", "War Titan", "Homebrew", "0"));
            MonsterList.Add(new Monster("17", "Wild Hunt General", "Homebrew", "0"));

        }

        //Create 
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //Random rd = new Random();

            if (tbxRoomRoll.Text != "")
                RoomRoll = Convert.ToString(tbxRoomRoll.Text);


            if (tbxBiomRoll.Text != "")
                BiomRoll = Convert.ToString(tbxBiomRoll.Text);


            if (tbxEventRoll.Text != "")
                EventRoll = Convert.ToString(tbxEventRoll.Text);


            if (tbxCRRoll.Text != "")
                CRRoll = Convert.ToString(tbxCRRoll.Text);



            GenerateValues();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();

            RoomRoll = Convert.ToString(rd.Next(1, 12));
            BiomRoll = Convert.ToString(rd.Next(1, 12));
            EventRoll = Convert.ToString(rd.Next(1, 12));
            CRRoll = Convert.ToString(rd.Next(1, 6));



            GenerateValues();
        }

        public void GenerateValues()
        {

            //Generate Room
            foreach (RoomNumber roll in RoomList)
            {
                if (roll.Number == RoomRoll)
                {
                    tbxRoomDesc.Text = "Current Room " + roll.Room;
                    CurrentRoomRoll = roll.Room;
                }
            }

            //Generate Biom
            foreach (Biom roll in BiomList)
            {
                if (roll.BiomNumber == BiomRoll)
                {
                    tbxBiomDesc.Text = roll.BiomDesc;
                }
            }

            //Generate Event
            foreach (Event roll in EventList)
            {
                if (roll.EventNumber == EventRoll)
                {
                    tbxEventDesc.Text = roll.EventDesc;
                }
            }

            //Generate CR
            foreach (MonsterCR roll in CRList)
            {
                if (roll.LVLNumber == CRRoll)
                {
                    tbxMonterCRDesc.Text = "Level " + roll.LVLDesc + " Monster(s)";
                    CurrentMonsterCR = roll.LVLDesc;
                }
            }


            tbxRoomRoll.Text = RoomRoll;
            tbxBiomRoll.Text = BiomRoll;
            tbxEventRoll.Text = EventRoll;
            tbxCRRoll.Text = CRRoll;

        }




        /* Assign 4 Monsters for each CR and pop them into a list */

        public void GetMonsterList()
        {
            //Random rd = new Random();
            //int index = rd.Next(MonsterList.Count);

        }

        public void AssignMonsterRolls()
        {

            for (int i = 2; i < 11; i++)
            {
                Random rd = new Random();
                int x = 1;
                foreach (Monster mon in MonsterList.Where(n => n.MonsterCR == Convert.ToString(i)))
                {
                    int index = rd.Next(1, 5);
                    mon.MonsterRdNumber = Convert.ToString(index);
                    TempMonsterList.Add(mon);
                    x++;
                }

            }
        }

        public void AssignRDnumbers()
        {
            Random rd = new Random();
            foreach (Monster mon in TempMonsterList)
            {
                string rdnumber = Convert.ToString(rd.Next(1, TempMonsterList.Count()));
                if (CheckExists(rdnumber) == true)
                {
                    mon.MonsterRdNumber = rdnumber;
                }
            }
        }

        public bool CheckExists(string rdnumber)
        {
            foreach (Monster moncr in TempMonsterList)
            {
                if (moncr.MonsterRdNumber != rdnumber)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        /*private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AssignMonsterRolls();
        }*/

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MonsterWindow monsterWindow = new MonsterWindow(CRRoll);
            monsterWindow.Show();

        }

        private void BtnRoom_Click(object sender, RoutedEventArgs e)
        {
            int addroom = 0;
            //addroom = Convert.ToInt32(roll.Room);
            int room = Convert.ToInt32(tbxRoomRoll.Text);
            int CurrentRoom = Convert.ToInt32(tbxCurrentRoom.Text);

            if (room == 1)
            {
                addroom = -6;
            }
            else if (room == 2)
            {
                addroom = -5;
            }
            else if (room == 3)
            {
                addroom = -4;
            }
            else if (room == 4)
            {
                addroom = -3;
            }
            else if (room == 5)
            {
                addroom = -2;
            }
            else if (room == 6)
            {
                addroom = -1;
            }
            else if (room == 7)
            {
                addroom = 1;
            }
            else if (room == 8)
            {
                addroom = 2;
            }
            else if (room == 9)
            {
                addroom = 3;
            }
            else if (room == 10)
            {
                addroom = 4;
            }
            else if (room == 11)
            {
                addroom = 5;
            }
            else if (room == 12)
            {
                addroom = 6;
            }



            //Generate New Room #
            if (tbxCurrentRoom.Text != "")
            {
                //int roomno = Convert.ToInt32(tbxCurrentRoom.Text) + Convert.ToInt32(CurrentRoomRoll);
                int roomno = Convert.ToInt32(tbxCurrentRoom.Text) + addroom;
                tbxCurrentRoom.Text = Convert.ToString(roomno);
            }
        }

        private void btnTowerLevel(object sender, RoutedEventArgs e)
        {
            TowerLevels tl = new TowerLevels();
            tl.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Merchant MerWin = new Merchant();
            MerWin.Show();
        }
    }
}
