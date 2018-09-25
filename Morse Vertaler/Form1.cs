using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Vertaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private string TConvert(string tekst)//Methode die tekst omzet naar morse code.
        {
            string Out = "";
            tekst = tekst.ToUpper();
            foreach (char c in tekst) 
            {
                if (c == 'A') { Out = Out + @"._,"; }
                if (c == 'B') { Out = Out + @"_...,"; }
                if (c == 'C') { Out = Out + @"_._.,"; }
                if (c == 'D') { Out = Out + @"_..,"; }
                if (c == 'E') { Out = Out + @".,"; }
                if (c == 'F') { Out = Out + @".._.,"; }
                if (c == 'G') { Out = Out + @"__.,"; }
                if (c == 'H') { Out = Out + @"....,"; }
                if (c == 'I') { Out = Out + @"..,"; }
                if (c == 'J') { Out = Out + @".___,"; }
                if (c == 'K') { Out = Out + @"_._,"; }
                if (c == 'L') { Out = Out + @"._..,"; }
                if (c == 'M') { Out = Out + @"__,"; }
                if (c == 'N') { Out = Out + @"_.,"; }
                if (c == 'O') { Out = Out + @"___,"; }
                if (c == 'P') { Out = Out + @".__.,"; }
                if (c == 'Q') { Out = Out + @"__._,"; }
                if (c == 'R') { Out = Out + @"._.,"; }
                if (c == 'S') { Out = Out + @"...,"; }
                if (c == 'T') { Out = Out + @"_,"; }
                if (c == 'U') { Out = Out + @".._,"; }
                if (c == 'V') { Out = Out + @"..._,"; }
                if (c == 'W') { Out = Out + @".__,"; }
                if (c == 'X') { Out = Out + @"_.._,"; }
                if (c == 'Y') { Out = Out + @"_.__,"; }
                if (c == 'Z') { Out = Out + @"__..,"; }
                if (c == '1') { Out = Out + @".____,"; }
                if (c == '2') { Out = Out + @"..___,"; }
                if (c == '3') { Out = Out + @"...__,"; }
                if (c == '4') { Out = Out + @"...._,"; }
                if (c == '5') { Out = Out + @".....,"; }
                if (c == '6') { Out = Out + @"_....,"; }
                if (c == '7') { Out = Out + @"__...,"; }
                if (c == '8') { Out = Out + @"___..,"; }
                if (c == '9') { Out = Out + @"____.,"; }
                if (c == '0') { Out = Out + @"_____,"; }
                if (c == ' ') { Out = Out + @" ,"; }
            }//We kijken per letter of cijfer welke lettere het is en voegen die toe aan de Out string die we net hebben gemaakt dit zou ook met een array kunnen maar ik probeer zo weinig mogelijk op te zoeken
            return Out;
        }

        private string MConvert(string morse)
        {
            string Out = "";
            string[] tekst = morse.Split(',');
            foreach (string c in tekst)
            {
                if (c == @"._") { Out = Out + 'a'; }
                if (c == @"_...") { Out = Out + 'b'; }
                if (c == @"_._.") { Out = Out + 'c'; }
                if (c == @"_..") { Out = Out + 'd'; }
                if (c == @".") { Out = Out + 'e'; }
                if (c == @".._.") { Out = Out + 'f'; }
                if (c == @"__.") { Out = Out + 'g'; }
                if (c == @"....") { Out = Out + 'h'; }
                if (c == @"..") { Out = Out + 'i'; }
                if (c == @".___") { Out = Out + 'j'; }
                if (c == @"_._") { Out = Out + 'k'; }
                if (c == @"._..") { Out = Out + 'l'; }
                if (c == @"__") { Out = Out + 'm'; }
                if (c == @"_.") { Out = Out + 'n'; }
                if (c == @"___") { Out = Out + 'o'; }
                if (c == @".__.") { Out = Out + 'p'; }
                if (c == @"__._") { Out = Out + 'q'; }
                if (c == @"._.") { Out = Out + 'r'; }
                if (c == @"...") { Out = Out + 's'; }
                if (c == @"_") { Out = Out + 't'; }
                if (c == @".._") { Out = Out + 'u'; }
                if (c == @"..._") { Out = Out + 'v'; }
                if (c == @".__") { Out = Out + 'w'; }
                if (c == @"_.._") { Out = Out + 'x'; }
                if (c == @"_.__") { Out = Out + 'y'; }
                if (c == @"__..") { Out = Out + 'z'; }
                if (c == @".____") { Out = Out + '1'; }
                if (c == @"..___") { Out = Out + '2'; }
                if (c == @"...__") { Out = Out + '3'; }
                if (c == @"...._") { Out = Out + '4'; }
                if (c == @".....") { Out = Out + '5'; }
                if (c == @"_....") { Out = Out + '6'; }
                if (c == @"__...") { Out = Out + '7'; }
                if (c == @"___..") { Out = Out + '8'; }
                if (c == @"____.") { Out = Out + '9'; }
                if (c == @"_____") { Out = Out + '0'; }
                if (c == " ") { Out = Out + ' '; }
            }//We kijken per code welke letter het is en voegen die toe aan de Out string die we net hebben gemaakt.
            return Out;
        }//Methode die Morse omzet naar Tekst


        private void button2_Click(object sender, EventArgs e)
        {
            rtbIO.Text = TConvert(rtbIO.Text);//Verwijzing naar de vertaal methode
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbIO.Text = MConvert(rtbIO.Text);//Verwijzing naar de vertaal methode
        }
    }
}
