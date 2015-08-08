using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public class StyleTrim
    {
        public Guid Guid;
        public string Code;
        public string Name;
        public string Description;
    }

    public class StyleTrimList
    {
        List<StyleTrim> list;

        public StyleTrimList()
        {
            list = new List<StyleTrim>();
            //Mitsubishi
            list.Add(new StyleTrim { Guid = new Guid("60A83108-7151-4666-8075-F7741E41C9B3"), Code = "GSR", Name = "GSR" });
            list.Add(new StyleTrim { Guid = new Guid("7ABFC350-6C09-4654-8C3E-1F6B666E90D3"), Code = "MR", Name = "MR" });
            list.Add(new StyleTrim { Guid = new Guid("24328EE4-8433-4A3A-93FE-4BA96B9D6DBD"), Code = "ES", Name = "ES" });
            list.Add(new StyleTrim { Guid = new Guid("71FD5FF6-4E1C-4D61-8B5E-FEC407173B24"), Code = "GS", Name = "GS" });
            list.Add(new StyleTrim { Guid = new Guid("0445A0D7-0967-41D5-89F6-EFB44CF3A3AB"), Code = "EX", Name = "EX" });
            list.Add(new StyleTrim { Guid = new Guid("2CD107A5-4FE0-4081-B32A-1AE1E0894167"), Code = "VRX", Name = "VRX" });
            list.Add(new StyleTrim { Guid = new Guid("AFE10715-DD32-4CCB-AB20-D19B5D175E5C"), Code = "GT", Name = "GT" });
            //Nissan
            list.Add(new StyleTrim { Guid = new Guid("60A83108-7151-4666-8075-F7741E41C9B3"), Code = "S", Name = "S" });
            list.Add(new StyleTrim { Guid = new Guid("B7AD5938-65C0-4ED8-87B0-50836CEB7592"), Code = "SV", Name = "SV" });
            list.Add(new StyleTrim { Guid = new Guid("338CF5AD-8BAB-4B1B-862B-0FE60CDD3FEF"), Code = "SL", Name = "SL" });
            list.Add(new StyleTrim { Guid = new Guid("063F2256-06FD-442D-BA7E-C2237BE09A81"), Code = "SR", Name = "SR" });
            list.Add(new StyleTrim { Guid = new Guid("E8937A4F-5A51-4154-98B5-B43B1A53CBEA"), Code = "Platinum", Name = "Platinum" });
            //Subaru
            list.Add(new StyleTrim { Guid = new Guid("60A83108-7151-4666-8075-F7741E41C9B3"), Code = "BrzPremium", Name = "Premium" });
            list.Add(new StyleTrim { Guid = new Guid("60A83108-7151-4666-8075-F7741E41C9B3"), Code = "BrzLimited", Name = "Limited" });
            //list.Add(new Package { Guid = new Guid(""), Code = "", Name = "" });
        }

        public StyleTrim GetCode(string code)
        {
            foreach (StyleTrim itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    return itm;
                }
            }
            return null;
        }
    }

}
