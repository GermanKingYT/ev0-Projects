using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace ev0SetallFN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("skins.ini"))
            {
                MessageBox.Show("skins.ini was Found!");
            }
            else
            {
                MessageBox.Show("skins.ini was NOT Found!\r\n\r\nMake sure that you put the Programm in the same Folder as the skins.ini");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parserWear = new FileIniDataParser();
            var Wear = parserWear.ReadFile("skins.ini");

            Wear["1"]["SkinWear"] = "0.000001";
            Wear["2"]["SkinWear"] = "0.000001";
            Wear["3"]["SkinWear"] = "0.000001";
            Wear["4"]["SkinWear"] = "0.000001";
            Wear["7"]["SkinWear"] = "0.000001";
            Wear["8"]["SkinWear"] = "0.000001";
            Wear["9"]["SkinWear"] = "0.000001";
            Wear["10"]["SkinWear"] = "0.000001";
            Wear["11"]["SkinWear"] = "0.000001";
            Wear["13"]["SkinWear"] = "0.000001";
            Wear["14"]["SkinWear"] = "0.000001";
            Wear["16"]["SkinWear"] = "0.000001";
            Wear["17"]["SkinWear"] = "0.000001";
            Wear["19"]["SkinWear"] = "0.000001";
            Wear["24"]["SkinWear"] = "0.000001";
            Wear["25"]["SkinWear"] = "0.000001";
            Wear["26"]["SkinWear"] = "0.000001";
            Wear["27"]["SkinWear"] = "0.000001";
            Wear["28"]["SkinWear"] = "0.000001";
            Wear["29"]["SkinWear"] = "0.000001";
            Wear["30"]["SkinWear"] = "0.000001";
            Wear["32"]["SkinWear"] = "0.000001";
            Wear["33"]["SkinWear"] = "0.000001";
            Wear["34"]["SkinWear"] = "0.000001";
            Wear["35"]["SkinWear"] = "0.000001";
            Wear["36"]["SkinWear"] = "0.000001";
            Wear["38"]["SkinWear"] = "0.000001";
            Wear["39"]["SkinWear"] = "0.000001";
            Wear["40"]["SkinWear"] = "0.000001";
            Wear["60"]["SkinWear"] = "0.000001";
            Wear["61"]["SkinWear"] = "0.000001";
            Wear["63"]["SkinWear"] = "0.000001";
            Wear["64"]["SkinWear"] = "0.000001";
            Wear["500"]["SkinWear"] = "0.000001";
            Wear["506"]["SkinWear"] = "0.000001";
            Wear["507"]["SkinWear"] = "0.000001";
            Wear["508"]["SkinWear"] = "0.000001";
            Wear["509"]["SkinWear"] = "0.000001";
            Wear["512"]["SkinWear"] = "0.000001";
            Wear["514"]["SkinWear"] = "0.000001";
            Wear["515"]["SkinWear"] = "0.000001";
            Wear["516"]["SkinWear"] = "0.000001";

            parserWear.WriteFile("skins.ini", Wear);
            MessageBox.Show("Finished!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parserSeed = new FileIniDataParser();
            var Seed = parserSeed.ReadFile("skins.ini");

            Seed["1"]["SkinSeed"] = "0";
            Seed["2"]["SkinSeed"] = "0";
            Seed["3"]["SkinSeed"] = "0";
            Seed["4"]["SkinSeed"] = "0";
            Seed["7"]["SkinSeed"] = "0";
            Seed["8"]["SkinSeed"] = "0";
            Seed["9"]["SkinSeed"] = "0";
            Seed["10"]["SkinSeed"] = "0";
            Seed["11"]["SkinSeed"] = "0";
            Seed["13"]["SkinSeed"] = "0";
            Seed["14"]["SkinSeed"] = "0";
            Seed["16"]["SkinSeed"] = "0";
            Seed["17"]["SkinSeed"] = "0";
            Seed["19"]["SkinSeed"] = "0";
            Seed["24"]["SkinSeed"] = "0";
            Seed["25"]["SkinSeed"] = "0";
            Seed["26"]["SkinSeed"] = "0";
            Seed["27"]["SkinSeed"] = "0";
            Seed["28"]["SkinSeed"] = "0";
            Seed["29"]["SkinSeed"] = "0";
            Seed["30"]["SkinSeed"] = "0";
            Seed["32"]["SkinSeed"] = "0";
            Seed["33"]["SkinSeed"] = "0";
            Seed["34"]["SkinSeed"] = "0";
            Seed["35"]["SkinSeed"] = "0";
            Seed["36"]["SkinSeed"] = "0";
            Seed["38"]["SkinSeed"] = "0";
            Seed["39"]["SkinSeed"] = "0";
            Seed["40"]["SkinSeed"] = "0";
            Seed["60"]["SkinSeed"] = "0";
            Seed["61"]["SkinSeed"] = "0";
            Seed["63"]["SkinSeed"] = "0";
            Seed["64"]["SkinSeed"] = "0";
            Seed["500"]["SkinSeed"] = "0";
            Seed["506"]["SkinSeed"] = "0";
            Seed["507"]["SkinSeed"] = "0";
            Seed["508"]["SkinSeed"] = "0";
            Seed["509"]["SkinSeed"] = "0";
            Seed["512"]["SkinSeed"] = "0";
            Seed["514"]["SkinSeed"] = "0";
            Seed["515"]["SkinSeed"] = "0";
            Seed["516"]["SkinSeed"] = "0";

            parserSeed.WriteFile("skins.ini", Seed);
            MessageBox.Show("Finished!");
        }
    }
}
