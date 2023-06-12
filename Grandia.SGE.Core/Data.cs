using Grandia.SGE.Core.Structures;
using System.Text;

namespace Grandia.SGE.Core
{
    public static class Data
    {
        // Save Offsets
        private readonly static int Gold = 0x330; // Uint32
        private readonly static int PlayTime = 0x290; // Saved in Frames ( Uint32/30 = Total Seconds )
        private readonly static int SaveName = 0x2D4; // ASCII 0x12
        internal static int SavePartyMember = 0x32C; // Displays Character on the Current Save by Character ID's
        private readonly static int FPSTimer = 60;

        // Characters
        internal static int CharacterStatsStart = 0x490;
        internal static int CharacterStatsLength = 0x80;

        // Stash
        internal static int StashQuantityStart = 0xC50;
        internal static int StashQuantityLength = 0x200;

        public static string? FileName { get; private set; }
        public static int SaveIdentifier { get; set; }
        public static byte[] SaveBlock { get; set; }


        public static void LoadSaveFile(string file)
        {
            SaveBlock = File.ReadAllBytes(file);
            FileName = Path.GetFileName(file);
            _ = int.TryParse(FileName[18..], out _);
        }

        public static int? CurrentGold => BitConverter.ToInt32(SaveBlock, Gold);

        private static TimeSpan GetPlaytime()
        {
            var playtime = TimeSpan.FromSeconds((BitConverter.ToUInt32(SaveBlock, PlayTime) / FPSTimer));
            return playtime;
        }

        public static string? SavePlayTime()
        {
            var time = GetPlaytime();
            return string.Format("{0:D2}h {1:D2}m {2:D2}s", (int)time.TotalHours, time.Minutes, time.Seconds);
        }

        public static string? SavePartyMembers()
        {
            if (Data.SaveBlock is null)
                return null;

            var data = Data.SaveBlock.AsSpan(SavePartyMember, 4).ToArray();

            string? party = string.Empty;

            foreach (var member in data)
                if (member != 0)
                    party += $"{(Character)member}/";
            if (party != string.Empty)
                return party.Remove(party.Length - 1, 1);
            return party;
        }

        public static List<CharacterInfo> GetCharacters() => CharacterStats.Characters.GetCharacters();

        public static CharacterInfo GetCharacter(int Slot) => GetCharacters()[Slot];

        public static string? SavePointName() => Encoding.UTF8.GetString(SaveBlock, SaveName, 0x12).TrimEnd('\\');
    }

}
