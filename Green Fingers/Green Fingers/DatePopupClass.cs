﻿using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Green_Fingers
{
    public class DatePopupClass : Mainfrm
    {
        public void Datechecker()
        {
            DateTime GrabSysDate = DateTime.Today;
            String FullDate = GrabSysDate.ToString("dd'/'MM'/'yyyy", new CultureInfo("en-GB"));
            String MoDate = GrabSysDate.ToString("dd'/'MM", new CultureInfo("en-GB"));
            //Console.WriteLine(FullDate); //For testing
            //Console.WriteLine(MoDate); //For testing

            //  Load the XML file
            XDocument gfdocxml = XDocument.Load("Resources\\SavedReminders.xml");
            string Pn;
            string Sidd;
            string Sucd;
            string Sodd;
            string Pod;
            string Htd;
            foreach (var desgf in gfdocxml.Descendants("Reminder"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    Pn = desgf.Element("PlantName").Value.ToString(),
                    Sidd = desgf.Element("SowInDoorsDate").Value.ToString(),
                    Sucd = desgf.Element("SowUnderCoverDate").Value.ToString(),
                    Sodd = desgf.Element("SowOutDoorsDate").Value.ToString(),
                    Pod = desgf.Element("PlantOutDoors").Value.ToString(),
                    Htd = desgf.Element("HarvestTimeDate").Value.ToString()

                });

                if (FullDate == Sidd || MoDate == Sidd)
                {
                    MessageBox.Show("Are ready to sow in doors! " + Sidd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nfyIGf = new System.Windows.Forms.NotifyIcon(components);
                    nfyIGf.BalloonTipText = "Are ready to sow in doors! " + Sidd;
                    nfyIGf.BalloonTipTitle = "Your: " + Pn;
                    nfyIGf.Visible = true;
                    nfyIGf.Icon = new Icon("Resources/leaf.ico", 40, 40);
                    nfyIGf.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGf.ShowBalloonTip(3);
                }

                if (FullDate == Sucd || MoDate == Sucd)
                {
                    MessageBox.Show("Are ready to sow under cover! " + Sucd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nfyIGf = new System.Windows.Forms.NotifyIcon(this.components);
                    nfyIGf.BalloonTipText = "Are ready to sow under cover! " + Sucd;
                    nfyIGf.BalloonTipTitle = "Your: " + Pn;
                    nfyIGf.Visible = true;
                    nfyIGf.Icon = new Icon("Resources/leaf.ico", 40, 40);
                    nfyIGf.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGf.ShowBalloonTip(3);
                }

                if (FullDate == Sodd || MoDate == Sodd)
                {
                    MessageBox.Show("Are ready to sow out doors! " + Sodd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nfyIGf = new System.Windows.Forms.NotifyIcon(this.components);
                    nfyIGf.BalloonTipText = "Are ready to sow out doors! " + Sodd;
                    nfyIGf.BalloonTipTitle = "Your: " + Pn;
                    nfyIGf.Visible = true;
                    nfyIGf.Icon = new Icon("Resources/leaf.ico", 40, 40);
                    nfyIGf.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGf.ShowBalloonTip(3);
                }

                if (FullDate == Pod || MoDate == Pod)
                {
                    MessageBox.Show("Are ready to plant out doors! " + Pod, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nfyIGf = new System.Windows.Forms.NotifyIcon(this.components);
                    nfyIGf.BalloonTipText = "Are ready to plant out doors! " + Pod;
                    nfyIGf.BalloonTipTitle = "Your: " + Pn;
                    nfyIGf.Visible = true;
                    nfyIGf.Icon = new Icon("Resources/leaf.ico", 40, 40);
                    nfyIGf.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGf.ShowBalloonTip(3);
                }

                if (FullDate == Htd || MoDate == Htd)
                {
                    MessageBox.Show("Are ready for harvest congratulations! " + Htd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nfyIGf = new System.Windows.Forms.NotifyIcon(this.components);
                    nfyIGf.BalloonTipText = "Are ready for harvest congratulations! " + Htd;
                    nfyIGf.BalloonTipTitle = "Your: " + Pn;
                    nfyIGf.Visible = true;
                    nfyIGf.Icon = new Icon("Resources/leaf.ico", 40, 40);
                    nfyIGf.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGf.ShowBalloonTip(3);
                }

                if (item == null)
                {
                    MessageBox.Show("Corrupt XML file!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}