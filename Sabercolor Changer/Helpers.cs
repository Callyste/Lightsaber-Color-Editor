using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabercolor_Changer
{
    public static class Helpers
    {
        public static byte FloatToByte(float value)
        {
            return (byte)(value * 255);
        }

        public static float ByteToFloat(byte value)
        {
            return value / 255f;
        }

        public static Color ReadColor(byte[] array, int offset)
        {
            byte r = ReadColorByte(array, offset);
            byte g = ReadColorByte(array, offset + 4);
            byte b = ReadColorByte(array, offset + 8);
            return Color.FromArgb(r, g, b);
        }

        public static byte ReadColorByte(byte[] array, int offset)
        {
            return FloatToByte(BitConverter.ToSingle(array, offset));
        }

        public static SoundFont ReadSoundFont(byte[] array, int offset)
        {
            int id = (int)BitConverter.ToSingle(array, offset);
            return SoundFont.soundFonts.First(x => x.ID == id);
        }

        public static void WriteColor(byte[] array, int offset, Color color)
        {
            WriteColorByte(array, offset,     ByteToFloat(color.R));
            WriteColorByte(array, offset + 4, ByteToFloat(color.G));
            WriteColorByte(array, offset + 8, ByteToFloat(color.B));
        }

        public static void WriteColorByte(byte[] array, int offset, float color)
        {
            Array.Copy(BitConverter.GetBytes(color), 0, array, offset, 4);
        }

        public static void WriteSoundFont(byte[] array, int offset, SoundFont soundFont)
        {
            Array.Copy(BitConverter.GetBytes((float)soundFont.ID), 0, array, offset, 4);
        }
    }
}
