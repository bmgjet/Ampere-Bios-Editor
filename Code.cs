using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

//Firmware-Checksum 0x18FFF
//Firmware-Start 0x9200


//Type 1 Bios
//Settings-Checksum 0x8E1FF
//Settings-Start 0x19000

//Clocks
//Boost Clock 0x8E103

//PowerLimits
//Board Minimum PL 0x8BDF2
//Board Default PL 0x8BDF6
//Board Max PL 0x8BDFA
//Unknown 0X8BE00 (350W=3335) (400W=3588) Single Table

//AUX Def 0x8C833 (400000)   Part Low
//		  0x8C866
//		  0x8C899
//        0x8C8CC

//AUX MAX 0x8C837 (500000)   Part High
//		  0x8C86A
//		  0x8C89D
//		  0x8C8D0


//SRC Def 0x8BF02 (150000) Plug1
//        0x8BF45 (150000) Plug2 
//        0x8C051 (150000) Plug3 

//SRC Max 0x8BF06 (175000) Plug1 
//        0x8BF49 (175000) Plug2 
//		  0x8C055 (175000) Plug3 

//ChipPower Def 0x8C0D7 (350w=226800)(400W=243000) Part1
//ChipPower Max 0x8C0DB (350w=226800)(400w=319920) Part2

//VRAM 0x8C1A0 (93750) Part1
//VRAM 0x8C1A4 (350w=100000)(400w=107800) Part2

//PCI-E Slot Def 0x8C1E3
//PCI-E Slot Max 0x8C1E7

//8pinPlug Def 0x8C226 (350w=121500)(400w=145800) Part1
//8pinPlug Max 0x8C22A (350w=121500)(400W=162000) Part2

//Type 2 Bios 
//Look up with address B table vs A table.

//3080FE
//Look up with address C table vs A table.

internal class Class24 : Class1
{
	public Class24(byte[] byte_2, int int_11) : base(byte_2, int_11)
	{
		this.class26_0 = new Class26(byte_2, int_11 + this.Int32_2);
	}


	private int Int32_1
	{
		get
		{
			if (this.nullable_0 == null)
			{
				int num = this.byte_0.smethod_0(Class24.byte_1, this.int_0, false, null);
				this.nullable_0 = new int?(num - (114 + this.int_0));
			}
			return this.nullable_0.Value;
		}
	}

	public int Int32_2
	{
		get
		{
			return (int)BitConverter.ToUInt16(this.byte_0, this.int_0 + 24);
		}
	}

	public string String_0
	{
		get
		{
			return this.byte_0.smethod_1(this.int_0 + 56, 8);
		}
	}

	public ushort UInt16_0
	{
		get
		{
			return BitConverter.ToUInt16(this.byte_0, this.int_0 + 84);
		}
	}

	public string String_1
	{
		get
		{
			return this.byte_0.smethod_1(this.int_0 + this.Int32_1 + 134, 57);
		}
	}

	public string String_2
	{
		get
		{
			return this.byte_0.smethod_1(this.int_0 + this.Int32_1 + 223, 14);
		}
	}

