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

namespace Sabercolor_Changer
{
    /*
static class Extensions
    {
        public static T[] GetRange<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
    */
    public partial class Form1 : Form
    {

        public string folderName = ("first_extract");

        private byte DoubleToByte(double value)
        {
            return (byte)(value * 255);
        }

        private float ByteToFloat(byte value)
        {
            return value / 255f;
        }


        public Form1()
        {
            InitializeComponent();

            Byte[] BlueBC = new byte[12];
            Byte[] BlueGC = new byte[12];
            Byte[] GreenBC = new byte[12];
            Byte[] GreenGC = new byte[12];
            Byte[] OrangeBC = new byte[12];
            Byte[] OrangeGC = new byte[12];
            Byte[] PurpleBC = new byte[12];
            Byte[] PurpleGC = new byte[12];
            Byte[] YellowBC = new byte[12];
            Byte[] YellowGC = new byte[12];
            Byte[] CyanBC = new byte[12];
            Byte[] CyanGC = new byte[12];
            Byte[] MagentaBC = new byte[12];
            Byte[] MagentaGC = new byte[12];
            Byte[] IndigoBC = new byte[12];
            Byte[] IndigoGC = new byte[12];


            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x105, BlueBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x146, BlueGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x319, GreenBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x35A, GreenGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xADC, OrangeBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xB1D, OrangeGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x43C, PurpleBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x47D, PurpleGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x55F, YellowBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x5A0, YellowGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x680, CyanBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x6C1, CyanGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x7A4, MagentaBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x7E5, MagentaGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x9B9, IndigoBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x9FA, IndigoGC, 0, 12);


            double rBlueBC = BitConverter.ToSingle(BlueBC, 0);
            double gBlueBC = BitConverter.ToSingle(BlueBC, 4);
            double bBlueBC = BitConverter.ToSingle(BlueBC, 8);
            double rBlueGC = BitConverter.ToSingle(BlueGC, 0);
            double gBlueGC = BitConverter.ToSingle(BlueGC, 4);
            double bBlueGC = BitConverter.ToSingle(BlueGC, 8);

            double rGreenBC = BitConverter.ToSingle(GreenBC, 0);
            double gGreenBC = BitConverter.ToSingle(GreenBC, 4);
            double bGreenBC = BitConverter.ToSingle(GreenBC, 8);
            double rGreenGC = BitConverter.ToSingle(GreenGC, 0);
            double gGreenGC = BitConverter.ToSingle(GreenGC, 4);
            double bGreenGC = BitConverter.ToSingle(GreenGC, 8);

            double rOrangeBC = BitConverter.ToSingle(OrangeBC, 0);
            double gOrangeBC = BitConverter.ToSingle(OrangeBC, 4);
            double bOrangeBC = BitConverter.ToSingle(OrangeBC, 8);
            double rOrangeGC = BitConverter.ToSingle(OrangeGC, 0);
            double gOrangeGC = BitConverter.ToSingle(OrangeGC, 4);
            double bOrangeGC = BitConverter.ToSingle(OrangeGC, 8);

            double rPurpleBC = BitConverter.ToSingle(PurpleBC, 0);
            double gPurpleBC = BitConverter.ToSingle(PurpleBC, 4);
            double bPurpleBC = BitConverter.ToSingle(PurpleBC, 8);
            double rPurpleGC = BitConverter.ToSingle(PurpleGC, 0);
            double gPurpleGC = BitConverter.ToSingle(PurpleGC, 4);
            double bPurpleGC = BitConverter.ToSingle(PurpleGC, 8);

            double rYellowBC = BitConverter.ToSingle(YellowBC, 0);
            double gYellowBC = BitConverter.ToSingle(YellowBC, 4);
            double bYellowBC = BitConverter.ToSingle(YellowBC, 8);
            double rYellowGC = BitConverter.ToSingle(YellowGC, 0);
            double gYellowGC = BitConverter.ToSingle(YellowGC, 4);
            double bYellowGC = BitConverter.ToSingle(YellowGC, 8);

            double rCyanBC = BitConverter.ToSingle(CyanBC, 0);
            double gCyanBC = BitConverter.ToSingle(CyanBC, 4);
            double bCyanBC = BitConverter.ToSingle(CyanBC, 8);
            double rCyanGC = BitConverter.ToSingle(CyanGC, 0);
            double gCyanGC = BitConverter.ToSingle(CyanGC, 4);
            double bCyanGC = BitConverter.ToSingle(CyanGC, 8);

            double rMagentaBC = BitConverter.ToSingle(MagentaBC, 0);
            double gMagentaBC = BitConverter.ToSingle(MagentaBC, 4);
            double bMagentaBC = BitConverter.ToSingle(MagentaBC, 8);
            double rMagentaGC = BitConverter.ToSingle(MagentaGC, 0);
            double gMagentaGC = BitConverter.ToSingle(MagentaGC, 4);
            double bMagentaGC = BitConverter.ToSingle(MagentaGC, 8);

            double rIndigoBC = BitConverter.ToSingle(IndigoBC, 0);
            double gIndigoBC = BitConverter.ToSingle(IndigoBC, 4);
            double bIndigoBC = BitConverter.ToSingle(IndigoBC, 8);
            double rIndigoGC = BitConverter.ToSingle(IndigoGC, 0);
            double gIndigoGC = BitConverter.ToSingle(IndigoGC, 4);
            double bIndigoGC = BitConverter.ToSingle(IndigoGC, 8);


            blueColor1.BackColor = Color.FromArgb(DoubleToByte(rBlueBC), DoubleToByte(gBlueBC), DoubleToByte(bBlueBC));
            blueColor2.BackColor = Color.FromArgb(DoubleToByte(rBlueGC), DoubleToByte(gBlueGC), DoubleToByte(bBlueGC));

            greenColor1.BackColor = Color.FromArgb(DoubleToByte(rGreenBC), DoubleToByte(gGreenBC), DoubleToByte(bGreenBC));
            greenColor2.BackColor = Color.FromArgb(DoubleToByte(rGreenGC), DoubleToByte(gGreenGC), DoubleToByte(bGreenGC));

