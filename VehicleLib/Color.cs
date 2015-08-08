using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public class Color
    {
        public Guid Guid;
        public string Code;
        public string Name;
        public string Description;
        public Boolean IsSelected;
    }

    public class ColorList
    {
        private List<Color> list;

        public ColorList()
        {
            list = new List<Color>();
            //Mitsubishi
            list.Add(new Color { Guid = new Guid("60A83108-7151-4666-8075-F7741E41C9B3"), Code = "WickedWhite", Name = "Wicked White" });
            list.Add(new Color { Guid = new Guid("7ABFC350-6C09-4654-8C3E-1F6B666E90D3"), Code = "RallyRed", Name = "Rally Red" });
            list.Add(new Color { Guid = new Guid("24328EE4-8433-4A3A-93FE-4BA96B9D6DBD"), Code = "PhantomBlack", Name = "Phantom Black" });
            list.Add(new Color { Guid = new Guid("71FD5FF6-4E1C-4D61-8B5E-FEC407173B24"), Code = "OctaneBlue", Name = "Octane Blue" });
            list.Add(new Color { Guid = new Guid("0445A0D7-0967-41D5-89F6-EFB44CF3A3AB"), Code = "MercuryGray", Name = "Mercury Gray" });
            list.Add(new Color { Guid = new Guid("2CD107A5-4FE0-4081-B32A-1AE1E0894167"), Code = "ApexSilver", Name = "Apex Silver" });
            //Nissan
            list.Add(new Color { Guid = new Guid("30B47B08-A254-496F-8533-D60D9484CD02"), Code = "CoulisRed", Name = "Coulis Red" });
            list.Add(new Color { Guid = new Guid("A8B76517-9C19-4408-9F94-1F1E2633E6B3"), Code = "BordeuxBlack", Name = "Bordeux Black" });
            list.Add(new Color { Guid = new Guid("7DCB715A-B81A-47D6-940B-28AA93CD2344"), Code = "BrilliantSilver", Name = "Brilliant Silver" });
            list.Add(new Color { Guid = new Guid("6C70E52D-5579-45B5-B429-898DE15C8CAD"), Code = "GunMetallic", Name = "Gun Metallic" });
            list.Add(new Color { Guid = new Guid("66ED1D6A-98D2-4628-AFED-840450EBDDF3"), Code = "ForgedBronze", Name = "Forged Bronze" });
            list.Add(new Color { Guid = new Guid("58DD961A-9225-4C64-99F0-9F18F18001EA"), Code = "SuperBlack", Name = "Super Black" });
            list.Add(new Color { Guid = new Guid("951149DB-9B58-46F1-B5FF-19968A847E72"), Code = "PearlWhite", Name = "Pearl White" });
            list.Add(new Color { Guid = new Guid("97BE2112-E175-4E2C-87BB-0F58711E4BDE"), Code = "DeepBluePearl", Name = "Deep Blue Pearl" });
            list.Add(new Color { Guid = new Guid("913732F3-702A-4CB6-875B-68B80E68807D"), Code = "StormBlue", Name = "Storm Blue" });
            // Subaru
            list.Add(new Color { Guid = new Guid(""), Code = "WrBluePearl", Name = "WR Blue Pearl" });
            list.Add(new Color { Guid = new Guid(""), Code = "CrystalWhitePearl", Name = "Crystal White Pearl" });
            list.Add(new Color { Guid = new Guid(""), Code = "DarkGrayMetallic", Name = "Dark Gray Metallic" });
            list.Add(new Color { Guid = new Guid(""), Code = "LightningRed", Name = "Lightning Red" });
            list.Add(new Color { Guid = new Guid(""), Code = "CrystalBlackSilica", Name = "Crystal Black Silica" });
            //list.Add(new Color { Guid = new Guid(""), Code = "", Name = "" });
        }

        public Color GetCode(string code)
        {
            foreach (Color itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    return itm;
                }
            }
            return null;
        }

        public Boolean SelectOne(string code)
        {
            foreach (Color itm in list)
            {
                itm.IsSelected = false;
            }

            foreach (Color itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    itm.IsSelected = true;
                    return true;
                }
            }
            return false;
        }
    }


}
