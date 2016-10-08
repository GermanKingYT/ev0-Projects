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
using System.Windows.Forms.VisualStyles;
using MetroFramework;
using IniParser.Model;
using IniParser;

namespace SkinEditor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileIniDataParser fileIniData = new FileIniDataParser();

            IniData parsedData = fileIniData.ReadFile("skins.ini");

            SkinsTextbox.Text = parsedData.ToString();
        }

        //Chose Weapon Combobox [NOT COMPLETE]
        private void choseweaponcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AWP
            if (choseweaponcombobox.SelectedItem.Equals("AWP"))
            {
                //Activate AWP Skin Checkbox
                awpselectskincheckbox.Visible = true;
                awpselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                awpselectskincheckbox.Visible = false;
                awpselectskincheckbox.Enabled = false;
            }
            //AK47
            if (choseweaponcombobox.SelectedItem.Equals("AK47"))
            {
                //Activate AK47 Skin Checkbox
                ak47skinselectioncombobox.Visible = true;
                ak47skinselectioncombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                ak47skinselectioncombobox.Visible = false;
                ak47skinselectioncombobox.Enabled = false;
            }
            //AUG
            if (choseweaponcombobox.SelectedItem.Equals("AUG"))
            {
                //Activate AUG Skin Checkbox
                augskinselectioncheckbox.Visible = true;
                augskinselectioncheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                augskinselectioncheckbox.Visible = false;
                augskinselectioncheckbox.Enabled = false;
            }
            //BIZON
            if (choseweaponcombobox.SelectedItem.Equals("BIZON"))
            {
                //Activate BIZON Skin Checkbox
                bizonskinselectcheckbox.Visible = true;
                bizonskinselectcheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                bizonskinselectcheckbox.Visible = false;
                bizonskinselectcheckbox.Enabled = false;
            }
            //CZ75A
            if (choseweaponcombobox.SelectedItem.Equals("CZ75A"))
            {
                //Activate CZ75A Skin Checkbox
                czselectskincheckbox.Visible = true;
                czselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                czselectskincheckbox.Visible = false;
                czselectskincheckbox.Enabled = false;
            }
            //DEAGLE
            if (choseweaponcombobox.SelectedItem.Equals("DEAGLE"))
            {
                //Active DEAGLE Skin Checkbox
                deagleselectskincheckbox.Visible = true;
                deagleselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                deagleselectskincheckbox.Visible = false;
                deagleselectskincheckbox.Enabled = false;
            }
            //SHADOW DAGGERS
            if (choseweaponcombobox.SelectedItem.Equals("SHADOW DAGGERS"))
            {
                //Active SHADOW DAGGERS Skin Checkbox
                shadowdaggersselectskincheckbox.Visible = true;
                shadowdaggersselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                shadowdaggersselectskincheckbox.Visible = false;
                shadowdaggersselectskincheckbox.Enabled = false;
            }
            //KARAMBIT
            if (choseweaponcombobox.SelectedItem.Equals("KARAMBIT"))
            {
                karambitselectskincheckbox.Visible = true;
                karambitselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                karambitselectskincheckbox.Visible = false;
                karambitselectskincheckbox.Enabled = false;
            }
            //BAYONET
            if (choseweaponcombobox.SelectedItem.Equals("BAYONET"))
            {
                bayonetselectskincheckbox.Visible = true;
                bayonetselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                bayonetselectskincheckbox.Visible = false;
                bayonetselectskincheckbox.Enabled = false;
            }
            //BOWIE
            if (choseweaponcombobox.SelectedItem.Equals("BOWIE"))
            {
                bowieselectskincheckbox.Visible = true;
                bowieselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                bowieselectskincheckbox.Visible = false;
                bowieselectskincheckbox.Enabled = false;
            }
            //BUTTERFLY
            if (choseweaponcombobox.SelectedItem.Equals("BUTTERFLY"))
            {
                butterflyselectskincheckbox.Visible = true;
                butterflyselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                butterflyselectskincheckbox.Visible = false;
                butterflyselectskincheckbox.Enabled = false;
            }
            //DUAL BERETTAS
            if (choseweaponcombobox.SelectedItem.Equals("DUAL BERETTAS"))
            {
                dualberettasselectskincheckbox.Visible = true;
                dualberettasselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                dualberettasselectskincheckbox.Visible = false;
                dualberettasselectskincheckbox.Enabled = false;
            }
            //FALCHION
            if (choseweaponcombobox.SelectedItem.Equals("FALCHION"))
            {
                falchionselectskincheckbox.Visible = true;
                falchionselectskincheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                falchionselectskincheckbox.Visible = false;
                falchionselectskincheckbox.Enabled = false;
            }

            //FAMAS
            if (choseweaponcombobox.SelectedItem.Equals("FAMAS"))
            {
                famasselectskincombobox.Visible = true;
                famasselectskincombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                famasselectskincombobox.Visible = false;
                famasselectskincombobox.Enabled = false;
            }

            //FIVESEVEN
            if (choseweaponcombobox.SelectedItem.Equals("FIVESEVEN"))
            {
                selectskinfivesevencheckbox.Visible = true;
                selectskinfivesevencheckbox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinfivesevencheckbox.Visible = false;
                selectskinfivesevencheckbox.Enabled = false;
            }
            //FLIP
            if (choseweaponcombobox.SelectedItem.Equals("FLIP"))
            {
                selectskinflipcombobox.Visible = true;
                selectskinflipcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinflipcombobox.Visible = false;
                selectskinflipcombobox.Enabled = false;
            }
            //G3SG1
            if (choseweaponcombobox.SelectedItem.Equals("G3SG1"))
            {
                selectsking3sg1combobox.Visible = true;
                selectsking3sg1combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectsking3sg1combobox.Visible = false;
                selectsking3sg1combobox.Enabled = false;
            }
            //GLOCK
            if (choseweaponcombobox.SelectedItem.Equals("GLOCK"))
            {
                selectskinglockcombobox.Visible = true;
                selectskinglockcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinglockcombobox.Visible = false;
                selectskinglockcombobox.Enabled = false;
            }
            //GUT
            if (choseweaponcombobox.SelectedItem.Equals("GUT"))
            {
                selectskingutcombobox.Visible = true;
                selectskingutcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskingutcombobox.Visible = false;
                selectskingutcombobox.Enabled = false;
            }
            //HUNTSMAN
            if (choseweaponcombobox.SelectedItem.Equals("HUNTSMAN"))
            {
                selectskinhuntsmancombobox.Visible = true;
                selectskinhuntsmancombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinhuntsmancombobox.Visible = false;
                selectskinhuntsmancombobox.Enabled = false;
            }
            //M249
            if (choseweaponcombobox.SelectedItem.Equals("M249"))
            {
                selectskinm249combobox.Visible = true;
                selectskinm249combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinm249combobox.Visible = false;
                selectskinm249combobox.Enabled = false;
            }
            //M4A4
            if (choseweaponcombobox.SelectedItem.Equals("M4A4"))
            {
                selectskinm4a4combobox.Visible = true;
                selectskinm4a4combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinm4a4combobox.Visible = false;
                selectskinm4a4combobox.Enabled = false;
            }
            //M4A1-S
            if (choseweaponcombobox.SelectedItem.Equals("M4A1-S"))
            {
                selectskinm4a1scombobox.Visible = true;
                selectskinm4a1scombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinm4a1scombobox.Visible = false;
                selectskinm4a1scombobox.Enabled = false;
            }
            //M9 BAYONET
            if (choseweaponcombobox.SelectedItem.Equals("M9 BAYONET"))
            {
                selectskinm9bayonetcombobox.Visible = true;
                selectskinm9bayonetcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinm9bayonetcombobox.Visible = false;
                selectskinm9bayonetcombobox.Enabled = false;
            }
            //MAC-10
            if (choseweaponcombobox.SelectedItem.Equals("MAC-10"))
            {
                selectskinmac10combobox.Visible = true;
                selectskinmac10combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinmac10combobox.Visible = false;
                selectskinmac10combobox.Enabled = false;
            }
            //GALILAR
            if (choseweaponcombobox.SelectedItem.Equals("GALILAR"))
            {
                selectskingalilarcombobox.Visible = true;
                selectskingalilarcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskingalilarcombobox.Visible = false;
                selectskingalilarcombobox.Enabled = false;
            }
            //P90
            if (choseweaponcombobox.SelectedItem.Equals("P90"))
            {
                selectskinp90combobox.Visible = true;
                selectskinp90combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinp90combobox.Visible = false;
                selectskinp90combobox.Enabled = false;
            }
            //R8-REVOLVER
            if (choseweaponcombobox.SelectedItem.Equals("R8-REVOLVER"))
            {
                selectskinr9revolvercombobox.Visible = true;
                selectskinr9revolvercombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinr9revolvercombobox.Visible = false;
                selectskinr9revolvercombobox.Enabled = false;
            }
            //USP-S
            if (choseweaponcombobox.SelectedItem.Equals("USP-S"))
            {
                selectskinuspscombobox.Visible = true;
                selectskinuspscombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinuspscombobox.Visible = false;
                selectskinuspscombobox.Enabled = false;
            }
            //UMP45
            if (choseweaponcombobox.SelectedItem.Equals("UMP45"))
            {
                selectskinump45combobox.Visible = true;
                selectskinump45combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinump45combobox.Visible = false;
                selectskinump45combobox.Enabled = false;
            }
            //XM1040
            if (choseweaponcombobox.SelectedItem.Equals("XM1014"))
            {
                selectskinxm1014combobox.Visible = true;
                selectskinxm1014combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinxm1014combobox.Visible = false;
                selectskinxm1014combobox.Enabled = false;
            }
            //MAG7
            if (choseweaponcombobox.SelectedItem.Equals("MAG7"))
            {
                selectskinmag7combobox.Visible = true;
                selectskinmag7combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinmag7combobox.Visible = false;
                selectskinmag7combobox.Enabled = false;
            }
            //NEGEV
            if (choseweaponcombobox.SelectedItem.Equals("NEGEV"))
            {
                selectskinnegevcombobox.Visible = true;
                selectskinnegevcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinnegevcombobox.Visible = false;
                selectskinnegevcombobox.Enabled = false;
            }
            //SAWEDOFF
            if (choseweaponcombobox.SelectedItem.Equals("SAWEDOFF"))
            {
                selectskinsawedoffcombobox.Visible = true;
                selectskinsawedoffcombobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinsawedoffcombobox.Visible = false;
                selectskinsawedoffcombobox.Enabled = false;
            }
            //TEC9
            if (choseweaponcombobox.SelectedItem.Equals("TEC9"))
            {
                selectskintec9combobox.Visible = true;
                selectskintec9combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskintec9combobox.Visible = false;
                selectskintec9combobox.Enabled = false;
            }
            //P2000
            if (choseweaponcombobox.SelectedItem.Equals("P2000"))
            {
                selectskinp2000combobox.Visible = true;
                selectskinp2000combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinp2000combobox.Visible = false;
                selectskinp2000combobox.Enabled = false;
            }
            //MP7
            if (choseweaponcombobox.SelectedItem.Equals("MP7"))
            {
                selectskinmp7combobox.Visible = true;
                selectskinmp7combobox.Enabled = true;

                dummycheckbox.Visible = false;
            }
            else
            {
                selectskinmp7combobox.Visible = false;
                selectskinmp7combobox.Enabled = false;
            }
        }

        //Trackbar Percent to Label
        private void skinweartrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            skinweartrackbarprcent.Text = skinweartrackbar.Value.ToString();
        }

        //Save Current Skin
        private void metroButton3_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("skins.ini");

            if (dummycheckbox.Visible == true)
            {
                MetroMessageBox.Show(this, "Please Select a Weapon and try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                #region AWP
                if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                {
                    if (awpselectskincheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (awpselectskincheckbox.SelectedItem.ToString() == "BOOM")
                        {
                            data["9"]["SkinID"] = "174";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Dragon Lore")
                        {
                            data["9"]["SkinID"] = "344";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["9"]["SkinID"] = "5";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Pink DDPAT")
                        {
                            data["9"]["SkinID"] = "84";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Snake Camo")
                        {
                            data["9"]["SkinID"] = "30";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Lightning Strike")
                        {
                            data["9"]["SkinID"] = "51";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Safari Mesh")
                        {
                            data["9"]["SkinID"] = "72";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Corticera")
                        {
                            data["9"]["SkinID"] = "181";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Redline")
                        {
                            data["9"]["SkinID"] = "259";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Man-o\'-war")
                        {
                            data["9"]["SkinID"] = "395";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Graphite1")
                        {
                            data["9"]["SkinID"] = "212";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Graphite2")
                        {
                            data["9"]["SkinID"] = "214";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Electric Hive")
                        {
                            data["9"]["SkinID"] = "227";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Pit Viper")
                        {
                            data["9"]["SkinID"] = "251";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Asiimov")
                        {
                            data["9"]["SkinID"] = "279";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Worm God")
                        {
                            data["9"]["SkinID"] = "424";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Medusa")
                        {
                            data["9"]["SkinID"] = "446";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Sun in Leo")
                        {
                            data["9"]["SkinID"] = "451";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Hyper Beast")
                        {
                            data["9"]["SkinID"] = "475";
                            parser.WriteFile("skins.ini", data);
                        }
                    }
                }
                #endregion AWP

                #region AK47
                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                {
                    if (ak47skinselectioncombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Aquamarine Revenge")
                        {
                            data["7"]["SkinID"] = "474";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Black Laminate")
                        {
                            data["7"]["SkinID"] = "172";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Blue Laminate")
                        {
                            data["7"]["SkinID"] = "226";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Cartel")
                        {
                            data["7"]["SkinID"] = "394";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Case Hardened")
                        {
                            data["7"]["SkinID"] = "44";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["7"]["SkinID"] = "22";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Elite Build")
                        {
                            data["7"]["SkinID"] = "422";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Emerald Pinstripe")
                        {
                            data["7"]["SkinID"] = "300";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Fire Serpent")
                        {
                            data["7"]["SkinID"] = "180";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "First Class")
                        {
                            data["7"]["SkinID"] = "341";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Frontside Misty")
                        {
                            data["7"]["SkinID"] = "490";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Fuel Injector")
                        {
                            data["7"]["SkinID"] = "524";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Hydroponic")
                        {
                            data["7"]["SkinID"] = "456";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Jaguar")
                        {
                            data["7"]["SkinID"] = "316";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Jet Set")
                        {
                            data["7"]["SkinID"] = "340";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Jungle Spray")
                        {
                            data["7"]["SkinID"] = "122";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Neon Revolution")
                        {
                            data["7"]["SkinID"] = "600";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Point Disarray")
                        {
                            data["7"]["SkinID"] = "506";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Predator")
                        {
                            data["7"]["SkinID"] = "170";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Red Laminate")
                        {
                            data["7"]["SkinID"] = "14";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Redline")
                        {
                            data["7"]["SkinID"] = "282";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Safari Mesh")
                        {
                            data["7"]["SkinID"] = "72";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Vulcan")
                        {
                            data["7"]["SkinID"] = "302";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Wasteland Rebel")
                        {
                            data["7"]["SkinID"] = "380";
                            parser.WriteFile("skins.ini", data);
                        }
                    }
                }
                #endregion AK47

                MetroMessageBox.Show(this, "Skin for " + choseweaponcombobox.SelectedItem.ToString() + " saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FileIniDataParser fileIniData = new FileIniDataParser();
                IniData parsedData = fileIniData.ReadFile("skins.ini");
                SkinsTextbox.Text = parsedData.ToString();
            }
        }

        //Save Current Seed & Wear
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("skins.ini");

            if (choseweaponcombobox.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Please Select a Weapon and try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (skinseedtextbox.Text.Length == 0)
                {
                    #region AWP
                    if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                    {
                        data["9"]["SkinSeed"] = "0";
                        data["9"]["SkinWear"] = "0.0000" + skinweartrackbarprcent.Text;
                        parser.WriteFile("skins.ini", data);
                    }
                    #endregion AWP

                    #region AK47
                    if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                    {
                        data["7"]["SkinSeed"] = "0";
                        data["7"]["SkinWear"] = "0.0000" + skinweartrackbarprcent.Text;
                        parser.WriteFile("skins.ini", data);
                    }
                    #endregion AK47
                }
                else
                {
                    #region AWP
                    if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                    {
                        data["9"]["SkinSeed"] = skinseedtextbox.Text;
                        data["9"]["SkinWear"] = "0.0000" + skinweartrackbarprcent.Text;
                        parser.WriteFile("skins.ini", data);
                    }
                    #endregion AWP

                    #region AK47
                    if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                    {
                        data["7"]["SkinSeed"] = skinseedtextbox.Text;
                        data["7"]["SkinWear"] = "0.0000" + skinweartrackbarprcent.Text;
                        parser.WriteFile("skins.ini", data);
                    }
                    #endregion AK47
                }
            }

            MetroMessageBox.Show(this, "Seed and Wear for " + choseweaponcombobox.SelectedItem.ToString() + " saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FileIniDataParser fileIniData = new FileIniDataParser();
            IniData parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset Wear Button
        private void metroButton5_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("skins.ini");

            if (choseweaponcombobox.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Please Select a Weapon and try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                #region AWP
                if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                {
                    data["9"]["SkinSeed"] = "0";
                    data["9"]["SkinWear"] = "0.000001";
                    parser.WriteFile("skins.ini", data);
                }
                #endregion AWP

                #region AK47
                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                {
                    data["7"]["SkinSeed"] = "0";
                    data["7"]["SkinWear"] = "0.000001";
                    parser.WriteFile("skins.ini", data);
                }
                #endregion AK47
            }

            MetroMessageBox.Show(this, "Reset Wear for " + choseweaponcombobox.SelectedItem.ToString() + "successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FileIniDataParser fileIniData = new FileIniDataParser();
            IniData parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }
    }
}