            orangeColor1.BackColor = Color.FromArgb(DoubleToByte(rOrangeBC), DoubleToByte(gOrangeBC), DoubleToByte(bOrangeBC));
            orangeColor2.BackColor = Color.FromArgb(DoubleToByte(rOrangeGC), DoubleToByte(gOrangeGC), DoubleToByte(bOrangeGC));

            purpleColor1.BackColor = Color.FromArgb(DoubleToByte(rPurpleBC), DoubleToByte(gPurpleBC), DoubleToByte(bPurpleBC));
            purpleColor2.BackColor = Color.FromArgb(DoubleToByte(rPurpleGC), DoubleToByte(gPurpleGC), DoubleToByte(bPurpleGC));

            yellowColor1.BackColor = Color.FromArgb(DoubleToByte(rYellowBC), DoubleToByte(gYellowBC), DoubleToByte(bYellowBC));
            yellowColor2.BackColor = Color.FromArgb(DoubleToByte(rYellowGC), DoubleToByte(gYellowGC), DoubleToByte(bYellowGC));

            cyanColor1.BackColor = Color.FromArgb(DoubleToByte(rCyanBC), DoubleToByte(gCyanBC), DoubleToByte(bCyanBC));
            cyanColor2.BackColor = Color.FromArgb(DoubleToByte(rCyanGC), DoubleToByte(gCyanGC), DoubleToByte(bCyanGC));

            magentaColor1.BackColor = Color.FromArgb(DoubleToByte(rMagentaBC), DoubleToByte(gMagentaBC), DoubleToByte(bMagentaBC));
            magentaColor2.BackColor = Color.FromArgb(DoubleToByte(rMagentaGC), DoubleToByte(gMagentaGC), DoubleToByte(bMagentaGC));

            indigoColor1.BackColor = Color.FromArgb(DoubleToByte(rIndigoBC), DoubleToByte(gIndigoBC), DoubleToByte(bIndigoBC));
            indigoColor2.BackColor = Color.FromArgb(DoubleToByte(rIndigoGC), DoubleToByte(gIndigoGC), DoubleToByte(bIndigoGC));




            Byte[] BlueSound = new byte[4];
            Byte[] GreenSound = new byte[4];
            Byte[] OrangeSound = new byte[4];
            Byte[] PurpleSound = new byte[4];
            Byte[] YellowSound = new byte[4];
            Byte[] CyanSound = new byte[4];
            Byte[] MagentaSound = new byte[4];
            Byte[] IndigoSound = new byte[4];

            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x16F, BlueSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x383, GreenSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xB46, OrangeSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x4A6, PurpleSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x5C9, YellowSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x6EA, CyanSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x80E, MagentaSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xA23, IndigoSound, 0, 4);

            float BlueSoundID = BitConverter.ToSingle(BlueSound, 0);
            float GreenSoundID = BitConverter.ToSingle(GreenSound, 0);
            float OrangeSoundID = BitConverter.ToSingle(OrangeSound, 0);
            float PurpleSoundID = BitConverter.ToSingle(PurpleSound, 0);
            float YellowSoundID = BitConverter.ToSingle(YellowSound, 0);
            float CyanSoundID = BitConverter.ToSingle(CyanSound, 0);
            float MagentaSoundID = BitConverter.ToSingle(MagentaSound, 0);
            float IndigoSoundID = BitConverter.ToSingle(IndigoSound, 0);

            int BlueSoundIDint = (int)BlueSoundID;
            int GreenSoundIDint = (int)GreenSoundID;
            int OrangeSoundIDint = (int)OrangeSoundID;
            int PurpleSoundIDint = (int)PurpleSoundID;
            int YellowSoundIDint = (int)YellowSoundID;
            int CyanSoundIDint = (int)CyanSoundID;
            int MagentaSoundIDint = (int)MagentaSoundID;
            int IndigoSoundIDint = (int)IndigoSoundID;

