using Microsoft.Win32;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.IO.IsolatedStorage;

namespace System_Info
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public Form1()
        {
            InitializeComponent();
        }
        CPUInfo ci = new CPUInfo();
        int isss = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtCPU_Click(object sender, EventArgs e)
        {
            bgwCPUInfo.RunWorkerAsync();
        }

        private void progCPU_ValueChanged(object sender, EventArgs e)
        {

        }
        string CPUName;
        int coreCount = 0;
        uint CPUSpeed;
        float basespe;
        bool started = false;
        RAMInfo ri = new RAMInfo();
        public string[] lines = { "StartUp:False", "LightMode:False" };
        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\Program Files (x86)\\System Info"))
            {
                create();
                settings.load();
            }
            else
            {
                settings.load();
            }
            started = true;
            pnlRAM.Hide();
            ManagementObjectSearcher mos =  new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                CPUName = mo["Name"].ToString();
                coreCount += int.Parse(mo["NumberOfCores"].ToString());
                CPUSpeed = (uint)mo["MaxClockSpeed"];
            }
            txtCPU.Text = CPUName;
            txtThreads.Text = "Threads: " + Environment.ProcessorCount.ToString();
            basespe = CPUSpeed;
            basespe = basespe / 1000f;
            txtClockSpeed.Text = "Base speed: " + basespe.ToString("0.00") + "GHz";
            txtCores.Text = "Cores: " + coreCount;
            txtRAM.Text = "Installed RAM: " + ri.GetTotalMemoryInBytes() + "GB " + ri.RamType;
            pnlCPU.Location = new Point(65, 0);
            txtRAMSpeed.Text = "RAM Speed: " + ri.sp.ToString() + "MHz";
            txtRAMSlots.Text = "Installed RAM Sticks: " + ri.GetNoRamSlots();
            pnlWhite.SendToBack();
            pnlWhite2.BringToFront();
            pnlWhite3.SendToBack();
            pnlSettings.Hide();

            pnlCPU.Show();
            if (settings.StartUp1)
            {
                tglstartup.Checked = true;
            }
            else
            {
                tglstartup.Checked = false;
            }
            if (settings.LightMode1)
            {
                tglLightMode.Checked = true;
            }
            else
            {
                tglLightMode.Checked = false;
            }

            ChangeMode();

        }
        
        public async void create()
        {
            Directory.CreateDirectory("C:\\Program Files (x86)\\System Info");
            File.Create("C:\\Program Files (x86)\\System Info\\settings.txt").Dispose();
            
            
            File.WriteAllLines("C:\\Program Files (x86)\\System Info\\settings.txt", lines);
        }
        private void pnlCPU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            pnlCPU.Location = new Point(65, 0);
            pnlWhite.SendToBack();
            pnlWhite2.BringToFront();
            pnlWhite3.SendToBack();
            tran.HideSync(pnlSettings);
            tran.HideSync(pnlRAM);
            tran.ShowSync(pnlCPU);
        }


        private void bgwCPUInfo_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            pnlWhite2.SendToBack();
            pnlRAM.Location = new Point(65, 0);
            pnlWhite.BringToFront();
            pnlWhite3.SendToBack();
            tran.HideSync(pnlSettings);
            tran.HideSync(pnlCPU);
            tran.ShowSync(pnlRAM);
        }
        float percent;
        int templ;
        private void tmrSys_Tick(object sender, EventArgs e)
        {
            if (started)
            {
                percent = 0;
                templ = 0;
                if (isss == 1)
                {
                    ci.first();
                    isss++;
                }
                progCPU.Value = (int)perCPU.NextValue();
                txtCPUsage.Text = progCPU.Value.ToString("0") + "%";
                txtCPUTemp.Text = "CPU Temperature: " + ci.GetCpuTemp() + "°C";
                templ = int.Parse(ri.mbs) - int.Parse(perRAM.NextValue().ToString());

                percent = (templ / float.Parse(ri.mbs)) * 100;

                progRAM.Value = int.Parse(percent.ToString("0"));
                txtRAMUse.Text = percent.ToString("0") + "%";
                txtAvailable.Text = "Available RAM: " + perRAM.NextValue().ToString() + "MB";
                niThis.Text = "CPU Temp: " + ci.GetCpuTemp() + "°C" + Environment.NewLine + "RAM Usage: " + percent.ToString("0") + "%";

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                niThis.Visible = true;
            }
        }

        private void niThis_Click(object sender, EventArgs e)
        {


        }

        private void niThis_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetAsyncKeyState(Keys.RButton) < 0)
            {

            }
            else
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                niThis.Visible = false;
                
            }
        }

        private void cmsNI_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmsNI_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.ToString() == "Exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                niThis.Visible = false;
            }
        }

        private void tglstartup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            try
            {
                if (tglstartup.Checked)
                {
                    registryKey.SetValue("SystemInfo", Application.ExecutablePath);

                }
                else
                {
                    registryKey.DeleteValue("SystemInfo");

                }
            }
            catch (Exception)
            {
                
            }

            settings.StartUp1 = tglstartup.Checked;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlWhite2.SendToBack();
            pnlWhite.SendToBack();
            pnlSettings.Location = new Point(65, 0);
            pnlWhite3.BringToFront();
            tran.HideSync(pnlCPU);
            tran.HideSync(pnlRAM);
            tran.ShowSync(pnlSettings);
        }

        private void tglLightMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMode();
            settings.LightMode1 = tglLightMode.Checked;
        }
        void ChangeMode()
        {
            if (tglLightMode.Checked)
            {
                btnCPU.Image = System_Info.Properties.Resources.processor_24pxBlack;
                btnRAM.Image = System_Info.Properties.Resources.memory_slot_24pxBlack;
                btnSettings.Image = System_Info.Properties.Resources.settings_24pxBlack;

                pnlSidebar.BackColor = Color.FromName("Gainsboro");
                this.BackColor = Color.FromArgb(231, 231, 231);
                pnlCPU.BackColor = Color.FromArgb(231, 231, 231);
                pnlRAM.BackColor = Color.FromArgb(231, 231, 231);
                pnlSettings.BackColor = Color.FromArgb(231, 231, 231);
                progCPU.FillColor = Color.FromName("Gainsboro");
                progRAM.FillColor = Color.FromName("Gainsboro");

                txtAvailable.ForeColor = Color.Black;
                txtClockSpeed.ForeColor = Color.Black;
                txtCores.ForeColor = Color.Black;
                txtCPU.ForeColor = Color.Black;
                txtCPUsage.ForeColor = Color.Black;
                txtCPUTemp.ForeColor = Color.Black;
                txtLightMode.ForeColor = Color.Black;
                txtME.ForeColor = Color.Black;
                txtRAM.ForeColor = Color.Black;
                txtRAMSlots.ForeColor = Color.Black;
                txtRAMSpeed.ForeColor = Color.Black;
                txtRAMUse.ForeColor = Color.Black;
                txtStartUp.ForeColor = Color.Black;
                txtThreads.ForeColor = Color.Black;

               
            }
            else
            {
                btnCPU.Image = System_Info.Properties.Resources.processor_24pxWhite;
                btnRAM.Image = System_Info.Properties.Resources.memory_slot_24pxWhite;
                btnSettings.Image = System_Info.Properties.Resources.settings_24px;

                pnlSidebar.BackColor = Color.FromArgb(35, 35, 35);
                this.BackColor = Color.FromArgb(25, 25, 25);
                pnlCPU.BackColor = Color.FromArgb(25, 25, 25);
                pnlRAM.BackColor = Color.FromArgb(25, 25, 25);
                pnlSettings.BackColor = Color.FromArgb(25, 25, 25);
                progCPU.FillColor = Color.FromArgb(35, 35, 35);;
                progRAM.FillColor = Color.FromArgb(35, 35, 35);;

                txtAvailable.ForeColor = Color.White;
                txtClockSpeed.ForeColor = Color.White;
                txtCores.ForeColor = Color.White;
                txtCPU.ForeColor = Color.White;
                txtCPUsage.ForeColor = Color.White;
                txtCPUTemp.ForeColor = Color.White;
                txtLightMode.ForeColor = Color.White;
                txtME.ForeColor = Color.White;
                txtRAM.ForeColor = Color.White;
                txtRAMSlots.ForeColor = Color.White;
                txtRAMSpeed.ForeColor = Color.White;
                txtRAMUse.ForeColor = Color.White;
                txtStartUp.ForeColor = Color.White;
                txtThreads.ForeColor = Color.White;

            }
        }
        public Settings settings = new Settings();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.save(tglstartup.Checked, tglLightMode.Checked);
            
        }

    }
    public class Settings
    {
       
        
        public TextReader tr;
        public TextWriter tr2;

        
        public bool StartUp1;
        public bool LightMode1;
        public void init(bool save)
        {

            if (save)
            {
                tr.Close();
                tr2 = new StreamWriter(@"C:\Program Files (x86)\System Info\settings.txt");
            }
            else
            {
                tr = new StreamReader(@"C:\Program Files (x86)\System Info\settings.txt");
            }

            
        }
        public async void load()
        {

            init(false);
            string[] one = tr.ReadLine().Split(':');
            string[] two = tr.ReadLine().Split(':');
            StartUp1 = bool.Parse(one[1]);
            LightMode1 = bool.Parse(two[1]);

            tr.Dispose();

        }
        public async void save(bool StartUp, bool LightMode)
        {
            init(true);

            
            tr2.WriteLine("StartUp:" + StartUp1);

            tr2.WriteLine("LightMode:" + LightMode1);
            tr2.Dispose();
        }

    }
}