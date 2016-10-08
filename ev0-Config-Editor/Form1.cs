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
using MetroFramework;
using IniParser.Model;
using IniParser;

namespace ev0_Test
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Loads on Start
        private void Form1_Load(object sender, EventArgs e)
        {
            //Legit Tab
            aimbotmode.SelectedItem = "On Fire";
            aimbottargetselection.SelectedItem = "Closest to Crosshair";
            pistolhitboxsetting.SelectedItem = "Neck";
            automatichitboxsetting.SelectedItem = "Closest";
            sniperhitboxselection.SelectedItem = "Body";
            shotgunhitboxselection.SelectedItem = "Closest";

            //Rage Tab
            ragetargetselection.SelectedItem = "Closest to Crosshair";
            ragehitboxselection.SelectedItem = "Head";

            //Triggerbot Tab
            triggerbotselectmode.SelectedItem = "On Key";

            //Visuals Tab
            metroComboBox2.SelectedItem = "None";
            metroComboBox3.SelectedItem = "Off";
            metroComboBox4.SelectedItem = "Off";

        }

        #region Legit Tab

        //Legit Tab Button
        private void LegitTab_Click(object sender, EventArgs e)
        {
            //Triggerbot Tab
            metroPanel10.Visible = false;
            //Rage Tab
            metroPanel6.Visible = false;
            //Visuals Tab
            metroPanel16.Visible = false;
        }

        //Get Textbox Line
        void changeLine(RichTextBox RTB, int line, string text)
        {
            int s1 = RTB.GetFirstCharIndexFromLine(line);
            int s2 = line < RTB.Lines.Count() - 1 ?
                      RTB.GetFirstCharIndexFromLine(line + 1) - 1 :
                      RTB.Text.Length;
            RTB.Select(s1, s2 - s1);
            RTB.SelectedText = text;
        }

        //Save Button [IMPLEMENTED]
        private void metroButton2_Click(object sender, EventArgs e)
        {
            var saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.cfg";
            saveFile1.Filter = @"ev0lve Config|*.cfg";
            saveFile1.FileName = "Custom";

            if ((saveFile1.ShowDialog() == DialogResult.OK) &&
                (saveFile1.FileName.Length > 0))
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        //Legit Active Checkbox [IMPLEMENTED]
        private void legitactive_CheckedChanged(object sender, EventArgs e)
        {
            rageactive.Checked = false;

            if (legitactive.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_legit=0", "aimbot_legit=1");
            }

            if (legitactive.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_legit=1", "aimbot_legit=0");
            }
        }

        //Aimbot Enable Checkbox [IMPLEMENTED]
        private void aimbotenable_CheckedChanged_1(object sender, EventArgs e)
        {
            if (aimbotenable.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_active=0", "aimbot_active=1");
            }

            if (aimbotenable.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_active=1", "aimbot_active=0");
            }
        }

        //Aimbot at Team Checkbox [IMPLEMENTED]
        private void aimatteammatescheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (aimatteammatescheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_team=0", "aimbot_team=1");
            }

            if (aimatteammatescheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_team=1", "aimbot_team=0");
            }
        }

        //Non Sticky Checkbox [IMPLEMENTED]
        private void nonstickycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nonstickycheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_nonsticky=0", "aimbot_nonsticky=1");
            }

            if (nonstickycheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_nonsticky=1", "aimbot_nonsticky=0");
            }
        }

        //Smoke Check Checkbox [IMPLEMENTED]
        private void smokecheckcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (smokecheckcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smoke_check=0", "aimbot_smoke_check=1");
            }

            if (smokecheckcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smoke_check=1", "aimbot_smoke_check=0");
            }
        }

        //Corner Scan Checkbox [IMPLEMENTED]
        private void cornerscancheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cornerscancheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_cornerscan=0", "aimbot_cornerscan=1");
            }

            if (cornerscancheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_cornerscan=1", "aimbot_cornerscan=0");
            }
        }

        //Weapon Groups Checkbox [IMPLEMENTED]
        private void weapongroupscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (weapongroupscheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_groups=0", "aimbot_groups=1");
            }

            if (weapongroupscheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_groups=1", "aimbot_groups=0");
            }
        }

        //Auto Pistol Checkbox [IMPLEMENTED]
        private void autopistolcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (autopistolcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("misc_autopistol=0", "misc_autopistol=1");
            }

            if (autopistolcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("misc_autopistol=1", "misc_autopistol=0");
            }
        }

        //Pistol Smooth Checkbox [IMPLEMENTED]
        private void pistolsmooth_CheckedChanged(object sender, EventArgs e)
        {
            if (pistolsmooth.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_pistol=0", "aimbot_smooth_pistol=1");
            }

            if (pistolsmooth.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_pistol=1", "aimbot_smooth_pistol=0");
            }
        }

        //Body AWP Checkbox [IMPLEMENTED]
        private void bodyawpcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (bodyawpcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_bodyawp=0", "aimbot_bodyawp=1");
            }

            if (bodyawpcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_bodyawp=1", "aimbot_bodyawp=0");
            }
        }

        //Silent Aim Checkbox [IMPLEMENTED]
        private void silentaimcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (silentaimcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_silent=0", "aimbot_silent=1");
            }

            if (silentaimcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_silent=1", "aimbot_silent=0");
            }
        }

        //Autmoic Smooth Checkbox [IMPLEMENTED]
        private void automaticsmooth_CheckedChanged(object sender, EventArgs e)
        {
            if (automaticsmooth.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_automatic=0", "aimbot_smooth_automatic=1");
            }

            if (automaticsmooth.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_automatic=1", "aimbot_smooth_automatic=0");
            }
        }

        //Sniper Smooth Checkbox [IMPLEMENTED]
        private void snipersmoothcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (snipersmoothcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_sniper=0", "aimbot_smooth_sniper=1");
            }

            if (snipersmoothcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_sniper=1", "aimbot_smooth_sniper=0");
            }
        }

        //Shotgun Smooth Checkbox [IMPLEMENTED]
        private void shotgunsmoothcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (shotgunsmoothcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_shotgun=0", "aimbot_smooth_shotgun=1");
            }

            if (shotgunsmoothcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_smooth_shotgun=1", "aimbot_smooth_shotgun=0");
            }
        }

        //Automatic Recoil Control Checkbox [IMPLEMENTED]
        private void recoilcontrolenable_CheckedChanged(object sender, EventArgs e)
        {
            if (recoilcontrolenable.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_rcs=0", "aimbot_rcs=1");
            }

            if (recoilcontrolenable.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_rcs=1", "aimbot_rcs=0");
            }
        }

        //RCS Standalone Checkbox [IMPLEMENTED]
        private void standalonercsenable_CheckedChanged(object sender, EventArgs e)
        {
            if (standalonercsenable.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_rcs_standalone=0", "aimbot_rcs_standalone=1");
            }

            if (standalonercsenable.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_rcs_standalone=1", "aimbot_rcs_standalone=0");
            }
        }

        //Aimbot Mode Selection [[IMPLEMENTED]]
        private void aimbotmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On Fire =  2
            //On Key = 3
            //Auto Aim = 1

            if (aimbotmode.SelectedItem.ToString() == "On Fire")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_mode=1", "aimbot_mode=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_mode=3", "aimbot_mode=2");
            }

            if (aimbotmode.SelectedItem.ToString() == "On Key")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_mode=1", "aimbot_mode=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_mode=2", "aimbot_mode=3");
            }

            if (aimbotmode.SelectedItem.ToString() == "Auto Aim")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_mode=2", "aimbot_mode=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_mode=3", "aimbot_mode=1");
            }
        }

        //Aimbot Target Selection [IMPLEMENTED]
        private void aimbottargetselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Closest to Crosshair = 0
            //Closest to Player = 1
            //Lowest HP = 2

            if (aimbottargetselection.SelectedItem.ToString() == "Closest to Crosshair")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_selection=1", "aimbot_selection=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_selection=2", "aimbot_selection=0");
            }
            if (aimbottargetselection.SelectedItem.ToString() == "Closest to Player")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_selection=0", "aimbot_selection=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_selection=2", "aimbot_selection=1");
            }
            if (aimbottargetselection.SelectedItem.ToString() == "Lowest HP")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_selection=0", "aimbot_selection=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_selection=1", "aimbot_selection=2");
            }
        }

        //Pistol Hitbox Selection [IMPLEMENTED]
        private void pistolhitboxsetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aimbot_hitbox_pistol=0 Head
            //aimbot_hitbox_pistol=2 Neck
            //aimbot_hitbox_pistol=6 Body
            //aimbot_hitbox_pistol=3 Pelvis
            //aimbot_hitbox_pistol=-1 Closest

            if (pistolhitboxsetting.SelectedItem.ToString() == "Head")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=-1", "aimbot_hitbox_pistol=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=2", "aimbot_hitbox_pistol=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=3", "aimbot_hitbox_pistol=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=6", "aimbot_hitbox_pistol=0");
            }
            if (pistolhitboxsetting.SelectedItem.ToString() == "Neck")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=-1", "aimbot_hitbox_pistol=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=0", "aimbot_hitbox_pistol=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=3", "aimbot_hitbox_pistol=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=6", "aimbot_hitbox_pistol=2");
            }
            if (pistolhitboxsetting.SelectedItem.ToString() == "Body")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=-1", "aimbot_hitbox_pistol=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=0", "aimbot_hitbox_pistol=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=2", "aimbot_hitbox_pistol=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=3", "aimbot_hitbox_pistol=6");
            }
            if (pistolhitboxsetting.SelectedItem.ToString() == "Pelvis")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=-1", "aimbot_hitbox_pistol=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=0", "aimbot_hitbox_pistol=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=2", "aimbot_hitbox_pistol=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=6", "aimbot_hitbox_pistol=3");
            }
            if (pistolhitboxsetting.SelectedItem.ToString() == "Closest")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=0", "aimbot_hitbox_pistol=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=2", "aimbot_hitbox_pistol=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=3", "aimbot_hitbox_pistol=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_pistol=6", "aimbot_hitbox_pistol=-1");
            }
        }

        //Sniper Hitbox Selection [IMPLEMENTED]
        private void sniperhitboxselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aimbot_hitbox_sniper=0 Head
            //aimbot_hitbox_sniper=2 Neck
            //aimbot_hitbox_sniper=6 Body
            //aimbot_hitbox_sniper=3 Pelvis
            //aimbot_hitbox_sniper=-1 Closest

            if (sniperhitboxselection.SelectedItem.ToString() == "Head")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=2", "aimbot_hitbox_sniper=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=6", "aimbot_hitbox_sniper=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=3", "aimbot_hitbox_sniper=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=-1", "aimbot_hitbox_sniper=0");
            }
            if (sniperhitboxselection.SelectedItem.ToString() == "Neck")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=0", "aimbot_hitbox_sniper=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=6", "aimbot_hitbox_sniper=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=3", "aimbot_hitbox_sniper=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=-1", "aimbot_hitbox_sniper=2");
            }
            if (sniperhitboxselection.SelectedItem.ToString() == "Body")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=0", "aimbot_hitbox_sniper=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=2", "aimbot_hitbox_sniper=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=3", "aimbot_hitbox_sniper=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=-1", "aimbot_hitbox_sniper=6");
            }
            if (sniperhitboxselection.SelectedItem.ToString() == "Pelvis")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=0", "aimbot_hitbox_sniper=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=2", "aimbot_hitbox_sniper=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=6", "aimbot_hitbox_sniper=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=-1", "aimbot_hitbox_sniper=3");
            }
            if (sniperhitboxselection.SelectedItem.ToString() == "Closest")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=0", "aimbot_hitbox_sniper=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=2", "aimbot_hitbox_sniper=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=6", "aimbot_hitbox_sniper=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_sniper=3", "aimbot_hitbox_sniper=-1");
            }
        }

        //Automatic Hitbox Selection [IMPLEMENTED]
        private void automatichitboxsetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aimbot_hitbox_automatic=0 Head
            //aimbot_hitbox_automatic=2 Neck
            //aimbot_hitbox_automatic=6 Body
            //aimbot_hitbox_automatic=3 Pelvis
            //aimbot_hitbox_automatic=-1 Closest

            if (automatichitboxsetting.SelectedItem.ToString() == "Head")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=2", "aimbot_hitbox_automatic=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=6", "aimbot_hitbox_automatic=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=3", "aimbot_hitbox_automatic=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=-1", "aimbot_hitbox_automatic=0");
            }
            if (automatichitboxsetting.SelectedItem.ToString() == "Neck")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=0", "aimbot_hitbox_automatic=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=6", "aimbot_hitbox_automatic=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=3", "aimbot_hitbox_automatic=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=-1", "aimbot_hitbox_automatic=2");
            }
            if (automatichitboxsetting.SelectedItem.ToString() == "Body")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=0", "aimbot_hitbox_automatic=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=2", "aimbot_hitbox_automatic=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=3", "aimbot_hitbox_automatic=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=-1", "aimbot_hitbox_automatic=6");
            }
            if (automatichitboxsetting.SelectedItem.ToString() == "Pelvis")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=0", "aimbot_hitbox_automatic=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=2", "aimbot_hitbox_automatic=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=6", "aimbot_hitbox_automatic=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=-1", "aimbot_hitbox_automatic=3");
            }
            if (automatichitboxsetting.SelectedItem.ToString() == "Closest")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=0", "aimbot_hitbox_automatic=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=2", "aimbot_hitbox_automatic=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=6", "aimbot_hitbox_automatic=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_automatic=3", "aimbot_hitbox_automatic=-1");
            }
        }

        //Shotgun Hitbox Selection [IMPLEMENTED]
        private void shotgunhitboxselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aimbot_hitbox_shotgun=0 Head
            //aimbot_hitbox_shotgun=2 Neck
            //aimbot_hitbox_shotgun=6 Body
            //aimbot_hitbox_shotgun=3 Pelvis
            //aimbot_hitbox_shotgun=-1 Closest

            if (shotgunhitboxselection.SelectedItem.ToString() == "Head")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=2", "aimbot_hitbox_shotgun=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=6", "aimbot_hitbox_shotgun=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=3", "aimbot_hitbox_shotgun=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=-1", "aimbot_hitbox_shotgun=0");
            }
            if (shotgunhitboxselection.SelectedItem.ToString() == "Neck")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=0", "aimbot_hitbox_shotgun=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=6", "aimbot_hitbox_shotgun=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=3", "aimbot_hitbox_shotgun=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=-1", "aimbot_hitbox_shotgun=2");
            }
            if (shotgunhitboxselection.SelectedItem.ToString() == "Body")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=0", "aimbot_hitbox_shotgun=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=2", "aimbot_hitbox_shotgun=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=3", "aimbot_hitbox_shotgun=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=-1", "aimbot_hitbox_shotgun=6");
            }
            if (shotgunhitboxselection.SelectedItem.ToString() == "Pelvis")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=0", "aimbot_hitbox_shotgun=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=2", "aimbot_hitbox_shotgun=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=6", "aimbot_hitbox_shotgun=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=-1", "aimbot_hitbox_shotgun=3");
            }
            if (shotgunhitboxselection.SelectedItem.ToString() == "Closest")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=0", "aimbot_hitbox_shotgun=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=2", "aimbot_hitbox_shotgun=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=6", "aimbot_hitbox_shotgun=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_hitbox_shotgun=3", "aimbot_hitbox_shotgun=-1");
            }
        }

        //Y-Axis Percent to Textbox [IMPLEMENTED]
        private void strengthyaxistrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            strengthyaxispercenttext.Text = strengthyaxistrackbar.Value.ToString();

            changeLine(richTextBox1, 16, "aimbot_rcs_y=" + strengthyaxistrackbar.Value + ".000000");
        }

        //X-Axis Percent to Textbox [IMPLEMENTED]
        private void strengthxaxistrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            strengthxaxispercenttext.Text = strengthxaxistrackbar.Value.ToString();

            changeLine(richTextBox1, 15, "aimbot_rcs_x=" + strengthxaxistrackbar.Value + ".000000");
        }

        //Aimtime Percent to Textbox [IMPLEMENTED]
        private void aimtimetrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            trackbarpercent.Text = aimtimetrackbar.Value.ToString();

            changeLine(richTextBox1, 7, "aimbot_aimtime=" + aimtimetrackbar.Value + ".000000");
        }

        //Aim Key to Textbox [IMPLEMENTED]
        private void aimkeytextbox_TextChanged(object sender, EventArgs e)
        {
            changeLine(richTextBox1, 4, "aimbot_key=" + aimkeytextbox.Text);
        }

        //Pistol Fov Percent to Textbox [NOT FINISHED!]
        private void pistolfovtrackbar_Scroll_1(object sender, ScrollEventArgs e)
        {
            
        }

        #endregion Legit Tab

        #region Rage Tab

        //Rage Tab Button [IMPLEMENTED]
        private void ragetabbutton_Click(object sender, EventArgs e)
        {
            //Rage Tab
            metroPanel6.Visible = true;
            //Triggerbot Tab
            metroPanel10.Visible = false;
            //Visuals Tab
            metroPanel16.Visible = false;
        }

        //Rage Aimbot Fov to Textbox [IMPLEMENTED]
        private void rageaimbottrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            rageaimbottrackbarpercent.Text = rageaimbottrackbar.Value.ToString();

            changeLine(richTextBox1, 40, "ragebot_fov=" + rageaimbottrackbar.Value + ".000000");
        }

        //Silent Aim Checkbox [IMPLEMENTED]
        private void ragesilentaimcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ragesilentaimcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_silent=0", "ragebot_silent=1");
            }
            if (ragesilentaimcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_silent=1", "ragebot_silent=0");
            }
        }

        //Perfect Silent Aim Checkbox [IMPLEMENTED]
        private void rageperfectsilentaimcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageperfectsilentaimcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_psilent=0", "ragebot_psilent=1");
            }
            if (rageperfectsilentaimcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_psilent=1", "ragebot_psilent=0");
            }
        }

        //Auto Aim Checkbox [IMPLEMENTED]
        private void rageautoaimcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautoaimcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoaim=0", "ragebot_autoaim=1");
            }
            if (rageautoaimcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoaim=1", "ragebot_autoaim=0");
            }
        }

        //Auto Shoot Checkbox [IMPLEMENTED]
        private void rageautoshootcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautoshootcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoshoot=0", "ragebot_autoshoot=1");
            }
            if (rageautoshootcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoshoot=1", "ragebot_autoshoot=0");
            }
        }

        //Auto Aim Step Checkbox [IMPLEMENTED]
        private void rageautoaimstepcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautoaimstepcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_aimstep=0", "ragebot_aimstep=1");
            }
            if (rageautoaimstepcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_aimstep=1", "ragebot_aimstep=0");
            }
        }

        //Resolver Checkbox [IMPLEMENTED]
        private void rageresolvercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageresolvercheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_resolver=0", "ragebot_resolver=1");
            }
            if (rageresolvercheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_resolver=1", "ragebot_resolver=0");
            }
        }

        //Auto Pistol Checkbox [IMPLEMENTED]
        private void rageautopistolcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautopistolcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("misc_autopistol=0", "misc_autopistol=1");
            }
            if (rageautopistolcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("misc_autopistol=1", "misc_autopistol=0");
            }
        }

        //Auto Stop Checkbox [IMPLEMENTED]
        private void rageautostopcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautostopcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autostop=0", "ragebot_autostop=1");
            }
            if (rageautostopcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autostop=1", "ragebot_autostop=0");
            }
        }

        //Auto Duck/Crouch Checkbox [IMPLEMENTED]
        private void rageautoduckcrouchcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautoduckcrouchcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoduck=0", "ragebot_autoduck=1");
            }
            if (rageautoduckcrouchcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoduck=1", "ragebot_autoduck=0");
            }
        }

        //Auto Scope Checkbox [IMPLEMENTED]
        private void rageautoscopecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautoscopecheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoscope=0", "ragebot_autoscope=1");
            }
            if (rageautoscopecheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autoscope=1", "ragebot_autoscope=0");
            }
        }

        //Enable Hitchance Checkbox [IMPLEMENTED]
        private void rageenablehitchancecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageenablehitchancecheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitchance=0", "ragebot_hitchance=1");
            }
            if (rageenablehitchancecheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitchance=1", "ragebot_hitchance=0");
            }
        }

        //Hitchance to Textbox [IMPLEMENTED]
        private void ragehitchancetrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            ragehitchancepercent.Text = ragehitchancetrackbar.Value.ToString();

            changeLine(richTextBox1, 58, "ragebot_hitchance_percent=" + ragehitchancetrackbar.Value + ".000000");
        }

        //Min AWP Wallbang Damage to Textbox [IMPLEMENTED]
        private void rageminawalldamagetrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            rageminawalldamagepercent.Text = rageminawalldamagetrackbar.Value.ToString();

            changeLine(richTextBox1, 49, "ragebot_min_awall_dmg=" + rageminawalldamagetrackbar.Value);
        }

        //Rage Target Selection [IMPLEMENTED]
        private void ragetargetselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Closest to Crosshair = 0
            //Closest to Player = 1
            //Lowest HP = 2

            if (ragetargetselection.SelectedItem.ToString() == "Closest to Crosshair")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_selection=1", "ragebot_selection=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_selection=2", "ragebot_selection=0");
            }
            if (ragetargetselection.SelectedItem.ToString() == "Closest to Player")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_selection=0", "ragebot_selection=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_selection=2", "ragebot_selection=1");
            }
            if (ragetargetselection.SelectedItem.ToString() == "Lowest HP")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_selection=0", "ragebot_selection=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_selection=1", "ragebot_selection=2");
            }
        }

        //Rage Hitbox Selection [IMPLEMENTED]
        private void ragehitboxselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ragebot_hitbox=0 Head
            //ragebot_hitbox=2 Neck
            //ragebot_hitbox=6 Body
            //ragebot_hitbox=3 Pelvis
            //ragebot_hitbox=-1 Closest

            if (ragehitboxselection.SelectedItem.ToString() == "Head")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=-1", "ragebot_hitbox=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=2", "ragebot_hitbox=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=3", "ragebot_hitbox=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=6", "ragebot_hitbox=0");
            }
            if (ragehitboxselection.SelectedItem.ToString() == "Neck")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=-1", "ragebot_hitbox=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=0", "ragebot_hitbox=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=3", "ragebot_hitbox=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=6", "ragebot_hitbox=2");
            }
            if (ragehitboxselection.SelectedItem.ToString() == "Body")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=-1", "ragebot_hitbox=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=0", "ragebot_hitbox=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=2", "ragebot_hitbox=6");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=3", "ragebot_hitbox=6");
            }
            if (ragehitboxselection.SelectedItem.ToString() == "Pelvis")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=-1", "ragebot_hitbox=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=0", "ragebot_hitbox=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=2", "ragebot_hitbox=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=6", "ragebot_hitbox=3");
            }
            if (ragehitboxselection.SelectedItem.ToString() == "Closest")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=0", "ragebot_hitbox=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=2", "ragebot_hitbox=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=3", "ragebot_hitbox=-1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitbox=6", "ragebot_hitbox=-1");
            }
        }

        //Rage Aim at Teammate Checkbox [IMPLEMENTED]
        private void rageaimatteammatescheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageaimatteammatescheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_team=0", "ragebot_team=1");
            }
            if (rageaimatteammatescheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_team=1", "ragebot_team=0");
            }
        }

        //Rage Body AWP Checkbox [IMPLEMENTED]
        private void ragebodyawpcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ragebodyawpcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_bodyawp=0", "ragebot_bodyawp=1");
            }
            if (ragebodyawpcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_bodyawp=1", "ragebot_bodyawp=0");
            }
        }

        //Rage Hitscan Checkbox [IMPLEMENTED]
        private void ragehitscancheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ragehitscancheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitscan=0", "ragebot_hitscan=1");
            }
            if (ragehitscancheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_hitscan=1", "ragebot_hitscan=0");
            }
        }

        //Rage Cornerscan Checkbox [IMPLEMENTED]
        private void ragecornerscancheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ragecornerscancheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_cornerscan=0", "ragebot_cornerscan=1");
            }
            if (ragecornerscancheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_cornerscan=1", "ragebot_cornerscan=0");
            }
        }

        //Rage Auto Wall Checkbox [IMPLEMENTED]
        private void rageautowallcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rageautowallcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autowall=0", "ragebot_autowall=1");
            }
            if (rageautowallcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_autowall=1", "ragebot_autowall=0");
            }
        }

        //Rage Aimbot Enable Checkbox [IMPLEMENTED]
        private void rageenableaimbot_CheckedChanged(object sender, EventArgs e)
        {
            if (rageenableaimbot.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_active=0", "ragebot_active=1");
            }
            if (rageenableaimbot.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("ragebot_active=0", "ragebot_active=1");
            }
        }

        //Rage Active Checkbox [IMPLEMENTED]
        private void rageactive_CheckedChanged(object sender, EventArgs e)
        {
            legitactive.Checked = false;

            if (rageactive.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_legit=1", "aimbot_legit=0");
            }
            if (rageactive.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("aimbot_legit=0", "aimbot_legit=1");
            }
        }

        #endregion Rage Tab

        #region Triggerbot Tab

        //Trigerbot Button Tab
        private void triggerbotbutton_Click(object sender, EventArgs e)
        {
            //Triggerbot Tab
            metroPanel10.Visible = true;
            //Rage Tab
            metroPanel6.Visible = true;
            //Visuals Tab
            metroPanel16.Visible = false;
        }

        //Triggerbot Enable Button [IMPLEMENTED]
        private void triggerbotenable_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotenable.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_active=0", "trigger_active=1");
            }
            if (triggerbotenable.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_active=1", "trigger_active=0");
            }
        }

        //Triggerbot Select Mode [IMPLEMENTED]
        private void triggerbotselectmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On Fire =  2
            //On Key = 3
            //Auto Aim = 1

            if (triggerbotselectmode.SelectedItem.ToString() == "On Fire")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_mode=1", "trigger_mode=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_mode=3", "trigger_mode=2");
            }

            if (triggerbotselectmode.SelectedItem.ToString() == "On Key")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_mode=1", "trigger_mode=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_mode=2", "trigger_mode=3");
            }

            if (triggerbotselectmode.SelectedItem.ToString() == "Auto Aim")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_mode=2", "trigger_mode=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_mode=3", "trigger_mode=1");
            }
        }

        //Triggerbot set Triggerkey
        private void triggerbotselectkey_TextChanged(object sender, EventArgs e)
        {
            changeLine(richTextBox1, 63, "trigger_key=" + triggerbotselectkey.Text);
        }

        //Triggerbot Smokecheck Checkbox [IMPLEMENTED]
        private void triggerbotsmokecheckcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsmokecheckcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_smoke_check=0", "trigger_smoke_check=1");
            }
            if (triggerbotsmokecheckcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_smoke_check=1", "trigger_smoke_check=0");
            }
        }

        //Triggerbot Hitchance Trackbar Value to Textbox [IMPLEMENTED]
        private void triggerbothitchancetrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            triggerbothitchancepercent.Text = triggerbothitchancetrackbar.Value.ToString();

            changeLine(richTextBox1, 67, "trigger_hitchance_percent=" + triggerbothitchancetrackbar.Value + ".000000");
        }

        //Triggerbot Enable Hitchance Checkbox [IMPLEMENTED]
        private void triggerbotenablehitchancecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotenablehitchancecheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitchance=0", "trigger_hitchance=1");
            }
            if (triggerbotenablehitchancecheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitchance=1", "trigger_hitchance=0");
            }
        }

        //Triggerbot Enemy Only Checkbox [IMPLEMENTED]
        private void triggerbotenemyonlycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotenemyonlycheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_enemy_only=0", "trigger_enemy_only=1");
            }
            if (triggerbotenemyonlycheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_enemy_only=1", "trigger_enemy_only=0");
            }
        }

        //Triggerbot Pistols Head Checkbox [IMPLEMENTED]
        private void triggerbotpistolshead_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotpistolshead.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_pistol=0", "trigger_hitbox_head_pistol=1");
            }
            if (triggerbotpistolshead.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_pistol=1", "trigger_hitbox_head_pistol=0");
            }
        }

        //Triggerbot Pistols Neck Checkbox [IMPLEMENTED]
        private void triggerbotpistolsneck_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotpistolsneck.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_pistol=0", "trigger_hitbox_neck_pistol=1");
            }
            if (triggerbotpistolsneck.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_pistol=1", "trigger_hitbox_neck_pistol=0");
            }
        }

        //Triggerbot Pistols Body Checkbox [IMPLEMENTED]
        private void triggerbotpistolsbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotpistolsbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_pistol=0", "trigger_hitbox_body_pistol=1");
            }
            if (triggerbotpistolsbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_pistol=1", "trigger_hitbox_body_pistol=0");
            }
        }

        //Triggerbot Pistols Arms Checkbox [IMPLEMENTED]
        private void triggerbotpistolsarms_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotpistolsarms.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_pistol=0", "trigger_hitbox_arms_pistol=1");
            }
            if (triggerbotpistolsarms.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_pistol=1", "trigger_hitbox_arms_pistol=0");
            }
        }

        //Triggerbot Pistols Legs Checkbox [IMPLEMENTED]
        private void triggerbotpistolslegs_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotpistolslegs.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_pistol=0", "trigger_hitbox_legs_pistol=1");
            }
            if (triggerbotpistolslegs.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_pistol=1", "trigger_hitbox_legs_pistol=0");
            }
        }

        //Triggerbot Pistols Full Body Checkbox [IMPLEMENTED]
        private void triggerbotpistolsfullbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotpistolsfullbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_pistol=0", "trigger_fullbody_pistol=1");
            }
            if (triggerbotpistolsfullbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_pistol=1", "trigger_fullbody_pistol=0");
            }
        }

        //Triggerbot Automatic Head Checkbox [IMPLEMENTED]
        private void triggerbotautomatichead_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotautomatichead.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_automatic=0", "trigger_hitbox_head_automatic=1");
            }
            if (triggerbotautomatichead.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_automatic=1", "trigger_hitbox_head_automatic=0");
            }
        }

        //Triggerbot Automatic Neck Checkbox [IMPLEMENTED]
        private void triggerbotautomaticneck_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotautomaticneck.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_automatic=0", "trigger_hitbox_neck_automatic=1");
            }
            if (triggerbotautomaticneck.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_automatic=1", "trigger_hitbox_neck_automatic=0");
            }
        }

        //Triggerbot Automatic Body Checkbox [IMPLEMENTED]
        private void triggerbotautomaticbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotautomaticbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_automatic=0", "trigger_hitbox_body_automatic=1");
            }
            if (triggerbotautomaticbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_automatic=1", "trigger_hitbox_body_automatic=0");
            }
        }

        //Triggerbot Automatic Arms Checkbox [IMPLEMENTED]
        private void triggerbotautomaticarms_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotautomaticarms.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_automatic=0", "trigger_hitbox_arms_automatic=1");
            }
            if (triggerbotautomaticarms.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_automatic=1", "trigger_hitbox_arms_automatic=0");
            }
        }

        //Triggerbot Automatic Legs Checkbox [IMPLEMENTED]
        private void triggerbotautomaticlegs_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotautomaticlegs.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_automatic=0", "trigger_hitbox_legs_automatic=1");
            }
            if (triggerbotautomaticlegs.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_automatic=1", "trigger_hitbox_legs_automatic=0");
            }
        }

        //Triggerbot Automatic Full Body Checkbox [IMPLEMENTED]
        private void triggerbotautomaticfullbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotautomaticfullbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_automatic=0", "trigger_fullbody_automatic=1");
            }
            if (triggerbotautomaticfullbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_automatic=1", "trigger_fullbody_automatic=0");
            }
        }

        //Triggerbot Sniper Head Checkbox [IMPLEMENTED]
        private void triggerbotsniperhead_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsniperhead.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_sniper=0", "trigger_hitbox_head_sniper=1");
            }
            if (triggerbotsniperhead.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_sniper=1", "trigger_hitbox_head_sniper=0");
            }
        }

        //Triggerbot Sniper Neck Checkbox [IMPLEMENTED]
        private void triggerbotsniperneck_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsniperneck.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_sniper=0", "trigger_hitbox_neck_sniper=1");
            }
            if (triggerbotsniperneck.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_sniper=1", "trigger_hitbox_neck_sniper=0");
            }
        }

        //Triggerbot Sniper Body Checkbox [IMPLEMENTED]
        private void triggerbotsniperbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsniperbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_sniper=0", "trigger_hitbox_body_sniper=1");
            }
            if (triggerbotsniperbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_sniper=1", "trigger_hitbox_body_sniper=0");
            }
        }

        //Triggerbot Sniper Arms Checkbox [IMPLEMENTED]
        private void triggerbotsniperarms_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsniperarms.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_sniper=0", "trigger_hitbox_arms_sniper=1");
            }
            if (triggerbotsniperarms.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_sniper=1", "trigger_hitbox_arms_sniper=0");
            }
        }

        //Triggerbot Sniper Legs Checkbox [IMPLEMENTED]
        private void triggerbotsniperlegs_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsniperlegs.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_sniper=0", "trigger_hitbox_legs_sniper=1");
            }
            if (triggerbotsniperlegs.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_sniper=1", "trigger_hitbox_legs_sniper=0");
            }
        }

        //Triggerbot Sniper Full Body Checkbox [IMPLEMENTED]
        private void triggerbotsniperfullbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotsniperfullbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_sniper=0", "trigger_fullbody_sniper=1");
            }
            if (triggerbotsniperfullbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_sniper=1", "trigger_fullbody_sniper=0");
            }
        }

        //Triggerbot Shotgun Head Checkbox [IMPLEMENTED]
        private void triggerbotshotgunhead_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotshotgunhead.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_shotgun=0", "trigger_hitbox_head_shotgun=1");
            }
            if (triggerbotshotgunhead.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_head_shotgun=1", "trigger_hitbox_head_shotgun=0");
            }
        }

        //Triggerbot Shotgun Neck Checkbox [IMPLEMENTED]
        private void triggerbotshotgunneck_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotshotgunneck.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_shotgun=0", "trigger_hitbox_neck_shotgun=1");
            }
            if (triggerbotshotgunneck.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_neck_shotgun=1", "trigger_hitbox_neck_shotgun=0");
            }
        }

        //Triggerbot Shotgun Body Checkbox [IMPLEMENTED]
        private void triggerbotshotgunbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotshotgunbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_shotgun=0", "trigger_hitbox_body_shotgun=1");
            }
            if (triggerbotshotgunbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_body_shotgun=1", "trigger_hitbox_body_shotgun=0");
            }
        }

        //Triggerbot Shotgun Arms Checkbox [IMPLEMENTED]
        private void triggerbotshotgunarms_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotshotgunarms.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_shotgun=0", "trigger_hitbox_arms_shotgun=1");
            }
            if (triggerbotshotgunarms.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_arms_shotgun=1", "trigger_hitbox_arms_shotgun=0");
            }
        }

        //Triggerbot Shotgun Legs Checkbox [IMPLEMENTED]
        private void triggerbotshotgunlegs_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotshotgunlegs.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_shotgun=0", "trigger_hitbox_legs_shotgun=1");
            }
            if (triggerbotshotgunlegs.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_hitbox_legs_shotgun=1", "trigger_hitbox_legs_shotgun=0");
            }
        }

        //Triggerbot Shotgun Full Body Checkbox [IMPLEMENTED]
        private void triggerbotshotgunfullbody_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotshotgunfullbody.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_shotgun=0", "trigger_fullbody_shotgun=1");
            }
            if (triggerbotshotgunfullbody.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("trigger_fullbody_shotgun=1", "trigger_fullbody_shotgun=0");
            }
        }

        #endregion Triggerbot Tab

        #region Visuals Tab

        private void visualstabbutton_Click(object sender, EventArgs e)
        {
            //Triggerbot Tab
            metroPanel10.Visible = true;
            //Rage Tab
            metroPanel6.Visible = true;
            //Visuals Tab
            metroPanel16.Visible = true;
        }

        //Visuals Filled Alpha Trackbar to Textbox [IMPLEMENTED]
        private void visualsfilledalphatrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            visualsfilledalphapercent.Text = visualsfilledalphatrackbar.Value.ToString();

            changeLine(richTextBox1, 101, "esp_fill_alpha=" + visualsfilledalphatrackbar.Value);
        }

        //Visuals Boxstyle to Textbox [IMPLEMENTED]
        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //None = 0
            //Static = 1
            //Static Corner = 2
            //Bounding = 3
            //Bounding Corner = 4

            if (metroComboBox2.SelectedItem.ToString() == "None")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=1", "esp_boxstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=2", "esp_boxstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=3", "esp_boxstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=4", "esp_boxstyle=0");
            }
            if (metroComboBox2.SelectedItem.ToString() == "Static")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=0", "esp_boxstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=2", "esp_boxstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=3", "esp_boxstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=4", "esp_boxstyle=1");
            }
            if (metroComboBox2.SelectedItem.ToString() == "Static Corner")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=0", "esp_boxstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=1", "esp_boxstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=3", "esp_boxstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=4", "esp_boxstyle=2");
            }
            if (metroComboBox2.SelectedItem.ToString() == "Bounding")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=0", "esp_boxstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=1", "esp_boxstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=2", "esp_boxstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=4", "esp_boxstyle=3");
            }
            if (metroComboBox2.SelectedItem.ToString() == "Bounding Corner")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=0", "esp_boxstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=1", "esp_boxstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=2", "esp_boxstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_boxstyle=3", "esp_boxstyle=4");
            }
        }

        //Visuals Healthbar Style to Textbox [IMPLEMENTED]
        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Off = 0
            //Text = 1
            //Bar Right = 2
            //Bar Left = 3
            //Bar Bottom = 4

            if (metroComboBox3.SelectedItem.ToString() == "Off")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=1", "esp_healthstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=2", "esp_healthstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=3", "esp_healthstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=4", "esp_healthstyle=0");
            }
            if (metroComboBox3.SelectedItem.ToString() == "Text")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=0", "esp_healthstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=2", "esp_healthstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=3", "esp_healthstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=4", "esp_healthstyle=1");
            }
            if (metroComboBox3.SelectedItem.ToString() == "Bar Right")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=0", "esp_healthstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=1", "esp_healthstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=3", "esp_healthstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=4", "esp_healthstyle=2");
            }
            if (metroComboBox3.SelectedItem.ToString() == "Bar Left")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=0", "esp_healthstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=1", "esp_healthstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=2", "esp_healthstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=4", "esp_healthstyle=3");
            }
            if (metroComboBox3.SelectedItem.ToString() == "Bar Bottom")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=0", "esp_healthstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=1", "esp_healthstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=2", "esp_healthstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_healthstyle=3", "esp_healthstyle=4");
            }
        }

        //Visuals Armor Style to Textbox [IMPLEMENTED]
        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Off = 0
            //Text = 1
            //Bar Right = 2
            //Bar Left = 3
            //Bar Bottom = 4

            if (metroComboBox4.SelectedItem.ToString() == "Off")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=1", "esp_armorstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=2", "esp_armorstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=3", "esp_armorstyle=0");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=4", "esp_armorstyle=0");
            }
            if (metroComboBox4.SelectedItem.ToString() == "Text")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=0", "esp_armorstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=2", "esp_armorstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=3", "esp_armorstyle=1");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=4", "esp_armorstyle=1");
            }
            if (metroComboBox4.SelectedItem.ToString() == "Bar Right")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=0", "esp_armorstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=1", "esp_armorstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=3", "esp_armorstyle=2");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=4", "esp_armorstyle=2");
            }
            if (metroComboBox4.SelectedItem.ToString() == "Bar Left")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=0", "esp_armorstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=1", "esp_armorstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=2", "esp_armorstyle=3");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=4", "esp_armorstyle=3");
            }
            if (metroComboBox4.SelectedItem.ToString() == "Bar Bottom")
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=0", "esp_armorstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=1", "esp_armorstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=2", "esp_armorstyle=4");
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_armorstyle=3", "esp_armorstyle=4");
            }
        }

        //Visual Enable ESP Checkbox [IMPLEMENTED]
        private void visualsenableesp_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsenableesp.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_active=0", "esp_active=1");
            }
            if (visualsenableesp.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_active=1", "esp_active=0");
            }
        }

        //Visual Filled Box Checkbox [IMPLEMENTED]
        private void visualsfilledboxcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsfilledboxcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_filledbox=0", "esp_filledbox=1");
            }
            if (visualsfilledboxcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_filledbox=1", "esp_filledbox=0");
            }
        }

        //Visuals Enable Glow Checkbox [IMPLEMENTED]
        private void visualsglowcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsglowcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_glow=0", "esp_glow=1");
            }
            if (visualsglowcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_glow=1", "esp_glow=0");
            }
        }

        //Visuals ESP Enemy Only Checkbox [IMPLEMENTED]
        private void visualsenemyonlycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsenemyonlycheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_enemy_only=0", "esp_enemy_only=1");
            }
            if (visualsenemyonlycheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_enemy_only=1", "esp_enemy_only=0");
            }
        }

        //Visuals Legit ESP Checkbox [IMPLEMENTED]
        private void visualslegitespcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualslegitespcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_legit=0", "esp_legit=1");
            }
            if (visualslegitespcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_legit=1", "esp_legit=0");
            }
        }

        //Visuals Glow Alpha Trackbar to Textbox [IMPLEMENTED]
        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel41.Text = metroTrackBar2.Value.ToString();

            changeLine(richTextBox1, 105, "esp_glow_alpha=" + metroTrackBar2.Value);
        }

        //Visuals Enable Radar Checkbox [IMPLEMENTED]
        private void visualsenableradarcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsenableradarcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_radar=0", "esp_radar=1");
            }
            if (visualsenableradarcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_radar=1", "esp_radar=0");
            }
        }

        //Visuals Visibility Check Checkbox [IMPLEMENTED]
        private void visualsvisibilitycheckcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsvisibilitycheckcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_visibility_check=0", "esp_visibility_check=1");
            }
            if (visualsvisibilitycheckcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_visibility_check=1", "esp_visibility_check=0");
            }
        }

        //Visuals Smoke Check Checkbox [IMPLEMENTED]
        private void visualssmokecheckcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualssmokecheckcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_smoke_check=0", "esp_smoke_check=1");
            }
            if (visualssmokecheckcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_smoke_check=1", "esp_smoke_check=0");
            }
        }

        //Visuals Headdot Checkbox [IMPLEMENTED]
        private void visualsheaddotcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsheaddotcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_headdot=0", "esp_headdot=1");
            }
            if (visualsheaddotcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_headdot=1", "esp_headdot=0");
            }
        }

        //Visuals Show Name Checkbox [IMPLEMENTED]
        private void visualsshownamecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsshownamecheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_name=0", "esp_name=1");
            }
            if (visualsshownamecheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_name=1", "esp_name=0");
            }
        }

        //Visuals Show Wins Checkbox [IMPLEMENTED]
        private void visualsshowwinscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsshowwinscheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_wins=0", "esp_wins=1");
            }
            if (visualsshowwinscheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_wins=1", "esp_wins=0");
            }
        }

        //Visuals Show Rank Checkbox [IMPLEMENTED]
        private void visualsshowrankcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsshowrankcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_rank=0", "esp_rank=1");
            }
            if (visualsshowrankcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_rank=1", "esp_rank=0");
            }
        }

        //Visuals Show Weapon Checkbox [IMPLEMENTED]
        private void visualsshowweaponcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsshowweaponcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_weapon=0", "esp_weapon=1");
            }
            if (visualsshowweaponcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_weapon=1", "esp_weapon=0");
            }
        }

        //Visuals Show Defusing Checkbox [MAYBE NOT RIGHT]
        private void visualsshowdefusingcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsshowdefusingcheckbox.Checked)
            {
                visualsbombespcheckbox.Checked = true;
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_bomb=0", "esp_bomb=1");
            }
            if (visualsshowdefusingcheckbox.Checked == false)
            {
                visualsbombespcheckbox.Checked = false;
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_bomb=1", "esp_bomb=0");
            }
        }

        //Visuals Chicken ESP Checkbox [IMPLEMENTED]
        private void visualschickenespcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualschickenespcheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_chicken=0", "esp_chicken=1");
            }
            if (visualschickenespcheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_chicken=1", "esp_chicken=0");
            }
        }

        //Visuals Show Bomb ESP Checkbox [IMPLEMENTED]
        private void visualsbombespcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsbombespcheckbox.Checked)
            {
                visualsshowdefusingcheckbox.Checked = true;
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_bomb=0", "esp_bomb=1");
            }
            if (visualsbombespcheckbox.Checked == false)
            {
                visualsshowdefusingcheckbox.Checked = false;
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("esp_bomb=1", "esp_bomb=0");
            }
        }

        //Visuals Charms Enable Checkbox [IMPLEMENTED]
        private void visualscharmsenablecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualscharmsenablecheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("chams_active=0", "chams_active=1");
            }
            if (visualscharmsenablecheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("chams_active=1", "chams_active=0");
            }
        }

        //Visuals Charms Visible Only Checkbox [IMPLEMENTED]
        private void visualsvisibleonlycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualsvisibleonlycheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("chams_visible_only=0", "chams_visible_only=1");
            }
            if (visualsvisibleonlycheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("chams_visible_only=1", "chams_visible_only=0");
            }
        }

        //Visuals Charms Enemy Only Checkbox [IMPLEMENTED]
        private void visualscharmsenemyonlycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (visualscharmsenemyonlycheckbox.Checked)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("chams_enemy_only=0", "chams_enemy_only=1");
            }
            if (visualscharmsenemyonlycheckbox.Checked == false)
            {
                richTextBox1.Rtf = richTextBox1.Rtf.Replace("chams_enemy_only=1", "chams_enemy_only=0");
            }
        }

        #endregion Visuals Tab

    }
}