            soundfontBlue.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontGreen.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontOrange.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontPurple.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontYellow.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontCyan.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontMagenta.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });
            soundfontIndigo.Items.AddRange(new string[] { "Blue", "Cyan", "Green", "Indigo", "Magenta", "Orange", "Orange-red", "Purple", "Red", "Malicos", "Yellow" });

            soundfontBlue.SelectedIndex = BlueSoundIDint - 1;
            soundfontGreen.SelectedIndex = GreenSoundIDint - 1;
            soundfontOrange.SelectedIndex = OrangeSoundIDint - 1;
            soundfontPurple.SelectedIndex = PurpleSoundIDint - 1;
            soundfontYellow.SelectedIndex = YellowSoundIDint - 1;
            soundfontCyan.SelectedIndex = CyanSoundIDint - 1;
            soundfontMagenta.SelectedIndex = MagentaSoundIDint - 1;
            soundfontIndigo.SelectedIndex = IndigoSoundIDint - 1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {
            /*           Byte[] Red1 = new byte[4];
                       //Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x105, Red1, 0, 4);

                       //Array.Reverse(Red1);
                       //Double Red1color = BitConverter.ToDouble(Red1, 0);

                       string PakString = BitConverter.ToString(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x105, Red1, 0, 4));
                       //string PakString = Red1color.ToString();
                       //label6.Text = PakString;
                       */
        }





        //RESET COLORS
        private void button13_Click(object sender, EventArgs e) //resetblueBC
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x105, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            blueColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetBlue2_Click(object sender, EventArgs e) //resetblueGC
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x146, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            blueColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));

        }

        private void button2_Click_1(object sender, EventArgs e) //resetgreenBC
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x319, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            greenColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));

        }

        private void ResetGreen2_Click(object sender, EventArgs e) //resetgreenGC
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x35A, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            greenColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetOrange1_Click(object sender, EventArgs e) //resetorangeBC
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xADC, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            orangeColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetOrange2_Click(object sender, EventArgs e) //resetorangeGC
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xB1D, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            orangeColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetPurple1_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x43C, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            purpleColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetPurple2_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x47D, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            purpleColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetYellow1_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x55F, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            yellowColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetYellow2_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x5A0, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            yellowColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetCyan1_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x680, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            cyanColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetCyan2_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x6C1, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            cyanColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetMagenta1_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x7A4, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            magentaColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetMagenta2_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x7E5, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            magentaColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetIndigo1_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x9B9, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            indigoColor1.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }

        private void ResetIndigo2_Click(object sender, EventArgs e)
        {
            Byte[] color = new byte[12];
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x9FA, color, 0, 12);
            double r = BitConverter.ToSingle(color, 0);
            double g = BitConverter.ToSingle(color, 4);
            double b = BitConverter.ToSingle(color, 8);
            indigoColor2.BackColor = Color.FromArgb(DoubleToByte(r), DoubleToByte(g), DoubleToByte(b));
        }


        private void ResetAll_Click(object sender, EventArgs e)
        {
            Byte[] BlueBC = new byte[12];
            Byte[] BlueGC = new byte[12];
            Byte[] GreenBC = new byte[12];
            Byte[] GreenGC = new byte[12];
            Byte[] PurpleBC = new byte[12];
            Byte[] PurpleGC = new byte[12];
            Byte[] YellowBC = new byte[12];
            Byte[] YellowGC = new byte[12];
            Byte[] CyanBC = new byte[12];
            Byte[] CyanGC = new byte[12];
            Byte[] MagentaBC = new byte[12];
            Byte[] MagentaGC = new byte[12];
            Byte[] IndigoBC = new byte[12];
            Byte[] IndigoGC = new byte[12];

            Byte[] OrangeBC = new byte[12];
            Byte[] OrangeGC = new byte[12];

            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x105, BlueBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x146, BlueGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x319, GreenBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x35A, GreenGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x43C, PurpleBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x47D, PurpleGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x55F, YellowBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x5A0, YellowGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x680, CyanBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x6C1, CyanGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x7A4, MagentaBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x7E5, MagentaGC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x9B9, IndigoBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x9FA, IndigoGC, 0, 12);

            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xADC, OrangeBC, 0, 12);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xB1D, OrangeGC, 0, 12);

            double rBlueBC = BitConverter.ToSingle(BlueBC, 0);
            double gBlueBC = BitConverter.ToSingle(BlueBC, 4);
            double bBlueBC = BitConverter.ToSingle(BlueBC, 8);
            double rBlueGC = BitConverter.ToSingle(BlueGC, 0);
            double gBlueGC = BitConverter.ToSingle(BlueGC, 4);
            double bBlueGC = BitConverter.ToSingle(BlueGC, 8);

            double rGreenBC = BitConverter.ToSingle(GreenBC, 0);
            double gGreenBC = BitConverter.ToSingle(GreenBC, 4);
            double bGreenBC = BitConverter.ToSingle(GreenBC, 8);
            double rGreenGC = BitConverter.ToSingle(GreenGC, 0);
            double gGreenGC = BitConverter.ToSingle(GreenGC, 4);
            double bGreenGC = BitConverter.ToSingle(GreenGC, 8);

            double rPurpleBC = BitConverter.ToSingle(PurpleBC, 0);
            double gPurpleBC = BitConverter.ToSingle(PurpleBC, 4);
            double bPurpleBC = BitConverter.ToSingle(PurpleBC, 8);
            double rPurpleGC = BitConverter.ToSingle(PurpleGC, 0);
            double gPurpleGC = BitConverter.ToSingle(PurpleGC, 4);
            double bPurpleGC = BitConverter.ToSingle(PurpleGC, 8);

            double rYellowBC = BitConverter.ToSingle(YellowBC, 0);
            double gYellowBC = BitConverter.ToSingle(YellowBC, 4);
            double bYellowBC = BitConverter.ToSingle(YellowBC, 8);
            double rYellowGC = BitConverter.ToSingle(YellowGC, 0);
            double gYellowGC = BitConverter.ToSingle(YellowGC, 4);
            double bYellowGC = BitConverter.ToSingle(YellowGC, 8);

            double rCyanBC = BitConverter.ToSingle(CyanBC, 0);
            double gCyanBC = BitConverter.ToSingle(CyanBC, 4);
            double bCyanBC = BitConverter.ToSingle(CyanBC, 8);
            double rCyanGC = BitConverter.ToSingle(CyanGC, 0);
            double gCyanGC = BitConverter.ToSingle(CyanGC, 4);
            double bCyanGC = BitConverter.ToSingle(CyanGC, 8);

            double rMagentaBC = BitConverter.ToSingle(MagentaBC, 0);
            double gMagentaBC = BitConverter.ToSingle(MagentaBC, 4);
            double bMagentaBC = BitConverter.ToSingle(MagentaBC, 8);
            double rMagentaGC = BitConverter.ToSingle(MagentaGC, 0);
            double gMagentaGC = BitConverter.ToSingle(MagentaGC, 4);
            double bMagentaGC = BitConverter.ToSingle(MagentaGC, 8);

            double rIndigoBC = BitConverter.ToSingle(IndigoBC, 0);
            double gIndigoBC = BitConverter.ToSingle(IndigoBC, 4);
            double bIndigoBC = BitConverter.ToSingle(IndigoBC, 8);
            double rIndigoGC = BitConverter.ToSingle(IndigoGC, 0);
            double gIndigoGC = BitConverter.ToSingle(IndigoGC, 4);
            double bIndigoGC = BitConverter.ToSingle(IndigoGC, 8);

            double rOrangeBC = BitConverter.ToSingle(OrangeBC, 0);
            double gOrangeBC = BitConverter.ToSingle(OrangeBC, 4);
            double bOrangeBC = BitConverter.ToSingle(OrangeBC, 8);
            double rOrangeGC = BitConverter.ToSingle(OrangeGC, 0);
            double gOrangeGC = BitConverter.ToSingle(OrangeGC, 4);
            double bOrangeGC = BitConverter.ToSingle(OrangeGC, 8);

            blueColor1.BackColor = Color.FromArgb(DoubleToByte(rBlueBC), DoubleToByte(gBlueBC), DoubleToByte(bBlueBC));
            blueColor2.BackColor = Color.FromArgb(DoubleToByte(rBlueGC), DoubleToByte(gBlueGC), DoubleToByte(bBlueGC));

            greenColor1.BackColor = Color.FromArgb(DoubleToByte(rGreenBC), DoubleToByte(gGreenBC), DoubleToByte(bGreenBC));
            greenColor2.BackColor = Color.FromArgb(DoubleToByte(rGreenGC), DoubleToByte(gGreenGC), DoubleToByte(bGreenGC));

            purpleColor1.BackColor = Color.FromArgb(DoubleToByte(rPurpleBC), DoubleToByte(gPurpleBC), DoubleToByte(bPurpleBC));
            purpleColor2.BackColor = Color.FromArgb(DoubleToByte(rPurpleGC), DoubleToByte(gPurpleGC), DoubleToByte(bPurpleGC));

            yellowColor1.BackColor = Color.FromArgb(DoubleToByte(rYellowBC), DoubleToByte(gYellowBC), DoubleToByte(bYellowBC));
            yellowColor2.BackColor = Color.FromArgb(DoubleToByte(rYellowGC), DoubleToByte(gYellowGC), DoubleToByte(bYellowGC));

            cyanColor1.BackColor = Color.FromArgb(DoubleToByte(rCyanBC), DoubleToByte(gCyanBC), DoubleToByte(bCyanBC));
            cyanColor2.BackColor = Color.FromArgb(DoubleToByte(rCyanGC), DoubleToByte(gCyanGC), DoubleToByte(bCyanGC));

            magentaColor1.BackColor = Color.FromArgb(DoubleToByte(rMagentaBC), DoubleToByte(gMagentaBC), DoubleToByte(bMagentaBC));
            magentaColor2.BackColor = Color.FromArgb(DoubleToByte(rMagentaGC), DoubleToByte(gMagentaGC), DoubleToByte(bMagentaGC));

            indigoColor1.BackColor = Color.FromArgb(DoubleToByte(rIndigoBC), DoubleToByte(gIndigoBC), DoubleToByte(bIndigoBC));
            indigoColor2.BackColor = Color.FromArgb(DoubleToByte(rIndigoGC), DoubleToByte(gIndigoGC), DoubleToByte(bIndigoGC));

            orangeColor1.BackColor = Color.FromArgb(DoubleToByte(rOrangeBC), DoubleToByte(gOrangeBC), DoubleToByte(bOrangeBC));
            orangeColor2.BackColor = Color.FromArgb(DoubleToByte(rOrangeGC), DoubleToByte(gOrangeGC), DoubleToByte(bOrangeGC));


            Byte[] BlueSound = new byte[4];
            Byte[] GreenSound = new byte[4];
            Byte[] OrangeSound = new byte[4];
            Byte[] PurpleSound = new byte[4];
            Byte[] YellowSound = new byte[4];
            Byte[] CyanSound = new byte[4];
            Byte[] MagentaSound = new byte[4];
            Byte[] IndigoSound = new byte[4];

            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x16F, BlueSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x383, GreenSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xB46, OrangeSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x4A6, PurpleSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x5C9, YellowSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x6EA, CyanSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x80E, MagentaSound, 0, 4);
            Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0xA23, IndigoSound, 0, 4);

            float BlueSoundID = BitConverter.ToSingle(BlueSound, 0);
            float GreenSoundID = BitConverter.ToSingle(GreenSound, 0);
            float OrangeSoundID = BitConverter.ToSingle(OrangeSound, 0);
            float PurpleSoundID = BitConverter.ToSingle(PurpleSound, 0);
            float YellowSoundID = BitConverter.ToSingle(YellowSound, 0);
            float CyanSoundID = BitConverter.ToSingle(CyanSound, 0);
            float MagentaSoundID = BitConverter.ToSingle(MagentaSound, 0);
            float IndigoSoundID = BitConverter.ToSingle(IndigoSound, 0);

            int BlueSoundIDint = (int)BlueSoundID;
            int GreenSoundIDint = (int)GreenSoundID;
            int OrangeSoundIDint = (int)OrangeSoundID;
            int PurpleSoundIDint = (int)PurpleSoundID;
            int YellowSoundIDint = (int)YellowSoundID;
            int CyanSoundIDint = (int)CyanSoundID;
            int MagentaSoundIDint = (int)MagentaSoundID;
            int IndigoSoundIDint = (int)IndigoSoundID;

            soundfontBlue.SelectedIndex = BlueSoundIDint - 1;
            soundfontGreen.SelectedIndex = GreenSoundIDint - 1;
            soundfontOrange.SelectedIndex = OrangeSoundIDint - 1;
            soundfontPurple.SelectedIndex = PurpleSoundIDint - 1;
            soundfontYellow.SelectedIndex = YellowSoundIDint - 1;
            soundfontCyan.SelectedIndex = CyanSoundIDint - 1;
            soundfontMagenta.SelectedIndex = MagentaSoundIDint - 1;
            soundfontIndigo.SelectedIndex = IndigoSoundIDint - 1;

        }


        //SET COLOR

        private void Blue1color_Click(object sender, EventArgs e)
        {
            colorpicker.Color = blueColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                blueColor1.BackColor = colorpicker.Color;
        }

        private void Blue2color_Click(object sender, EventArgs e)
        {
            colorpicker.Color = blueColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                blueColor2.BackColor = colorpicker.Color;
        }

        private void button2_Click(object sender, EventArgs e) //greencolor1
        {
            colorpicker.Color = greenColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                greenColor1.BackColor = colorpicker.Color;
        }

        private void greenColor2_Click(object sender, EventArgs e) //greencolor2
        {
            colorpicker.Color = greenColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                greenColor2.BackColor = colorpicker.Color;
        }

        private void orangeColor1_Click(object sender, EventArgs e)
        {
            colorpicker.Color = orangeColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                orangeColor1.BackColor = colorpicker.Color;
        }

        private void orangeColor2_Click(object sender, EventArgs e)
        {
            colorpicker.Color = orangeColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                orangeColor2.BackColor = colorpicker.Color;
        }

        private void purpleColor1_Click(object sender, EventArgs e)
        {
            colorpicker.Color = purpleColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                purpleColor1.BackColor = colorpicker.Color;
        }

        private void purpleColor2_Click(object sender, EventArgs e)
        {
            colorpicker.Color = purpleColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                purpleColor2.BackColor = colorpicker.Color;
        }

        private void yellowColor1_Click(object sender, EventArgs e)
        {
            colorpicker.Color = yellowColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                yellowColor1.BackColor = colorpicker.Color;
        }

        private void yellowColor2_Click(object sender, EventArgs e)
        {
            colorpicker.Color = yellowColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                yellowColor2.BackColor = colorpicker.Color;
        }

        private void cyanColor1_Click(object sender, EventArgs e)
        {
            colorpicker.Color = cyanColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                cyanColor1.BackColor = colorpicker.Color;
        }

        private void cyanColor2_Click(object sender, EventArgs e)
        {
            colorpicker.Color = cyanColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                cyanColor2.BackColor = colorpicker.Color;
        }

        private void magentaColor1_Click(object sender, EventArgs e)
        {
            colorpicker.Color = magentaColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                magentaColor1.BackColor = colorpicker.Color;
        }

        private void magentaColor2_Click(object sender, EventArgs e)
        {
            colorpicker.Color = magentaColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                magentaColor2.BackColor = colorpicker.Color;
        }

        private void indigoColor1_Click(object sender, EventArgs e)
        {
            colorpicker.Color = indigoColor1.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                indigoColor1.BackColor = colorpicker.Color;
        }

        private void indigoColor2_Click(object sender, EventArgs e)
        {
            colorpicker.Color = indigoColor2.BackColor;
            if (colorpicker.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                indigoColor2.BackColor = colorpicker.Color;
        }






        // EXPORT TO PAK
        private void ExportToPakButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select your .../Jedi Fallen Order/SwGame/Content/Paks folder";

            //remember path
            if (folderName != "first_extract") folderBrowserDialog1.SelectedPath = folderName;

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;

                Byte[] PakFile = new byte[0xC3B];
                Array.Copy(Properties.Resources.Pakchunk99_Mods_CustomSabercolors_P, 0x0, PakFile, 0, 0xC3B);

                byte[] Color = new byte[12];
                float ToConvert;
                byte[] Converted;
                Byte[] BlueBC = new byte[12];
                Byte[] BlueGC = new byte[12];
                Byte[] GreenBC = new byte[12];
                Byte[] GreenGC = new byte[12];
                Byte[] OrangeBC = new byte[12];
                Byte[] OrangeGC = new byte[12];
                Byte[] PurpleBC = new byte[12];
                Byte[] PurpleGC = new byte[12];
                Byte[] YellowBC = new byte[12];
                Byte[] YellowGC = new byte[12];
                Byte[] CyanBC = new byte[12];
                Byte[] CyanGC = new byte[12];
                Byte[] MagentaBC = new byte[12];
                Byte[] MagentaGC = new byte[12];
                Byte[] IndigoBC = new byte[12];
                Byte[] IndigoGC = new byte[12];

                //get all color values, combine them as float, and copy the array to the master array
                //blue1
                ToConvert = ByteToFloat(blueColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(blueColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(blueColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x105, 12);

                //blue2
                ToConvert = ByteToFloat(blueColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(blueColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(blueColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x146, 12);

                //green1
                ToConvert = ByteToFloat(greenColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(greenColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(greenColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x319, 12);

                //green2
                ToConvert = ByteToFloat(greenColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(greenColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(greenColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x35A, 12);

                //orange1
                ToConvert = ByteToFloat(orangeColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(orangeColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(orangeColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0xADC, 12);

                //orange2
                ToConvert = ByteToFloat(orangeColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(orangeColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(orangeColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0xB1D, 12);

                //purple1
                ToConvert = ByteToFloat(purpleColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(purpleColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(purpleColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x43C, 12);

                //purple2
                ToConvert = ByteToFloat(purpleColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(purpleColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(purpleColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x47D, 12);

                //yellow1
                ToConvert = ByteToFloat(yellowColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(yellowColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(yellowColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x55F, 12);

                //yellow2
                ToConvert = ByteToFloat(yellowColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(yellowColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(yellowColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x5A0, 12);

                //cyan1
                ToConvert = ByteToFloat(cyanColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(cyanColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(cyanColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x680, 12);

                //cyan2
                ToConvert = ByteToFloat(cyanColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(cyanColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(cyanColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x6C1, 12);

                //magenta1
                ToConvert = ByteToFloat(magentaColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(magentaColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(magentaColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x7A4, 12);

                //magenta2
                ToConvert = ByteToFloat(magentaColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(magentaColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(magentaColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x7E5, 12);

                //indigo1
                ToConvert = ByteToFloat(indigoColor1.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(indigoColor1.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(indigoColor1.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x9B9, 12);

                //indigo2
                ToConvert = ByteToFloat(indigoColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 0, 4);
                ToConvert = ByteToFloat(indigoColor2.BackColor.G);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 4, 4);
                ToConvert = ByteToFloat(indigoColor2.BackColor.B);
                Converted = BitConverter.GetBytes(ToConvert);
                Array.Copy(Converted, 0, Color, 8, 4);

                Array.Copy(Color, 0, PakFile, 0x9FA, 12);

                byte[] soundfontID = new byte[4];
                //blue
                if (soundfontBlue.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontBlue.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontBlue.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontBlue.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontBlue.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontBlue.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontBlue.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontBlue.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontBlue.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontBlue.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontBlue.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0x171, 2);
                //green
                if (soundfontGreen.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontGreen.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontGreen.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontGreen.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontGreen.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontGreen.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontGreen.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontGreen.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontGreen.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontGreen.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontGreen.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0x385, 2);
                //orange
                if (soundfontOrange.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontOrange.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontOrange.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontOrange.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontOrange.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontOrange.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontOrange.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontOrange.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontOrange.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontOrange.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontOrange.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0xB48, 2);
                //purple
                if (soundfontPurple.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontPurple.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontPurple.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontPurple.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontPurple.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontPurple.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontPurple.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontPurple.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontPurple.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontPurple.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontPurple.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0x4A8, 2);
                //yellow
                if (soundfontYellow.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontYellow.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontYellow.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontYellow.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontYellow.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontYellow.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontYellow.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontYellow.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontYellow.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontYellow.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontYellow.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0x5CB, 2);
                //cyan
                if (soundfontCyan.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontCyan.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontCyan.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontCyan.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontCyan.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontCyan.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontCyan.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontCyan.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontCyan.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontCyan.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontCyan.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0x6EC, 2);
                //magenta
                if (soundfontMagenta.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontMagenta.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontMagenta.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontMagenta.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontMagenta.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontMagenta.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontMagenta.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontMagenta.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontMagenta.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontMagenta.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontMagenta.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0x810, 2);
                //indigo
                if (soundfontIndigo.SelectedIndex == 0) soundfontID = new byte[2] { 0x80, 0x3F }; //1
                else if (soundfontIndigo.SelectedIndex == 1) soundfontID = new byte[2] { 0x00, 0x40 }; //2
                else if (soundfontIndigo.SelectedIndex == 2) soundfontID = new byte[2] { 0x40, 0x40 }; //3
                else if (soundfontIndigo.SelectedIndex == 3) soundfontID = new byte[2] { 0x80, 0x40 }; //4
                else if (soundfontIndigo.SelectedIndex == 4) soundfontID = new byte[2] { 0xA0, 0x40 }; //5
                else if (soundfontIndigo.SelectedIndex == 5) soundfontID = new byte[2] { 0xC0, 0x40 }; //6
                else if (soundfontIndigo.SelectedIndex == 6) soundfontID = new byte[2] { 0xE0, 0x40 }; //7
                else if (soundfontIndigo.SelectedIndex == 7) soundfontID = new byte[2] { 0x00, 0x41 }; //8
                else if (soundfontIndigo.SelectedIndex == 8) soundfontID = new byte[2] { 0x10, 0x41 }; //9
                else if (soundfontIndigo.SelectedIndex == 9) soundfontID = new byte[2] { 0x20, 0x41 }; //10
                else if (soundfontIndigo.SelectedIndex == 10) soundfontID = new byte[2] { 0x30, 0x41 }; //11
                Array.Copy(soundfontID, 0, PakFile, 0xA25, 2);

                ToConvert = ByteToFloat(indigoColor2.BackColor.R);
                Converted = BitConverter.GetBytes(ToConvert);

                var check = File.Exists(folderName + "/pakchunk0-WindowsNoEditor.pak");
                //Console.WriteLine(folderName + "/pakchunk0-WindowsNoEditor.pak");
                //Console.WriteLine(check);

                if (check == false) InfoBox.Text = "Pakchunk99_CustomSabercolors.pak exported to: " + folderName + Environment.NewLine + Environment.NewLine + "This does not look like your game's Paks folder." + Environment.NewLine + "You will need to manually copy Pakchunk99_CustomSabercolors.pak to your .../Jedi Fallen Order/SwGame/Content/Paks folder.";
                else
                {
                    check = File.Exists(folderName + "/pakchunk99-Mods_BetterGreenSaber_P.pak");
                    var check2 = File.Exists(folderName + "/pakchunk99-Mods_GreenToRedSaber_P.pak");

                    if (check == true) InfoBox.Text = "Custom lightsaber colors exported to the game, but BETTER GREEN LIGHTSABER mod is also installed." + Environment.NewLine + "Please navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete pakchunk99-Mods_BetterGreenSaber_P.pak to ensure your custom colors are working." + Environment.NewLine + Environment.NewLine + "To uninstall your custom colors, navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete Pakchunk99_CustomSabercolors.pak";
                    if (check2 == true) InfoBox.Text = "Custom lightsaber colors exported to the game, but GREEN TO RED LIGHTSABER mod is also installed." + Environment.NewLine + "Please navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete pakchunk99-Mods_GreenToRedSaber_P.pak to ensure your custom colors are working." + Environment.NewLine + Environment.NewLine + "To uninstall your custom colors, navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete Pakchunk99_CustomSabercolors.pak";
                    if (check == false & check2 == false) InfoBox.Text = "Custom lightsaber colors exported to the game!" + Environment.NewLine + Environment.NewLine + "To uninstall, navigate to /Jedi Fallen Order/SwGame/Content/Paks and delete Pakchunk99_CustomSabercolors.pak";
                }
                File.WriteAllBytes(folderName + "/Pakchunk99_CustomSabercolors.pak", PakFile);
            }
        }

        private void ExportToPak_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ExportTest_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog2 = new FolderBrowserDialog();
            folderBrowserDialog2.Description = "Select the location of the Pakchunk99_CustomSabercolors.pak file to import.";

            if (folderName != "first_extract") folderBrowserDialog2.SelectedPath = folderName;

            DialogResult result = folderBrowserDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog2.SelectedPath;
                var check = File.Exists(folderName + "/Pakchunk99_CustomSabercolors.pak");
                if (check == false) InfoBox.Text = "Pakchunk99_CustomSabercolors.pak not found. Please check the destination folder.";
                else
                {
                    byte[] New_File = File.ReadAllBytes(folderName + "/Pakchunk99_CustomSabercolors.pak");
                    if (New_File.Length != 0xC3B) InfoBox.Text = "Pakchunk99_CustomSabercolors.pak found but is invalid. Please export a new file.";
                    else
                    {
                        Byte[] BlueBC = new byte[12];
                        Byte[] BlueGC = new byte[12];
                        Byte[] GreenBC = new byte[12];
                        Byte[] GreenGC = new byte[12];
                        Byte[] PurpleBC = new byte[12];
                        Byte[] PurpleGC = new byte[12];
                        Byte[] YellowBC = new byte[12];
                        Byte[] YellowGC = new byte[12];
                        Byte[] CyanBC = new byte[12];
                        Byte[] CyanGC = new byte[12];
                        Byte[] MagentaBC = new byte[12];
                        Byte[] MagentaGC = new byte[12];
                        Byte[] IndigoBC = new byte[12];
                        Byte[] IndigoGC = new byte[12];

                        Byte[] OrangeBC = new byte[12];
                        Byte[] OrangeGC = new byte[12];

                        Array.Copy(New_File, 0x105, BlueBC, 0, 12);
                        Array.Copy(New_File, 0x146, BlueGC, 0, 12);
                        Array.Copy(New_File, 0x319, GreenBC, 0, 12);
                        Array.Copy(New_File, 0x35A, GreenGC, 0, 12);
                        Array.Copy(New_File, 0x43C, PurpleBC, 0, 12);
                        Array.Copy(New_File, 0x47D, PurpleGC, 0, 12);
                        Array.Copy(New_File, 0x55F, YellowBC, 0, 12);
                        Array.Copy(New_File, 0x5A0, YellowGC, 0, 12);
                        Array.Copy(New_File, 0x680, CyanBC, 0, 12);
                        Array.Copy(New_File, 0x6C1, CyanGC, 0, 12);
                        Array.Copy(New_File, 0x7A4, MagentaBC, 0, 12);
                        Array.Copy(New_File, 0x7E5, MagentaGC, 0, 12);
                        Array.Copy(New_File, 0x9B9, IndigoBC, 0, 12);
                        Array.Copy(New_File, 0x9FA, IndigoGC, 0, 12);

                        Array.Copy(New_File, 0xADC, OrangeBC, 0, 12);
                        Array.Copy(New_File, 0xB1D, OrangeGC, 0, 12);

                        double rBlueBC = BitConverter.ToSingle(BlueBC, 0);
                        double gBlueBC = BitConverter.ToSingle(BlueBC, 4);
                        double bBlueBC = BitConverter.ToSingle(BlueBC, 8);
                        double rBlueGC = BitConverter.ToSingle(BlueGC, 0);
                        double gBlueGC = BitConverter.ToSingle(BlueGC, 4);
                        double bBlueGC = BitConverter.ToSingle(BlueGC, 8);

                        double rGreenBC = BitConverter.ToSingle(GreenBC, 0);
                        double gGreenBC = BitConverter.ToSingle(GreenBC, 4);
                        double bGreenBC = BitConverter.ToSingle(GreenBC, 8);
                        double rGreenGC = BitConverter.ToSingle(GreenGC, 0);
                        double gGreenGC = BitConverter.ToSingle(GreenGC, 4);
                        double bGreenGC = BitConverter.ToSingle(GreenGC, 8);

                        double rPurpleBC = BitConverter.ToSingle(PurpleBC, 0);
                        double gPurpleBC = BitConverter.ToSingle(PurpleBC, 4);
                        double bPurpleBC = BitConverter.ToSingle(PurpleBC, 8);
                        double rPurpleGC = BitConverter.ToSingle(PurpleGC, 0);
                        double gPurpleGC = BitConverter.ToSingle(PurpleGC, 4);
                        double bPurpleGC = BitConverter.ToSingle(PurpleGC, 8);

                        double rYellowBC = BitConverter.ToSingle(YellowBC, 0);
                        double gYellowBC = BitConverter.ToSingle(YellowBC, 4);
                        double bYellowBC = BitConverter.ToSingle(YellowBC, 8);
                        double rYellowGC = BitConverter.ToSingle(YellowGC, 0);
                        double gYellowGC = BitConverter.ToSingle(YellowGC, 4);
                        double bYellowGC = BitConverter.ToSingle(YellowGC, 8);

                        double rCyanBC = BitConverter.ToSingle(CyanBC, 0);
                        double gCyanBC = BitConverter.ToSingle(CyanBC, 4);
                        double bCyanBC = BitConverter.ToSingle(CyanBC, 8);
                        double rCyanGC = BitConverter.ToSingle(CyanGC, 0);
                        double gCyanGC = BitConverter.ToSingle(CyanGC, 4);
                        double bCyanGC = BitConverter.ToSingle(CyanGC, 8);

                        double rMagentaBC = BitConverter.ToSingle(MagentaBC, 0);
                        double gMagentaBC = BitConverter.ToSingle(MagentaBC, 4);
                        double bMagentaBC = BitConverter.ToSingle(MagentaBC, 8);
                        double rMagentaGC = BitConverter.ToSingle(MagentaGC, 0);
                        double gMagentaGC = BitConverter.ToSingle(MagentaGC, 4);
                        double bMagentaGC = BitConverter.ToSingle(MagentaGC, 8);

                        double rIndigoBC = BitConverter.ToSingle(IndigoBC, 0);
                        double gIndigoBC = BitConverter.ToSingle(IndigoBC, 4);
                        double bIndigoBC = BitConverter.ToSingle(IndigoBC, 8);
                        double rIndigoGC = BitConverter.ToSingle(IndigoGC, 0);
                        double gIndigoGC = BitConverter.ToSingle(IndigoGC, 4);
                        double bIndigoGC = BitConverter.ToSingle(IndigoGC, 8);

                        double rOrangeBC = BitConverter.ToSingle(OrangeBC, 0);
                        double gOrangeBC = BitConverter.ToSingle(OrangeBC, 4);
                        double bOrangeBC = BitConverter.ToSingle(OrangeBC, 8);
                        double rOrangeGC = BitConverter.ToSingle(OrangeGC, 0);
                        double gOrangeGC = BitConverter.ToSingle(OrangeGC, 4);
                        double bOrangeGC = BitConverter.ToSingle(OrangeGC, 8);

                        blueColor1.BackColor = Color.FromArgb(DoubleToByte(rBlueBC), DoubleToByte(gBlueBC), DoubleToByte(bBlueBC));
                        blueColor2.BackColor = Color.FromArgb(DoubleToByte(rBlueGC), DoubleToByte(gBlueGC), DoubleToByte(bBlueGC));

                        greenColor1.BackColor = Color.FromArgb(DoubleToByte(rGreenBC), DoubleToByte(gGreenBC), DoubleToByte(bGreenBC));
                        greenColor2.BackColor = Color.FromArgb(DoubleToByte(rGreenGC), DoubleToByte(gGreenGC), DoubleToByte(bGreenGC));

                        purpleColor1.BackColor = Color.FromArgb(DoubleToByte(rPurpleBC), DoubleToByte(gPurpleBC), DoubleToByte(bPurpleBC));
                        purpleColor2.BackColor = Color.FromArgb(DoubleToByte(rPurpleGC), DoubleToByte(gPurpleGC), DoubleToByte(bPurpleGC));

                        yellowColor1.BackColor = Color.FromArgb(DoubleToByte(rYellowBC), DoubleToByte(gYellowBC), DoubleToByte(bYellowBC));
                        yellowColor2.BackColor = Color.FromArgb(DoubleToByte(rYellowGC), DoubleToByte(gYellowGC), DoubleToByte(bYellowGC));

                        cyanColor1.BackColor = Color.FromArgb(DoubleToByte(rCyanBC), DoubleToByte(gCyanBC), DoubleToByte(bCyanBC));
                        cyanColor2.BackColor = Color.FromArgb(DoubleToByte(rCyanGC), DoubleToByte(gCyanGC), DoubleToByte(bCyanGC));

                        magentaColor1.BackColor = Color.FromArgb(DoubleToByte(rMagentaBC), DoubleToByte(gMagentaBC), DoubleToByte(bMagentaBC));
                        magentaColor2.BackColor = Color.FromArgb(DoubleToByte(rMagentaGC), DoubleToByte(gMagentaGC), DoubleToByte(bMagentaGC));

                        indigoColor1.BackColor = Color.FromArgb(DoubleToByte(rIndigoBC), DoubleToByte(gIndigoBC), DoubleToByte(bIndigoBC));
                        indigoColor2.BackColor = Color.FromArgb(DoubleToByte(rIndigoGC), DoubleToByte(gIndigoGC), DoubleToByte(bIndigoGC));

                        orangeColor1.BackColor = Color.FromArgb(DoubleToByte(rOrangeBC), DoubleToByte(gOrangeBC), DoubleToByte(bOrangeBC));
                        orangeColor2.BackColor = Color.FromArgb(DoubleToByte(rOrangeGC), DoubleToByte(gOrangeGC), DoubleToByte(bOrangeGC));


                        Byte[] BlueSound = new byte[4];
                        Byte[] GreenSound = new byte[4];
                        Byte[] OrangeSound = new byte[4];
                        Byte[] PurpleSound = new byte[4];
                        Byte[] YellowSound = new byte[4];
                        Byte[] CyanSound = new byte[4];
                        Byte[] MagentaSound = new byte[4];
                        Byte[] IndigoSound = new byte[4];

                        Array.Copy(New_File, 0x16F, BlueSound, 0, 4);
                        Array.Copy(New_File, 0x383, GreenSound, 0, 4);
                        Array.Copy(New_File, 0xB46, OrangeSound, 0, 4);
                        Array.Copy(New_File, 0x4A6, PurpleSound, 0, 4);
                        Array.Copy(New_File, 0x5C9, YellowSound, 0, 4);
                        Array.Copy(New_File, 0x6EA, CyanSound, 0, 4);
                        Array.Copy(New_File, 0x80E, MagentaSound, 0, 4);
                        Array.Copy(New_File, 0xA23, IndigoSound, 0, 4);

                        float BlueSoundID = BitConverter.ToSingle(BlueSound, 0);
                        float GreenSoundID = BitConverter.ToSingle(GreenSound, 0);
                        float OrangeSoundID = BitConverter.ToSingle(OrangeSound, 0);
                        float PurpleSoundID = BitConverter.ToSingle(PurpleSound, 0);
                        float YellowSoundID = BitConverter.ToSingle(YellowSound, 0);
                        float CyanSoundID = BitConverter.ToSingle(CyanSound, 0);
                        float MagentaSoundID = BitConverter.ToSingle(MagentaSound, 0);
                        float IndigoSoundID = BitConverter.ToSingle(IndigoSound, 0);

                        int BlueSoundIDint = (int)BlueSoundID;
                        int GreenSoundIDint = (int)GreenSoundID;
                        int OrangeSoundIDint = (int)OrangeSoundID;
                        int PurpleSoundIDint = (int)PurpleSoundID;
                        int YellowSoundIDint = (int)YellowSoundID;
                        int CyanSoundIDint = (int)CyanSoundID;
                        int MagentaSoundIDint = (int)MagentaSoundID;
                        int IndigoSoundIDint = (int)IndigoSoundID;

                        soundfontBlue.SelectedIndex = BlueSoundIDint - 1;
                        soundfontGreen.SelectedIndex = GreenSoundIDint - 1;
                        soundfontOrange.SelectedIndex = OrangeSoundIDint - 1;
                        soundfontPurple.SelectedIndex = PurpleSoundIDint - 1;
                        soundfontYellow.SelectedIndex = YellowSoundIDint - 1;
                        soundfontCyan.SelectedIndex = CyanSoundIDint - 1;
                        soundfontMagenta.SelectedIndex = MagentaSoundIDint - 1;
                        soundfontIndigo.SelectedIndex = IndigoSoundIDint - 1;

                        InfoBox.Text = "Valid Pakchunk99_CustomSabercolors.pak found and imported.";

                    }
                }
            }
        }
    }
}
