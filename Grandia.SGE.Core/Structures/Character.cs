namespace Grandia.SGE.Core.Structures
{
    public enum Character
    {
        Justin = 1,
        Feena = 2,
        Sue = 3,
        Gadwin = 4,
        Rapp = 5,
        Milda = 6,
        Guido = 7,
        Liete = 8,
    }

    public class CharacterInfo
    {
        // Character Stats
        public Character Name;

        public uint Current_EXP;
        public uint Total_EXP;

        public int HP_Current;
        public int HP_Max;

        public int STR;
        public int VIT;
        public int WIT;
        public int AGI;
        public int Level;


        public int SP_Current;
        public int SP_Total;

        public int Magic1_Current;
        public int Magic1_Total;

        public int Magic2_Current;
        public int Magic2_Total;

        public int Magic3_Current;
        public int Magic3_Total;


        public int FireLevel;
        public int FireEXP;

        public int WaterLevel;
        public int WaterEXP;

        public int WindLevel;
        public int WindEXP;

        public int EarthLevel;
        public int EarthEXP;

        public int Weapon1Level;
        public int Weapon1EXP;

        public int Weapon2Level;
        public int Weapon2EXP;

        public int Weapon3Level;
        public int Weapon3EXP;

        public int Weapon;
        public int Shield;
        public int Armor;
        public int Helmet;
        public int Shoes;
        public int Jewerly;

        public List<uint>? Inventory;
    }
}