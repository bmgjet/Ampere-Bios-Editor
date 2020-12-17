using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			this.list_0 = this.method_1();
		}
		public static bool triedalready = false;
		public static bool notsupported = false;
		private Class24 _RomHeader;
		private string _FileName;
		private string _FileDir;
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

		private bool CheckMD5()
        {
			switch (this.RomHeader.Hash)
            {
                case "cf8b37fe940a85050b212e87798b339e":
					Class24.ThisBiosType = 2;
					Type2Warning();
                    return true;
                case "4760b62bdbb01260de56597c3d85ac4a":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "e4511fe6d20827b85058186f97b42c55":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "8017929d9a182440c581a6ed107bbdce":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "889c2f6b5a436cb3ed56c4e18899eeb9":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "ae2c678973f9c4daa053a53205126905":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "68ec3d602eb615bb417b20abf07719d6":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "58566f6ba754c95b8838d4276a662f61":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "2733eb04d8c0ec2a7d561b7306ad38e6":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				//3080
				case "2e8a6d0da567f87345a70c279b81f325":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "3fb11fab95af362775dbf034cad119a2":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "81a0f234218a494bc4d92b4d94b2b68f":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "711bde3d69b017178eb8da387700b0a2":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "c9078ea00d8cd5f2819994d0eddc5088":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "a7badc1b16426818f4c0d49463cef098":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "43aff3b5a7777abd6a94c1d31e868c36":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "888cf1df22663c4e56025a6927558c56":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "edcf0861f45d29fbae4695c27a06a1c1":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
				case "ea51d0d6dde4b41548f3ee6f7cfc816f":
					Class24.ThisBiosType = 2;
					Type2Warning();
					return true;
                case "f51900c425b32be1db67c7f7e67e89f3":
                    Class24.ThisBiosType = 2;
					Type2Warning();
                    return true;
				case "aa212fd0e4c7b4a0ddecb21acbcdc019": //3080 FE
					Class24.ThisBiosType = 3;
					MessageBox.Show("Warning 3080 FE tables not found.");
					triedalready = true;
					return true;
				default:
					if (Class24.ThisBiosType == 0)
					{
						Class24.ThisBiosType = 2;
						Type2Warning();
					}
					else
					{
						Class24.ThisBiosType = 1;
					}

					return true;
            }
        }

		private void Type2Warning()
        {
			//MessageBox.Show("Type2 Bios have less support then Type1.");
		}


		private void ResetVFRTable()
        {
            for (int y = 0; y < Class24.Temperture.Length; y++)
            {
                Class24.Temperture[y] = 99 - y;
            }
            CreateVFRChart();
			CreateTFRChart();
		}


		private void ResetFanTable()
		{
            for (int y = 0; y < Class24.FanTarget.Length; y++)
            {
				Class24.FanScaler[y] = y;
				Class24.FanTarget[y] = y;
            }
            CreateFanChart();
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
			lblMinimumPL.Text = this.RomHeader.GetMinimumPL;
			lblDefault8pinPL.Text = this.RomHeader.GetDefault8pinPL;
			lblMax8pinPL.Text = this.RomHeader.GetMax8pinPL;
			lblDefaultSRCPL.Text = this.RomHeader.GetDefaultSRCPL;
			lblDefaultSRC2PL.Text = this.RomHeader.GetDefaultSRC2PL;
			lblDefaultSRC3PL.Text = this.RomHeader.GetDefaultSRC3PL;
			lblMaxSRCPL.Text = this.RomHeader.GetMaxSRCPL;
			lblMaxSRC2PL.Text = this.RomHeader.GetMaxSRC2PL;
			lblMaxSRC3PL.Text = this.RomHeader.GetMaxSRC3PL;
			lblDefaultChipPL.Text = this.RomHeader.GetDefaultChipPL;
			lblMaxChipPL.Text = this.RomHeader.GetMaxChipPL;
			lblDefaultSlotPL.Text = this.RomHeader.GetDefaultSlotPL;
			lblMaxSlotPL.Text = this.RomHeader.GetMaxSlotPL;
			lblDefaultVRAMPL.Text = this.RomHeader.GetDefaultVRAMPL;
			lblMaxVRAMPL.Text = this.RomHeader.GetMaxVRAMPL;
			lblUnknownPL.Text = this.RomHeader.GetUnknownPL;

			lblDefAUX1PL.Text = this.RomHeader.GetDefAUX1PL;
			lblDefAUX2PL.Text = this.RomHeader.GetDefAUX2PL;
			lblDefAUX3PL.Text = this.RomHeader.GetDefAUX3PL;
			lblDefAUX4PL.Text = this.RomHeader.GetDefAUX4PL;
			lblMaxAUX1PL.Text = this.RomHeader.GetMaxAUX1PL;
			lblMaxAUX2PL.Text = this.RomHeader.GetMaxAUX2PL;
			lblMaxAUX3PL.Text = this.RomHeader.GetMaxAUX3PL;
			lblMaxAUX4PL.Text = this.RomHeader.GetMaxAUX4PL;

			if (this.RomHeader.GetBoostClock == "0")
			{
				lblBoostClock.Text = this.RomHeader.class26_0.referenceclocks.ToString();
			}
			else
			{
				lblBoostClock.Text = this.RomHeader.GetBoostClock;
			}
			Class24.BoostClock = int.Parse(lblBoostClock.Text);

			ResetVFRTable();
			ResetFanTable();

			if (this.lblBaseClock.Text == "")
			{
				lblBaseClock.Text = trackBarBaseClock.Value.ToString();
			}
			if (this.lblFBClock.Text == "")
			{
				lblFBClock.Text = trackBarFBClock.Value.ToString();
			}
			if (this.lblVideoClock.Text == "")
			{
				lblVideoClock.Text = trackBarVideoClock.Value.ToString();
			}
			if (this.lblTempLimit.Text == "")
			{
				lblTempLimit.Text = trackBarTempLimit.Value.ToString();
			}

			trackBarBoostClock.Value = int.Parse(lblBoostClock.Text);
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

		public string FileDir
		{
			get
			{
				return this._FileDir;
			}
			set
			{
				this._FileDir = value;
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

			this.lblMinimumPL.Text = "";
			this.lblDefaultPL.Text = "";
			this.lblMaxPL.Text = "";
			this.lblDefault8pinPL.Text = "";
			this.lblMax8pinPL.Text = "";
			this.lblDefaultSRCPL.Text = "";
			this.lblMaxSRCPL.Text = "";
			this.lblDefaultChipPL.Text = "";
			this.lblMaxChipPL.Text = "";
			this.lblDefaultSlotPL.Text = "";
			this.lblMaxSlotPL.Text = "";
			this.lblDefaultVRAMPL.Text = "";
			this.lblMaxVRAMPL.Text = "";
			this.lblUnknownPL.Text = "";
			this.lblDefAUX1PL.Text = "";
			this.lblDefAUX2PL.Text = "";
			this.lblDefAUX3PL.Text = "";
			this.lblDefAUX4PL.Text = "";
			this.lblMaxAUX1PL.Text = "";
			this.lblMaxAUX2PL.Text = "";
			this.lblMaxAUX3PL.Text = "";
			this.lblMaxAUX4PL.Text = "";
			this.lblDefaultSRC2PL.Text = "";
			this.lblDefaultSRC3PL.Text = "";
			this.lblMaxSRC2PL.Text = "";
			this.lblMaxSRC3PL.Text = "";
			this.lblBoostClock.Text = "";
			this.lblBaseClock.Text = "";
			this.lblFBClock.Text = "";
			this.lblVideoClock.Text = "";
			this.lblTempLimit.Text = "";
			GridDefaults();
			DisableControls();
			this.lblChkSum.BackColor = SystemColors.Control;
		}

		private void GridDefaults()
        {
			Class24.Voltage = new[] { 700, 706, 712, 718, 725, 731, 737, 743, 750, 756, 762, 768, 775, 781, 787, 793, 800, 806, 812, 818, 825, 831, 837, 843, 850, 856, 862, 868, 875, 881, 887, 893, 900, 906, 912, 918, 925, 931, 937, 943, 950, 956, 962, 968, 975, 981, 987, 993, 1000, 1006, 1012, 1018, 1025, 1031, 1037, 1043, 1050, 1056, 1062, 1068, 1075, 1081, 1087, 1093, 1100, 1106, 1112, 1118, 1125, 1131, 1137, 1143, 1150, 1156, 1162, 1168, 1175, 1181, 1187, 1193, 1200, 1206, 1212, 1218, 1225, 1231, 1237, 1243, 1250 };
			Class24.Frequency = new[] { 1245, 1275, 1290, 1305, 1335, 1350, 1365, 1380, 1410, 1400, 1425, 1440, 1455, 1470, 1485, 1515, 1530, 1545, 1560, 1575, 1590, 1605, 1620, 1635, 1650, 1665, 1680, 1695, 1710, 1725, 1725, 1740, 1755, 1770, 1785, 1800, 1800, 1815, 1830, 1830, 1845, 1860, 1875, 1875, 1890, 1890, 1905, 1920, 1920, 1935, 1935, 1950, 1950, 1965, 1965, 1980, 1980, 1995, 1995, 1995, 2010, 2010, 2010, 2025, 2025, 2025, 2025, 2040, 2040, 2040, 2040, 2040, 2040, 2040, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055 };

		}

		private void DisableControls()
        {
			this.lblDefaultPL.Enabled = false;
			this.lblMaxPL.Enabled = false;
			this.Btn_Save.Enabled = false;
			this.lblMinimumPL.Enabled = false;
			this.lblDefault8pinPL.Enabled = false;
			this.lblMax8pinPL.Enabled = false;
			this.lblDefaultSRCPL.Enabled = false;
			this.lblMaxSRCPL.Enabled = false;
			this.lblDefaultChipPL.Enabled = false;
			this.lblMaxChipPL.Enabled = false;
			this.lblDefaultSlotPL.Enabled = false;
			this.lblMaxSlotPL.Enabled = false;
			this.lblDefaultVRAMPL.Enabled = false;
			this.lblMaxVRAMPL.Enabled = false;
			this.lblUnknownPL.Enabled = false;
			this.lblDefAUX1PL.Enabled = false;
			this.lblDefAUX2PL.Enabled = false;
			this.lblDefAUX3PL.Enabled = false;
			this.lblDefAUX4PL.Enabled = false;
			this.lblMaxAUX1PL.Enabled = false;
			this.lblMaxAUX2PL.Enabled = false;
			this.lblMaxAUX3PL.Enabled = false;
			this.lblMaxAUX4PL.Enabled = false;
			this.lblDefaultSRC2PL.Enabled = false;
			this.lblDefaultSRC3PL.Enabled = false;
			this.lblMaxSRC2PL.Enabled = false;
			this.lblMaxSRC3PL.Enabled = false;
			this.label65.Enabled = false;
			this.trackBarBoostClock.Enabled = false;
			this.lblBoostClock.Enabled = false;
			this.tcSettings.Enabled = false;
		}

        private void Btn_open_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.DefaultExt = "*.rom";
			openFileDialog.Filter = "BIOS Files|*.rom;*.bin";
			triedalready = false;
			notsupported = false;
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
        }
		

		private void method_3(string string_0)
		{
			try
			{
				this.method_2();
				this.class30_0 = new Class30(string_0);
				Class25 @class = this.class30_0.list_0[0];
				this.RomHeader = @class.class24_0;
				if (RomHeader.Boolean_0 && CheckMD5())
				{

					this.FileName = new FileInfo(string_0).Name;
					this.FileDir = string_0;

				if (lblName.Text.Contains("3070") || lblName.Text.Contains("PG124") || lblName.Text.Contains("3060") || lblName.Text.Contains("3050"))
				{
					if (!notsupported)
					{
						notsupported = true;
						MessageBox.Show(lblName.Text + " not supported");
					}
					DisableControls();
					return;
				}

				if (lblDefaultPL.Text == "0" || lblMaxPL.Text == "0" || lblMinimumPL.Text == "0")
                {
					if (!triedalready)
					{
						DialogResult dialogResult = MessageBox.Show("Do you want to try open this rom as Type2?", "Something Doesnt Look Right!", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.Yes)
						{
							Class24.ThisBiosType = 0;
							triedalready = true;
							this.method_3(FileDir);
						}
					}
                }

					this.ImageChecksum = @class.Byte_0;
					this.GeneratedChecksum = @class.method_2(false);
					this.ImageChecksum2 = @class.Byte_2;
					this.GeneratedChecksum2 = @class.method_2(true);
					this.lblMinimumPL.Enabled = true;
					this.lblDefaultPL.Enabled = true;
					this.lblMaxPL.Enabled = true;
					this.Btn_Save.Enabled = true;
					this.lblDefault8pinPL.Enabled = true;
					this.lblMax8pinPL.Enabled = true;
					this.lblDefaultSRCPL.Enabled = true;
					this.lblMaxSRCPL.Enabled = true;
					this.lblDefaultChipPL.Enabled = true;
					this.lblMaxChipPL.Enabled = true;
					this.lblDefaultSlotPL.Enabled = true;
					this.lblMaxSlotPL.Enabled = true;
					this.lblDefaultVRAMPL.Enabled = true;
					this.lblMaxVRAMPL.Enabled = true;
					this.lblUnknownPL.Enabled = true;
					this.lblDefAUX1PL.Enabled = true;
					this.lblDefAUX2PL.Enabled = true;
					this.lblDefAUX3PL.Enabled = true;
					this.lblDefAUX4PL.Enabled = true;
					this.lblMaxAUX1PL.Enabled = true;
					this.lblMaxAUX2PL.Enabled = true;
					this.lblMaxAUX3PL.Enabled = true;
					this.lblMaxAUX4PL.Enabled = true;
					this.lblDefaultSRC2PL.Enabled = true;
					this.lblDefaultSRC3PL.Enabled = true;
					this.lblMaxSRC2PL.Enabled = true;
					this.lblMaxSRC3PL.Enabled = true;
					this.label65.Enabled = true;
					this.trackBarBoostClock.Enabled = true;
					this.lblBoostClock.Enabled = true;
					this.tcSettings.Enabled = true;
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

		private bool notnull()
        {
			if (lblMinimumPL.Text.Length != 0 &&
				lblDefaultPL.Text.Length != 0 && 
				lblMaxPL.Text.Length != 0 && 
				lblDefault8pinPL.Text.Length != 0 &&
				lblMax8pinPL.Text.Length != 0 &&
				lblDefaultSRCPL.Text.Length != 0 &&
				lblMaxSRCPL.Text.Length != 0 &&
				lblDefaultChipPL.Text.Length != 0 &&
				lblMaxChipPL.Text.Length != 0 &&
				lblDefaultSlotPL.Text.Length != 0 &&
				lblMaxSlotPL.Text.Length != 0 &&
				lblDefaultVRAMPL.Text.Length != 0 &&
				lblMaxVRAMPL.Text.Length != 0 &&
				lblUnknownPL.Text.Length != 0)
			{
				return true;
			}
			else
			{
				return false;
			}
        }


		private void EditBiosBoardPowerLimit(byte max)
		{ 
			if (notnull())
            {
				Class25 @class = this.class30_0.list_0[0];
				switch(max)
                {
					case 0:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A5, int.Parse(lblMinimumPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B5, int.Parse(lblMinimumPL.Text));
						}
						break;
					case 1:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A6, int.Parse(lblDefaultPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B6, int.Parse(lblDefaultPL.Text));
						}
						break;
					case 2:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A7, int.Parse(lblMaxPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B7, int.Parse(lblMaxPL.Text));
						}
						break;
					case 3:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A17, int.Parse(lblDefault8pinPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B17, int.Parse(lblDefault8pinPL.Text));
						}
						break;
					case 4:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A18, int.Parse(lblMax8pinPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B18, int.Parse(lblMax8pinPL.Text));
						}
						break;
					case 5:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A9, int.Parse(lblDefaultSRCPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.A9, int.Parse(lblDefaultSRCPL.Text));
						}
						break;
					case 6:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A10, int.Parse(lblMaxSRCPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B10, int.Parse(lblMaxSRCPL.Text));
						}
						break;
					case 7:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A11, int.Parse(lblDefaultChipPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B11, int.Parse(lblDefaultChipPL.Text));
						}
						break;
					case 8:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A12, int.Parse(lblMaxChipPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B12, int.Parse(lblMaxChipPL.Text));
						}
						break;
					case 9:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A15, int.Parse(lblDefaultSlotPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B15, int.Parse(lblDefaultSlotPL.Text));
						}
						break;
					case 10:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A16, int.Parse(lblMaxSlotPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B16, int.Parse(lblMaxSlotPL.Text));
						}
						break;
					case 11:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A13, int.Parse(lblDefaultVRAMPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B13, int.Parse(lblDefaultVRAMPL.Text));
						}
						break;
					case 12:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A14, int.Parse(lblMaxVRAMPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B14, int.Parse(lblMaxVRAMPL.Text));
						}
						break;
					case 13:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A8, int.Parse(lblUnknownPL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B8, int.Parse(lblUnknownPL.Text));
						}
						break;
					case 14:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A9_1, int.Parse(lblDefaultSRC2PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B9_1, int.Parse(lblDefaultSRC2PL.Text));
						}
						break;
					case 15:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A9_2, int.Parse(lblDefaultSRC3PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B9_2, int.Parse(lblDefaultSRC3PL.Text));
						}
						break;
					case 16:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A10_1, int.Parse(lblMaxSRC2PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B10_1, int.Parse(lblMaxSRC2PL.Text));
						}
						break;
					case 17:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A10_2, int.Parse(lblMaxSRC3PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B10_2, int.Parse(lblMaxSRC3PL.Text));
						}
						break;
					case 18:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A19, int.Parse(lblDefAUX1PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B19, int.Parse(lblDefAUX1PL.Text));
						}
						break;
					case 19:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A20, int.Parse(lblDefAUX2PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B20, int.Parse(lblDefAUX2PL.Text));
						}
						break;
					case 20:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A21, int.Parse(lblDefAUX3PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B21, int.Parse(lblDefAUX3PL.Text));
						}
						break;
					case 21:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A22, int.Parse(lblDefAUX4PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B22, int.Parse(lblDefAUX4PL.Text));
						}
						break;
					case 22:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A23, int.Parse(lblMaxAUX1PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B23, int.Parse(lblMaxAUX1PL.Text));
						}
						break;
					case 23:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A24, int.Parse(lblMaxAUX2PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B24, int.Parse(lblMaxAUX2PL.Text));
						}
						break;
					case 24:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A25, int.Parse(lblMaxAUX3PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B25, int.Parse(lblMaxAUX3PL.Text));
						}
						break;
					case 25:
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A26, int.Parse(lblMaxAUX4PL.Text));
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B26, int.Parse(lblMaxAUX4PL.Text));
						}
						break;
					case 26:
						if(lblBoostClock.Text == trackBarBoostClock.Value.ToString())
                        {
						if (Class24.ThisBiosType == 1)
						{
							Class29.setpower(class30_0.byte_1, Class24.A27, int.Parse(lblBoostClock.Text) * 1000);
						}
						else if (Class24.ThisBiosType == 2)
						{
							Class29.setpower(class30_0.byte_1, Class24.B27, int.Parse(lblBoostClock.Text) * 1000);
						}
						}
						break;


					default:
						break;
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

		Point? prevPosition = null;
		ToolTip tooltip = new ToolTip();

		private void chart_MouseMove(object sender, MouseEventArgs e)
		{
			var pos = e.Location;
			if (prevPosition.HasValue && pos == prevPosition.Value)
				return;
			tooltip.RemoveAll();
			prevPosition = pos;
			var results = chart1.HitTest(pos.X, pos.Y, true, ChartElementType.PlottingArea); // set ChartElementType.PlottingArea for full area, not only DataPoints
			foreach (var result in results)
			{
				if (result.ChartElementType == ChartElementType.PlottingArea) // set ChartElementType.PlottingArea for full area, not only DataPoints
				{
					var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
					var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
					tooltip.Show(((int)yVal).ToString() + "MHz@"+ ((int)xVal).ToString()+"MV", chart1, pos.X, pos.Y - 15);
				}
			}
		}
		private void chart2_MouseMove(object sender, MouseEventArgs e)
		{
			var pos = e.Location;
			if (prevPosition.HasValue && pos == prevPosition.Value)
				return;
			tooltip.RemoveAll();
			prevPosition = pos;
			var results = chart2.HitTest(pos.X, pos.Y, true, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
			foreach (var result in results)
			{
				if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
				{
					var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
					var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
					tooltip.Show(((int)yVal).ToString() + "% @ " + ((int)xVal).ToString() + "C", chart2, pos.X, pos.Y - 15);
				}
			}
		}

		private void chart3_MouseMove(object sender, MouseEventArgs e)
		{
			var pos = e.Location;
			if (prevPosition.HasValue && pos == prevPosition.Value)
				return;
			tooltip.RemoveAll();
			prevPosition = pos;
			var results = chart3.HitTest(pos.X, pos.Y, true, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
			foreach (var result in results)
			{
				if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
				{
					var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
					var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
					tooltip.Show(((int)yVal).ToString() + "% @ " + ((int)xVal).ToString() + "C", chart3, pos.X, pos.Y - 15);
				}
			}
		}

		private void CreateVFRChart()
		{
			chart1.Series.Clear();
			var series = new Series("VFR");
			series.ChartType = SeriesChartType.StepLine;
			series.Color = Color.Black;
			series.Points.DataBindXY(Class24.Voltage, Class24.Frequency);
			chart1.Series.Add(series);
		}

		private void CreateTFRChart()
		{
			chart3.Series.Clear();
			var series = new Series("TFR");
			series.ChartType = SeriesChartType.Spline;
			series.Color = Color.Black;
			series.Points.DataBindXY(Class24.FanScaler, Class24.Temperture);
			chart3.Series.Add(series);
			chart3.ChartAreas[0].AxisX.Title = "Temperature C";
		}

		private void CreateFanChart()
		{
			chart2.Series.Clear();
			var series = new Series("Fan");
			series.ChartType = SeriesChartType.Spline;
			series.Color = Color.Black;
			series.Points.DataBindXY(Class24.FanScaler, Class24.FanTarget);
			chart2.Series.Add(series);
			chart2.ChartAreas[0].AxisX.Title = "Temperature C";
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

		private void lblMinimumPL_Validated(object sender, EventArgs e)
		{
			EditBiosBoardPowerLimit(0);
		}

		private void lblDefaultPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(1);
		}

        private void lblMaxPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(2);
		}

        private void lblDefault8pinPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(3);
		}

        private void lblMax8pinPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(4);
		}

        private void lblDefaultSRCPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(5);
		}

        private void lblMaxSRCPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(6);
		}

        private void lblDefaultChipPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(7);
		}

        private void lblMaxChipPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(8);
		}

        private void lblDefaultSlotPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(9);
		}

        private void lblMaxSlotPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(10);
		}

        private void lblDefaultVRAMPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(11);
		}

        private void lblMaxVRAMPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(12);
		}

        private void lblUnknownPL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(13);
		}

        private void lblDefaultSRC2PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(14);
		}

        private void lblDefaultSRC3PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(15);
		}

        private void lblMaxSRC2PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(16);
		}

        private void lblMaxSRC3PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(17);
		}

        private void lblDefAUX1PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(18);
		}

        private void lblDefAUX2PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(19);
		}

        private void lblDefAUX3PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(20);
		}

        private void lblDefAUX4PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(21);
		}

        private void lblMaxAUX1PL_VisibleChanged(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(22);
		}

        private void lblMaxAUX2PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(23);
		}

        private void lblMaxAUX3PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(24);
		}

        private void lblMaxAUX4PL_Validated(object sender, EventArgs e)
        {
			EditBiosBoardPowerLimit(25);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string databasedump =
				lblSubVendor.Text + "," +
				lblDate.Text + "," +
				lblBIOS.Text + "," +
				lblHash.Text + "," +
				lblMinimumPL.Text + "," +
				lblDefaultPL.Text + "," +
				lblMaxPL.Text + "," +
				lblDefault8pinPL.Text + "," +
				lblMax8pinPL.Text + "," +
				lblDefaultSRCPL.Text + "," +
				lblMaxSRCPL.Text + "," +
				lblDefaultChipPL.Text + "," +
				lblMaxChipPL.Text + "," +
				lblDefaultSlotPL.Text + "," +
				lblMaxSlotPL.Text + "," +
				lblDefaultVRAMPL.Text + "," +
				lblMaxVRAMPL.Text + "," +
				lblUnknownPL.Text;
			Clipboard.SetText(databasedump);

		}

		private void lFilename_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			button1.Visible = true;
		}

        private void trackBarBoostClock_ValueChanged(object sender, EventArgs e)
        {
			lblBoostClock.Text = trackBarBoostClock.Value.ToString();
		}

        private void lblBoostClock_Validated(object sender, EventArgs e)
        {
			trackBarBoostClock.Value = int.Parse(lblBoostClock.Text);
			EditBiosBoardPowerLimit(26);
		}

        private void trackBarBaseClock_ValueChanged(object sender, EventArgs e)
        {
			lblBaseClock.Text = trackBarBaseClock.Value.ToString();
		}

        private void trackBarVideoClock_ValueChanged(object sender, EventArgs e)
        {
			lblVideoClock.Text = trackBarVideoClock.Value.ToString();
		}

        private void trackBarFBClock_ValueChanged(object sender, EventArgs e)
        {
			lblFBClock.Text = trackBarFBClock.Value.ToString();
		}

        private void trackBarTempLimit_ValueChanged(object sender, EventArgs e)
        {
			lblTempLimit.Text = trackBarTempLimit.Value.ToString();
		}

        private void trackBarBoostClock_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
			EditBiosBoardPowerLimit(26);
		}
    }
}
