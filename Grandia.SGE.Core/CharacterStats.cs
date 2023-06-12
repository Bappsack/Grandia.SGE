using Grandia.SGE.Core.Structures;

namespace Grandia.SGE.Core
{
    public static class CharacterStats
    {
        internal static int CharacterAmount = 8;
        internal static int InventorySize = 0x18;
        internal class Blocks
        {
            // Stats
            internal static int Name = 0x00;
            internal static int Level = 0x03;

            //internal int UNDOCUMENTED 0x04 - 0x05;

            internal static int Current_Experience = 0x08;
            internal static int Total_Experience = 0x34;

            internal static int STR = 0xE;
            internal static int VIT = 0x10;
            internal static int WIT = 0x12;
            internal static int AGI = 0x14;

            internal static int HP_Current = 0xA;
            internal static int HP_Total = 0xC;

            internal static int SP_Current = 0x16;
            internal static int SP_Total = 0x18;

            internal static int MP_1_Current = 0x3C;
            internal static int MP_1_Total = 0x3D;

            internal static int MP_2_Current = 0x3E;
            internal static int MP_2_Total = 0x3F;

            internal static int MP_3_Current = 0x40;
            internal static int MP_3_Total = 0x41;


            internal static int Fire_Level = 0x2C;
            internal static int Wind_Level = 0x2D;
            internal static int Water_Level = 0x2E;
            internal static int Earth_Level = 0x2F;

            internal static int Weapon1_Level = 0x30;
            internal static int Weapon2_Level = 0x32;
            internal static int Weapon3_Level = 0x33;

            internal static int Fire_Experience = 0x1C;
            internal static int Wind_Experience = 0x20;
            internal static int Water_Experience = 0x1E;
            internal static int Earth_Experience = 0x22;

            internal static int Weapon1_Experience = 0x24;
            internal static int Weapon2_Experience = 0x26;
            internal static int Weapon3_Experience = 0x28;

            // Equipment

            internal static int Weapon = 0x4C;
            internal static int Shield = 0x4E;
            internal static int Armor = 0x50;
            internal static int Helmet = 0x52;
            internal static int Shoes = 0x54;
            internal static int Jewerly = 0x56;

            // Inventory
            internal static int Inventory = 0x58; // 18 Bytes, 2 per slot (ID)
        }

        public static class Characters
        {
            public static List<CharacterInfo> GetCharacters()
            {
                if (Data.SaveBlock is null)
                    return null;

                var CharacterList = new List<CharacterInfo>();

                // Dump whole Characters Block
                var characters = Data.SaveBlock.AsSpan(Data.CharacterStatsStart, Data.CharacterStatsLength * CharacterAmount).ToArray();

                for (int i = 0; i < CharacterAmount; i++)
                {
                    var dump = characters.AsSpan(i * Data.CharacterStatsLength, Data.CharacterStatsLength).ToArray();

                    var slot = new CharacterInfo
                    {
                        // Character Stats
                        Name = (Character)dump[Blocks.Name],

                        Current_EXP = BitConverter.ToUInt16(dump, Blocks.Current_Experience),
                        Total_EXP = BitConverter.ToUInt16(dump, Blocks.Total_Experience),

                        HP_Current = BitConverter.ToInt16(dump, Blocks.HP_Current),
                        HP_Max = BitConverter.ToInt16(dump, Blocks.HP_Total),
                        SP_Current = BitConverter.ToInt16(dump, Blocks.SP_Current),
                        SP_Total = BitConverter.ToInt16(dump, Blocks.SP_Total),

                        Magic1_Current = dump[Blocks.MP_1_Current],
                        Magic1_Total = dump[Blocks.MP_1_Total],
                        Magic2_Current = dump[Blocks.MP_2_Current],
                        Magic2_Total = dump[Blocks.MP_2_Total],
                        Magic3_Current = dump[Blocks.MP_3_Current],
                        Magic3_Total = dump[Blocks.MP_3_Total],

                        // Base Stats
                        STR = BitConverter.ToInt16(dump, Blocks.STR),
                        WIT = BitConverter.ToInt16(dump, Blocks.WIT),
                        VIT = BitConverter.ToInt16(dump, Blocks.VIT),
                        AGI = BitConverter.ToInt16(dump, Blocks.AGI),

                        Level = dump[Blocks.Level],

                        FireLevel = dump[Blocks.Fire_Level],
                        WindLevel = dump[Blocks.Wind_Level],
                        WaterLevel = dump[Blocks.Water_Level],
                        EarthLevel = dump[Blocks.Earth_Level],

                        Weapon1Level = dump[Blocks.Weapon1_Level],
                        Weapon2Level = dump[Blocks.Weapon2_Level],
                        Weapon3Level = dump[Blocks.Weapon3_Level],

                        FireEXP = dump[Blocks.Fire_Experience],
                        WindEXP = dump[Blocks.Wind_Experience],
                        WaterEXP = dump[Blocks.Water_Experience],
                        EarthEXP = dump[Blocks.Earth_Experience],

                        Weapon1EXP = dump[Blocks.Weapon1_Experience],
                        Weapon2EXP = dump[Blocks.Weapon2_Experience],
                        Weapon3EXP = dump[Blocks.Weapon3_Experience],


                        // Equipment
                        Weapon = BitConverter.ToInt16(dump, Blocks.Weapon),
                        Shield = BitConverter.ToInt16(dump, Blocks.Shield),
                        Armor = BitConverter.ToInt16(dump, Blocks.Armor),
                        Helmet = BitConverter.ToInt16(dump, Blocks.Helmet),
                        Shoes = BitConverter.ToInt16(dump, Blocks.Shoes),
                        Jewerly = BitConverter.ToInt16(dump, Blocks.Jewerly),

                        // Inventory
                        Inventory = GetInventory(dump.AsSpan(Blocks.Inventory, InventorySize).ToArray()),
                    };
                    CharacterList.Add(slot);
                }

                return CharacterList;
            }

            private static List<uint> GetInventory(byte[] data)
            {
                List<uint> inventory = new();
                for (int i = 0; i < InventorySize; i += 2)
                {
                    var result = BitConverter.ToUInt16(data.AsSpan(i).ToArray());
                    inventory.Add(result);
                }
                return inventory;
            }
        }
    }
}
