using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
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
        private byte[] url = { 0x68, 0x74, 0x74, 0x70, 0x73, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x74, 0x65, 0x63, 0x68, 0x70, 0x6f, 0x77, 0x65, 0x72, 0x75, 0x70, 0x2e, 0x63, 0x6f, 0x6d, 0x2f, 0x76, 0x67, 0x61, 0x62, 0x69, 0x6f, 0x73, 0x2f, 0x3f, 0x61, 0x72, 0x63, 0x68, 0x69, 0x74, 0x65, 0x63, 0x74, 0x75, 0x72, 0x65, 0x3d, 0x26, 0x6d, 0x61, 0x6e, 0x75, 0x66, 0x61, 0x63, 0x74, 0x75, 0x72, 0x65, 0x72, 0x3d, 0x26, 0x6d, 0x6f, 0x64, 0x65, 0x6c, 0x3d, 0x26, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6f, 0x6e, 0x3d };
        private byte[] url2 = { 0x26, 0x69, 0x6e, 0x74, 0x65, 0x72, 0x66, 0x61, 0x63, 0x65, 0x3d, 0x26, 0x6d, 0x65, 0x6d, 0x54, 0x79, 0x70, 0x65, 0x3d, 0x26, 0x6d, 0x65, 0x6d, 0x53, 0x69, 0x7a, 0x65, 0x3d, 0x26, 0x73, 0x69, 0x6e, 0x63, 0x65, 0x3d };
        private byte[] ti = { 0x41, 0x42, 0x45, 0x20, 0x76, 0x7b, 0x30, 0x7d, 0x2e, 0x7b, 0x31, 0x7d, 0x7b, 0x32, 0x7d };
        private byte[] mv = { 0x4d, 0x56 };
        private byte[] mhz = { 0x4d, 0x48, 0x7a, 0x40 };
        private byte[] VFR = { 0x56, 0x46, 0x52 };
        private byte[] vmv = { 0x56, 0x6f, 0x6c, 0x74, 0x61, 0x67, 0x65, 0x20, 0x4d, 0x56 };
        private byte[] cmhz = { 0x43, 0x6c, 0x6f, 0x63, 0x6b, 0x20, 0x4d, 0x48, 0x7a };
        private byte[] TFR = { 0x54, 0x46, 0x52 };
        private byte[] ptarget = { 0x50, 0x65, 0x72, 0x63, 0x65, 0x6e, 0x74, 0x61, 0x67, 0x65, 0x20, 0x54, 0x61, 0x72, 0x67, 0x65, 0x74 };
        private byte[] fan = { 0x46, 0x61, 0x6e };
        private byte[] tempc = { 0x54, 0x65, 0x6d, 0x70, 0x65, 0x72, 0x61, 0x74, 0x75, 0x72, 0x65, 0x20, 0x43 };
        private byte[] fans = { 0x46, 0x61, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x65, 0x64, 0x20, 0x25 };
        private List<Interface0> method_1()
        {
            return new List<Interface0>
            {
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

        private bool CheckifXOC()
        {
            if (class30_0.byte_1[0x5226] == 0x30 && class30_0.byte_1[0x5227] == 0x36 && class30_0.byte_1[0x5228] == 0x37 && class30_0.byte_1[0x5229] == 0x37)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckMD5()
        {
            Class25 @class = this.class30_0.list_0[0];
            if (CheckifXOC())
            {
                Class24.ThisBiosType = 4;
                return true;
            }

            if (@class.class24_0.class26_0.card == 3060)
            {
                Class24.ThisBiosType = 6;
                return true;
            }
            else if (@class.class24_0.class26_0.card == 3070)
            {
                Class24.ThisBiosType = 7;
                return true;
            }

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
                    msgbox(4);
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

        private void msgbox(int message)
        {
            switch (message)
            {
                case 1:
                    MessageBox.Show("UID Saved!");
                    break;
                case 2:
                    MessageBox.Show("UID applied to Bios!");
                    break;
                case 3:
                    MessageBox.Show("Incorrect sized UID file!");
                    break;
                case 4:
                    MessageBox.Show("Warning 3080 FE limited support.");
                    break;
                case 5:
                    MessageBox.Show(lblName.Text + " not supported");
                    break;
                case 6:
                    MessageBox.Show(h2s(Class24.easteregg));
                    break;

            }
        }
        public string hexformat = "{0:X2} - [{1:X2}] / {2:X2} - [{3:X2}]";
        public string hexformat2 = "{0:X4} - {1:X4}";

        public string estring()
        {
            return "";
        }

        public string zstring()
        {
            return 0.ToString();
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
            this.lblDevID.Text = string.Format(hexformat2, this.RomHeader.class26_0.UInt16_0, this.RomHeader.class26_0.UInt16_1);
            this.lblSubVendor.Text = this.RomHeader.String_4.ToUpper();
            this.lblDate.Text = this.RomHeader.String_0;
            this.lblChkSum.Text = string.Format(hexformat, this.ImageChecksum, this.GeneratedChecksum, this.ImageChecksum2, this.GeneratedChecksum2);

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

            if (this.RomHeader.GetBoostClock == zstring())
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

            if (this.lblBaseClock.Text == estring())
            {
                lblBaseClock.Text = trackBarBaseClock.Value.ToString();
            }
            if (this.lblFBClock.Text == estring())
            {
                lblFBClock.Text = trackBarFBClock.Value.ToString();
            }
            if (this.lblVideoClock.Text == estring())
            {
                lblVideoClock.Text = trackBarVideoClock.Value.ToString();
            }
            if (this.lblTempLimit.Text == estring())
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
            string emptystring = estring();
            this.lblName.Text = (unsupported ? h2s(Class24.Unsupported) : emptystring);
            this.lblGPU.Text = emptystring;
            this.lblBIOS.Text = emptystring;
            this.lblDevID.Text = emptystring;
            this.lblSubVendor.Text = emptystring;
            this.lblDate.Text = emptystring;
            this.lblFilename.Text = emptystring;
            this.lblChkSum.Text = emptystring;
            this.lblMinimumPL.Text = emptystring;
            this.lblDefaultPL.Text = emptystring;
            this.lblMaxPL.Text = emptystring;
            this.lblDefault8pinPL.Text = emptystring;
            this.lblMax8pinPL.Text = emptystring;
            this.lblDefaultSRCPL.Text = emptystring;
            this.lblMaxSRCPL.Text = emptystring;
            this.lblDefaultChipPL.Text = emptystring;
            this.lblMaxChipPL.Text = emptystring;
            this.lblDefaultSlotPL.Text = emptystring;
            this.lblMaxSlotPL.Text = emptystring;
            this.lblDefaultVRAMPL.Text = emptystring;
            this.lblMaxVRAMPL.Text = emptystring;
            this.lblUnknownPL.Text = emptystring;
            this.lblDefAUX1PL.Text = emptystring;
            this.lblDefAUX2PL.Text = emptystring;
            this.lblDefAUX3PL.Text = emptystring;
            this.lblDefAUX4PL.Text = emptystring;
            this.lblMaxAUX1PL.Text = emptystring;
            this.lblMaxAUX2PL.Text = emptystring;
            this.lblMaxAUX3PL.Text = emptystring;
            this.lblMaxAUX4PL.Text = emptystring;
            this.lblDefaultSRC2PL.Text = emptystring;
            this.lblDefaultSRC3PL.Text = emptystring;
            this.lblMaxSRC2PL.Text = emptystring;
            this.lblMaxSRC3PL.Text = emptystring;
            this.lblBoostClock.Text = emptystring;
            this.lblBaseClock.Text = emptystring;
            this.lblFBClock.Text = emptystring;
            this.lblVideoClock.Text = emptystring;
            this.lblTempLimit.Text = emptystring;
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
            //this.tcSettings.Enabled = false;
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = h2s(Class24.rom);
            openFileDialog.Filter = h2s(Class24.defs);
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

                    if (@class.class24_0.class26_0.card != 3080 && @class.class24_0.class26_0.card != 3090)
                    {
                        if (!notsupported)
                        {
                            notsupported = true;
                            msgbox(5);
                        }
                        DisableControls();
                        return;
                    }

                    if (lblDefaultPL.Text == zstring() || lblMaxPL.Text == zstring() || lblMinimumPL.Text == zstring())
                    {
                        if (!triedalready)
                        {
                            DialogResult dialogResult = MessageBox.Show(h2s(Class24.t2fault), estring(), MessageBoxButtons.YesNo);
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
                    //this.tcSettings.Enabled = true;
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
            tcSettings.Enabled = false;
            this.method_2();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = string.Format(h2s(ti), version.Major, version.Minor, version.Build);
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            if (commandLineArgs.Length > 1 && (commandLineArgs[1].ToLower().EndsWith(".bin") || commandLineArgs[1].ToLower().EndsWith(".rom")))
            {
                this.method_3(commandLineArgs[1]);
            }
        }

        private void lblBIOS_Click(object sender, EventArgs e)
        {
            if (lblBIOS.Text.Length == 14)
            {
                System.Diagnostics.Process.Start(h2s(url) + lblBIOS.Text + h2s(url2));
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
                switch (max)
                {
                    case 0:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[5], int.Parse(lblMinimumPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[5], int.Parse(lblMinimumPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[5], int.Parse(lblMinimumPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[5], int.Parse(lblMinimumPL.Text));
                        }
                        break;
                    case 1:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[6], int.Parse(lblDefaultPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[6], int.Parse(lblDefaultPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[6], int.Parse(lblDefaultPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[6], int.Parse(lblDefaultPL.Text));
                        }
                        break;
                    case 2:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[7], int.Parse(lblMaxPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[7], int.Parse(lblMaxPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[7], int.Parse(lblMaxPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[7], int.Parse(lblMaxPL.Text));
                        }
                        break;
                    case 3:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[21], int.Parse(lblDefault8pinPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[21], int.Parse(lblDefault8pinPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[21], int.Parse(lblDefault8pinPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[21], int.Parse(lblDefault8pinPL.Text));
                        }
                        break;
                    case 4:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[22], int.Parse(lblMax8pinPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[22], int.Parse(lblMax8pinPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[22], int.Parse(lblMax8pinPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[22], int.Parse(lblMax8pinPL.Text));
                        }
                        break;
                    case 5:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[9], int.Parse(lblDefaultSRCPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[9], int.Parse(lblDefaultSRCPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[9], int.Parse(lblDefaultSRCPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[9], int.Parse(lblDefaultSRCPL.Text));
                        }
                        break;
                    case 6:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[12], int.Parse(lblMaxSRCPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[12], int.Parse(lblMaxSRCPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[12], int.Parse(lblMaxSRCPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[12], int.Parse(lblMaxSRCPL.Text));
                        }
                        break;
                    case 7:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[15], int.Parse(lblDefaultChipPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[15], int.Parse(lblDefaultChipPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[15], int.Parse(lblDefaultChipPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[15], int.Parse(lblDefaultChipPL.Text));
                        }
                        break;
                    case 8:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[16], int.Parse(lblMaxChipPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[16], int.Parse(lblMaxChipPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[16], int.Parse(lblMaxChipPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[16], int.Parse(lblMaxChipPL.Text));
                        }
                        break;
                    case 9:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[19], int.Parse(lblDefaultSlotPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[19], int.Parse(lblDefaultSlotPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[19], int.Parse(lblDefaultSlotPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[19], int.Parse(lblDefaultSlotPL.Text));
                        }
                        break;
                    case 10:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[20], int.Parse(lblMaxSlotPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[20], int.Parse(lblMaxSlotPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[20], int.Parse(lblMaxSlotPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[20], int.Parse(lblMaxSlotPL.Text));
                        }
                        break;
                    case 11:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[17], int.Parse(lblDefaultVRAMPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[17], int.Parse(lblDefaultVRAMPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[17], int.Parse(lblDefaultVRAMPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[17], int.Parse(lblDefaultVRAMPL.Text));
                        }
                        break;
                    case 12:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[18], int.Parse(lblMaxVRAMPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[18], int.Parse(lblMaxVRAMPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[18], int.Parse(lblMaxVRAMPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[18], int.Parse(lblMaxVRAMPL.Text));
                        }
                        break;
                    case 13:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[8], int.Parse(lblUnknownPL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[8], int.Parse(lblUnknownPL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[8], int.Parse(lblUnknownPL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[8], int.Parse(lblUnknownPL.Text));
                        }
                        break;
                    case 14:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[10], int.Parse(lblDefaultSRC2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[10], int.Parse(lblDefaultSRC2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[10], int.Parse(lblDefaultSRC2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[10], int.Parse(lblDefaultSRC2PL.Text));
                        }
                        break;
                    case 15:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[11], int.Parse(lblDefaultSRC3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[11], int.Parse(lblDefaultSRC3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[11], int.Parse(lblDefaultSRC3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[11], int.Parse(lblDefaultSRC3PL.Text));
                        }
                        break;
                    case 16:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[13], int.Parse(lblMaxSRC2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[13], int.Parse(lblMaxSRC2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[13], int.Parse(lblMaxSRC2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[13], int.Parse(lblMaxSRC2PL.Text));
                        }
                        break;
                    case 17:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[14], int.Parse(lblMaxSRC3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[14], int.Parse(lblMaxSRC3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[14], int.Parse(lblMaxSRC3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[14], int.Parse(lblMaxSRC3PL.Text));
                        }
                        break;
                    case 18:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[23], int.Parse(lblDefAUX1PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[23], int.Parse(lblDefAUX1PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[23], int.Parse(lblDefAUX1PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[23], int.Parse(lblDefAUX1PL.Text));
                        }
                        break;
                    case 19:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[24], int.Parse(lblDefAUX2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[24], int.Parse(lblDefAUX2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[24], int.Parse(lblDefAUX2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[24], int.Parse(lblDefAUX2PL.Text));
                        }
                        break;
                    case 20:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[25], int.Parse(lblDefAUX3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[25], int.Parse(lblDefAUX3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[25], int.Parse(lblDefAUX3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[25], int.Parse(lblDefAUX3PL.Text));
                        }
                        break;
                    case 21:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[26], int.Parse(lblDefAUX4PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[26], int.Parse(lblDefAUX4PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[26], int.Parse(lblDefAUX4PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[26], int.Parse(lblDefAUX4PL.Text));
                        }
                        break;
                    case 22:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[27], int.Parse(lblMaxAUX1PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[27], int.Parse(lblMaxAUX1PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[27], int.Parse(lblMaxAUX1PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[27], int.Parse(lblMaxAUX1PL.Text));
                        }
                        break;
                    case 23:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[28], int.Parse(lblMaxAUX2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[28], int.Parse(lblMaxAUX2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[28], int.Parse(lblMaxAUX2PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[28], int.Parse(lblMaxAUX2PL.Text));
                        }
                        break;
                    case 24:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[29], int.Parse(lblMaxAUX3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[29], int.Parse(lblMaxAUX3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[29], int.Parse(lblMaxAUX3PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[29], int.Parse(lblMaxAUX3PL.Text));
                        }
                        break;
                    case 25:
                        if (Class24.ThisBiosType == 1)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type1[30], int.Parse(lblMaxAUX4PL.Text));
                        }
                        else if (Class24.ThisBiosType == 2)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type2[30], int.Parse(lblMaxAUX4PL.Text));
                        }
                        else if (Class24.ThisBiosType == 3)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.Type3[30], int.Parse(lblMaxAUX4PL.Text));
                        }
                        else if (Class24.ThisBiosType == 4)
                        {
                            Class29.setpower(class30_0.byte_1, Class24.XOC[30], int.Parse(lblMaxAUX4PL.Text));
                        }
                        break;
                    case 26:
                        if (lblBoostClock.Text == trackBarBoostClock.Value.ToString())
                        {
                            if (Class24.ThisBiosType == 1)
                            {
                                Class29.setpower(class30_0.byte_1, Class24.Type1[31], int.Parse(lblBoostClock.Text) * 1000);
                            }
                            else if (Class24.ThisBiosType == 2)
                            {
                                Class29.setpower(class30_0.byte_1, Class24.Type2[31], int.Parse(lblBoostClock.Text) * 1000);
                            }
                            else if (Class24.ThisBiosType == 3)
                            {
                                Class29.setpower(class30_0.byte_1, Class24.Type3[31], int.Parse(lblBoostClock.Text) * 1000);
                            }
                            else if (Class24.ThisBiosType == 4)
                            {
                                Class29.setpower(class30_0.byte_1, Class24.XOC[31], int.Parse(lblBoostClock.Text) * 1000);
                            }
                        }
                        break;


                    default:
                        break;
                }
                this.GeneratedChecksum2 = @class.method_2(true);
                this.lblChkSum.Text = string.Format(hexformat, this.ImageChecksum, this.GeneratedChecksum, this.ImageChecksum2, this.GeneratedChecksum2);
                if (this.ImageChecksum == this.GeneratedChecksum && this.ImageChecksum2 == this.GeneratedChecksum2)
                {
                    this.lblChkSum.BackColor = Color.LightGreen;
                }
                else
                {
                    this.lblChkSum.BackColor = Color.LightCoral;
                    DialogResult dialogResult = MessageBox.Show(h2s(Class24.csfault), estring(), MessageBoxButtons.YesNo);
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
            var results = chart1.HitTest(pos.X, pos.Y, true, ChartElementType.PlottingArea);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                    tooltip.Show(((int)yVal).ToString() + h2s(mhz) + ((int)xVal).ToString() + h2s(mv), chart1, pos.X, pos.Y - 15);
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
            var results = chart2.HitTest(pos.X, pos.Y, true, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
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
            var results = chart3.HitTest(pos.X, pos.Y, true, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
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
            var series = new Series(h2s(VFR));
            series.ChartType = SeriesChartType.StepLine;
            series.Color = Color.Black;
            series.Points.DataBindXY(Class24.Voltage, Class24.Frequency);
            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = h2s(vmv);
            chart1.ChartAreas[0].AxisY.Title = h2s(cmhz);
        }

        private void CreateTFRChart()
        {
            chart3.Series.Clear();
            var series = new Series(h2s(TFR));
            series.ChartType = SeriesChartType.Spline;
            series.Color = Color.Black;
            series.Points.DataBindXY(Class24.FanScaler, Class24.Temperture);
            chart3.Series.Add(series);
            chart3.ChartAreas[0].AxisX.Title = h2s(tempc);
            chart3.ChartAreas[0].AxisY.Title = h2s(ptarget);
        }

        private void CreateFanChart()
        {
            chart2.Series.Clear();
            var series = new Series(h2s(fan));
            series.ChartType = SeriesChartType.Spline;
            series.Color = Color.Black;
            series.Points.DataBindXY(Class24.FanScaler, Class24.FanTarget);
            chart2.Series.Add(series);
            chart2.ChartAreas[0].AxisX.Title = h2s(tempc);
            chart2.ChartAreas[0].AxisY.Title = h2s(fans);
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
                saveFileDialog.DefaultExt = h2s(Class24.rom);
                saveFileDialog.Filter = h2s(Class24.defs);
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

        private void trackBarBoostClock_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EditBiosBoardPowerLimit(26);
        }

        private void lblBoostClock_Validated(object sender, EventArgs e)
        {
            trackBarBoostClock.Value = int.Parse(lblBoostClock.Text);
            EditBiosBoardPowerLimit(26);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(h2s(Class24.CSVHead) + Environment.NewLine + databasedump());
        }

        private string h2s(byte[] inp)
        {
            return Encoding.ASCII.GetString(inp);

        }

        private string databasedump()
        {
            byte[] c = { 0x2c };
            string comma = h2s(c);
            return
lblSubVendor.Text + comma +
lblBIOS.Text + comma +
lblDate.Text + comma +
lblDevID.Text + comma +
lblHash.Text + comma +
lblBaseClock.Text + comma +
lblBoostClock.Text + comma +
lblFBClock.Text + comma +
lblDefaultPL.Text + comma +
lblMaxPL.Text + comma +
lblDefault8pinPL.Text + comma +
lblMax8pinPL.Text + comma +
lblDefaultSlotPL.Text + comma +
lblMaxSlotPL.Text + comma +
lblDefaultChipPL.Text + comma +
lblMaxChipPL.Text + comma +
lblDefaultSRCPL.Text + comma +
lblDefaultSRC2PL.Text + comma +
lblDefaultSRC3PL.Text + comma +
lblMaxSRCPL.Text + comma +
lblMaxSRC2PL.Text + comma +
lblMaxSRC3PL.Text + comma +
lblDefaultVRAMPL.Text + comma +
lblMaxVRAMPL.Text + comma +
lblDefAUX1PL.Text + comma +
lblDefAUX2PL.Text + comma +
lblDefAUX3PL.Text + comma +
lblDefAUX4PL.Text + comma +
lblMaxAUX1PL.Text + comma +
lblMaxAUX2PL.Text + comma +
lblMaxAUX3PL.Text + comma +
lblMaxAUX4PL.Text + comma +
lblUnknownPL.Text + comma;


        }

        private void lFilename_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            Btn_Save.Visible = true;
            tableLayoutPanel1.Enabled = true;
            tcSettings.Enabled = true;
        }

        private void trackBarBoostClock_ValueChanged(object sender, EventArgs e)
        {
            lblBoostClock.Text = trackBarBoostClock.Value.ToString();
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

        private void ExtractUID_Click(object sender, EventArgs e)
        {
            byte[] UID = new byte[0xFFF];
            for (int i = 0; i < UID.Length; i++)
            {
                UID[i] = class30_0.byte_1[0x4000 + i];
            }
            if (UID != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = h2s(Class24.UUID);
                saveFileDialog.Filter = h2s(Class24.UID);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, UID);
                    msgbox(1);
                }
            }
        }

        private void InjectUID_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = h2s(Class24.UUID);
            openFileDialog.Filter = h2s(Class24.UID);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] UID = File.ReadAllBytes(openFileDialog.FileName);
                if (UID.Length == 4095)
                {
                    for (int i = 0; i < UID.Length; i++)
                    {
                        class30_0.byte_1[0x4000 + i] = UID[i];
                    }
                    msgbox(2);
                }
                else
                {
                    msgbox(3);
                }
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (e.TabPageIndex == 0 || e.TabPageIndex == 1)
            {
                return;
            }
            else
            {
                if (button1.Visible == false)
                    e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string[] files = Directory.GetFiles(currentDirectory, h2s(Class24.rom));
            string dumplog = h2s(Class24.CSVHead) + Environment.NewLine;
            foreach (string s in files)
            {
                triedalready = false;
                notsupported = false;
                this.method_3(s);
                dumplog += databasedump() + Environment.NewLine;
            }
            Clipboard.SetText(dumplog);

        }

        private void lChkSum_DoubleClick(object sender, EventArgs e)
        {
            msgbox(6);
        }
    }
}