	public string GetDefaultPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A6);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B6);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C6);
			}
			return "0";

		}
	}

	public string GetMaxPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A7);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B7);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C7);
			}
			return "0";
		}
	}
	public string GetMinimumPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A5);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B5);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C5);
			}
			return "0";
		}
	}

	public string GetBoostClock
	{
		get
		{
			
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.ClockSpeed(Class24.A27);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.ClockSpeed(Class24.B27);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.ClockSpeed(Class24.C27);
			}
			return "0";
		}
	}

	public string GetDefault8pinPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A17);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B17);
			}

			return "0";
		}
	}

	public string GetMax8pinPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A18);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B18);
			}
			return "0";
		}
	}

	public string GetDefaultSRCPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A9);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B9);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C9);
			}
			return "0";
		}
	}

	public string GetDefaultSRC2PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A9_1);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B9_1);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C9_1);
			}
			return "0";
		}
	}

	public string GetDefaultSRC3PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A9_2);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B9_2);
			}
			return "0";
		}
	}

	public string GetMaxSRCPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A10);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B10);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C10);
			}
			return "0";
		}
	}

	public string GetMaxSRC2PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A10_1);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B10_1);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C10_1);
			}
			return "0";
		}
	}


	public string GetMaxSRC3PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A10_2);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B10_2);
			}
			return "0";
		}
	}

	public string GetDefaultChipPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A11);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B11);
			}
			return "0";
		}
	}

	public string GetMaxChipPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A12);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B12);
			}
			return "0";
		}
	}

	public string GetDefaultSlotPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A15);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B15);
			}
			return "0";
		}
	}

	public string GetMaxSlotPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A16);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B16);
			}
			return "0";
		}
	}

	public string GetDefaultVRAMPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A13);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B13);
			}
			return "0";
		}
	}

	public string GetMaxVRAMPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A14);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B14);
			}
			return "0";
		}
	}

	public string GetUnknownPL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A8);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B8);
			}
			else if (Class24.ThisBiosType == 3)
			{
				return this.byte_0.spower(Class24.C8);
			}
			return "0";
		}
	}

	public string GetDefAUX1PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A19);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B19);
			}
			return "0";
		}
	}
	public string GetDefAUX2PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A20);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B20);
			}
			return "0";
		}
	}
	public string GetDefAUX3PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A21);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B21);
			}
			return "0";
		}
	}
	public string GetDefAUX4PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A22);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B22);
			}
			return "0";
		}
	}

	public string GetMaxAUX1PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A23);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B23);
			}
			return "0";
		}
	}

	public string GetMaxAUX2PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A24);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B24);
			}
			return "0";
		}
	}

	public string GetMaxAUX3PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A25);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B25);
			}
			return "0";
		}
	}

	public string GetMaxAUX4PL
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0.spower(Class24.A26);
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0.spower(Class24.B26);
			}
			return "0";
		}
	}


	public string Hash
	{
		get
		{
			byte[] hash;
			using (var md5 = System.Security.Cryptography.MD5.Create())
			{
				md5.TransformFinalBlock(this.byte_0, 0, this.byte_0.Length);
				hash = md5.Hash;
				return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

			}
		}
	}




	public string String_3
	{
		get
		{
			return this.byte_0.smethod_1(this.int_0 + this.Int32_1 + 290, 35);
		}
	}

	public bool Boolean_0
	{
		get
		{
			string biostype = this.byte_0.smethod_1(0, 4);
			if (biostype == "NVGI")
			{
				if (this.byte_0.Length == 999424)
				{
					return true;
				}
				else
					return false;
			}
			else
			{
				return false;
			}
		}
	}

	public string String_4
	{
		get
		{
			return this.byte_0.smethod_1(21034, 30);
		}
	}




	public static byte ThisBiosType = 1;
	//Constants
	private const int int_1 = 24;
	private const int int_2 = 84;
	private const int int_3 = 56;
	private const int int_4 = 8;
	private const int int_5 = 134;
	private const int int_6 = 57;
	private const int int_7 = 223;
	private const int int_8 = 14;
	private const int int_9 = 290;
	private const int int_10 = 35;
	public int A1 = 0x18FFF;
	public int A2 = 0x9200;

	//Bios Type 1

	public static int A3 = 0x8E1FF; //Settings Table Checksum
	public static int A4 = 0x19000; //Settings Table Start
	public static int A5 = 0x8BDF2; //Min TDP
	public static int A6 = 0x8BDF6; //Default TDP
	public static int A7 = 0x8BDFA; //Max TDP
	public static int A8 = 0X8BE00; //Unknown (gets higher with higher powerlimited cards)
	public static int A9 = 0x8BF02; //SRC
	public static int A9_1 = 0x8BF45; //2
	public static int A9_2 = 0x8C051; //3
	public static int A10 = 0x8BF06; //Max
	public static int A10_1 = 0x8BF49; //2
	public static int A10_2 = 0x8C055; //3
	public static int A11 = 0x8C0D7; //chip power
	public static int A12 = 0x8C0DB; //max
	public static int A13 = 0x8C1A0; //Vram
	public static int A14 = 0x8C1A4; //max
	public static int A15 = 0x8C1E3; //Slot
	public static int A16 = 0x8C1E7; //max
	public static int A17 = 0x8C226; //8pin
	public static int A18 = 0x8C22A; //max
	public static int A19 = 0x8C833; //AUX
	public static int A20 = 0x8C866; //2
	public static int A21 = 0x8C899; //3
	public static int A22 = 0x8C8CC; //4
	public static int A23 = 0x8C837; //Aux Hi
	public static int A24 = 0x8C86A; //2
	public static int A25 = 0x8C89D; //3
	public static int A26 = 0x8C8D0; //4
	public static int A27 = 0x8E103; //Boost Clock

	//Bios Type 2
	public static int B3 = 0x8F3FF; //Settings Table Checksum
	public static int B4 = Class24.A4; //Settings Table Start
	public static int B5 = 0x8CF04; //Min TDP
	public static int B6 = 0x8CF08; //Default TDP
	public static int B7 = 0X8CF0C; //Max TDP
	public static int B8 = 0x8CF12; //Unknown
	public static int B9 = 0x8D024;  //SRC
	public static int B9_1 = 0x8D06B; //2
	public static int B9_2 = 0x8D187; //3
	public static int B10 = 0x8D028;  //max
	public static int B10_1 = 0x8D06F; //2
	public static int B10_2 = 0x8D18B; //3
	public static int B11 = 0x8D215; //Chip power
	public static int B12 = 0x8D219; //max
	public static int B13 = 0x8D331;  //Vram
	public static int B14 = 0x8D335;    //max
	public static int B15 = 0x8CFDD; //slot
	public static int B16 = 0x8CFE1; //max
	public static int B17 = 0x8D024;  //8pin
	public static int B18 = 0x8D028; //max
	public static int B19 = 0x8D98D;    //Aux
	public static int B20 = 0x8D9C0; //2
	public static int B21 = 0x8D9F3; //3
	public static int B22 = 0x8DA26; //4
	public static int B23 = 0x8D991;  //Aux Hi
	public static int B24 = 0x8D9C4; //2
	public static int B25 = 0x8D9F7; //3
	public static int B26 = 0x8DA2A; //4
	public static int B27 = 0x8F25E; //boost clock

	//Bios Type 3
	public static int C3 = 0x8F3FF; //Settings Table Checksum
	public static int C4 = Class24.A4; //Settings Table Start
	public static int C5 = 0x8BB0A; //Min TDP
	public static int C6 = 0x8BB0E; //Default TDP
	public static int C7 = 0x8BB12; //Max TDP
	public static int C8 = 0x8BB18; //Unknown
	public static int C9 = 0x8BC1A;  //SRC
	public static int C9_1 = 0x8BC5D; //2
	public static int C9_2 = 0; //3
	public static int C10 = 0x8BC1E;  //max
	public static int C10_1 = 0x8BC61; //2
	public static int C10_2 = 0; //3
	public static int C11 = 0; //Chip power
	public static int C12 = 0; //max
	public static int C13 = 0;  //Vram
	public static int C14 = 0;    //max
	public static int C15 = 0; //slot
	public static int C16 = 0; //max
	public static int C17 = 0;  //8pin
	public static int C18 = 0; //max
	public static int C19 = 0;    //Aux
	public static int C20 = 0; //2
	public static int C21 = 0; //3
	public static int C22 = 0; //4
	public static int C23 = 0;  //Aux Hi
	public static int C24 = 0; //2
	public static int C25 = 0; //3
	public static int C26 = 0; //4
	public static int C27 = 0; //boost clock


	public static int[] Voltage; // = new[] { 700, 706, 712, 718, 725, 731, 737, 743, 750, 756, 762, 768, 775, 781, 787, 793, 800, 806, 812, 818, 825, 831, 837, 843, 850, 856, 862, 868, 875, 881, 887, 893, 900, 906, 912, 918, 925, 931, 937, 943, 950, 956, 962, 968, 975, 981, 987, 993, 1000, 1006, 1012, 1018, 1025, 1031, 1037, 1043, 1050, 1056, 1062, 1068, 1075, 1081, 1087, 1093, 1100, 1106, 1112, 1118, 1125, 1131, 1137, 1143, 1150, 1156, 1162, 1168, 1175, 1181, 1187, 1193, 1200, 1206, 1212, 1218, 1225, 1231, 1237, 1243, 1250 };
	public static int[] Frequency; // = new[] { 1245, 1275, 1290, 1305, 1335, 1350, 1365, 1380, 1410, 1400, 1425, 1440, 1455, 1470, 1485, 1515, 1530, 1545, 1560, 1575, 1590, 1605, 1620, 1635, 1650, 1665, 1680, 1695, 1710, 1725, 1725, 1740, 1755, 1770, 1785, 1800, 1800, 1815, 1830, 1830, 1845, 1860, 1875, 1875, 1890, 1890, 1905, 1920, 1920, 1935, 1935, 1950, 1950, 1965, 1965, 1980, 1980, 1995, 1995, 1995, 2010, 2010, 2010, 2025, 2025, 2025, 2025, 2040, 2040, 2040, 2040, 2040, 2040, 2040, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055, 2055 };
	public static int[] Temperture = new int[100];
	public static int[] FanTarget = new int[100];
	public static int[] FanScaler = new int[100];
	public static int BoostClock = 0;


	private static byte[] byte_1 = new byte[]
	{
		80,
		77,
		73,
		68
	};

	public readonly Class26 class26_0;

	private int? nullable_0;
}

