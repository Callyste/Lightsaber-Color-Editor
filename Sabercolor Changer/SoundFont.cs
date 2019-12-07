using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabercolor_Changer
{
    public class SoundFont
    {
        public static readonly List<SoundFont> soundFonts = new List<SoundFont>
        {
            new SoundFont(1,    "Blue" ),
            new SoundFont(2,    "Cyan" ),
            new SoundFont(3,    "Green" ),
            new SoundFont(4,    "Indigo" ),
            new SoundFont(5,    "Magenta" ),
            new SoundFont(6,    "Orange" ),
            new SoundFont(7,    "Orange-red" ),
            new SoundFont(8,    "Purple" ),
            new SoundFont(9,    "Red" ),
            new SoundFont(10,   "Malicos" ),
            new SoundFont(11,   "Yellow" )
        };

        public int ID { get; set; }
        public string Name { get; set; }

        public SoundFont(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
