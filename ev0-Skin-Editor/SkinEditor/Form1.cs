using System;
using System.IO;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
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

        //Main Function [FINISHED]
        private void Form1_Load(object sender, EventArgs e)
        {
            //Get Directory
            var parserDirectory = new FileIniDataParser();
            IniData dataDirectory = parserDirectory.ReadFile("Config.ini");

            string Directory = dataDirectory["Settings"]["Directory"];
            label2.Text = Directory;

            if (File.Exists(label2.Text))
            {
                //Load skins.ini to Textbox
                var fileIniData = new FileIniDataParser();
                var parsedData = fileIniData.ReadFile(label2.Text);
                SkinsTextbox.Text = parsedData.ToString();
                label1.Text = label2.Text;
            }
            else
            {
                MetroMessageBox.Show(this, "Please Select your Counter Strike Global Offensive Folder!", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                FolderBrowserDialog browser = new FolderBrowserDialog();

                string tempPath = "";

                if (browser.ShowDialog() == DialogResult.OK)
                {
                    tempPath = browser.SelectedPath;
                    if (File.Exists(tempPath + @"\ev0lve\skins.ini"))
                    {
                        //Save Directory
                        label1.Text = tempPath + @"\ev0lve\skins.ini";

                        //Load skins.ini to Textbox
                        var fileIniData = new FileIniDataParser();
                        var parsedData = fileIniData.ReadFile(label1.Text);
                        SkinsTextbox.Text = parsedData.ToString();

                        //Write Directory to Config File
                        var parserConfig = new FileIniDataParser();
                        var dataConfig = parserConfig.ReadFile("Config.ini");
                        dataConfig["Settings"]["Directory"] = tempPath + @"\ev0lve\skins.ini";
                        parserConfig.WriteFile("Config.ini", dataConfig);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "No skins.ini Found!\r\nMake sure to select your Global Offensive Folder!", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Close();
                    }
                }

                if (SkinsTextbox.TextLength == 0)
                {
                    Close();
                }
            }
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
            var data = parser.ReadFile(label1.Text);

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
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Dragon Lore")
                        {
                            data["9"]["SkinID"] = "344";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["9"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Pink DDPAT")
                        {
                            data["9"]["SkinID"] = "84";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Snake Camo")
                        {
                            data["9"]["SkinID"] = "30";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Lightning Strike")
                        {
                            data["9"]["SkinID"] = "51";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Safari Mesh")
                        {
                            data["9"]["SkinID"] = "72";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Corticera")
                        {
                            data["9"]["SkinID"] = "181";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Redline")
                        {
                            data["9"]["SkinID"] = "259";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Man-o\'-war")
                        {
                            data["9"]["SkinID"] = "395";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Graphite1")
                        {
                            data["9"]["SkinID"] = "212";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Graphite2")
                        {
                            data["9"]["SkinID"] = "214";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Electric Hive")
                        {
                            data["9"]["SkinID"] = "227";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Pit Viper")
                        {
                            data["9"]["SkinID"] = "251";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Asiimov")
                        {
                            data["9"]["SkinID"] = "279";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Worm God")
                        {
                            data["9"]["SkinID"] = "424";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Medusa")
                        {
                            data["9"]["SkinID"] = "446";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Sun in Leo")
                        {
                            data["9"]["SkinID"] = "451";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (awpselectskincheckbox.SelectedItem.ToString() == "Hyper Beast")
                        {
                            data["9"]["SkinID"] = "475";
                            parser.WriteFile(label1.Text, data);
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
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Black Laminate")
                        {
                            data["7"]["SkinID"] = "172";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Blue Laminate")
                        {
                            data["7"]["SkinID"] = "226";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Cartel")
                        {
                            data["7"]["SkinID"] = "394";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Case Hardened")
                        {
                            data["7"]["SkinID"] = "44";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["7"]["SkinID"] = "22";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Elite Build")
                        {
                            data["7"]["SkinID"] = "422";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Emerald Pinstripe")
                        {
                            data["7"]["SkinID"] = "300";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Fire Serpent")
                        {
                            data["7"]["SkinID"] = "180";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "First Class")
                        {
                            data["7"]["SkinID"] = "341";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Frontside Misty")
                        {
                            data["7"]["SkinID"] = "490";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Fuel Injector")
                        {
                            data["7"]["SkinID"] = "524";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Hydroponic")
                        {
                            data["7"]["SkinID"] = "456";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Jaguar")
                        {
                            data["7"]["SkinID"] = "316";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Jet Set")
                        {
                            data["7"]["SkinID"] = "340";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Jungle Spray")
                        {
                            data["7"]["SkinID"] = "122";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Neon Revolution")
                        {
                            data["7"]["SkinID"] = "600";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Point Disarray")
                        {
                            data["7"]["SkinID"] = "506";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Predator")
                        {
                            data["7"]["SkinID"] = "170";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Red Laminate")
                        {
                            data["7"]["SkinID"] = "14";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Redline")
                        {
                            data["7"]["SkinID"] = "282";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Safari Mesh")
                        {
                            data["7"]["SkinID"] = "72";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Vulcan")
                        {
                            data["7"]["SkinID"] = "302";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (ak47skinselectioncombobox.SelectedItem.ToString() == "Wasteland Rebel")
                        {
                            data["7"]["SkinID"] = "380";
                            parser.WriteFile(label1.Text, data);
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
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Bronze Deco")
                        {
                            data["1"]["SkinID"] = "425";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Cobalt Disruption")
                        {
                            data["1"]["SkinID"] = "231";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Conspiracy")
                        {
                            data["1"]["SkinID"] = "351";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Corinthian")
                        {
                            data["1"]["SkinID"] = "509";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Crimson Web")
                        {
                            data["1"]["SkinID"] = "232";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Directive")
                        {
                            data["1"]["SkinID"] = "603";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["1"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Golden Koi")
                        {
                            data["1"]["SkinID"] = "185";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Hand Cannon")
                        {
                            data["1"]["SkinID"] = "328";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Heirloom")
                        {
                            data["1"]["SkinID"] = "273";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Hypnotic")
                        {
                            data["1"]["SkinID"] = "61";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Kumicho Dragon")
                        {
                            data["1"]["SkinID"] = "527";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Meteorite")
                        {
                            data["1"]["SkinID"] = "296";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Midnight Storm")
                        {
                            data["1"]["SkinID"] = "468";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Mudder")
                        {
                            data["1"]["SkinID"] = "90";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Naga")
                        {
                            data["1"]["SkinID"] = "397";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Night")
                        {
                            data["1"]["SkinID"] = "40";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Pilot")
                        {
                            data["1"]["SkinID"] = "347";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Sunset Storm 1")
                        {
                            data["1"]["SkinID"] = "469";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Sunset Storm 2")
                        {
                            data["1"]["SkinID"] = "470";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Urban DDPAT")
                        {
                            data["1"]["SkinID"] = "17";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "Urban Rubble")
                        {
                            data["1"]["SkinID"] = "237";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (deagleselectskincheckbox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["1"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
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
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Anodized Navy 1")
                        {
                            data["8"]["SkinID"] = "28";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Anodized Navy 2")
                        {
                            data["8"]["SkinID"] = "197";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Aristocrat")
                        {
                            data["8"]["SkinID"] = "583";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Asterion")
                        {
                            data["8"]["SkinID"] = "442";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Bengal Tiger")
                        {
                            data["8"]["SkinID"] = "9";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Chameleon")
                        {
                            data["8"]["SkinID"] = "280";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Colony")
                        {
                            data["8"]["SkinID"] = "47";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Condemned")
                        {
                            data["8"]["SkinID"] = "110";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Contractor")
                        {
                            data["8"]["SkinID"] = "46";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Copperhead")
                        {
                            data["8"]["SkinID"] = "10";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Daedalus")
                        {
                            data["8"]["SkinID"] = "444";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Fleet Flock")
                        {
                            data["8"]["SkinID"] = "541";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Hot Rod")
                        {
                            data["8"]["SkinID"] = "33";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Radiation Hazard 1")
                        {
                            data["8"]["SkinID"] = "167";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Radiation Hazard 2")
                        {
                            data["8"]["SkinID"] = "375";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Ricochet")
                        {
                            data["8"]["SkinID"] = "507";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Storm")
                        {
                            data["8"]["SkinID"] = "100";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Syd Mead")
                        {
                            data["8"]["SkinID"] = "601";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Torque")
                        {
                            data["8"]["SkinID"] = "305";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (augskinselectioncheckbox.SelectedItem.ToString() == "Wings")
                        {
                            data["8"]["SkinID"] = "73";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion AUG

                #region GLOCK

                if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
                    if (selectskinglockcombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Blue Fissure")
                        {
                            data["4"]["SkinID"] = "278";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Brass")
                        {
                            data["4"]["SkinID"] = "159";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Bunsen Burner")
                        {
                            data["4"]["SkinID"] = "479";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Candy Apple")
                        {
                            data["4"]["SkinID"] = "3";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Catacombs")
                        {
                            data["4"]["SkinID"] = "399";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Death Rattle")
                        {
                            data["4"]["SkinID"] = "293";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Dragon Tattoo")
                        {
                            data["4"]["SkinID"] = "48";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Fade")
                        {
                            data["4"]["SkinID"] = "38";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Grinder")
                        {
                            data["4"]["SkinID"] = "381";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Groundwater")
                        {
                            data["4"]["SkinID"] = "2";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Night")
                        {
                            data["4"]["SkinID"] = "40";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Reactor")
                        {
                            data["4"]["SkinID"] = "367";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Royal Legion")
                        {
                            data["4"]["SkinID"] = "532";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Sand Dune1")
                        {
                            data["4"]["SkinID"] = "99";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Sand Dune2")
                        {
                            data["4"]["SkinID"] = "208";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Steel Disruption")
                        {
                            data["4"]["SkinID"] = "230";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Twilight Galaxy")
                        {
                            data["4"]["SkinID"] = "437";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Wasteland Rebel")
                        {
                            data["4"]["SkinID"] = "586";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Water Elemental")
                        {
                            data["4"]["SkinID"] = "353";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinglockcombobox.SelectedItem.ToString() == "Weasel")
                        {
                            data["4"]["SkinID"] = "607";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion GLOCK

                #region FIVESEVEN

                if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
                    if (selectskinfivesevencheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Anodized Gunmetal")
                        {
                            data["3"]["SkinID"] = "210";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Bone Mask")
                        {
                            data["3"]["SkinID"] = "27";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Candy Apple")
                        {
                            data["3"]["SkinID"] = "3";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Case Hardened")
                        {
                            data["3"]["SkinID"] = "44";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Contractor")
                        {
                            data["3"]["SkinID"] = "46";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Copper Galaxy")
                        {
                            data["3"]["SkinID"] = "274";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Forest Night")
                        {
                            data["3"]["SkinID"] = "78";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Fowl Play")
                        {
                            data["3"]["SkinID"] = "352";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Hot Shot")
                        {
                            data["3"]["SkinID"] = "377";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Jungle")
                        {
                            data["3"]["SkinID"] = "205";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Kami")
                        {
                            data["3"]["SkinID"] = "265";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Monkey Business")
                        {
                            data["3"]["SkinID"] = "427";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Neon Kimono")
                        {
                            data["3"]["SkinID"] = "464";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Nightshade")
                        {
                            data["3"]["SkinID"] = "223";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Nitro")
                        {
                            data["3"]["SkinID"] = "322";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Orange Peel")
                        {
                            data["3"]["SkinID"] = "141";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Red Quartz")
                        {
                            data["3"]["SkinID"] = "248";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Retrobution")
                        {
                            data["3"]["SkinID"] = "510";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Scumbria")
                        {
                            data["3"]["SkinID"] = "605";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Silver Quartz")
                        {
                            data["3"]["SkinID"] = "252";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Triumvirate")
                        {
                            data["3"]["SkinID"] = "530";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Urban Hazard")
                        {
                            data["3"]["SkinID"] = "387";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinfivesevencheckbox.SelectedItem.ToString() == "Violent Daimyo")
                        {
                            data["3"]["SkinID"] = "585";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion FIVESEVEN

                #region DUAL BERETTAS

                if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
                    if (dualberettasselectskincheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Anodized Navy")
                        {
                            data["2"]["SkinID"] = "28";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Black Limba")
                        {
                            data["2"]["SkinID"] = "190";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Briar")
                        {
                            data["2"]["SkinID"] = "330";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Cobalt Quartz")
                        {
                            data["2"]["SkinID"] = "249";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Colony")
                        {
                            data["2"]["SkinID"] = "47";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Contractor")
                        {
                            data["2"]["SkinID"] = "46";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Demolition")
                        {
                            data["2"]["SkinID"] = "153";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Dualing Dragons")
                        {
                            data["2"]["SkinID"] = "491";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Duelist")
                        {
                            data["2"]["SkinID"] = "447";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Hemoglobin")
                        {
                            data["2"]["SkinID"] = "220";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Marina")
                        {
                            data["2"]["SkinID"] = "261";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Moon in Libra")
                        {
                            data["2"]["SkinID"] = "450";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Ossified")
                        {
                            data["2"]["SkinID"] = "36";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Panther")
                        {
                            data["2"]["SkinID"] = "276";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Red Quartz")
                        {
                            data["2"]["SkinID"] = "248";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Retribution")
                        {
                            data["2"]["SkinID"] = "307";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Stained")
                        {
                            data["2"]["SkinID"] = "43";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Urban Shock")
                        {
                            data["2"]["SkinID"] = "396";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (dualberettasselectskincheckbox.SelectedItem.ToString() == "Ventilators")
                        {
                            data["2"]["SkinID"] = "544";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion DUAL BERETTAS

                #region FAMAS

                if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
                    if (famasselectskincombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (famasselectskincombobox.SelectedItem.ToString() == "Afterimage")
                        {
                            data["10"]["SkinID"] = "154";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Colony")
                        {
                            data["10"]["SkinID"] = "47";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["10"]["SkinID"] = "22";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Cyanospatter")
                        {
                            data["10"]["SkinID"] = "92";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Djinn")
                        {
                            data["10"]["SkinID"] = "429";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Doomkitty")
                        {
                            data["10"]["SkinID"] = "178";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Hexane")
                        {
                            data["10"]["SkinID"] = "218";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Neural Net")
                        {
                            data["10"]["SkinID"] = "477";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Pulse")
                        {
                            data["10"]["SkinID"] = "260";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Roll Cage")
                        {
                            data["10"]["SkinID"] = "604";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Sergeant")
                        {
                            data["10"]["SkinID"] = "288";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Spitfire")
                        {
                            data["10"]["SkinID"] = "194";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Styx")
                        {
                            data["10"]["SkinID"] = "371";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Survivor Z")
                        {
                            data["10"]["SkinID"] = "492";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Teardown")
                        {
                            data["10"]["SkinID"] = "244";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (famasselectskincombobox.SelectedItem.ToString() == "Valence")
                        {
                            data["10"]["SkinID"] = "426";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion FAMAS

                #region G3SG1

                if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
                    if (selectsking3sg1combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Arctic Camo")
                        {
                            data["11"]["SkinID"] = "6";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Azure Zebra")
                        {
                            data["11"]["SkinID"] = "229";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Bone Mask")
                        {
                            data["11"]["SkinID"] = "27";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Chronos")
                        {
                            data["11"]["SkinID"] = "438";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Contractor")
                        {
                            data["11"]["SkinID"] = "46";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Demeter")
                        {
                            data["11"]["SkinID"] = "195";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Desert Storm")
                        {
                            data["11"]["SkinID"] = "8";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Flux")
                        {
                            data["11"]["SkinID"] = "493";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Green Apple")
                        {
                            data["11"]["SkinID"] = "294";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Jungle Dashed")
                        {
                            data["11"]["SkinID"] = "147";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Murky")
                        {
                            data["11"]["SkinID"] = "382";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Neon Kimono")
                        {
                            data["11"]["SkinID"] = "464";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Orange Crash")
                        {
                            data["11"]["SkinID"] = "545";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Orange Kimono")
                        {
                            data["11"]["SkinID"] = "465";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Polar Camo")
                        {
                            data["11"]["SkinID"] = "74";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Predator")
                        {
                            data["11"]["SkinID"] = "170";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Safari Mesh")
                        {
                            data["11"]["SkinID"] = "72";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "The Executioner")
                        {
                            data["11"]["SkinID"] = "511";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["11"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectsking3sg1combobox.SelectedItem.ToString() == "Ventilator")
                        {
                            data["11"]["SkinID"] = "606";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion G3SG1

                #region GALILAR

                if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
                    if (selectskingalilarcombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Aqua Terrace")
                        {
                            data["13"]["SkinID"] = "460";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Blue Titanium")
                        {
                            data["13"]["SkinID"] = "216";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Cerberus")
                        {
                            data["13"]["SkinID"] = "379";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Chatterbox")
                        {
                            data["13"]["SkinID"] = "398";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["13"]["SkinID"] = "22";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Eco")
                        {
                            data["13"]["SkinID"] = "428";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Firefight")
                        {
                            data["13"]["SkinID"] = "546";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["13"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Hunting Blind")
                        {
                            data["13"]["SkinID"] = "241";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Kami")
                        {
                            data["13"]["SkinID"] = "308";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Orange DDPAT")
                        {
                            data["13"]["SkinID"] = "83";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Rocket Pop")
                        {
                            data["13"]["SkinID"] = "478";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Sage Spray")
                        {
                            data["13"]["SkinID"] = "119";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Sandstorm")
                        {
                            data["13"]["SkinID"] = "264";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Shattered")
                        {
                            data["13"]["SkinID"] = "192";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Stone Cold")
                        {
                            data["13"]["SkinID"] = "494";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Tuxedo")
                        {
                            data["13"]["SkinID"] = "297";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Urban Rubble")
                        {
                            data["13"]["SkinID"] = "237";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["13"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskingalilarcombobox.SelectedItem.ToString() == "Winter Forest")
                        {
                            data["13"]["SkinID"] = "76";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion GALILAR

                #region M249

                if (choseweaponcombobox.SelectedItem.ToString() == "M249")
                    if (selectskinm249combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinm249combobox.SelectedItem.ToString() == "Blizzard Marbleized")
                        {
                            data["14"]["SkinID"] = "75";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["14"]["SkinID"] = "22";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Gator Mesh")
                        {
                            data["14"]["SkinID"] = "243";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Impact Drill")
                        {
                            data["14"]["SkinID"] = "472";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Jungle DDPAT")
                        {
                            data["14"]["SkinID"] = "202";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Magma")
                        {
                            data["14"]["SkinID"] = "266";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Nebula Crusader")
                        {
                            data["14"]["SkinID"] = "496";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Shipping Forecast")
                        {
                            data["14"]["SkinID"] = "452";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "Spectre")
                        {
                            data["14"]["SkinID"] = "547";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm249combobox.SelectedItem.ToString() == "System Lock")
                        {
                            data["14"]["SkinID"] = "401";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion M249

                #region M4A4

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
                    if (selectskinm4a4combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Asiimov")
                        {
                            data["16"]["SkinID"] = "255";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Bullet Rain")
                        {
                            data["16"]["SkinID"] = "155";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Daybreak")
                        {
                            data["16"]["SkinID"] = "471";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Desert-Strike")
                        {
                            data["16"]["SkinID"] = "355";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Desert Storm")
                        {
                            data["16"]["SkinID"] = "8";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Desolate Space")
                        {
                            data["16"]["SkinID"] = "588";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Dragon King")
                        {
                            data["16"]["SkinID"] = "400";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Evil Daimyo")
                        {
                            data["16"]["SkinID"] = "480";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Faded Zebra")
                        {
                            data["16"]["SkinID"] = "176";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["16"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Griffin")
                        {
                            data["16"]["SkinID"] = "384";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Howl")
                        {
                            data["16"]["SkinID"] = "309";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Jungle Tiger")
                        {
                            data["16"]["SkinID"] = "16";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Modern Hunter")
                        {
                            data["16"]["SkinID"] = "164";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Poseidon")
                        {
                            data["16"]["SkinID"] = "449";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Predator")
                        {
                            data["16"]["SkinID"] = "170";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Radiation Hazard")
                        {
                            data["16"]["SkinID"] = "375";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Royal Paladin")
                        {
                            data["16"]["SkinID"] = "512";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "The Battlestar")
                        {
                            data["16"]["SkinID"] = "533";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Tornado")
                        {
                            data["16"]["SkinID"] = "101";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Urban DDPAT")
                        {
                            data["16"]["SkinID"] = "17";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "X-Ray")
                        {
                            data["16"]["SkinID"] = "215";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinm4a4combobox.SelectedItem.ToString() == "Zirka")
                        {
                            data["16"]["SkinID"] = "187";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion M4A4

                #region MAC10

                if (choseweaponcombobox.SelectedItem.ToString() == "MAC-10")
                    if (selectskinmac10combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Amber Fade")
                        {
                            data["17"]["SkinID"] = "246";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Candy Apple")
                        {
                            data["17"]["SkinID"] = "3";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Carnivore")
                        {
                            data["17"]["SkinID"] = "589";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Commuter")
                        {
                            data["17"]["SkinID"] = "343";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Curse")
                        {
                            data["17"]["SkinID"] = "310";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Fade")
                        {
                            data["17"]["SkinID"] = "38";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["17"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Graven")
                        {
                            data["17"]["SkinID"] = "188";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Heat")
                        {
                            data["17"]["SkinID"] = "284";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Indigo")
                        {
                            data["17"]["SkinID"] = "333";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Lapis Gator")
                        {
                            data["17"]["SkinID"] = "534";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Malachite")
                        {
                            data["17"]["SkinID"] = "402";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Neon Rider")
                        {
                            data["17"]["SkinID"] = "433";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Nuclear Garden")
                        {
                            data["17"]["SkinID"] = "372";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Palm")
                        {
                            data["17"]["SkinID"] = "201";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Rangeen")
                        {
                            data["17"]["SkinID"] = "498";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Silver")
                        {
                            data["17"]["SkinID"] = "32";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Tatter")
                        {
                            data["17"]["SkinID"] = "337";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Tornado")
                        {
                            data["17"]["SkinID"] = "101";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Ultraviolet")
                        {
                            data["17"]["SkinID"] = "98";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmac10combobox.SelectedItem.ToString() == "Urban DDPAT")
                        {
                            data["17"]["SkinID"] = "17";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion MAC10

                #region P90

                if (choseweaponcombobox.SelectedItem.ToString() == "P90")
                    if (selectskinp90combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinp90combobox.SelectedItem.ToString() == "Ash Wood")
                        {
                            data["19"]["SkinID"] = "234";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Asiimov")
                        {
                            data["19"]["SkinID"] = "359";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Blind Spot")
                        {
                            data["19"]["SkinID"] = "228";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Chopper")
                        {
                            data["19"]["SkinID"] = "593";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Cold Blooded")
                        {
                            data["19"]["SkinID"] = "67";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["19"]["SkinID"] = "22";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Death by Kitty")
                        {
                            data["19"]["SkinID"] = "156";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Desert Warfare")
                        {
                            data["19"]["SkinID"] = "311";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Elite Build")
                        {
                            data["19"]["SkinID"] = "486";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Emerald Dragon")
                        {
                            data["19"]["SkinID"] = "182";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Fallout Warning")
                        {
                            data["19"]["SkinID"] = "378";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Glacier Mesh")
                        {
                            data["19"]["SkinID"] = "111";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Grim")
                        {
                            data["19"]["SkinID"] = "611";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Leather")
                        {
                            data["19"]["SkinID"] = "342";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Module")
                        {
                            data["19"]["SkinID"] = "335";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Sand Spray")
                        {
                            data["19"]["SkinID"] = "124";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Scorched")
                        {
                            data["19"]["SkinID"] = "175";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Shapewood")
                        {
                            data["19"]["SkinID"] = "516";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Storm")
                        {
                            data["19"]["SkinID"] = "100";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Teardown")
                        {
                            data["19"]["SkinID"] = "244";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Trigon")
                        {
                            data["19"]["SkinID"] = "283";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp90combobox.SelectedItem.ToString() == "Virus")
                        {
                            data["19"]["SkinID"] = "20";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion P90

                #region UMP45

                if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
                    if (selectskinump45combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinump45combobox.SelectedItem.ToString() == "Blaze")
                        {
                            data["24"]["SkinID"] = "37";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Bone Pile")
                        {
                            data["24"]["SkinID"] = "193";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Briefing")
                        {
                            data["24"]["SkinID"] = "615";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Caramel")
                        {
                            data["24"]["SkinID"] = "93";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Carbon Fiber")
                        {
                            data["24"]["SkinID"] = "70";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Corporal")
                        {
                            data["24"]["SkinID"] = "281";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Delusion")
                        {
                            data["24"]["SkinID"] = "392";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Fallout Warning")
                        {
                            data["24"]["SkinID"] = "378";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["24"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Grand Prix")
                        {
                            data["24"]["SkinID"] = "436";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Gunsmoke")
                        {
                            data["24"]["SkinID"] = "15";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Indigo")
                        {
                            data["24"]["SkinID"] = "333";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Labyrinth")
                        {
                            data["24"]["SkinID"] = "362";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Minotaur\'s Labyrinth")
                        {
                            data["24"]["SkinID"] = "441";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Primal Saber")
                        {
                            data["24"]["SkinID"] = "556";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Riot")
                        {
                            data["24"]["SkinID"] = "488";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Scorched")
                        {
                            data["24"]["SkinID"] = "175";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinump45combobox.SelectedItem.ToString() == "Urban DDPAT")
                        {
                            data["24"]["SkinID"] = "17";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion UMP45

                #region XM1014

                if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
                    if (selectskinxm1014combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Black Tie")
                        {
                            data["25"]["SkinID"] = "557";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Blaze Orange")
                        {
                            data["25"]["SkinID"] = "166";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Blue Spruce")
                        {
                            data["25"]["SkinID"] = "96";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Blue Steel")
                        {
                            data["25"]["SkinID"] = "42";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Bone Machine")
                        {
                            data["25"]["SkinID"] = "370";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Bone Mask")
                        {
                            data["25"]["SkinID"] = "27";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "CaliCamo")
                        {
                            data["25"]["SkinID"] = "240";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Fallout Warning")
                        {
                            data["25"]["SkinID"] = "378";
                            parser.WriteFile(label1.Text, data);
                        }

                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Grassland")
                        {
                            data["25"]["SkinID"] = "95";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Heaven Guard")
                        {
                            data["25"]["SkinID"] = "314";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Jungle 1")
                        {
                            data["25"]["SkinID"] = "151";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Jungle 2")
                        {
                            data["25"]["SkinID"] = "205";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Pit Viper")
                        {
                            data["25"]["SkinID"] = "251";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Quicksilver")
                        {
                            data["25"]["SkinID"] = "407";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Red Leather")
                        {
                            data["25"]["SkinID"] = "348";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Red Python")
                        {
                            data["25"]["SkinID"] = "320";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Scumbria")
                        {
                            data["25"]["SkinID"] = "505";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Slipstream")
                        {
                            data["25"]["SkinID"] = "616";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Teclu Burner")
                        {
                            data["25"]["SkinID"] = "521";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Tranquility")
                        {
                            data["25"]["SkinID"] = "393";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "Urban Perforated")
                        {
                            data["25"]["SkinID"] = "135";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["25"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinxm1014combobox.SelectedItem.ToString() == "VariCamo Blue")
                        {
                            data["25"]["SkinID"] = "238";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion XM1014

                #region BIZON

                if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
                    if (bizonskinselectcheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Antique")
                        {
                            data["26"]["SkinID"] = "306";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Bamboo Forest")
                        {
                            data["26"]["SkinID"] = "459";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Bamboo Print")
                        {
                            data["26"]["SkinID"] = "457";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Blue Streak")
                        {
                            data["26"]["SkinID"] = "13";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Bone Mask")
                        {
                            data["26"]["SkinID"] = "27";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Brass")
                        {
                            data["26"]["SkinID"] = "159";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Carbon Fiber")
                        {
                            data["26"]["SkinID"] = "70";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Chemical Green")
                        {
                            data["26"]["SkinID"] = "376";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Cobalt Halftone")
                        {
                            data["26"]["SkinID"] = "267";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Forest Leaves")
                        {
                            data["26"]["SkinID"] = "25";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Fuel Rod")
                        {
                            data["26"]["SkinID"] = "508";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Harvester")
                        {
                            data["26"]["SkinID"] = "594";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Irradiated Alert")
                        {
                            data["26"]["SkinID"] = "171";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Judgement of Anubis")
                        {
                            data["26"]["SkinID"] = "542";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Modern Hunter")
                        {
                            data["26"]["SkinID"] = "164";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Night Ops")
                        {
                            data["26"]["SkinID"] = "236";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Osiris")
                        {
                            data["26"]["SkinID"] = "349";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Photic Zone")
                        {
                            data["26"]["SkinID"] = "526";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Rust Coat 1")
                        {
                            data["26"]["SkinID"] = "203";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Rust Coat 2")
                        {
                            data["26"]["SkinID"] = "323";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Sand Dashed")
                        {
                            data["26"]["SkinID"] = "148";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Urban Dashed")
                        {
                            data["26"]["SkinID"] = "149";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["26"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (bizonskinselectcheckbox.SelectedItem.ToString() == "Water Sigil")
                        {
                            data["26"]["SkinID"] = "224";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion BIZON

                #region MAG7

                if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
                    if (selectskinmag7combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Bulldozer")
                        {
                            data["27"]["SkinID"] = "39";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Cobalt Core")
                        {
                            data["27"]["SkinID"] = "499";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Counter Terrace")
                        {
                            data["27"]["SkinID"] = "462";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Firestarter")
                        {
                            data["27"]["SkinID"] = "385";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Hazard")
                        {
                            data["27"]["SkinID"] = "198";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Heat")
                        {
                            data["27"]["SkinID"] = "431";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Heaven Guard")
                        {
                            data["27"]["SkinID"] = "291";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Irradiated Alert")
                        {
                            data["27"]["SkinID"] = "171";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Memento")
                        {
                            data["27"]["SkinID"] = "177";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Metallic DDPAT")
                        {
                            data["27"]["SkinID"] = "34";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Petroglyph")
                        {
                            data["27"]["SkinID"] = "608";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Praetorian")
                        {
                            data["27"]["SkinID"] = "535";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Sand Dune")
                        {
                            data["27"]["SkinID"] = "99";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Seabird")
                        {
                            data["27"]["SkinID"] = "473";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Silver")
                        {
                            data["27"]["SkinID"] = "32";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinmag7combobox.SelectedItem.ToString() == "Storm")
                        {
                            data["27"]["SkinID"] = "100";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion MAG7

                #region NEGEV

                if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
                    if (selectskinnegevcombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Anodized Navy")
                        {
                            data["28"]["SkinID"] = "28";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Army Sheen")
                        {
                            data["28"]["SkinID"] = "298";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Bratatat")
                        {
                            data["28"]["SkinID"] = "317";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "CaliCamo")
                        {
                            data["28"]["SkinID"] = "240";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Dazzle")
                        {
                            data["28"]["SkinID"] = "610";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Desert-Strike")
                        {
                            data["28"]["SkinID"] = "355";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Loudmouth")
                        {
                            data["28"]["SkinID"] = "483";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Man-o\'-war")
                        {
                            data["28"]["SkinID"] = "432";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Nuclear Waste")
                        {
                            data["28"]["SkinID"] = "369";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Palm 1")
                        {
                            data["28"]["SkinID"] = "157";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Palm 2")
                        {
                            data["28"]["SkinID"] = "201";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Power Loader")
                        {
                            data["28"]["SkinID"] = "514";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "Terrain")
                        {
                            data["28"]["SkinID"] = "285";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinnegevcombobox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["28"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion NEGEV

                #region SAWEDOFF

                if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
                    if (selectskinsawedoffcombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Amber Fade")
                        {
                            data["29"]["SkinID"] = "246";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Bamboo Forest")
                        {
                            data["29"]["SkinID"] = "459";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Bamboo Shadow")
                        {
                            data["29"]["SkinID"] = "458";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Contrast Spray")
                        {
                            data["29"]["SkinID"] = "22";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Copper")
                        {
                            data["29"]["SkinID"] = "41";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Fade")
                        {
                            data["29"]["SkinID"] = "38";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "First Class")
                        {
                            data["29"]["SkinID"] = "345";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["29"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Fubar")
                        {
                            data["29"]["SkinID"] = "552";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Full Stop")
                        {
                            data["29"]["SkinID"] = "250";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Highwayman")
                        {
                            data["29"]["SkinID"] = "390";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Irradiated Alert")
                        {
                            data["29"]["SkinID"] = "171";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Limelight")
                        {
                            data["29"]["SkinID"] = "596";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Mosaico")
                        {
                            data["29"]["SkinID"] = "204";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Orange DDPAT")
                        {
                            data["29"]["SkinID"] = "83";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Origami")
                        {
                            data["29"]["SkinID"] = "434";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Rust Coat")
                        {
                            data["29"]["SkinID"] = "203";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Sage Spray")
                        {
                            data["29"]["SkinID"] = "119";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Serenity")
                        {
                            data["29"]["SkinID"] = "405";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Snake Camo")
                        {
                            data["29"]["SkinID"] = "30";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "The Kraken")
                        {
                            data["29"]["SkinID"] = "256";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["29"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinsawedoffcombobox.SelectedItem.ToString() == "Yorick")
                        {
                            data["29"]["SkinID"] = "517";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion SAWEDOFF

                #region TEC9

                if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
                    if (selectskintec9combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskintec9combobox.SelectedItem.ToString() == "Army Mesh")
                        {
                            data["30"]["SkinID"] = "242";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Avalanche")
                        {
                            data["30"]["SkinID"] = "520";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Bamboo Forest")
                        {
                            data["30"]["SkinID"] = "459";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Blue Titanium")
                        {
                            data["30"]["SkinID"] = "216";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Brass")
                        {
                            data["30"]["SkinID"] = "159";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Forest DDPAT")
                        {
                            data["30"]["SkinID"] = "5";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Fuel Injector")
                        {
                            data["30"]["SkinID"] = "614";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Groundwater")
                        {
                            data["30"]["SkinID"] = "2";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Hades")
                        {
                            data["30"]["SkinID"] = "439";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Ice Cap")
                        {
                            data["30"]["SkinID"] = "599";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Isaac")
                        {
                            data["30"]["SkinID"] = "303";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Jambiya")
                        {
                            data["30"]["SkinID"] = "539";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Nuclear Threat")
                        {
                            data["30"]["SkinID"] = "179";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Ossified")
                        {
                            data["30"]["SkinID"] = "36";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Re-Entry")
                        {
                            data["30"]["SkinID"] = "555";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Red Quartz")
                        {
                            data["30"]["SkinID"] = "248";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Sandstorm")
                        {
                            data["30"]["SkinID"] = "289";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Terrace")
                        {
                            data["30"]["SkinID"] = "463";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Titanium Bit")
                        {
                            data["30"]["SkinID"] = "272";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Tornado 1")
                        {
                            data["30"]["SkinID"] = "101";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Tornado 2")
                        {
                            data["30"]["SkinID"] = "206";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Toxic")
                        {
                            data["30"]["SkinID"] = "374";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "Urban DDPAT")
                        {
                            data["30"]["SkinID"] = "17";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskintec9combobox.SelectedItem.ToString() == "VariCamo")
                        {
                            data["30"]["SkinID"] = "235";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion TEC9

                #region P2000

                if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
                    if (selectskinp2000combobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Amber Fade")
                        {
                            data["32"]["SkinID"] = "246";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Asterion")
                        {
                            data["32"]["SkinID"] = "442";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Chainmail")
                        {
                            data["32"]["SkinID"] = "327";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Coach Class")
                        {
                            data["32"]["SkinID"] = "346";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Corticera")
                        {
                            data["32"]["SkinID"] = "184";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Fade")
                        {
                            data["32"]["SkinID"] = "38";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Fire Elemental")
                        {
                            data["32"]["SkinID"] = "389";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Forest Leaves")
                        {
                            data["32"]["SkinID"] = "25";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Granite Marbleized")
                        {
                            data["32"]["SkinID"] = "21";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Grassland")
                        {
                            data["32"]["SkinID"] = "95";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Grassland Leaves")
                        {
                            data["32"]["SkinID"] = "104";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Handgun")
                        {
                            data["32"]["SkinID"] = "485";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Imperial Dragon")
                        {
                            data["32"]["SkinID"] = "591";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Ivory")
                        {
                            data["32"]["SkinID"] = "357";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Ocean Foam")
                        {
                            data["32"]["SkinID"] = "211";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Oceanic")
                        {
                            data["32"]["SkinID"] = "550";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Ossified")
                        {
                            data["32"]["SkinID"] = "36";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Pathfinder")
                        {
                            data["32"]["SkinID"] = "443";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Pulse")
                        {
                            data["32"]["SkinID"] = "338";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Red FragCam")
                        {
                            data["32"]["SkinID"] = "275";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Scorpion")
                        {
                            data["32"]["SkinID"] = "71";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinp2000combobox.SelectedItem.ToString() == "Silver")
                        {
                            data["32"]["SkinID"] = "32";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion P2000

                #region R8-REVOLVER

                if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
                    if (selectskinr9revolvercombobox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (selectskinr9revolvercombobox.SelectedItem.ToString() == "Amber Fade")
                        {
                            data["64"]["SkinID"] = "523";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinr9revolvercombobox.SelectedItem.ToString() == "Bone Mask")
                        {
                            data["64"]["SkinID"] = "27";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinr9revolvercombobox.SelectedItem.ToString() == "Crimson Web")
                        {
                            data["64"]["SkinID"] = "232";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinr9revolvercombobox.SelectedItem.ToString() == "Fade")
                        {
                            data["64"]["SkinID"] = "522";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (selectskinr9revolvercombobox.SelectedItem.ToString() == "Reboot")
                        {
                            data["64"]["SkinID"] = "595";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion R8-REVOLVER

                #region CZ75A

                if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
                    if (czselectskincheckbox.SelectedItem == null)
                    {
                        MetroMessageBox.Show(this, "Please Select a Skin and try again!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (czselectskincheckbox.SelectedItem.ToString() == "Chalice")
                        {
                            data["63"]["SkinID"] = "325";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Crimson Web")
                        {
                            data["63"]["SkinID"] = "12";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Emerald")
                        {
                            data["63"]["SkinID"] = "453";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Green Plaid")
                        {
                            data["63"]["SkinID"] = "366";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Hexane")
                        {
                            data["63"]["SkinID"] = "218";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Imprint")
                        {
                            data["63"]["SkinID"] = "602";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Nitro 1")
                        {
                            data["63"]["SkinID"] = "254";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Nitro 2")
                        {
                            data["63"]["SkinID"] = "322";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Poison Dart")
                        {
                            data["63"]["SkinID"] = "315";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Pole Position")
                        {
                            data["63"]["SkinID"] = "435";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Red Astor")
                        {
                            data["63"]["SkinID"] = "543";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "The Fuschia Is Now")
                        {
                            data["63"]["SkinID"] = "269";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Tigris")
                        {
                            data["63"]["SkinID"] = "350";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Tread Plate")
                        {
                            data["63"]["SkinID"] = "268";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Tuxedo")
                        {
                            data["63"]["SkinID"] = "297";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Twist")
                        {
                            data["63"]["SkinID"] = "334";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Victoria")
                        {
                            data["63"]["SkinID"] = "270";
                            parser.WriteFile(label1.Text, data);
                        }
                        if (czselectskincheckbox.SelectedItem.ToString() == "Yellow Jacket")
                        {
                            data["63"]["SkinID"] = "476";
                            parser.WriteFile(label1.Text, data);
                        }
                    }

                #endregion CZ75A

                MetroMessageBox.Show(this, "Skin for " + choseweaponcombobox.SelectedItem + " saved!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var fileIniData = new FileIniDataParser();
                var parsedData = fileIniData.ReadFile(label1.Text);
                SkinsTextbox.Text = parsedData.ToString();
            }
        }

        //Save Current Seed & Wear [FINISHED]
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(label1.Text);

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
                    parser.WriteFile(label1.Text, data);
                }

                #endregion AWP

                #region AK47

                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                {
                    data["7"]["SkinSeed"] = "0";
                    data["7"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion AK47

                #region DEAGLE

                if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
                {
                    data["1"]["SkinSeed"] = "0";
                    data["1"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion DEAGLE

                #region DUAL BERETTAS

                if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
                {
                    data["2"]["SkinSeed"] = "0";
                    data["2"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion DUAL BERETTAS

                #region FIVESEVEN

                if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
                {
                    data["3"]["SkinSeed"] = "0";
                    data["3"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FIVESEVEN

                #region GLOCK

                if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
                {
                    data["4"]["SkinSeed"] = "0";
                    data["4"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion GLOCK

                #region AUG

                if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
                {
                    data["8"]["SkinSeed"] = "0";
                    data["8"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion AUG

                #region FAMAS

                if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
                {
                    data["10"]["SkinSeed"] = "0";
                    data["10"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FAMAS

                #region G3SG1

                if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
                {
                    data["11"]["SkinSeed"] = "0";
                    data["11"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion G3SG1

                #region GALILAR

                if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
                {
                    data["13"]["SkinSeed"] = "0";
                    data["13"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion GALILAR

                #region M249

                if (choseweaponcombobox.SelectedItem.ToString() == "M249")
                {
                    data["14"]["SkinSeed"] = "0";
                    data["14"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M249

                #region M4A4

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
                {
                    data["16"]["SkinSeed"] = "0";
                    data["16"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M4A4

                #region MAC10

                if (choseweaponcombobox.SelectedItem.ToString() == "MAC10")
                {
                    data["17"]["SkinSeed"] = "0";
                    data["17"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MAC10

                #region P90

                if (choseweaponcombobox.SelectedItem.ToString() == "P90")
                {
                    data["19"]["SkinSeed"] = "0";
                    data["19"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion P90

                #region UMP45

                if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
                {
                    data["24"]["SkinSeed"] = "0";
                    data["24"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion UMP45

                #region XM1014

                if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
                {
                    data["25"]["SkinSeed"] = "0";
                    data["25"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion XM1014

                #region BIZON

                if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
                {
                    data["26"]["SkinSeed"] = "0";
                    data["26"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion BIZON

                #region MAG7

                if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
                {
                    data["27"]["SkinSeed"] = "0";
                    data["27"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MAG7

                #region NEGEV

                if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
                {
                    data["28"]["SkinSeed"] = "0";
                    data["28"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion NEGEV

                #region SAWEDOFF

                if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
                {
                    data["29"]["SkinSeed"] = "0";
                    data["29"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SAWEDOFF

                #region TEC9

                if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
                {
                    data["30"]["SkinSeed"] = "0";
                    data["30"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion TEC9

                #region P2000

                if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
                {
                    data["32"]["SkinSeed"] = "0";
                    data["32"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion P2000

                #region MP7

                if (choseweaponcombobox.SelectedItem.ToString() == "MP7")
                {
                    data["33"]["SkinSeed"] = "0";
                    data["33"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MP7

                #region MP9

                if (choseweaponcombobox.SelectedItem.ToString() == "MP9")
                {
                    data["34"]["SkinSeed"] = "0";
                    data["34"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MP9

                #region NOVA

                if (choseweaponcombobox.SelectedItem.ToString() == "NOVA")
                {
                    data["35"]["SkinSeed"] = "0";
                    data["35"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion NOVA

                #region P250

                if (choseweaponcombobox.SelectedItem.ToString() == "P250")
                {
                    data["36"]["SkinSeed"] = "0";
                    data["36"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion P250

                #region SCAR20

                if (choseweaponcombobox.SelectedItem.ToString() == "SCAR20")
                {
                    data["38"]["SkinSeed"] = "0";
                    data["38"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SCAR20

                #region SG556

                if (choseweaponcombobox.SelectedItem.ToString() == "SG556")
                {
                    data["39"]["SkinSeed"] = "0";
                    data["39"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SG556

                #region SSG08

                if (choseweaponcombobox.SelectedItem.ToString() == "SSG08")
                {
                    data["40"]["SkinSeed"] = "0";
                    data["40"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SSG08

                #region M4A1-S

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A1-S")
                {
                    data["60"]["SkinSeed"] = "0";
                    data["60"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M4A1-S

                #region USP-S

                if (choseweaponcombobox.SelectedItem.ToString() == "USP-S")
                {
                    data["61"]["SkinSeed"] = "0";
                    data["61"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion USP-S

                #region CZ75A

                if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
                {
                    data["63"]["SkinSeed"] = "0";
                    data["63"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion CZ75A

                #region R8-REVOLVER

                if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
                {
                    data["64"]["SkinSeed"] = "0";
                    data["64"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion R8-REVOLVER

                #region BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "BAYONET")
                {
                    data["500"]["SkinSeed"] = "0";
                    data["500"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion BAYONET

                #region FLIP

                if (choseweaponcombobox.SelectedItem.ToString() == "FLIP")
                {
                    data["505"]["SkinSeed"] = "0";
                    data["505"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FLIP

                #region GUT

                if (choseweaponcombobox.SelectedItem.ToString() == "GUT")
                {
                    data["506"]["SkinSeed"] = "0";
                    data["506"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion GUT

                #region KARAMBIT

                if (choseweaponcombobox.SelectedItem.ToString() == "KARAMBIT")
                {
                    data["507"]["SkinSeed"] = "0";
                    data["507"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion KARAMBIT

                #region M9 BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "M9 BAYONET")
                {
                    data["508"]["SkinSeed"] = "0";
                    data["508"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M9 BAYONET

                #region HUNTSMAN

                if (choseweaponcombobox.SelectedItem.ToString() == "HUNTSMAN")
                {
                    data["509"]["SkinSeed"] = "0";
                    data["509"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion HUNTSMAN

                #region FALCHION

                if (choseweaponcombobox.SelectedItem.ToString() == "FALCHION")
                {
                    data["512"]["SkinSeed"] = "0";
                    data["512"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FALCHION

                #region BOWIE

                if (choseweaponcombobox.SelectedItem.ToString() == "BOWIE")
                {
                    data["514"]["SkinSeed"] = "0";
                    data["514"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion BOWIE

                #region BUTTERFLY

                if (choseweaponcombobox.SelectedItem.ToString() == "BUTTERFLY")
                {
                    data["515"]["SkinSeed"] = "0";
                    data["515"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion BUTTERFLY

                #region SHADOW DAGGERS

                if (choseweaponcombobox.SelectedItem.ToString() == "SHADOW DAGGERS")
                {
                    data["516"]["SkinSeed"] = "0";
                    data["516"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
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
                    parser.WriteFile(label1.Text, data);
                }

                #endregion AWP

                #region AK47

                if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
                {
                    data["7"]["SkinSeed"] = skinseedtextbox.Text;
                    data["7"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion AK47

                #region DEAGLE

                if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
                {
                    data["1"]["SkinSeed"] = skinseedtextbox.Text;
                    data["1"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion DEAGLE

                #region DUAL BERETTAS

                if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
                {
                    data["2"]["SkinSeed"] = skinseedtextbox.Text;
                    data["2"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion DUAL BERETTAS

                #region FIVESEVEN

                if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
                {
                    data["3"]["SkinSeed"] = skinseedtextbox.Text;
                    data["3"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FIVESEVEN

                #region GLOCK

                if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
                {
                    data["4"]["SkinSeed"] = skinseedtextbox.Text;
                    data["4"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion GLOCK

                #region AUG

                if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
                {
                    data["8"]["SkinSeed"] = skinseedtextbox.Text;
                    data["8"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion AUG

                #region FAMAS

                if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
                {
                    data["10"]["SkinSeed"] = skinseedtextbox.Text;
                    data["10"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FAMAS

                #region G3SG1

                if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
                {
                    data["11"]["SkinSeed"] = skinseedtextbox.Text;
                    data["11"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion G3SG1

                #region GALILAR

                if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
                {
                    data["13"]["SkinSeed"] = skinseedtextbox.Text;
                    data["13"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion GALILAR

                #region M249

                if (choseweaponcombobox.SelectedItem.ToString() == "M249")
                {
                    data["14"]["SkinSeed"] = skinseedtextbox.Text;
                    data["14"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M249

                #region M4A4

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
                {
                    data["16"]["SkinSeed"] = skinseedtextbox.Text;
                    data["16"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M4A4

                #region MAC10

                if (choseweaponcombobox.SelectedItem.ToString() == "MAC10")
                {
                    data["17"]["SkinSeed"] = skinseedtextbox.Text;
                    data["17"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MAC10

                #region P90

                if (choseweaponcombobox.SelectedItem.ToString() == "P90")
                {
                    data["19"]["SkinSeed"] = skinseedtextbox.Text;
                    data["19"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion P90

                #region UMP45

                if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
                {
                    data["24"]["SkinSeed"] = skinseedtextbox.Text;
                    data["24"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion UMP45

                #region XM1014

                if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
                {
                    data["25"]["SkinSeed"] = skinseedtextbox.Text;
                    data["25"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion XM1014

                #region BIZON

                if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
                {
                    data["26"]["SkinSeed"] = skinseedtextbox.Text;
                    data["26"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion BIZON

                #region MAG7

                if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
                {
                    data["27"]["SkinSeed"] = skinseedtextbox.Text;
                    data["27"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MAG7

                #region NEGEV

                if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
                {
                    data["28"]["SkinSeed"] = skinseedtextbox.Text;
                    data["28"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion NEGEV

                #region SAWEDOFF

                if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
                {
                    data["29"]["SkinSeed"] = skinseedtextbox.Text;
                    data["29"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SAWEDOFF

                #region TEC9

                if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
                {
                    data["30"]["SkinSeed"] = skinseedtextbox.Text;
                    data["30"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion TEC9

                #region P2000

                if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
                {
                    data["32"]["SkinSeed"] = skinseedtextbox.Text;
                    data["32"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion P2000

                #region MP7

                if (choseweaponcombobox.SelectedItem.ToString() == "MP7")
                {
                    data["33"]["SkinSeed"] = skinseedtextbox.Text;
                    data["33"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MP7

                #region MP9

                if (choseweaponcombobox.SelectedItem.ToString() == "MP9")
                {
                    data["34"]["SkinSeed"] = skinseedtextbox.Text;
                    data["34"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion MP9

                #region NOVA

                if (choseweaponcombobox.SelectedItem.ToString() == "NOVA")
                {
                    data["35"]["SkinSeed"] = skinseedtextbox.Text;
                    data["35"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion NOVA

                #region P250

                if (choseweaponcombobox.SelectedItem.ToString() == "P250")
                {
                    data["36"]["SkinSeed"] = skinseedtextbox.Text;
                    data["36"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion P250

                #region SCAR20

                if (choseweaponcombobox.SelectedItem.ToString() == "SCAR20")
                {
                    data["38"]["SkinSeed"] = skinseedtextbox.Text;
                    data["38"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SCAR20

                #region SG556

                if (choseweaponcombobox.SelectedItem.ToString() == "SG556")
                {
                    data["39"]["SkinSeed"] = skinseedtextbox.Text;
                    data["39"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SG556

                #region SSG08

                if (choseweaponcombobox.SelectedItem.ToString() == "SSG08")
                {
                    data["40"]["SkinSeed"] = skinseedtextbox.Text;
                    data["40"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion SSG08

                #region M4A1-S

                if (choseweaponcombobox.SelectedItem.ToString() == "M4A1-S")
                {
                    data["60"]["SkinSeed"] = skinseedtextbox.Text;
                    data["60"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M4A1-S

                #region USP-S

                if (choseweaponcombobox.SelectedItem.ToString() == "USP-S")
                {
                    data["61"]["SkinSeed"] = skinseedtextbox.Text;
                    data["61"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion USP-S

                #region CZ75A

                if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
                {
                    data["63"]["SkinSeed"] = skinseedtextbox.Text;
                    data["63"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion CZ75A

                #region R8-REVOLVER

                if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
                {
                    data["64"]["SkinSeed"] = skinseedtextbox.Text;
                    data["64"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion R8-REVOLVER

                #region BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "BAYONET")
                {
                    data["500"]["SkinSeed"] = skinseedtextbox.Text;
                    data["500"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion BAYONET

                #region FLIP

                if (choseweaponcombobox.SelectedItem.ToString() == "FLIP")
                {
                    data["505"]["SkinSeed"] = skinseedtextbox.Text;
                    data["505"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion FLIP

                #region GUT

                if (choseweaponcombobox.SelectedItem.ToString() == "GUT")
                {
                    data["506"]["SkinSeed"] = skinseedtextbox.Text;
                    data["506"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion GUT

                #region KARAMBIT

                if (choseweaponcombobox.SelectedItem.ToString() == "KARAMBIT")
                {
                    data["507"]["SkinSeed"] = skinseedtextbox.Text;
                    data["507"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion KARAMBIT

                #region M9 BAYONET

                if (choseweaponcombobox.SelectedItem.ToString() == "M9 BAYONET")
                {
                    data["508"]["SkinSeed"] = skinseedtextbox.Text;
                    data["508"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                #endregion M9 BAYONET

                #region HUNTSMAN

                if (choseweaponcombobox.SelectedItem.ToString() == "HUNTSMAN")
                {
                    data["509"]["SkinSeed"] = skinseedtextbox.Text;
                    data["509"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                # endregion HUNTSMAN

                #region FALCHION

                if (choseweaponcombobox.SelectedItem.ToString() == "FALCHION")
                {
                    data["512"]["SkinSeed"] = skinseedtextbox.Text;
                    data["512"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                # endregion FALCHION

                #region BOWIE

                if (choseweaponcombobox.SelectedItem.ToString() == "BOWIE")
                {
                    data["514"]["SkinSeed"] = skinseedtextbox.Text;
                    data["514"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                # endregion BOWIE

                #region BUTTERFLY

                if (choseweaponcombobox.SelectedItem.ToString() == "BUTTERFLY")
                {
                    data["515"]["SkinSeed"] = skinseedtextbox.Text;
                    data["515"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                # endregion BUTTERFLY

                #region SHADOW DAGGERS

                if (choseweaponcombobox.SelectedItem.ToString() == "SHADOW DAGGERS")
                {
                    data["516"]["SkinSeed"] = skinseedtextbox.Text;
                    data["516"]["SkinWear"] = "0." + skinweartrackbarprcent.Text + "0000";
                    parser.WriteFile(label1.Text, data);
                }

                # endregion SHADOW DAGGERS
            }

            MetroMessageBox.Show(this, "Seed and Wear for " + choseweaponcombobox.SelectedItem + " saved!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile(label1.Text);
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset Wear Button [FINISHED]
        private void metroButton5_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(label1.Text);

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
                parser.WriteFile(label1.Text, data);
            }

            #endregion AWP

            #region AK47

            if (choseweaponcombobox.SelectedItem.ToString() == "AK47")
            {
                data["7"]["SkinSeed"] = "0";
                data["7"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion AK47

            #region DEAGLE

            if (choseweaponcombobox.SelectedItem.ToString() == "DEAGLE")
            {
                data["1"]["SkinSeed"] = "0";
                data["1"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion DEAGLE

            #region DUAL BERETTAS

            if (choseweaponcombobox.SelectedItem.ToString() == "DUAL BERETTAS")
            {
                data["2"]["SkinSeed"] = "0";
                data["2"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion DUAL BERETTAS

            #region FIVESEVEN

            if (choseweaponcombobox.SelectedItem.ToString() == "FIVESEVEN")
            {
                data["3"]["SkinSeed"] = "0";
                data["3"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion FIVESEVEN

            #region GLOCK

            if (choseweaponcombobox.SelectedItem.ToString() == "GLOCK")
            {
                data["4"]["SkinSeed"] = "0";
                data["4"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion GLOCK

            #region AUG

            if (choseweaponcombobox.SelectedItem.ToString() == "AUG")
            {
                data["8"]["SkinSeed"] = "0";
                data["8"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion AUG

            #region FAMAS

            if (choseweaponcombobox.SelectedItem.ToString() == "FAMAS")
            {
                data["10"]["SkinSeed"] = "0";
                data["10"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion FAMAS

            #region G3SG1

            if (choseweaponcombobox.SelectedItem.ToString() == "G3SG1")
            {
                data["11"]["SkinSeed"] = "0";
                data["11"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion G3SG1

            #region GALILAR

            if (choseweaponcombobox.SelectedItem.ToString() == "GALILAR")
            {
                data["13"]["SkinSeed"] = "0";
                data["13"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion GALILAR

            #region M249

            if (choseweaponcombobox.SelectedItem.ToString() == "M249")
            {
                data["14"]["SkinSeed"] = "0";
                data["14"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion M249

            #region M4A4

            if (choseweaponcombobox.SelectedItem.ToString() == "M4A4")
            {
                data["16"]["SkinSeed"] = "0";
                data["16"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion M4A4

            #region MAC10

            if (choseweaponcombobox.SelectedItem.ToString() == "MAC10")
            {
                data["17"]["SkinSeed"] = "0";
                data["17"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion MAC10

            #region P90

            if (choseweaponcombobox.SelectedItem.ToString() == "P90")
            {
                data["19"]["SkinSeed"] = "0";
                data["19"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion P90

            #region UMP45

            if (choseweaponcombobox.SelectedItem.ToString() == "UMP45")
            {
                data["24"]["SkinSeed"] = "0";
                data["24"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion UMP45

            #region XM1014

            if (choseweaponcombobox.SelectedItem.ToString() == "XM1014")
            {
                data["25"]["SkinSeed"] = "0";
                data["25"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion XM1014

            #region BIZON

            if (choseweaponcombobox.SelectedItem.ToString() == "BIZON")
            {
                data["26"]["SkinSeed"] = "0";
                data["26"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion BIZON

            #region MAG7

            if (choseweaponcombobox.SelectedItem.ToString() == "MAG7")
            {
                data["27"]["SkinSeed"] = "0";
                data["27"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion MAG7

            #region NEGEV

            if (choseweaponcombobox.SelectedItem.ToString() == "NEGEV")
            {
                data["28"]["SkinSeed"] = "0";
                data["28"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion NEGEV

            #region SAWEDOFF

            if (choseweaponcombobox.SelectedItem.ToString() == "SAWEDOFF")
            {
                data["29"]["SkinSeed"] = "0";
                data["29"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion SAWEDOFF

            #region TEC9

            if (choseweaponcombobox.SelectedItem.ToString() == "TEC9")
            {
                data["30"]["SkinSeed"] = "0";
                data["30"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion TEC9

            #region P2000

            if (choseweaponcombobox.SelectedItem.ToString() == "P2000")
            {
                data["32"]["SkinSeed"] = "0";
                data["32"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion P2000

            #region MP7

            if (choseweaponcombobox.SelectedItem.ToString() == "MP7")
            {
                data["33"]["SkinSeed"] = "0";
                data["33"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion MP7

            #region MP9

            if (choseweaponcombobox.SelectedItem.ToString() == "MP9")
            {
                data["34"]["SkinSeed"] = "0";
                data["34"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion MP9

            #region NOVA

            if (choseweaponcombobox.SelectedItem.ToString() == "NOVA")
            {
                data["35"]["SkinSeed"] = "0";
                data["35"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion NOVA

            #region P250

            if (choseweaponcombobox.SelectedItem.ToString() == "P250")
            {
                data["36"]["SkinSeed"] = "0";
                data["36"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion P250

            #region SCAR20

            if (choseweaponcombobox.SelectedItem.ToString() == "SCAR20")
            {
                data["38"]["SkinSeed"] = "0";
                data["38"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion SCAR20

            #region SG556

            if (choseweaponcombobox.SelectedItem.ToString() == "SG556")
            {
                data["39"]["SkinSeed"] = "0";
                data["39"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion SG556

            #region SSG08

            if (choseweaponcombobox.SelectedItem.ToString() == "SSG08")
            {
                data["40"]["SkinSeed"] = "0";
                data["40"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion SSG08

            #region M4A1-S

            if (choseweaponcombobox.SelectedItem.ToString() == "M4A1-S")
            {
                data["60"]["SkinSeed"] = "0";
                data["60"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion M4A1-S

            #region USP-S

            if (choseweaponcombobox.SelectedItem.ToString() == "USP-S")
            {
                data["61"]["SkinSeed"] = "0";
                data["61"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion USP-S

            #region CZ75A

            if (choseweaponcombobox.SelectedItem.ToString() == "CZ75A")
            {
                data["63"]["SkinSeed"] = "0";
                data["63"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion CZ75A

            #region R8-REVOLVER

            if (choseweaponcombobox.SelectedItem.ToString() == "R8-REVOLVER")
            {
                data["64"]["SkinSeed"] = "0";
                data["64"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion R8-REVOLVER

            #region BAYONET

            if (choseweaponcombobox.SelectedItem.ToString() == "BAYONET")
            {
                data["500"]["SkinSeed"] = "0";
                data["500"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion BAYONET

            #region FLIP

            if (choseweaponcombobox.SelectedItem.ToString() == "FLIP")
            {
                data["505"]["SkinSeed"] = "0";
                data["505"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion FLIP

            #region GUT

            if (choseweaponcombobox.SelectedItem.ToString() == "GUT")
            {
                data["506"]["SkinSeed"] = "0";
                data["506"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion GUT

            #region KARAMBIT

            if (choseweaponcombobox.SelectedItem.ToString() == "KARAMBIT")
            {
                data["507"]["SkinSeed"] = "0";
                data["507"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion KARAMBIT

            #region M9 BAYONET

            if (choseweaponcombobox.SelectedItem.ToString() == "M9 BAYONET")
            {
                data["508"]["SkinSeed"] = "0";
                data["508"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion M9 BAYONET

            #region HUNTSMAN

            if (choseweaponcombobox.SelectedItem.ToString() == "HUNTSMAN")
            {
                data["509"]["SkinSeed"] = "0";
                data["509"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion HUNTSMAN

            #region FALCHION

            if (choseweaponcombobox.SelectedItem.ToString() == "FALCHION")
            {
                data["512"]["SkinSeed"] = "0";
                data["512"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion FALCHION

            #region BOWIE

            if (choseweaponcombobox.SelectedItem.ToString() == "BOWIE")
            {
                data["514"]["SkinSeed"] = "0";
                data["514"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion BOWIE

            #region BUTTERFLY

            if (choseweaponcombobox.SelectedItem.ToString() == "BUTTERFLY")
            {
                data["515"]["SkinSeed"] = "0";
                data["515"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion BUTTERFLY

            #region SHADOW DAGGERS

            if (choseweaponcombobox.SelectedItem.ToString() == "SHADOW DAGGERS")
            {
                data["516"]["SkinSeed"] = "0";
                data["516"]["SkinWear"] = "0.000001";
                parser.WriteFile(label1.Text, data);
            }

            #endregion SHADOW DAGGERS

            MetroMessageBox.Show(this, "Reset Wear for " + choseweaponcombobox.SelectedItem + "successful",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile(label1.Text);
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset all Skin Seed's [FINISHED]
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(label1.Text);

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

            parser.WriteFile(label1.Text, data);

            MetroMessageBox.Show(this, "Seeds for all Weapons Reset.", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile(label1.Text);
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset all Skin Wear's [FINISHED]
        private void metroButton2_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(label1.Text);

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

            parser.WriteFile(label1.Text, data);

            MetroMessageBox.Show(this, "Wears for all Weapons Reset.", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile(label1.Text);
            SkinsTextbox.Text = parsedData.ToString();
        }

        //Reset all Skins [FINISHED]
        private void metroButton6_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(label1.Text);

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

            parser.WriteFile(label1.Text, data);

            MetroMessageBox.Show(this, "Skins for all Weapons have been reset!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var fileIniData = new FileIniDataParser();
            var parsedData = fileIniData.ReadFile(label1.Text);
            SkinsTextbox.Text = parsedData.ToString();
        }
    }
}