internal class Class26 : Class1
{
	public Class26(byte[] byte_2, int int_6) : base(byte_2, int_6)
	{
	}

	public bool Boolean_0
	{
		get
		{
			return this.byte_0.smethod_0(this.byte_1, this.int_0, false, null) == this.int_0;
		}
	}

	public int card
    {
        get
        {
			if (UInt16_1 == 0x2204)
				return 3080;
			else if (UInt16_1 == 0x2206)
				return 3080;
			else
				return 0;
		}
	}

	public int offsetVFR
    {
		get
		{
			return Class24.BoostClock - referenceclocks;
		}

    }
		

	public int referenceclocks
    {
		get
        {
			if (UInt16_1 == 0x2204)
				return 1695;
			else if (UInt16_1 == 0x2206)
				return 1710;
			else
				return 0;
		}
    }

	public ushort UInt16_0
	{
		get
		{
			return BitConverter.ToUInt16(this.byte_0, this.int_0 + 4);
		}
	}

	public ushort UInt16_1
	{
		get
		{
			return BitConverter.ToUInt16(this.byte_0, this.int_0 + 6);
		}
	}

	public ushort UInt16_2
	{
		get
		{
			return BitConverter.ToUInt16(this.byte_0, this.int_0 + 295);
		}
	}

	public int Int32_1
	{
		get
		{
			return (int)(BitConverter.ToUInt16(this.byte_0, this.int_0 + 16) * 512);
		}
	}

