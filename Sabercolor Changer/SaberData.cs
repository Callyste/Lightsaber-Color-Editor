using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sabercolor_Changer.Helpers;

namespace Sabercolor_Changer
{
    public class SaberData
    {
        public int OffsetBlade { get; set; }
        public int OffsetGlow { get; set; }
        public int OffsetSoundFont { get; set; }

        public Button ButtonBladeColor { get; set; }
        public Button ButtonGlowColor { get; set; }
        public ComboBox ComboBoxSoundFont { get; set; }

        private Color ColorBlade {
            get => ButtonBladeColor.BackColor;
            set => ButtonBladeColor.BackColor = value;
        }

        private Color ColorGlow {
            get => ButtonGlowColor.BackColor;
            set => ButtonGlowColor.BackColor = value;
        }

        private SoundFont SoundFont {
            get => (SoundFont)ComboBoxSoundFont.SelectedItem;
            set => ComboBoxSoundFont.SelectedItem = value;
        }

        public SaberData(int offsetBlade, int offsetGlow, int offsetSound, 
            Button buttonBladeColor, Button buttonGlowColor, ComboBox comboBoxSoundFont,
            Button buttonResetBladeColor, Button buttonResetGlowColor)
        {
            OffsetBlade = offsetBlade;
            OffsetGlow = offsetGlow;
            OffsetSoundFont = offsetSound;

            ButtonBladeColor = buttonBladeColor;
            ButtonGlowColor = buttonGlowColor;
            ComboBoxSoundFont = comboBoxSoundFont;

            buttonBladeColor.Tag = this;
            buttonGlowColor.Tag = this;

            buttonResetBladeColor.Tag = this;
            buttonResetGlowColor.Tag = this;

            comboBoxSoundFont.BindingContext = new BindingContext();
            comboBoxSoundFont.DataSource = SoundFont.soundFonts;
            comboBoxSoundFont.DisplayMember = "Name";
            comboBoxSoundFont.ValueMember = "ID";
        }

        public void LoadAll(byte[] array) {
            LoadBladeColor(array);
            LoadGlowColor(array);
            SoundFont = ReadSoundFont(array, OffsetSoundFont);
        }

        public void LoadBladeColor(byte[] array)
        {
            ColorBlade = ReadColor(array, OffsetBlade);
        }

        public void LoadGlowColor(byte[] array)
        {
            ColorGlow = ReadColor(array, OffsetGlow);
        }

        public void Save(byte[] array)
        {
            WriteColor(array, OffsetBlade, ColorBlade);
            WriteColor(array, OffsetGlow, ColorGlow);
            WriteSoundFont(array, OffsetSoundFont, SoundFont);
        }
    }
}
