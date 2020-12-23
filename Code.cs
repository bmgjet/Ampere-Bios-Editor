using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
                return this.byte_0.spower(Class24.Type1[6]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[6]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C6);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[6]);
            }
            return 0.ToString();

        }
    }

    public string GetMaxPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[7]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[7]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C7);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[7]);
            }
            return 0.ToString();
        }
    }
    public string GetMinimumPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[5]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[5]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C5);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[5]);
            }
            return 0.ToString();
        }
    }

    public string GetBoostClock
    {
        get
        {

            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.ClockSpeed(Class24.Type1[31]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.ClockSpeed(Class24.Type2[31]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[31]);
            }
            return 0.ToString();
        }
    }

    public string GetDefault8pinPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[21]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[21]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[21]);
            }

            return 0.ToString();
        }
    }

    public string GetMax8pinPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[22]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[22]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[22]);
            }
            return 0.ToString();
        }
    }

    public string GetDefaultSRCPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[9]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[9]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C9);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[9]);
            }
            return 0.ToString();
        }
    }

    public string GetDefaultSRC2PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[10]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[10]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C9_1);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[10]);
            }
            return 0.ToString();
        }
    }

    public string GetDefaultSRC3PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[11]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[11]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[11]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxSRCPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[12]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[12]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C10);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[12]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxSRC2PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[13]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[13]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C10_1);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[13]);
            }
            return 0.ToString();
        }
    }


    public string GetMaxSRC3PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[14]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[14]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[14]);
            }
            return 0.ToString();
        }
    }

    public string GetDefaultChipPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[15]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[15]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[15]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxChipPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[16]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[16]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[16]);
            }
            return 0.ToString();
        }
    }

    public string GetDefaultSlotPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[19]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[19]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[19]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxSlotPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[20]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[20]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[20]);
            }
            return 0.ToString();
        }
    }

    public string GetDefaultVRAMPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[17]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[17]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[17]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxVRAMPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[18]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[18]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[18]);
            }
            return 0.ToString();
        }
    }

    public string GetUnknownPL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[8]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[8]);
            }
            else if (Class24.ThisBiosType == 3)
            {
                return this.byte_0.spower(Class24.C8);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[8]);
            }
            return 0.ToString();
        }
    }

    public string GetDefAUX1PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[23]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[23]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[23]);
            }
            return 0.ToString();
        }
    }
    public string GetDefAUX2PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[24]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[24]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[24]);
            }
            return 0.ToString();
        }
    }
    public string GetDefAUX3PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[25]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[25]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[25]);
            }
            return 0.ToString();
        }
    }
    public string GetDefAUX4PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[26]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[26]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[26]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxAUX1PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[27]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[27]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[27]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxAUX2PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[28]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[28]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[28]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxAUX3PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[29]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[29]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[29]);
            }
            return 0.ToString();
        }
    }

    public string GetMaxAUX4PL
    {
        get
        {
            if (Class24.ThisBiosType == 1)
            {
                return this.byte_0.spower(Class24.Type1[30]);
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0.spower(Class24.Type2[30]);
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0.spower(Class24.XOC[30]);
            }
            return 0.ToString();
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

    //Nvidia Magic System block
    //public int A2 = 0x9200;
    //public int A1 = 0x18FFF;


    //Bios Type 1 (AIB Reference Cards & 3090 FE)
    //Legacy Bios
    //0x0000
    //0x1FFF

    //UEFI Bios
    //0x2000
    //0x3FFF

    //Unique tables
    //0x4000
    //0x4FFF

    //power tables
    //public static int A3 = 0x8E1FF; //Settings Table Checksum
    //public static int A4 = 0x19000; //Settings Table Start
    //public static int A5 = 0x8BDF2; //Min TDP
    //public static int A6 = 0x8BDF6; //Default TDP
    //public static int A7 = 0x8BDFA; //Max TDP
    //public static int A8 = 0X8BE00; //Unknown (gets higher with higher powerlimited cards)
    //public static int A9 = 0x8BF02; //SRC
    //public static int A9_1 = 0x8BF45; //2
    //public static int A9_2 = 0x8C051; //3
    //public static int A10 = 0x8BF06; //Max
    //public static int A10_1 = 0x8BF49; //2
    //public static int A10_2 = 0x8C055; //3
    //public static int A11 = 0x8C0D7; //chip power
    //public static int A12 = 0x8C0DB; //max
    //public static int A13 = 0x8C1A0; //Vram        17
    //public static int A14 = 0x8C1A4; //max
    //public static int A15 = 0x8C1E3; //Slot
    //public static int A16 = 0x8C1E7; //max
    //public static int A17 = 0x8C226; //8pin
    //public static int A18 = 0x8C22A; //max
    //public static int A19 = 0x8C833; //AUX
    //public static int A20 = 0x8C866; //2
    //public static int A21 = 0x8C899; //3
    //public static int A22 = 0x8C8CC; //4
    //public static int A23 = 0x8C837; //Aux Hi
    //public static int A24 = 0x8C86A; //2
    //public static int A25 = 0x8C89D; //3
    //public static int A26 = 0x8C8D0; //4
    //public static int A27 = 0x8E103; //Boost Clock

    public static int[] Type1 = {0x0,0x18FFF,0x9200, 0x8E1FF,0x19000,0x8BDF2,0x8BDF6,0x8BDFA,0X8BE00,0x8BF02,0x8BF45,0x8C051,
0x8BF06, 0x8BF49,0x8C055,0x8C0D7,0x8C0DB,0x8C1A0,0x8C1A4,0x8C1E3,0x8C1E7,0x8C226,0x8C22A,0x8C833,
0x8C866,0x8C899,0x8C8CC,0x8C837,0x8C86A,0x8C89D,0x8C8D0,0x8E103};

    public static int[] Type2 = {Type1[0],Type1[1],Type1[2], 0x8F3FF,Type1[4],0x8CF04,0x8CF08,0X8CF0C,0x8CF12,0x8D024,0x8D06B,0x8D187,
0x8D028, 0x8D06F,0x8D18B,0x8D215,0x8D219,0x8D331,0x8D335,0x8CFDD,0x8CFE1,0x8D024,0x8D028,0x8D98D,
0x8D9C0,0x8D9F3,0x8DA26,0x8D991,0x8D9C4,0x8D9F7,0x8DA2A,0x8F25E};

    public static int[] XOC = {Type1[0],Type1[1],Type1[2], 0x8EDFF,Type1[4],0x8CAA6,0x8CAAA,0x8CAAE,0x8CAB4,Type1[9] + 0xCB4,Type1[10] + 0xCB4,Type1[11] + 0xCB4,
Type1[12] + 0xCB4, Type1[13] + 0xCB4,Type1[14] + 0xCB4,Type1[15] + 0xCB4,Type1[16] + 0xCB4,Type1[17] + 0xCB4,Type1[18] + 0xCB4,Type1[19] + 0xCB4,Type1[20] + 0xCB4,Type1[21] + 0xCB4,Type1[22] + 0xCB4,Type1[23] + 0xCB4,
Type1[24] + 0xCB4,Type1[25] + 0xCB4,Type1[26] + 0xCB4,Type1[27] + 0xCB4,Type1[28] + 0xCB4,Type1[29] + 0xCB4,Type1[30] + 0xCB4,Type1[31] + 0xCB4};

    
    
    
    //Bios Type 2 (Custom Cards)
    //public static int B3 = 0x8F3FF; //Settings Table Checksum
    //public static int B4 = Class24.Type1[4]; //Settings Table Start
    //public static int B5 = 0x8CF04; //Min TDP
    //public static int B6 = 0x8CF08; //Default TDP
    //public static int B7 = 0X8CF0C; //Max TDP
    //public static int B8 = 0x8CF12; //Unknown
    //public static int B9 = 0x8D024;  //SRC
    //public static int B9_1 = 0x8D06B; //2
    //public static int B9_2 = 0x8D187; //3
    //public static int B10 = 0x8D028;  //max
    //public static int B10_1 = 0x8D06F; //2
    //public static int B10_2 = 0x8D18B; //3
    //public static int B11 = 0x8D215; //Chip power
    //public static int B12 = 0x8D219; //max
    //public static int B13 = 0x8D331;  //Vram
    //public static int B14 = 0x8D335;    //max
    //public static int B15 = 0x8CFDD; //slot
    //public static int B16 = 0x8CFE1; //max
    //public static int B17 = 0x8D024;  //8pin
    //public static int B18 = 0x8D028; //max
    //public static int B19 = 0x8D98D;    //Aux
    //public static int B20 = 0x8D9C0; //2
    //public static int B21 = 0x8D9F3; //3
    //public static int B22 = 0x8DA26; //4
    //public static int B23 = 0x8D991;  //Aux Hi
    //public static int B24 = 0x8D9C4; //2
    //public static int B25 = 0x8D9F7; //3
    //public static int B26 = 0x8DA2A; //4
    //public static int B27 = 0x8F25E; //boost clock

    //Bios Type 3 (3080 FE)
    public static int C3 = 0x8F3FF; //Settings Table Checksum
    public static int C4 = Class24.Type1[4]; //Settings Table Start
    public static int C5 = 0x8BB0A; //Min TDP
    public static int C6 = 0x8BB0E; //Default TDP
    public static int C7 = 0x8BB12; //Max TDP
    public static int C8 = 0x8BB18; //Unknown
    public static int C9 = 0x8BC1A;  //SRC
    public static int C9_1 = 0x8BC5D; //2
                                      //public static int C9_2 = 0; //3
    public static int C10 = 0x8BC1E;  //max
    public static int C10_1 = 0x8BC61; //2
                                       //public static int C10_2 = 0; //3
                                       //public static int C11 = 0; //Chip power
                                       //public static int C12 = 0; //max
                                       //public static int C13 = 0;  //Vram
                                       //public static int C14 = 0;    //max
                                       //public static int C15 = 0; //slot
                                       //public static int C16 = 0; //max
                                       //public static int C17 = 0;  //8pin
                                       //public static int C18 = 0; //max
                                       //public static int C19 = 0;    //Aux
                                       //public static int C20 = 0; //2
                                       //public static int C21 = 0; //3
                                       //public static int C22 = 0; //4
                                       //public static int C23 = 0;  //Aux Hi
                                       //public static int C24 = 0; //2
                                       //public static int C25 = 0; //3
                                       //public static int C26 = 0; //4
                                       //public static int C27 = 0; //boost clock


    public static int[] Voltage;
    public static int[] Frequency;
    public static int[] Temperture = new int[100];
    public static int[] FanTarget = new int[100];
    public static int[] FanScaler = new int[100];
    public static int BoostClock = 0;
    public static byte[] CSVHead = { 0x5b, 0x56, 0x65, 0x6e, 0x64, 0x6f, 0x72, 0x5d, 0x2c, 0x5b, 0x56, 0x65, 0x72, 0x73, 0x69, 0x6f, 0x6e, 0x5d, 0x2c, 0x5b, 0x44, 0x61, 0x74, 0x65, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x76, 0x69, 0x63, 0x65, 0x49, 0x44, 0x5d, 0x2c, 0x5b, 0x4d, 0x44, 0x35, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x61, 0x75, 0x6c, 0x74, 0x43, 0x6c, 0x6f, 0x63, 0x6b, 0x5d, 0x2c, 0x5b, 0x42, 0x6f, 0x6f, 0x73, 0x74, 0x43, 0x6c, 0x6f, 0x63, 0x6b, 0x5d, 0x2c, 0x5b, 0x4d, 0x65, 0x6d, 0x43, 0x6c, 0x6f, 0x63, 0x6b, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x61, 0x75, 0x6c, 0x74, 0x50, 0x4c, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x50, 0x4c, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x61, 0x75, 0x6c, 0x74, 0x38, 0x70, 0x69, 0x6e, 0x54, 0x61, 0x72, 0x67, 0x65, 0x74, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x38, 0x70, 0x69, 0x6e, 0x54, 0x61, 0x72, 0x67, 0x65, 0x74, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x61, 0x75, 0x6c, 0x74, 0x53, 0x6c, 0x6f, 0x74, 0x54, 0x61, 0x72, 0x67, 0x65, 0x74, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x53, 0x6c, 0x6f, 0x74, 0x54, 0x61, 0x72, 0x67, 0x65, 0x74, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x43, 0x68, 0x69, 0x70, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x43, 0x68, 0x69, 0x70, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x53, 0x52, 0x43, 0x31, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x53, 0x52, 0x43, 0x32, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x53, 0x52, 0x43, 0x33, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x53, 0x52, 0x43, 0x31, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x53, 0x52, 0x43, 0x32, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x53, 0x52, 0x43, 0x33, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x4d, 0x53, 0x56, 0x44, 0x44, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x4d, 0x53, 0x56, 0x44, 0x44, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x41, 0x55, 0x58, 0x31, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x41, 0x55, 0x58, 0x32, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x41, 0x55, 0x58, 0x33, 0x5d, 0x2c, 0x5b, 0x44, 0x65, 0x66, 0x41, 0x55, 0x58, 0x34, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x41, 0x55, 0x58, 0x31, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x41, 0x55, 0x58, 0x32, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x41, 0x55, 0x58, 0x33, 0x5d, 0x2c, 0x5b, 0x4d, 0x61, 0x78, 0x41, 0x55, 0x58, 0x34, 0x5d, 0x2c, 0x5b, 0x55, 0x6e, 0x6b, 0x6e, 0x6f, 0x77, 0x6e, 0x5d };
    public static byte[] Unsupported = { 0x55, 0x6e, 0x73, 0x75, 0x70, 0x70, 0x6f, 0x72, 0x74, 0x65, 0x64, 0x20, 0x44, 0x65, 0x76, 0x69, 0x63, 0x65 };
    public static byte[] defs = { 0x42, 0x49, 0x4f, 0x53, 0x20, 0x46, 0x69, 0x6c, 0x65, 0x73, 0x7c, 0x2a, 0x2e, 0x72, 0x6f, 0x6d, 0x3b, 0x2a, 0x2e, 0x62, 0x69, 0x6e };
    public static byte[] rom = { 0x2a, 0x2e, 0x72, 0x6f, 0x6d };
    public static byte[] UID = { 0x4e, 0x76, 0x69, 0x64, 0x69, 0x61, 0x20, 0x47, 0x50, 0x55, 0x20, 0x55, 0x49, 0x44, 0x7c, 0x2a, 0x2e, 0x55, 0x49, 0x44 };
    public static byte[] UUID = { 0x2a, 0x2e, 0x55, 0x49, 0x44 };
    public static byte[] csfault = { 0x54, 0x68, 0x65, 0x20, 0x43, 0x68, 0x65, 0x63, 0x6b, 0x53, 0x75, 0x6d, 0x20, 0x69, 0x73, 0x20, 0x69, 0x6e, 0x63, 0x6f, 0x72, 0x72, 0x65, 0x63, 0x74, 0x2c, 0x20, 0x44, 0x6f, 0x20, 0x79, 0x6f, 0x75, 0x20, 0x77, 0x61, 0x6e, 0x74, 0x20, 0x74, 0x6f, 0x20, 0x63, 0x6f, 0x72, 0x72, 0x65, 0x63, 0x74, 0x20, 0x74, 0x68, 0x69, 0x73, 0x3f };
    public static byte[] t2fault = { 0x44, 0x6f, 0x20, 0x79, 0x6f, 0x75, 0x20, 0x77, 0x61, 0x6e, 0x74, 0x20, 0x74, 0x6f, 0x20, 0x74, 0x72, 0x79, 0x20, 0x6f, 0x70, 0x65, 0x6e, 0x20, 0x74, 0x68, 0x69, 0x73, 0x20, 0x72, 0x6f, 0x6d, 0x20, 0x61, 0x73, 0x20, 0x54, 0x79, 0x70, 0x65, 0x32, 0x3f };
    public static byte[] easteregg = { 0x46, 0x72, 0x61, 0x6d, 0x65, 0x20, 0x43, 0x68, 0x61, 0x73, 0x65, 0x72, 0x73, 0x20, 0x69, 0x73, 0x20, 0x61, 0x6e, 0x20, 0x69, 0x64, 0x69, 0x6f, 0x74, 0x20, 0x73, 0x63, 0x61, 0x6d, 0x6d, 0x65, 0x72, 0x2c, 0x20, 0x44, 0x6f, 0x6e, 0x27, 0x74, 0x20, 0x67, 0x69, 0x76, 0x65, 0x20, 0x68, 0x69, 0x6d, 0x20, 0x6d, 0x6f, 0x6e, 0x65, 0x79, 0x21 };

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
                return 3090;
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


    internal static void setpower(this byte[] byte_0, int int_0, int NewPL)
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
                return this.byte_0[Class24.Type1[3]];
            }
            else if (Class24.ThisBiosType == 2)
            {
                return this.byte_0[Class24.Type2[3]];
            }
            else if (Class24.ThisBiosType == 4)
            {
                return this.byte_0[Class24.XOC[3]];
            }
            return 0;
        }
        set
        {
            if (Class24.ThisBiosType == 1)
            {
                this.byte_0[Class24.Type1[3]] = value;
            }
            else if (Class24.ThisBiosType == 2)
            {
                this.byte_0[Class24.Type2[3]] = value;
            }
            else if (Class24.ThisBiosType == 4)
            {
                this.byte_0[Class24.XOC[3]] = value;
            }

        }
    }


    public byte method_2(bool ImageChecksum2)
    {
        ulong num = 0UL;
        if (ImageChecksum2)
        {

            int datastart = Class24.Type1[4];
            int dataend = Class24.Type1[3];
            if (Class24.ThisBiosType == 2)
            {
                datastart = Class24.Type2[4];
                dataend = Class24.Type2[3];
            }
            else if (Class24.ThisBiosType == 3)
            {

            }
            else if (Class24.ThisBiosType == 4)
            {
                datastart = Class24.XOC[4];
                dataend = Class24.XOC[3];
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

