using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Sabercolor_Changer.Helpers;

namespace Sabercolor_Changer
{
    public partial class Form1 : Form
    {

        public string folderName = ("first_extract");
        public List<SaberData> saberList;

        public Form1()
        {
            InitializeComponent();

            saberList = new List<SaberData>
            {
                new SaberData(0x105, 0x146, 0x16F, blueColor1,    blueColor2,    soundfontBlue,    resetBlue1,    resetBlue2),
                new SaberData(0x319, 0x35A, 0x383, greenColor1,   greenColor2,   soundfontGreen,   resetGreen1,   resetGreen2),
                new SaberData(0xADC, 0xB1D, 0xB46, orangeColor1,  orangeColor2,  soundfontOrange,  resetOrange1,  resetOrange2),
                new SaberData(0x43C, 0x47D, 0x4A6, purpleColor1,  purpleColor2,  soundfontPurple,  resetPurple1,  resetPurple2),
                new SaberData(0x55F, 0x5A0, 0x5C9, yellowColor1,  yellowColor2,  soundfontYellow,  resetYellow1,  resetYellow2),
                new SaberData(0x680, 0x6C1, 0x6EA, cyanColor1,    cyanColor2,    soundfontCyan,    resetCyan1,    resetCyan2),
                new SaberData(0x7A4, 0x7E5, 0x80E, magentaColor1, magentaColor2, soundfontMagenta, resetMagenta1, resetMagenta2),
                new SaberData(0x9B9, 0x9FA, 0xA23, indigoColor1,  indigoColor2,  soundfontIndigo,  resetIndigo1,  resetIndigo2),
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saberList.ForEach(x => x.LoadAll(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P));
        }

        private void ResetColorBlade_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SaberData saber = (SaberData)button.Tag;

            saber.LoadBladeColor(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P);
        }

        private void ResetColorGlow_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SaberData saber = (SaberData)button.Tag;

            saber.LoadGlowColor(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P);
        }

        private void EditColor_Color(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            colorpicker.Color = button.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                button.BackColor = colorpicker.Color;
        }

        private void ResetAll_Click(object sender, EventArgs e)
        {
            saberList.ForEach(saber => saber.LoadAll(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P));
        }

        private void ExportToPakButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select your .../Jedi Fallen Order/SwGame/Content/Paks folder";

            //remember path
            if (folderName != "first_extract")
                folderBrowserDialog.SelectedPath = folderName;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderName = folderBrowserDialog.SelectedPath;

                byte[] pakFile = new byte[Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P.Length];
                Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x0, pakFile, 0, Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P.Length);

                saberList.ForEach(saber => saber.Save(pakFile));

                if (!File.Exists(folderName + "/pakchunk0-WindowsNoEditor.pak"))
                    InfoBox.Text = "Pakchunk99_CustomSabercolors.pak exported to: " + folderName + Environment.NewLine + Environment.NewLine + "This does not look like your game's Paks folder." + Environment.NewLine + "You will need to manually copy Pakchunk99_CustomSabercolors.pak to your .../Jedi Fallen Order/SwGame/Content/Paks folder.";
                else
                {
                    var check = File.Exists(folderName + "/pakchunk99-Mods_BetterGreenSaber_P.pak");
                    var check2 = File.Exists(folderName + "/pakchunk99-Mods_GreenToRedSaber_P.pak");

                    if (check)
                        InfoBox.Text = "Custom lightsaber colors exported to the game, but BETTER GREEN LIGHTSABER mod is also installed." + Environment.NewLine + "Please navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete pakchunk99-Mods_BetterGreenSaber_P.pak to ensure your custom colors are working." + Environment.NewLine + Environment.NewLine + "To uninstall your custom colors, navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete Pakchunk99_CustomSabercolors.pak";
                    
                    if (check2)
                        InfoBox.Text = "Custom lightsaber colors exported to the game, but GREEN TO RED LIGHTSABER mod is also installed." + Environment.NewLine + "Please navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete pakchunk99-Mods_GreenToRedSaber_P.pak to ensure your custom colors are working." + Environment.NewLine + Environment.NewLine + "To uninstall your custom colors, navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete Pakchunk99_CustomSabercolors.pak";
                    
                    if (!check && !check2)
                        InfoBox.Text = "Custom lightsaber colors exported to the game!" + Environment.NewLine + Environment.NewLine + "To uninstall, navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete Pakchunk99_CustomSabercolors.pak";
                }
                File.WriteAllBytes(folderName + "/Pakchunk99_CustomSabercolors.pak", pakFile);
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the location of the Pakchunk99_CustomSabercolors.pak file to import.";

            if (folderName != "first_extract")
                folderBrowserDialog.SelectedPath = folderName;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderName = folderBrowserDialog.SelectedPath;

                if (!File.Exists(folderName + "/Pakchunk99_CustomSabercolors.pak"))
                    InfoBox.Text = "Pakchunk99_CustomSabercolors.pak not found. Please check the destination folder.";
                else
                {
                    byte[] newFile = File.ReadAllBytes(folderName + "/Pakchunk99_CustomSabercolors.pak");

                    if (newFile.Length != Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P.Length)
                        InfoBox.Text = "Pakchunk99_CustomSabercolors.pak found but is invalid. Please export a new file.";
                    else
                    {
                        saberList.ForEach(saber => saber.LoadAll(newFile));

                        InfoBox.Text = "Valid Pakchunk99_CustomSabercolors.pak found and imported.";
                    }
                }
            }
        }
    }
}