	public bool Boolean_1
	{
		get
		{
			return (this.byte_0[this.int_0 + 21] & 128) == 128;
		}
	}

	private const int int_1 = 4;
	private const int int_2 = 6;
	private const int int_3 = 16;
	private const int int_4 = 21;
	private const int int_5 = 295;

	private byte[] byte_1 = new byte[]
	{
		80,
		67,
		73,
		82
	};
}

internal class Class1
{
	public Class1(byte[] byte_1, int int_1)
	{
		this.int_0 = int_1;
		this.byte_0 = byte_1;
	}

	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
	}

	protected int int_0;
	protected byte[] byte_0;
}

internal static class Class29
{
	internal static int smethod_0(this byte[] byte_0, byte[] byte_1, int int_0 = 0, bool bool_0 = false, byte? nullable_0 = null)
	{
		for (int i = int_0; i < byte_0.Length; i++)
		{
			if (byte_1[0] == byte_0[i] && byte_0.Length - i >= byte_1.Length)
			{
				bool flag = true;
				int num = 1;
				while (num < byte_1.Length && flag)
				{
					byte b = byte_0[i + num];
					if (b != byte_1[num] && ((bool_0 && num == byte_1.Length - 1 && (b & 63) != byte_1[num]) || !bool_0) && ((nullable_0 != null && nullable_0 != byte_1[num]) || nullable_0 == null))
					{
						flag = false;
						break;
					}
					num++;
				}
				if (flag)
				{
					return i;
				}
			}
		}
		return -1;
	}

