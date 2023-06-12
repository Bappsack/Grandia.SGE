using Grandia.SGE.Core;
using Grandia.SGE.Core.Structures;

namespace Grandia.SGE.WinForms
{
    public partial class Form1 : Form
    {
        private int CurrentCharacter = 0;
        private CharacterInfo characterinfo;

        public Form1()
        {
            InitializeComponent();

            PopulateCharacterEquipmentForms();
            // Collect Savegames
            string savePathMemCard1 = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\GRANDIA1\\";

            foreach (var file in Directory.GetFiles(savePathMemCard1, "*.*", SearchOption.AllDirectories))
            {
                if (Path.GetExtension(file).ToLower() is ".vdf" or ".txt" or ".ini") // Ignore Steam Cloud and game setting files
                    continue;
                comboBox1.Items.Add(file);
            }
        }

        private static void BackupSaveFile(string Filename)
        {
            var BackupName = $"{Filename}_{DateTime.Now.TimeOfDay.TotalNanoseconds}";
            File.Copy(Filename, BackupName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load Save

            if (!File.Exists(comboBox1.Text))
            {
                MessageBox.Show("File not found!");
                return;
            }

            Data.LoadSaveFile(comboBox1.Text);
            BackupSaveFile(comboBox1.Text);
            SaveDataText.Text = Data.SavePointName();
            SaveDataPlaytime.Text = Data.SavePlayTime();
            SaveDataPartyMembers.Text = Data.SavePartyMembers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentCharacterBox.Text == string.Empty)
                return;

            PopulateCharacterForm();
        }

        public void PopulateCharacterForm()
        {
            if (Data.SaveBlock is null)
                return;

            if (characterinfo is null)
                return;

            // Populate Form
            Portrait.Image = GetCharacterPortrait(characterinfo.Name);

            STR.Value = characterinfo.STR;
            VIT.Value = characterinfo.VIT;
            WIT.Value = characterinfo.WIT;
            AGI.Value = characterinfo.AGI;
            LVL.Value = characterinfo.Level;

            HP.Value = characterinfo.HP_Current;
            HPMAX.Value = characterinfo.HP_Max;
            SP.Value = characterinfo.SP_Current;
            SPMAX.Value = characterinfo.SP_Total;
            MP1.Value = characterinfo.Magic1_Current;
            MP1MAX.Value = characterinfo.Magic1_Total;
            MP2.Value = characterinfo.Magic2_Current;
            MP2MAX.Value = characterinfo.Magic2_Total;
            MP3.Value = characterinfo.Magic3_Current;
            MP3MAX.Value = characterinfo.Magic3_Total;
            CurrentEXP.Value = characterinfo.Current_EXP;
            TotalEXP.Value = characterinfo.Total_EXP;

            Weapon1LVL.Value = characterinfo.Weapon1Level;
            Weapon1EXP.Value = characterinfo.Weapon1EXP;
            Weapon2LVL.Value = characterinfo.Weapon2Level;
            Weapon2EXP.Value = characterinfo.Weapon2EXP;
            Weapon3LVL.Value = characterinfo.Weapon3Level;
            Weapon3EXP.Value = characterinfo.Weapon3EXP;

            FireLVL.Value = characterinfo.FireLevel;
            FireEXP.Value = characterinfo.FireEXP;
            WindLVL.Value = characterinfo.WindLevel;
            WindEXP.Value = characterinfo.WindEXP;
            WaterLVL.Value = characterinfo.WaterLevel;
            WaterEXP.Value = characterinfo.WaterEXP;
            EarthLVL.Value = characterinfo.EarthLevel;
            EarthEXP.Value = characterinfo.EarthEXP;

            // Equipment
            Weapon.Text = Items.GetInventoryItemName((uint)characterinfo.Weapon);
            Shield.Text = Items.GetInventoryItemName((uint)characterinfo.Shield);
            Armor.Text = Items.GetInventoryItemName((uint)characterinfo.Armor);
            Helmet.Text = Items.GetInventoryItemName((uint)characterinfo.Helmet);
            Shoes.Text = Items.GetInventoryItemName((uint)characterinfo.Shield);
            Jewerly.Text = Items.GetInventoryItemName((uint)characterinfo.Jewerly);
        }

        private static Image GetCharacterPortrait(Character character)
        {
            return character switch
            {
                Character.Justin => LoadPortraitImage(Resources.Justin),
                Character.Feena => LoadPortraitImage(Resources.Feena),
                Character.Sue => LoadPortraitImage(Resources.Sue),
                Character.Gadwin => LoadPortraitImage(Resources.Gadwin),
                Character.Rapp => LoadPortraitImage(Resources.Rapp),
                Character.Milda => LoadPortraitImage(Resources.Milda),
                Character.Guido => LoadPortraitImage(Resources.Guido),
                Character.Liete => LoadPortraitImage(Resources.Liete),
                _ => LoadPortraitImage(Resources.invalid),
            }; ;
        }

        private static Image LoadPortraitImage(byte[] input)
        {
            using var ms = new MemoryStream(input);
            return Image.FromStream(ms);
        }

        public void PopulateCharacterEquipmentForms()
        {
            for (int i = 10; i < 512; i++)
            {
                Weapon.Items.Add(Items.GetInventoryItemName((uint)i));
                Shield.Items.Add(Items.GetInventoryItemName((uint)i));
                Armor.Items.Add(Items.GetInventoryItemName((uint)i));
                Helmet.Items.Add(Items.GetInventoryItemName((uint)i));
                Shoes.Items.Add(Items.GetInventoryItemName((uint)i));
                Jewerly.Items.Add(Items.GetInventoryItemName((uint)i));
            }


            foreach (Character ch in Enum.GetValues(typeof(Character)))
                CurrentCharacterBox.Items.Add(ch);
        }

        private void CurrentCharacterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Data.SaveBlock is null)
                return;

            CurrentCharacter = CurrentCharacterBox.SelectedIndex;
            characterinfo = Data.GetCharacter(CurrentCharacter);
        }
    }
}