using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Firmware-Checksum 0x18FFF
//Firmware-Start 0x9200

//Settings-Checksum 0x8E1FF
//Settings-Start 19000

//Board PowerLimits
//Default PL 0x8BDF6
//Max PL 0x8BDFA

namespace ABE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			this.list_0 = this.method_1();
		}

		private Class24 _RomHeader;
		private string _FileName;
		private byte _ImageChecksum;
		private byte _ImageChecksum2;
		private byte _GeneratedChecksum;
		private byte _GeneratedChecksum2;
		private Class30 class30_0;
		private readonly List<Interface0> list_0;

		private List<Interface0> method_1()
		{
			return new List<Interface0>
			{
				//this.frcFanRange,
				//this.bbcBaseBoost,
				//this.ptcPerfTable,
				//this.btcBoostClocks,
				//this.bccBoostStates,
				//this.ptcPowerTable,
				//this.vtcVoltageTable,
				//this.ttcTempTargets
			};
		}

		internal Class24 RomHeader
		{
			get
			{
				return this._RomHeader;
			}
			set
			{
				this._RomHeader = value;
				this.UpdateDisplay();
			}
		}

		private void UpdateDisplay()
		{
			if (this.RomHeader == null)
			{
				return;
			}
			this.lblName.Text = this.RomHeader.String_1.Replace("\r\n", " ");
			this.lblGPU.Text = this.RomHeader.String_3;
			this.lblBIOS.Text = this.RomHeader.String_2;
			this.lblDevID.Text = string.Format("{0:X4} - {1:X4}", this.RomHeader.class26_0.UInt16_0, this.RomHeader.class26_0.UInt16_1);
			this.lblSubVendor.Text = this.RomHeader.String_4.ToUpper();
			this.lblDate.Text = this.RomHeader.String_0;
			this.lblChkSum.Text = string.Format("{0:X2} - [{1:X2}] / {2:X2} - [{3:X2}]", this.ImageChecksum, this.GeneratedChecksum, this.ImageChecksum2, this.GeneratedChecksum2);
			if (this.ImageChecksum == this.GeneratedChecksum && this.ImageChecksum2 == this.GeneratedChecksum2)
			{
				this.lblChkSum.BackColor = Color.LightGreen;
			}
			else
			{
				this.lblChkSum.BackColor = Color.LightCoral;
			}
			this.lblFilename.Text = this.FileName;
			lblHash.Text = this.RomHeader.Hash;
			lblDefaultPL.Text = this.RomHeader.GetDefaultPL;
			lblMaxPL.Text = this.RomHeader.GetMaxPL;
		}


		public byte ImageChecksum2
		{
			get
			{
				return this._ImageChecksum2;
			}
			set
			{
				this._ImageChecksum2 = value;
				this.UpdateDisplay();
			}
		}

		public byte GeneratedChecksum2
		{
			get
			{
				return this._GeneratedChecksum2;
			}
			set
			{
				this._GeneratedChecksum2 = value;
				this.UpdateDisplay();
			}
		}

		public byte ImageChecksum
		{
			get
			{
				return this._ImageChecksum;
			}
			set
			{
				this._ImageChecksum = value;
				this.UpdateDisplay();
			}
		}

		public byte GeneratedChecksum
		{
			get
			{
				return this._GeneratedChecksum;
			}
			set
			{
				this._GeneratedChecksum = value;
				this.UpdateDisplay();
			}
		}

		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				this._FileName = value;
				this.UpdateDisplay();
			}
		}

		public void ResetDisplay(bool unsupported = false)
		{
			this.lblName.Text = (unsupported ? "Unsupported Device" : "");
			this.lblGPU.Text = "";
			this.lblBIOS.Text = "";
			this.lblDevID.Text = "";
			this.lblSubVendor.Text = "";
			this.lblDate.Text = "";
			this.lblFilename.Text = "";
			this.lblChkSum.Text = "";
			this.lblDefaultPL.Enabled = false;
			this.lblMaxPL.Enabled = false;
			this.Btn_Save.Enabled = false;
			this.lblChkSum.BackColor = SystemColors.Control;
		}

        private void Btn_open_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.DefaultExt = "*.rom";
			openFileDialog.Filter = "BIOS Files|*.rom;*.bin";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_3(openFileDialog.FileName);
			}
		}

		private void method_2()
		{
			ResetDisplay(false);
			foreach (Interface0 @interface in this.list_0)
            {
                @interface.Reset();
            }
            this.tcSettings.Enabled = false;
        }

		private void method_3(string string_0)
		{
			try
			{
				this.method_2();
				this.class30_0 = new Class30(string_0);
				Class25 @class = this.class30_0.list_0[0];
				this.RomHeader = @class.class24_0;
				if (RomHeader.Boolean_0)
				{

					this.FileName = new FileInfo(string_0).Name;
					this.ImageChecksum = @class.Byte_0;
					this.GeneratedChecksum = @class.method_2(false);
					this.ImageChecksum2 = @class.Byte_2;
					this.GeneratedChecksum2 = @class.method_2(true);
					this.lblDefaultPL.Enabled = true;
					this.lblMaxPL.Enabled = true;
					this.Btn_Save.Enabled = true;
				return;
				}
				this.ResetDisplay(true);
			}
			catch
			{
				this.ResetDisplay(true);
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			this.method_2();
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			this.Text = string.Format("ABE v{0}.{1}{2}", version.Major, version.Minor, version.Build);
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length > 1 && (commandLineArgs[1].ToLower().EndsWith(".bin") || commandLineArgs[1].ToLower().EndsWith(".rom")))
			{
				this.method_3(commandLineArgs[1]);
			}
		}

        private void lblBIOS_Click(object sender, EventArgs e)
        {
			if(lblBIOS.Text.Length == 14)
            {
				System.Diagnostics.Process.Start(@"https://www.techpowerup.com/vgabios/?architecture=&manufacturer=&model=&version="+ lblBIOS.Text +@"&interface=&memType=&memSize=&since=");
			}
        }


		private void EditBiosBoardPowerLimit(bool max)
		{ 
			if (lblDefaultPL.Text.Length != 0 && lblMaxPL.Text.Length !=0)
            {
				Class25 @class = this.class30_0.list_0[0];
				if (!max)
				{
					Class29.setpower(class30_0.byte_1, 0x8BDF6, int.Parse(lblDefaultPL.Text));
				}
				else
				{
					Class29.setpower(class30_0.byte_1, 0x8BDFA, int.Parse(lblMaxPL.Text));
				}
				this.GeneratedChecksum2 = @class.method_2(true);
				this.lblChkSum.Text = string.Format("{0:X2} - [{1:X2}] / {2:X2} - [{3:X2}]", this.ImageChecksum, this.GeneratedChecksum, this.ImageChecksum2, this.GeneratedChecksum2);
				if (this.ImageChecksum == this.GeneratedChecksum && this.ImageChecksum2 == this.GeneratedChecksum2)
				{
					this.lblChkSum.BackColor = Color.LightGreen;
				}
				else
				{
					this.lblChkSum.BackColor = Color.LightCoral;
					DialogResult dialogResult = MessageBox.Show("The CheckSum is incorrect, Do you want to correct this?", "CheckSum Fault:", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						@class.Byte_2 = GeneratedChecksum2;
						ImageChecksum2 = @class.Byte_2;
						UpdateDisplay();
					}				
				}

			}
        }

		public void method_1(string string_1)
		{
			foreach (Class25 @class in this.list_0)
			{
				@class.method_1();
			}
			File.WriteAllBytes(string_1, class30_0.byte_1);
		}

		private void method_4(string string_0)
		{
			if (this.class30_0 != null)
			{
				this.class30_0.method_1(string_0);
			}
		}

		private void Btn_Save_Click(object sender, EventArgs e)
        {
			if (this.class30_0 != null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.DefaultExt = "*.rom";
				saveFileDialog.Filter = "BIOS ROM|*.rom";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{

					this.method_4(saveFileDialog.FileName);
					this.method_3(saveFileDialog.FileName);
				}
			}
		}

        private void lblDefaultPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(false);
		}

        private void lblMaxPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(true);
		}
    }
}