	internal static string spower(this byte[] byte_0, int int_0)
	{
		byte[] wattage = { byte_0[int_0], byte_0[int_0 + 1], byte_0[int_0 + 2], byte_0[int_0 + 3] };
		int decWat = BitConverter.ToInt32(wattage, 0);
		string @string = decWat.ToString();
		return @string;
	}

	internal static string ClockSpeed(this byte[] byte_0, int int_0)
	{
		byte[] Clock = { byte_0[int_0], byte_0[int_0 + 1], byte_0[int_0 + 2], byte_0[int_0 + 3] };
		int Speed = BitConverter.ToInt32(Clock, 0) / 1000;
		string @string = Speed.ToString();
		return @string;
	}


	internal static void setpower(this byte[] byte_0, int int_0,int NewPL)
	{
		byte[] NewWattage = BitConverter.GetBytes(NewPL);
		byte_0[int_0] = NewWattage[0];
		byte_0[int_0 + 1] = NewWattage[1];
		byte_0[int_0 + 2] = NewWattage[2];
		byte_0[int_0 + 3] = NewWattage[3];
	}

	internal static string smethod_1(this byte[] byte_0, int int_0, int int_1)
	{
		string @string = Encoding.ASCII.GetString(byte_0, int_0, int_1);
		int num = @string.IndexOf('\0');
		if (num > -1)
		{
			return @string.Substring(0, num).Trim();
		}
		return @string.Trim();
	}

	internal static string smethod_2(this byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = int_0; i < int_0 + int_1; i++)
		{
			if (num % 16 == 0)
			{
				stringBuilder.AppendLine();
			}
			stringBuilder.Append(byte_0[i].ToString("X2") + " ");
			num++;
		}
		return stringBuilder.ToString().Trim();
	}

	internal static void smethod_3(this uint uint_0, byte[] byte_0, int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(uint_0);
		Buffer.BlockCopy(bytes, 0, byte_0, int_0, bytes.Length);
	}

	internal static void smethod_4(this ushort ushort_0, byte[] byte_0, int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(ushort_0);
		Buffer.BlockCopy(bytes, 0, byte_0, int_0, bytes.Length);
	}
}
internal class Class25 : Class1
{
	public Class25(byte[] byte_2, int int_1) : base(byte_2, int_1)
	{
		this.class24_0 = new Class24(byte_2, int_1);
		int num = byte_2.smethod_0(this.byte_1, int_1, false, new byte?(0));
	}

	private bool method_0(ushort ushort_0)
	{
		return true;
	}

	public void method_1()
	{
		this.Byte_0 = this.method_2(false);
	}

	public byte Byte_0
	{
		get
		{
			return this.byte_0[this.int_0 + this.class24_0.class26_0.Int32_1 - 1];
		}
		set
		{
			this.byte_0[this.int_0 + this.class24_0.class26_0.Int32_1 - 1] = value;
		}
	}

