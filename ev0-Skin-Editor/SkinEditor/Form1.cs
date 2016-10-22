using System;
using System.Windows.Forms;
using IniParser;
using MetroFramework;
using MetroFramework.Forms;

namespace SkinEditor
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fileIniData = new FileIniDataParser();

            var parsedData = fileIniData.ReadFile("skins.ini");

            SkinsTextbox.Text = parsedData.ToString();
        }

        //Chose Weapon Combobox [NOT FINISHED]
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

        //Trackbar Percent to Label [FINISHED]
        private void skinweartrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            skinweartrackbarprcent.Text = skinweartrackbar.Value.ToString();
        }

        //Save Current Skin [NOT FINISHED]
        private void metroButton3_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("skins.ini");

            if (dummycheckbox.Visible)
            {
                MetroMessageBox.Show(this, "Please Select a Weapon and try again!", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                #region AWP

                if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                    if (awpselectskincheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                #endregion AWP

                #region AK47

                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                    if (ak47skinselectioncombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                #endregion AK47

                #region DEAGLE

                if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
                    if (deagleselectskincheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Blaze")
                        {
                            data["1"]["SkinID"] = "37";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Bronze Deco")
                        {
                            data["1"]["SkinID"] = "425";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Cobalt Disruption")
                        {
                            data["1"]["SkinID"] = "231";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Conspiracy")
                        {
                            data["1"]["SkinID"] = "351";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Corinthian")
                        {
                            data["1"]["SkinID"] = "509";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Crimson Web")
                        {
                            data["1"]["SkinID"] = "232";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Directive")
                        {
                            data["1"]["SkinID"] = "603";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["1"]["SkinID"] = "5";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Golden Koi")
                        {
                            data["1"]["SkinID"] = "185";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Hand Cannon")
                        {
                            data["1"]["SkinID"] = "328";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Heirloom")
                        {
                            data["1"]["SkinID"] = "273";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Hypnotic")
                        {
                            data["1"]["SkinID"] = "61";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Kumicho Dragon")
                        {
                            data["1"]["SkinID"] = "527";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Meteorite")
                        {
                            data["1"]["SkinID"] = "296";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Midnight Storm")
                        {
                            data["1"]["SkinID"] = "468";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Mudder")
                        {
                            data["1"]["SkinID"] = "90";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Naga")
                        {
                            data["1"]["SkinID"] = "397";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Night")
                        {
                            data["1"]["SkinID"] = "40";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Pilot")
                        {
                            data["1"]["SkinID"] = "347";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Sunset Storm 1")
                        {
                            data["1"]["SkinID"] = "469";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Sunset Storm 2")
                        {
                            data["1"]["SkinID"] = "470";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Urban DDPAT")
                        {
                            data["1"]["SkinID"] = "17";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Urban Rubble")
                        {
                            data["1"]["SkinID"] = "237";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["1"]["SkinID"] = "235";
                            parser.WriteFile("skins.ini", data);
                        }
                    }

                #endregion DEAGLE

                #region AUG

                if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
                    if (augskinselectioncheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Akihabara Accept")
                        {
                            data["8"]["SkinID"] = "455";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Anodized Navy 1")
                        {
                            data["8"]["SkinID"] = "28";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Anodized Navy 2")
                        {
                            data["8"]["SkinID"] = "197";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Aristocrat")
                        {
                            data["8"]["SkinID"] = "583";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Asterion")
                        {
                            data["8"]["SkinID"] = "442";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Bengal Tiger")
                        {
                            data["8"]["SkinID"] = "9";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Chameleon")
                        {
                            data["8"]["SkinID"] = "280";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Colony")
                        {
                            data["8"]["SkinID"] = "47";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Condemned")
                        {
                            data["8"]["SkinID"] = "110";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Contractor")
                        {
                            data["8"]["SkinID"] = "46";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Copperhead")
                        {
                            data["8"]["SkinID"] = "10";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Daedalus")
                        {
                            data["8"]["SkinID"] = "444";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Fleet Flock")
                        {
                            data["8"]["SkinID"] = "541";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Hot Rod")
                        {
                            data["8"]["SkinID"] = "33";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Radiation Hazard 1")
                        {
                            data["8"]["SkinID"] = "167";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Radiation Hazard 2")
                        {
                            data["8"]["SkinID"] = "375";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Ricochet")
                        {
                            data["8"]["SkinID"] = "507";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Storm")
                        {
                            data["8"]["SkinID"] = "100";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Syd Mead")
                        {
                            data["8"]["SkinID"] = "601";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Torque")
                        {
                            data["8"]["SkinID"] = "305";
                            parser.WriteFile("skins.ini", data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Wings")
                        {
                            data["8"]["SkinID"] = "73";
                            parser.WriteFile("skins.ini", data);
                        }
                    }

                #endregion AUG

                MetroMessageBox.Show(this, "Skin for " + choseweaponcombobox.SelectedItem + " saved!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var fileIniData = new FileIniDataParser();
                var parsedData = fileIniData.ReadFile("skins.ini");
                SkinsTextbox.Text = parsedData.ToString();
            }
        }

        //Save Current Seed & Wear [FINISHED]
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("skins.ini");

            if (choseweaponcombobox.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Please Select a Weapon and try again!", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (skinseedtextbox.Text.Length == 0)
            {
                #region AWP

                if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                {
                    data["9"]["SkinSeed"] = "0";
                    data["9"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion AWP

                #region AK47

                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                {
                    data["7"]["SkinSeed"] = "0";
                    data["7"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion AK47

                #region DEAGLE

                if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
                {
                    data["1"]["SkinSeed"] = "0";
                    data["1"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion DEAGLE

                #region DUAL BERETTAS

                if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
                {
                    data["2"]["SkinSeed"] = "0";
                    data["2"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion DUAL BERETTAS

                #region FIVESEVEN

                if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
                {
                    data["3"]["SkinSeed"] = "0";
                    data["3"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FIVESEVEN

                #region GLOCK

                if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
                {
                    data["4"]["SkinSeed"] = "0";
                    data["4"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion GLOCK

                #region AUG

                if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
                {
                    data["8"]["SkinSeed"] = "0";
                    data["8"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion AUG

                #region FAMAS

                if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
                {
                    data["10"]["SkinSeed"] = "0";
                    data["10"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FAMAS

                #region G3SG1

                if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
                {
                    data["11"]["SkinSeed"] = "0";
                    data["11"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion G3SG1

                #region GALILAR

                if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
                {
                    data["13"]["SkinSeed"] = "0";
                    data["13"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion GALILAR

                #region M249

                if (choseweaponcombobox.SelectedItem.ToString() == "M249")
                {
                    data["14"]["SkinSeed"] = "0";
                    data["14"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M249

                #region M4A4

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
                {
                    data["16"]["SkinSeed"] = "0";
                    data["16"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M4A4

                #region MAC10

                if (choseweaponcombobox.SelectedItem.ToString() == "MAC10")
                {
                    data["17"]["SkinSeed"] = "0";
                    data["17"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MAC10

                #region P90

                if (choseweaponcombobox.SelectedItem.ToString() == "P90")
                {
                    data["19"]["SkinSeed"] = "0";
                    data["19"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion P90

                #region UMP45

                if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
                {
                    data["24"]["SkinSeed"] = "0";
                    data["24"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion UMP45

                #region XM1014

                if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
                {
                    data["25"]["SkinSeed"] = "0";
                    data["25"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion XM1014

                #region BIZON

                if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
                {
                    data["26"]["SkinSeed"] = "0";
                    data["26"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion BIZON

                #region MAG7

                if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
                {
                    data["27"]["SkinSeed"] = "0";
                    data["27"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MAG7

                #region NEGEV

                if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
                {
                    data["28"]["SkinSeed"] = "0";
                    data["28"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion NEGEV

                #region SAWEDOFF

                if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
                {
                    data["29"]["SkinSeed"] = "0";
                    data["29"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SAWEDOFF

                #region TEC9

                if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
                {
                    data["30"]["SkinSeed"] = "0";
                    data["30"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion TEC9

                #region P2000

                if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
                {
                    data["32"]["SkinSeed"] = "0";
                    data["32"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion P2000

                #region MP7

                if (choseweaponcombobox.SelectedItem.ToString() == "MP7")
                {
                    data["33"]["SkinSeed"] = "0";
                    data["33"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MP7

                #region MP9

                if (choseweaponcombobox.SelectedItem.ToString() == "MP9")
                {
                    data["34"]["SkinSeed"] = "0";
                    data["34"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MP9

                #region NOVA

                if (choseweaponcombobox.SelectedItem.ToString() == "NOVA")
                {
                    data["35"]["SkinSeed"] = "0";
                    data["35"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion NOVA

                #region P250

                if (choseweaponcombobox.SelectedItem.ToString() == "P250")
                {
                    data["36"]["SkinSeed"] = "0";
                    data["36"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion P250

                #region SCAR20

                if (choseweaponcombobox.SelectedItem.ToString() == "SCAR20")
                {
                    data["38"]["SkinSeed"] = "0";
                    data["38"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SCAR20

                #region SG556

                if (choseweaponcombobox.SelectedItem.ToString() == "SG556")
                {
                    data["39"]["SkinSeed"] = "0";
                    data["39"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SG556

                #region SSG08

                if (choseweaponcombobox.SelectedItem.ToString() == "SSG08")
                {
                    data["40"]["SkinSeed"] = "0";
                    data["40"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SSG08

                #region M4A1-S

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A1-S")
                {
                    data["60"]["SkinSeed"] = "0";
                    data["60"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M4A1-S

                #region USP-S

                if (choseweaponcombobox.SelectedItem.ToString() == "USP-S")
                {
                    data["61"]["SkinSeed"] = "0";
                    data["61"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion USP-S

                #region CZ75A

                if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
                {
                    data["63"]["SkinSeed"] = "0";
                    data["63"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion CZ75A

                #region R8-REVOLVER

                if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
                {
                    data["64"]["SkinSeed"] = "0";
                    data["64"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion R8-REVOLVER

                #region BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "BAYONET")
                {
                    data["500"]["SkinSeed"] = "0";
                    data["500"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion BAYONET

                #region FLIP

                if (choseweaponcombobox.SelectedItem.ToString() == "FLIP")
                {
                    data["505"]["SkinSeed"] = "0";
                    data["505"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FLIP

                #region GUT

                if (choseweaponcombobox.SelectedItem.ToString() == "GUT")
                {
                    data["506"]["SkinSeed"] = "0";
                    data["506"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion GUT

                #region KARAMBIT

                if (choseweaponcombobox.SelectedItem.ToString() == "KARAMBIT")
                {
                    data["507"]["SkinSeed"] = "0";
                    data["507"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion KARAMBIT

                #region M9 BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "M9 BAYONET")
                {
                    data["508"]["SkinSeed"] = "0";
                    data["508"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M9 BAYONET

                #region HUNTSMAN

                if (choseweaponcombobox.SelectedItem.ToString() == "HUNTSMAN")
                {
                    data["509"]["SkinSeed"] = "0";
                    data["509"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion HUNTSMAN

                #region FALCHION

                if (choseweaponcombobox.SelectedItem.ToString() == "FALCHION")
                {
                    data["512"]["SkinSeed"] = "0";
                    data["512"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FALCHION

                #region BOWIE

                if (choseweaponcombobox.SelectedItem.ToString() == "BOWIE")
                {
                    data["514"]["SkinSeed"] = "0";
                    data["514"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion BOWIE

                #region BUTTERFLY

                if (choseweaponcombobox.SelectedItem.ToString() == "BUTTERFLY")
                {
                    data["515"]["SkinSeed"] = "0";
                    data["515"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion BUTTERFLY

                #region SHADOW DAGGERS

                if (choseweaponcombobox.SelectedItem.ToString() == "SHADOW DAGGERS")
                {
                    data["516"]["SkinSeed"] = "0";
                    data["516"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SHADOW DAGGERS
            }
            else
            {
                #region AWP

                if (choseweaponcombobox.SelectedItem.ToString() == "AWP")
                {
                    data["9"]["SkinSeed"] = skinseedtextbox.Text;
                    data["9"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion AWP

                #region AK47

                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                {
                    data["7"]["SkinSeed"] = skinseedtextbox.Text;
                    data["7"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion AK47

                #region DEAGLE

                if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
                {
                    data["1"]["SkinSeed"] = skinseedtextbox.Text;
                    data["1"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion DEAGLE

                #region DUAL BERETTAS

                if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
                {
                    data["2"]["SkinSeed"] = skinseedtextbox.Text;
                    data["2"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion DUAL BERETTAS

                #region FIVESEVEN

                if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
                {
                    data["3"]["SkinSeed"] = skinseedtextbox.Text;
                    data["3"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FIVESEVEN

                #region GLOCK

                if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
                {
                    data["4"]["SkinSeed"] = skinseedtextbox.Text;
                    data["4"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion GLOCK

                #region AUG

                if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
                {
                    data["8"]["SkinSeed"] = skinseedtextbox.Text;
                    data["8"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion AUG

                #region FAMAS

                if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
                {
                    data["10"]["SkinSeed"] = skinseedtextbox.Text;
                    data["10"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FAMAS

                #region G3SG1

                if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
                {
                    data["11"]["SkinSeed"] = skinseedtextbox.Text;
                    data["11"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion G3SG1

                #region GALILAR

                if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
                {
                    data["13"]["SkinSeed"] = skinseedtextbox.Text;
                    data["13"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion GALILAR

                #region M249

                if (choseweaponcombobox.SelectedItem.ToString() == "M249")
                {
                    data["14"]["SkinSeed"] = skinseedtextbox.Text;
                    data["14"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M249

                #region M4A4

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
                {
                    data["16"]["SkinSeed"] = skinseedtextbox.Text;
                    data["16"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M4A4

                #region MAC10

                if (choseweaponcombobox.SelectedItem.ToString() == "MAC10")
                {
                    data["17"]["SkinSeed"] = skinseedtextbox.Text;
                    data["17"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MAC10

                #region P90

                if (choseweaponcombobox.SelectedItem.ToString() == "P90")
                {
                    data["19"]["SkinSeed"] = skinseedtextbox.Text;
                    data["19"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion P90

                #region UMP45

                if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
                {
                    data["24"]["SkinSeed"] = skinseedtextbox.Text;
                    data["24"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion UMP45

                #region XM1014

                if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
                {
                    data["25"]["SkinSeed"] = skinseedtextbox.Text;
                    data["25"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion XM1014

                #region BIZON

                if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
                {
                    data["26"]["SkinSeed"] = skinseedtextbox.Text;
                    data["26"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion BIZON

                #region MAG7

                if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
                {
                    data["27"]["SkinSeed"] = skinseedtextbox.Text;
                    data["27"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MAG7

                #region NEGEV

                if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
                {
                    data["28"]["SkinSeed"] = skinseedtextbox.Text;
                    data["28"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion NEGEV

                #region SAWEDOFF

                if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
                {
                    data["29"]["SkinSeed"] = skinseedtextbox.Text;
                    data["29"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SAWEDOFF

                #region TEC9

                if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
                {
                    data["30"]["SkinSeed"] = skinseedtextbox.Text;
                    data["30"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion TEC9

                #region P2000

                if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
                {
                    data["32"]["SkinSeed"] = skinseedtextbox.Text;
                    data["32"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion P2000

                #region MP7

                if (choseweaponcombobox.SelectedItem.ToString() == "MP7")
                {
                    data["33"]["SkinSeed"] = skinseedtextbox.Text;
                    data["33"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MP7

                #region MP9

                if (choseweaponcombobox.SelectedItem.ToString() == "MP9")
                {
                    data["34"]["SkinSeed"] = skinseedtextbox.Text;
                    data["34"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion MP9

                #region NOVA

                if (choseweaponcombobox.SelectedItem.ToString() == "NOVA")
                {
                    data["35"]["SkinSeed"] = skinseedtextbox.Text;
                    data["35"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion NOVA

                #region P250

                if (choseweaponcombobox.SelectedItem.ToString() == "P250")
                {
                    data["36"]["SkinSeed"] = skinseedtextbox.Text;
                    data["36"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion P250

                #region SCAR20

                if (choseweaponcombobox.SelectedItem.ToString() == "SCAR20")
                {
                    data["38"]["SkinSeed"] = skinseedtextbox.Text;
                    data["38"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SCAR20

                #region SG556

                if (choseweaponcombobox.SelectedItem.ToString() == "SG556")
                {
                    data["39"]["SkinSeed"] = skinseedtextbox.Text;
                    data["39"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SG556

                #region SSG08

                if (choseweaponcombobox.SelectedItem.ToString() == "SSG08")
                {
                    data["40"]["SkinSeed"] = skinseedtextbox.Text;
                    data["40"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion SSG08

                #region M4A1-S

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A1-S")
                {
                    data["60"]["SkinSeed"] = skinseedtextbox.Text;
                    data["60"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M4A1-S

                #region USP-S

                if (choseweaponcombobox.SelectedItem.ToString() == "USP-S")
                {
                    data["61"]["SkinSeed"] = skinseedtextbox.Text;
                    data["61"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion USP-S

                #region CZ75A

                if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
                {
                    data["63"]["SkinSeed"] = skinseedtextbox.Text;
                    data["63"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion CZ75A

                #region R8-REVOLVER

                if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
                {
                    data["64"]["SkinSeed"] = skinseedtextbox.Text;
                    data["64"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion R8-REVOLVER

                #region BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "BAYONET")
                {
                    data["500"]["SkinSeed"] = skinseedtextbox.Text;
                    data["500"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion BAYONET

                #region FLIP

                if (choseweaponcombobox.SelectedItem.ToString() == "FLIP")
                {
                    data["505"]["SkinSeed"] = skinseedtextbox.Text;
                    data["505"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion FLIP

                #region GUT

                if (choseweaponcombobox.SelectedItem.ToString() == "GUT")
                {
                    data["506"]["SkinSeed"] = skinseedtextbox.Text;
                    data["506"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion GUT

                #region KARAMBIT

                if (choseweaponcombobox.SelectedItem.ToString() == "KARAMBIT")
                {
                    data["507"]["SkinSeed"] = skinseedtextbox.Text;
                    data["507"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion KARAMBIT

                #region M9 BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "M9 BAYONET")
                {
                    data["508"]["SkinSeed"] = skinseedtextbox.Text;
                    data["508"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                #endregion M9 BAYONET

                #region HUNTSMAN

                if (choseweaponcombobox.SelectedItem.ToString() == "HUNTSMAN")
                {
                    data["509"]["SkinSeed"] = skinseedtextbox.Text;
                    data["509"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                # endregion HUNTSMAN

                #region FALCHION

                if (choseweaponcombobox.SelectedItem.ToString() == "FALCHION")
                {
                    data["512"]["SkinSeed"] = skinseedtextbox.Text;
                    data["512"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                # endregion FALCHION

                #region BOWIE

                if (choseweaponcombobox.SelectedItem.ToString() == "BOWIE")
                {
                    data["514"]["SkinSeed"] = skinseedtextbox.Text;
                    data["514"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                # endregion BOWIE

                #region BUTTERFLY

                if (choseweaponcombobox.SelectedItem.ToString() == "BUTTERFLY")
                {
                    data["515"]["SkinSeed"] = skinseedtextbox.Text;
                    data["515"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                # endregion BUTTERFLY

                #region SHADOW DAGGERS

                if (choseweaponcombobox.SelectedItem.ToString() == "SHADOW DAGGERS")
                {
                    data["516"]["SkinSeed"] = skinseedtextbox.Text;
                    data["516"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile("skins.ini", data);
                }

                # endregion SHADOW DAGGERS
            }

            MetroMessageBox.Show(this, "Seed and Wear for " + choseweaponcombobox.SelectedItem + " saved!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset Wear Button [FINISHED]
        private void metroButton5_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("skins.ini");

            if (choseweaponcombobox.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Please Select a Weapon and try again!", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

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

            #region DEAGLE

            if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
            {
                data["1"]["SkinSeed"] = "0";
                data["1"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion DEAGLE

            #region DUAL BERETTAS

            if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
            {
                data["2"]["SkinSeed"] = "0";
                data["2"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion DUAL BERETTAS

            #region FIVESEVEN

            if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
            {
                data["3"]["SkinSeed"] = "0";
                data["3"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion FIVESEVEN

            #region GLOCK

            if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
            {
                data["4"]["SkinSeed"] = "0";
                data["4"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion GLOCK

            #region AUG

            if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
            {
                data["8"]["SkinSeed"] = "0";
                data["8"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion AUG

            #region FAMAS

            if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
            {
                data["10"]["SkinSeed"] = "0";
                data["10"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion FAMAS

            #region G3SG1

            if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
            {
                data["11"]["SkinSeed"] = "0";
                data["11"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion G3SG1

            #region GALILAR

            if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
            {
                data["13"]["SkinSeed"] = "0";
                data["13"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion GALILAR

            #region M249

            if (choseweaponcombobox.SelectedItem.ToString() == "M249")
            {
                data["14"]["SkinSeed"] = "0";
                data["14"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion M249

            #region M4A4

            if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
            {
                data["16"]["SkinSeed"] = "0";
                data["16"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion M4A4

            #region MAC10

            if (choseweaponcombobox.SelectedItem.ToString() == "MAC10")
            {
                data["17"]["SkinSeed"] = "0";
                data["17"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion MAC10

            #region P90

            if (choseweaponcombobox.SelectedItem.ToString() == "P90")
            {
                data["19"]["SkinSeed"] = "0";
                data["19"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion P90

            #region UMP45

            if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
            {
                data["24"]["SkinSeed"] = "0";
                data["24"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion UMP45

            #region XM1014

            if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
            {
                data["25"]["SkinSeed"] = "0";
                data["25"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion XM1014

            #region BIZON

            if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
            {
                data["26"]["SkinSeed"] = "0";
                data["26"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion BIZON

            #region MAG7

            if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
            {
                data["27"]["SkinSeed"] = "0";
                data["27"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion MAG7

            #region NEGEV

            if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
            {
                data["28"]["SkinSeed"] = "0";
                data["28"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion NEGEV

            #region SAWEDOFF

            if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
            {
                data["29"]["SkinSeed"] = "0";
                data["29"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion SAWEDOFF

            #region TEC9

            if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
            {
                data["30"]["SkinSeed"] = "0";
                data["30"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion TEC9

            #region P2000

            if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
            {
                data["32"]["SkinSeed"] = "0";
                data["32"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion P2000

            #region MP7

            if (choseweaponcombobox.SelectedItem.ToString() == "MP7")
            {
                data["33"]["SkinSeed"] = "0";
                data["33"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion MP7

            #region MP9

            if (choseweaponcombobox.SelectedItem.ToString() == "MP9")
            {
                data["34"]["SkinSeed"] = "0";
                data["34"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion MP9

            #region NOVA

            if (choseweaponcombobox.SelectedItem.ToString() == "NOVA")
            {
                data["35"]["SkinSeed"] = "0";
                data["35"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion NOVA

            #region P250

            if (choseweaponcombobox.SelectedItem.ToString() == "P250")
            {
                data["36"]["SkinSeed"] = "0";
                data["36"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion P250

            #region SCAR20

            if (choseweaponcombobox.SelectedItem.ToString() == "SCAR20")
            {
                data["38"]["SkinSeed"] = "0";
                data["38"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion SCAR20

            #region SG556

            if (choseweaponcombobox.SelectedItem.ToString() == "SG556")
            {
                data["39"]["SkinSeed"] = "0";
                data["39"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion SG556

            #region SSG08

            if (choseweaponcombobox.SelectedItem.ToString() == "SSG08")
            {
                data["40"]["SkinSeed"] = "0";
                data["40"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion SSG08

            #region M4A1-S

            if (choseweaponcombobox.SelectedItem.ToString() == "M4A1-S")
            {
                data["60"]["SkinSeed"] = "0";
                data["60"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion M4A1-S

            #region USP-S

            if (choseweaponcombobox.SelectedItem.ToString() == "USP-S")
            {
                data["61"]["SkinSeed"] = "0";
                data["61"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion USP-S

            #region CZ75A

            if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
            {
                data["63"]["SkinSeed"] = "0";
                data["63"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion CZ75A

            #region R8-REVOLVER

            if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
            {
                data["64"]["SkinSeed"] = "0";
                data["64"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion R8-REVOLVER

            #region BAYONET

            if (choseweaponcombobox.SelectedItem.ToString() == "BAYONET")
            {
                data["500"]["SkinSeed"] = "0";
                data["500"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion BAYONET

            #region FLIP

            if (choseweaponcombobox.SelectedItem.ToString() == "FLIP")
            {
                data["505"]["SkinSeed"] = "0";
                data["505"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion FLIP

            #region GUT

            if (choseweaponcombobox.SelectedItem.ToString() == "GUT")
            {
                data["506"]["SkinSeed"] = "0";
                data["506"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion GUT

            #region KARAMBIT

            if (choseweaponcombobox.SelectedItem.ToString() == "KARAMBIT")
            {
                data["507"]["SkinSeed"] = "0";
                data["507"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion KARAMBIT

            #region M9 BAYONET

            if (choseweaponcombobox.SelectedItem.ToString() == "M9 BAYONET")
            {
                data["508"]["SkinSeed"] = "0";
                data["508"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion M9 BAYONET

            #region HUNTSMAN

            if (choseweaponcombobox.SelectedItem.ToString() == "HUNTSMAN")
            {
                data["509"]["SkinSeed"] = "0";
                data["509"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion HUNTSMAN

            #region FALCHION

            if (choseweaponcombobox.SelectedItem.ToString() == "FALCHION")
            {
                data["512"]["SkinSeed"] = "0";
                data["512"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion FALCHION

            #region BOWIE

            if (choseweaponcombobox.SelectedItem.ToString() == "BOWIE")
            {
                data["514"]["SkinSeed"] = "0";
                data["514"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion BOWIE

            #region BUTTERFLY

            if (choseweaponcombobox.SelectedItem.ToString() == "BUTTERFLY")
            {
                data["515"]["SkinSeed"] = "0";
                data["515"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion BUTTERFLY

            #region SHADOW DAGGERS

            if (choseweaponcombobox.SelectedItem.ToString() == "SHADOW DAGGERS")
            {
                data["516"]["SkinSeed"] = "0";
                data["516"]["SkinWear"] = "0.000001";
                parser.WriteFile("skins.ini", data);
            }

            #endregion SHADOW DAGGERS

            MetroMessageBox.Show(this, "Reset Wear for " + choseweaponcombobox.SelectedItem + "successful",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset all Skin Seed's [FINISHED]
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("skins.ini");

            data["1"]["SkinSeed"] = "0";

            data["2"]["SkinSeed"] = "0";

            data["3"]["SkinSeed"] = "0";

            data["4"]["SkinSeed"] = "0";

            data["7"]["SkinSeed"] = "0";

            data["8"]["SkinSeed"] = "0";

            data["9"]["SkinSeed"] = "0";

            data["10"]["SkinSeed"] = "0";

            data["11"]["SkinSeed"] = "0";

            data["13"]["SkinSeed"] = "0";

            data["14"]["SkinSeed"] = "0";

            data["16"]["SkinSeed"] = "0";

            data["17"]["SkinSeed"] = "0";

            data["19"]["SkinSeed"] = "0";

            data["24"]["SkinSeed"] = "0";

            data["25"]["SkinSeed"] = "0";

            data["26"]["SkinSeed"] = "0";

            data["27"]["SkinSeed"] = "0";

            data["28"]["SkinSeed"] = "0";

            data["29"]["SkinSeed"] = "0";

            data["30"]["SkinSeed"] = "0";

            data["32"]["SkinSeed"] = "0";

            data["33"]["SkinSeed"] = "0";

            data["34"]["SkinSeed"] = "0";

            data["35"]["SkinSeed"] = "0";

            data["36"]["SkinSeed"] = "0";

            data["38"]["SkinSeed"] = "0";

            data["39"]["SkinSeed"] = "0";

            data["40"]["SkinSeed"] = "0";

            data["60"]["SkinSeed"] = "0";

            data["61"]["SkinSeed"] = "0";
            
            data["63"]["SkinSeed"] = "0";

            data["64"]["SkinSeed"] = "0";

            data["500"]["SkinSeed"] = "0";

            data["505"]["SkinSeed"] = "0";

            data["506"]["SkinSeed"] = "0";

            data["507"]["SkinSeed"] = "0";

            data["508"]["SkinSeed"] = "0";

            data["509"]["SkinSeed"] = "0";

            data["512"]["SkinSeed"] = "0";

            data["514"]["SkinSeed"] = "0";

            data["515"]["SkinSeed"] = "0";

            data["516"]["SkinSeed"] = "0";

            //Extra ID's?

            data["49"]["SkinSeed"] = "0";

            data["0"]["SkinSeed"] = "0";

            data["44"]["SkinSeed"] = "0";

            data["48"]["SkinSeed"] = "0";

            data["45"]["SkinSeed"] = "0";

            data["43"]["SkinSeed"] = "0";

            data["46"]["SkinSeed"] = "0";

            data["47"]["SkinSeed"] = "0";

            parser.WriteFile("skins.ini", data);

            MetroMessageBox.Show(this, "Seeds for all Weapons Reset.", "Information", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset all Skin Wear's [FINISHED]
        private void metroButton2_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("skins.ini");

            data["1"]["SkinWear"] = "0.000001";

            data["2"]["SkinWear"] = "0.000001";

            data["3"]["SkinWear"] = "0.000001";

            data["4"]["SkinWear"] = "0.000001";

            data["7"]["SkinWear"] = "0.000001";

            data["8"]["SkinWear"] = "0.000001";

            data["9"]["SkinWear"] = "0.000001";

            data["10"]["SkinWear"] = "0.000001";

            data["11"]["SkinWear"] = "0.000001";

            data["13"]["SkinWear"] = "0.000001";

            data["14"]["SkinWear"] = "0.000001";

            data["16"]["SkinWear"] = "0.000001";

            data["17"]["SkinWear"] = "0.000001";

            data["19"]["SkinWear"] = "0.000001";

            data["24"]["SkinWear"] = "0.000001";

            data["25"]["SkinWear"] = "0.000001";

            data["26"]["SkinWear"] = "0.000001";

            data["27"]["SkinWear"] = "0.000001";

            data["28"]["SkinWear"] = "0.000001";

            data["29"]["SkinWear"] = "0.000001";

            data["30"]["SkinWear"] = "0.000001";

            data["32"]["SkinWear"] = "0.000001";

            data["33"]["SkinWear"] = "0.000001";

            data["34"]["SkinWear"] = "0.000001";

            data["35"]["SkinWear"] = "0.000001";

            data["36"]["SkinWear"] = "0.000001";

            data["38"]["SkinWear"] = "0.000001";

            data["39"]["SkinWear"] = "0.000001";

            data["40"]["SkinWear"] = "0.000001";

            data["60"]["SkinWear"] = "0.000001";

            data["61"]["SkinWear"] = "0.000001";

            data["63"]["SkinWear"] = "0.000001";

            data["64"]["SkinWear"] = "0.000001";

            data["500"]["SkinWear"] = "0.000001";

            data["505"]["SkinWear"] = "0.000001";

            data["506"]["SkinWear"] = "0.000001";

            data["507"]["SkinWear"] = "0.000001";

            data["508"]["SkinWear"] = "0.000001";

            data["509"]["SkinWear"] = "0.000001";

            data["512"]["SkinWear"] = "0.000001";

            data["514"]["SkinWear"] = "0.000001";

            data["515"]["SkinWear"] = "0.000001";

            data["516"]["SkinWear"] = "0.000001";

            //Extra ID's?

            data["49"]["SkinWear"] = "0.000001";

            data["0"]["SkinWear"] = "0.000001";

            data["44"]["SkinWear"] = "0.000001";

            data["48"]["SkinWear"] = "0.000001";

            data["45"]["SkinWear"] = "0.000001";

            data["43"]["SkinWear"] = "0.000001";

            data["46"]["SkinWear"] = "0.000001";

            data["47"]["SkinWear"] = "0.000001";

            parser.WriteFile("skins.ini", data);

            MetroMessageBox.Show(this, "Wears for all Weapons Reset.", "Information", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset all Skins [FINISHED]
        private void metroButton6_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("skins.ini");

            data["1"]["SkinID"] = "0";

            data["2"]["SkinID"] = "0";

            data["3"]["SkinID"] = "0";

            data["4"]["SkinID"] = "0";

            data["7"]["SkinID"] = "0";

            data["8"]["SkinID"] = "0";

            data["9"]["SkinID"] = "0";

            data["10"]["SkinID"] = "0";

            data["11"]["SkinID"] = "0";

            data["13"]["SkinID"] = "0";

            data["14"]["SkinID"] = "0";

            data["16"]["SkinID"] = "0";

            data["17"]["SkinID"] = "0";

            data["19"]["SkinID"] = "0";

            data["24"]["SkinID"] = "0";

            data["25"]["SkinID"] = "0";

            data["26"]["SkinID"] = "0";

            data["27"]["SkinID"] = "0";

            data["28"]["SkinID"] = "0";

            data["29"]["SkinID"] = "0";

            data["30"]["SkinID"] = "0";

            data["32"]["SkinID"] = "0";

            data["33"]["SkinID"] = "0";

            data["34"]["SkinID"] = "0";

            data["35"]["SkinID"] = "0";

            data["36"]["SkinID"] = "0";

            data["38"]["SkinID"] = "0";

            data["39"]["SkinID"] = "0";

            data["40"]["SkinID"] = "0";

            data["60"]["SkinID"] = "0";

            data["61"]["SkinID"] = "0";

            data["63"]["SkinID"] = "0";

            data["64"]["SkinID"] = "0";

            data["500"]["SkinID"] = "0";

            data["505"]["SkinID"] = "0";

            data["506"]["SkinID"] = "0";

            data["507"]["SkinID"] = "0";

            data["508"]["SkinID"] = "0";

            data["509"]["SkinID"] = "0";

            data["512"]["SkinID"] = "0";

            data["514"]["SkinID"] = "0";

            data["515"]["SkinID"] = "0";

            data["516"]["SkinID"] = "0";

            //Extra ID's?

            data["49"]["SkinID"] = "0";

            data["0"]["SkinID"] = "0";

            data["44"]["SkinID"] = "0";

            data["48"]["SkinID"] = "0";

            data["45"]["SkinID"] = "0";

            data["43"]["SkinID"] = "0";

            data["46"]["SkinID"] = "0";

            data["47"]["SkinID"] = "0";

            parser.WriteFile("skins.ini", data);

            MetroMessageBox.Show(this, "Are you sure that you want to Reset all Weapon Skins?", "Information", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile("skins.ini");
            SkinsTextbox.Text = parsedData.ToString();
        }
    }
}