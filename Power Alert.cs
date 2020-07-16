using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using HtmlAgilityPack;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AESO__Power_Alert
{
    public partial class Form1 : Form
    {

        bool enableTimer = false;
        bool soundPlaying = false;
        bool warned = false;
        int PreviousPowerMode = 0;
        int PowerMode = 0;
        double dblPrice = 0;
        string strPrice = "";
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //Drumheller Power Variables
        int DHDispatch = 0;
        int DH16nm = 0;
        int DHClarke = 0;
        int DHMin = 0;

        //Three Hills Power Variables
        int THDispatch = 0;
        int TH16nm = 0;
        int THClarke = 0;
        int THMin = 0;

        //Excel Grabbing Power Bounds
        double LowerBound = 0;
        double Range1a = 0;
        double Range1b = 0;
        double Range2a = 0;
        double Range2b = 0;
        double Range3a = 0;
        double Range3b = 0;
        double UpperBound = 0;

        

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            updatePrice();
            fillDataGrid();
            grabPowerBounds();
            updatePowerMode();
            PreviousPowerMode = PowerMode;
            PowerModeColor(PowerMode);



            lblPrice.Text = "$" + strPrice;
            lblUpdate.Text = "Last updated: " + DateTime.Now.ToString("h:mm:ss tt");
            lblPowerMode.Text = "Power Mode: " + PowerMode.ToString();

            enableTimer = true;
            timer1.Enabled = true;

        }

        private void updatePrice()
        {
            string html;
            // obtain some arbitrary html....
            using (var client = new WebClient())
            {
                html = client.DownloadString("http://ets.aeso.ca/ets_web/ip/Market/Reports/CSMPriceReportServlet?contentType=html");
            }
            // use the html agility pack: http://www.codeplex.com/htmlagilitypack
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            StringBuilder sb = new StringBuilder();
            foreach (HtmlTextNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                sb.AppendLine(node.Text);
                if (node.Text.Length > 2)
                {
                    if (node.Text.Substring(0, 3) == "Pro")
                    {
                        String Price = node.Text.Substring(44, 5);
                        strPrice = Price;
                        dblPrice = Convert.ToDouble(Price);
                    }
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (enableTimer == true)
            {
                updatePrice();
                updatePowerMode();
                PowerModeColor(PowerMode);
                checkPowerModeChange();
            }
            lblPowerMode.Text = "Power Mode: " + PowerMode.ToString();
            lblPrice.Text = "$" + strPrice;
            lblUpdate.Text = "Last updated: " + DateTime.Now.ToString("h:mm:ss tt");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                player.Stop();
                soundPlaying = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillDataGrid()
        {
            var workbook = ExcelFile.Load((String)Directory.GetCurrentDirectory().ToString() + "\\PowerSpreadSheet\\PowerPrice.xlsx");

            DataGridViewConverter.ExportToDataGridView(workbook.Worksheets.ActiveWorksheet, this.dataGridView1, new ExportToDataGridViewOptions() { ColumnHeaders = true });
        }

        private void PowerModeColor(int i)
        {
            DataGridViewRow PowerMode1 = dataGridView1.Rows[1];
            DataGridViewRow PowerMode2 = dataGridView1.Rows[2];
            DataGridViewRow PowerMode3 = dataGridView1.Rows[3];
            DataGridViewRow PowerMode4 = dataGridView1.Rows[4];
            DataGridViewRow PowerMode5 = dataGridView1.Rows[5];

            switch (i)
            {
                case 1:


                    PowerMode1.DefaultCellStyle.BackColor = Color.White;
                    PowerMode2.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode3.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode4.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode5.DefaultCellStyle.BackColor = Color.Gray;
                    break;

                case 2:

                    PowerMode1.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode2.DefaultCellStyle.BackColor = Color.White;
                    PowerMode3.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode4.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode5.DefaultCellStyle.BackColor = Color.Gray;
                    break;

                case 3:
                    PowerMode1.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode2.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode3.DefaultCellStyle.BackColor = Color.White;
                    PowerMode4.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode5.DefaultCellStyle.BackColor = Color.Gray;
                    break;

                case 4:

                    PowerMode1.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode2.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode3.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode4.DefaultCellStyle.BackColor = Color.White;
                    PowerMode5.DefaultCellStyle.BackColor = Color.Gray;
                    break;

                case 5:

                    PowerMode1.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode2.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode3.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode4.DefaultCellStyle.BackColor = Color.Gray;
                    PowerMode5.DefaultCellStyle.BackColor = Color.White;
                    break;
            }

                    dataGridView1.Rows[1].Equals(PowerMode1);
                    dataGridView1.Rows[2].Equals(PowerMode2);
                    dataGridView1.Rows[3].Equals(PowerMode3);
                    dataGridView1.Rows[4].Equals(PowerMode4);
                    dataGridView1.Rows[5].Equals(PowerMode5);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void updatePowerMode()
        {
            if (dblPrice < LowerBound)
            {
                PowerMode = 1;

                txtDH16nm.Text = "Full";
                txt3H16nm.Text = "Full";
                txtDHClarke.Text = "Full";
                txt3HClarke.Text = "Full";
                txtDHMin.Text = (DHDispatch + 1).ToString();
                txt3HMin.Text = (THDispatch + 1).ToString();
                txtCMHPower.Text = "Full";
            }
            else if (dblPrice >= LowerBound && dblPrice <= Range1b -1)
            {
                PowerMode = 2;

                txtDH16nm.Text = "ECO";
                txt3H16nm.Text = "ECO";
                txtDHClarke.Text = "Full";
                txt3HClarke.Text = "Full";
                txtDHMin.Text = (DHDispatch + 1).ToString();
                txt3HMin.Text = (THDispatch + 1).ToString();
                txtCMHPower.Text = "Full";
            }
            else if (dblPrice >= Range2a && dblPrice <= Range2b -1)
            {
                PowerMode = 3;

                txtDH16nm.Text = "ECO";
                txt3H16nm.Text = "ECO";
                txtDHClarke.Text = "Full";
                txt3HClarke.Text = "Full";
                txtDHMin.Text = (DHDispatch + 1).ToString();
                txt3HMin.Text = (THDispatch + 1).ToString();
                txtCMHPower.Text = "42MW";
            }
            else if (dblPrice >= Range3a && dblPrice <= Range3b -1)
            {
                PowerMode = 4;

                txtDH16nm.Text = "Standby";
                txt3H16nm.Text = "Standby";
                txtDHClarke.Text = "ECO";
                txt3HClarke.Text = "ECO";
                txtDHMin.Text = (DHDispatch + 1).ToString();
                txt3HMin.Text = (THDispatch + 1).ToString();
                txtCMHPower.Text = "42MW";
            }
            else if (dblPrice >= UpperBound)
            {
                PowerMode = 5;

                txtDH16nm.Text = "Standby";
                txt3H16nm.Text = "Standby";
                txtDHClarke.Text = "Standby";
                txt3HClarke.Text = "STandby";
                txtDHMin.Text = (DHDispatch + 1).ToString();
                txt3HMin.Text = (THDispatch + 1).ToString();
                txtCMHPower.Text = "42MW";
            }
        }

        private void checkPowerModeChange()
        {
            if(PreviousPowerMode != PowerMode)
            {
                switch(PowerMode)
                {
                    case 1:
                        playSoundLooping(Directory.GetCurrentDirectory() + "\\Alerts\\Alert1.wav");
                        break;

                    case 2:
                        playSoundLooping(Directory.GetCurrentDirectory() + "\\Alerts\\Alert2.wav");
                        break;

                    case 3:
                        playSoundLooping(Directory.GetCurrentDirectory() + "\\Alerts\\Alert3.wav");
                        break;

                    case 4:
                        playSoundLooping(Directory.GetCurrentDirectory() + "\\Alerts\\Alert4.wav");
                        break;

                    case 5:
                        playSoundLooping(Directory.GetCurrentDirectory() + "\\Alerts\\Alert5.wav");
                        break;
                }
               
            }
            PreviousPowerMode = PowerMode;

        }

        private void playSoundLooping(string path)
        {
            player = new System.Media.SoundPlayer(@path);
            player.PlayLooping();
            soundPlaying = true;
        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@path);
            player.Play();
        }

        private void grabPowerBounds()
        {


            string strLowerBound = dataGridView1[0,1].Value.ToString();
            string strRange1 = dataGridView1[0,2].Value.ToString();
            int Range1Dash = findDashIndex(strRange1);
            string strRange2 = dataGridView1[0,3].Value.ToString();
            int Range2Dash = findDashIndex(strRange2);
            string strRange3 = dataGridView1[0,4].Value.ToString();
            int Range3Dash = findDashIndex(strRange3);
            string strUpperBound = dataGridView1[0, 5].Value.ToString();


            LowerBound = Convert.ToDouble(strLowerBound.Substring(1,strLowerBound.Length - 1));
            Range1a =    Convert.ToDouble(strRange1.Substring(0, Range1Dash - 1));
            Range1b =    Convert.ToDouble(strRange1.Substring(Range1Dash + 2, strRange1.Length - Range1Dash - 2));
            Range2a =    Convert.ToDouble(strRange2.Substring(0, Range2Dash - 1));
            Range2b =    Convert.ToDouble(strRange2.Substring(Range2Dash + 2, strRange2.Length - Range2Dash - 2));
            Range3a =    Convert.ToDouble(strRange3.Substring(0, Range3Dash - 1));
            Range3b =    Convert.ToDouble(strRange3.Substring(Range3Dash + 2, strRange3.Length - Range3Dash - 2));
            UpperBound = Convert.ToDouble(strUpperBound.Substring(1, strUpperBound.Length -1));
        }

        private int findDashIndex(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if(s.Substring(i,1) == "-")
                {
                    return i;
                    break;
                }
                
            }
            return 0;
        }

        private void BtnSetDH_Click(object sender, EventArgs e)
        {
            DHDispatch = Convert.ToInt32(txtDHSet.Text);
            txtDHDispatch.Text = DHDispatch.ToString();
            updatePowerMode();
            txtDHSet.Text = "";
        }

        private void BtnSet3H_Click(object sender, EventArgs e)
        {
            THDispatch = Convert.ToInt32(txt3HSet.Text);
            txt3HDispatch.Text = THDispatch.ToString();
            updatePowerMode();
            txt3HSet.Text = "";
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            updatePrice();
            updatePowerMode();
            PowerModeColor(PowerMode);
            checkPowerModeChange();

            lblPowerMode.Text = "Power Mode: " + PowerMode.ToString();
            lblPrice.Text = "$" + strPrice;
            lblUpdate.Text = "Last updated: " + DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}