	public byte Byte_2
	{
		get
		{
			if (Class24.ThisBiosType == 1)
			{
				return this.byte_0[Class24.A3];
			}
			else if (Class24.ThisBiosType == 2)
			{
				return this.byte_0[Class24.B3];
			}
			return 0;
		}
		set
		{
			if (Class24.ThisBiosType == 1)
			{
				this.byte_0[Class24.A3] = value;
			}
			else if (Class24.ThisBiosType == 2)
			{
				this.byte_0[Class24.B3] = value;
			}
			
		}
	}


	public byte method_2(bool ImageChecksum2)
	{
		ulong num = 0UL;
		if (ImageChecksum2)
		{

			int datastart = Class24.A4;
			int dataend = Class24.A3;
			if (Class24.ThisBiosType == 2)
			{
				datastart = Class24.B4;
				dataend = Class24.B3;
			}
			else if (Class24.ThisBiosType == 3)
            {

            }
				for (int i = datastart; i < dataend; i++)
			{
				num += (ulong)this.byte_0[i];
			}
		}
		else
		{
			int datastart = this.int_0;
			int dataend = this.class24_0.class26_0.Int32_1 - 1;
			int datarange = datastart + dataend;
			for (int i = datastart; i < datarange; i++)
			{
				num += (ulong)this.byte_0[i];
			}
		}
		return (byte)(255UL - (num - 1UL & 255UL));
	}



	private bool method_3(int int_1)
	{
		return int_1 != -1 && int_1 > this.int_0 && int_1 < this.int_0 + this.class24_0.class26_0.Int32_1;
	}

	public readonly Class24 class24_0;

	private readonly byte[] byte_1 = new byte[]
	{
		byte.MaxValue,
		184,
		66,
		73,
		84
	};

}
internal class Class30
{
	public Class30(string string_1)
	{
		this.string_0 = string_1;
		this.byte_1 = File.ReadAllBytes(string_1);
		this.list_0 = this.method_0();
	}

	private List<Class25> method_0()
	{
		List<Class25> list = new List<Class25>();
        int num = this.byte_1.smethod_0(this.byte_0, 0, false, null);
		if (num != 0x9200)
        {
			num = 0x9200;
		}
		if (num > -1)
		{
			Class24 @class;
			do
			{
				@class = new Class24(this.byte_1, num);
				if (!@class.class26_0.Boolean_0)
				{
					break;
				}
				list.Add(new Class25(this.byte_1, num));
				num += @class.class26_0.Int32_1;
			}
			while (!@class.class26_0.Boolean_1);
		}
		return list;
	}


	public void method_1(string string_1)
	{
		foreach (Class25 @class in this.list_0)
		{
			@class.method_1();
		}
		File.WriteAllBytes(string_1, this.byte_1);
	}



    
    private byte[] byte_0 = new byte[]
	{
		85,
		170
	};

	public readonly string string_0;
	public readonly byte[] byte_1;
	public readonly List<Class25> list_0;
}
internal class Class23 : Class1
{
	public Class23(byte[] byte_1, int int_6) : base(byte_1, int_6)
	{
		this.list_0 = this.method_0();
	}

	private List<Class22> method_0()
	{
		List<Class22> list = new List<Class22>();
		for (int i = 0; i < (int)this.Byte_2; i++)
		{
			int num = this.int_0 + (int)((ulong)this.Byte_0 + (ulong)this.UInt32_0 * (ulong)((long)i));
			list.Add(new Class22(this.byte_0, num, (uint)this.Byte_1, (uint)this.Byte_4, (uint)this.Byte_3));
		}
		return list;
	}

	public string String_0
	{
		get
		{
			return this.byte_0.smethod_2(this.int_0, (int)this.Byte_0);
		}
	}

	public byte Byte_0
	{
		get
		{
			return this.byte_0[this.int_0 + 1];
		}
	}

