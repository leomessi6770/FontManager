using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpFont;
using SharpFont.PostScript;
using SharpFont.TrueType;
using SharpFont.Fnt;
using SharpFont.Bdf;
using SharpFont.Cache;
using SharpFont.Bdf;
using System.Runtime.InteropServices;

namespace FontMananger
{
    public partial class Form1 : Form
    {
        private Face face;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        [DllImport("TestLib.dll")]
        public static extern int GetValue();

        [DllImport("TestLib.dll")]
        public static extern string GetSong();

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(GetValue());
            //string song = GetSong();
            //Console.WriteLine(song);

            //Library lib = new Library();
            // face = new Face(lib, @"C:/Windows/Fonts/Arial.ttf");

            //uint count = face.GetSfntNameCount();
            //for (uint i = 0; i < count; i++)
            //{
            //    try
            //    {
            //        SfntName sfnt = face.GetSfntName(2);
            //        Console.WriteLine(Convert.ChangeType(sfnt.PlatformId, sfnt.PlatformId.GetTypeCode()));
            //        Console.WriteLine(sfnt.LanguageId);
            //        Console.WriteLine(sfnt.EncodingId);
            //        Console.WriteLine(sfnt.NameId);
            //        Console.WriteLine(sfnt.String);
            //    }
            //    catch (AccessViolationException ex)
            //    {

            //    }
            //}

        }
    }
}