	public byte Byte_1
	{
		get
		{
			return this.byte_0[this.int_0 + 2];
		}
	}

	public byte Byte_2
	{
		get
		{
			return this.byte_0[this.int_0 + 5];
		}
	}

	public byte Byte_3
	{
		get
		{
			return this.byte_0[this.int_0 + 3];
		}
	}

	public byte Byte_4
	{
		get
		{
			return this.byte_0[this.int_0 + 4];
		}
	}

	public uint UInt32_0
	{
		get
		{
			return (uint)(this.Byte_1 + this.Byte_3 * this.Byte_4);
		}
	}

	public uint UInt32_1
	{
		get
		{
			return (uint)this.Byte_0 + this.UInt32_0 * (uint)this.Byte_2;
		}
	}


	private const int int_1 = 1;
	private const int int_2 = 2;
	private const int int_3 = 3;
	private const int int_4 = 4;
	private const int int_5 = 5;
	public readonly List<Class22> list_0;
}

internal class Class22 : Class1
{
	public Class22(byte[] byte_1, int int_4, uint uint_4, uint uint_5, uint uint_6) : base(byte_1, int_4)
	{
		this.uint_0 = uint_4;
		this.uint_1 = uint_5;
		this.uint_2 = uint_6;
		this.uint_3 = uint_4 + uint_5 * uint_6;
		this.list_0 = this.method_0();
	}

	private List<Class21> method_0()
	{
		List<Class21> list = new List<Class21>();
		int num = 0;
		while ((long)num < (long)((ulong)this.uint_1))
		{
			list.Add(new Class21(this.byte_0, this.int_0 + (int)this.uint_0 + num * (int)this.uint_2, (int)this.uint_2));
			num++;
		}
		return list;
	}

	public string String_0
	{
		get
		{
			return this.byte_0.smethod_2(this.int_0, (int)this.uint_0);
		}
	}

	public byte Byte_0
	{
		get
		{
			return this.byte_0[this.int_0 + 2];
		}
		set
		{
			this.byte_0[this.int_0 + 2] = value;
		}
	}

	public byte Byte_1
	{
		get
		{
			return (byte)(15 - this.byte_0[this.int_0]);
		}
	}

	public byte Byte_2
	{
		get
		{
			return this.byte_0[this.int_0 + 3];
		}
		set
		{
			this.byte_0[this.int_0 + 3] = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return this.byte_0[this.int_0] == byte.MaxValue;
		}
	}

	public int Int32_1
	{
		get
		{
			return (int)this.uint_1;
		}
	}


	private const int int_1 = 0;
	private const int int_2 = 2;
	private const int int_3 = 3;
	private readonly uint uint_0;
	private readonly uint uint_1;
	private readonly uint uint_2;
	private readonly uint uint_3;
	public readonly List<Class21> list_0;
}
internal class Class21 : Class1
{
	public Class21(byte[] byte_1, int int_3, int int_4) : base(byte_1, int_3)
	{
		this.int_1 = int_4;
		this.int_2 = int_4 - 4;
	}

	public string String_0
	{
		get
		{
			return this.byte_0.smethod_2(this.int_0, this.int_1);
		}
	}

	public uint UInt32_0
	{
		get
		{
			return this.UInt32_1 & 8191U;
		}
		set
		{
			this.UInt32_1 = ((this.UInt32_1 & 57344U) | value);
		}
	}

	public uint UInt32_1
	{
		get
		{
			return BitConverter.ToUInt32(this.byte_0, this.int_0 + this.int_2);
		}
		set
		{
			value.smethod_3(this.byte_0, this.int_0 + this.int_2);
		}
	}

	public bool Boolean_0
	{
		get
		{
			return this.UInt32_0 == this.UInt32_1;
		}
	}

	private readonly int int_1;
	private readonly int int_2;
}

internal interface Interface0
{
	void ApplyChanges();
	void Reset();
}

