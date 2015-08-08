using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLib
{
    public class ModelList
    {
        List<Model> list = null;

        public ModelList()
        {
            list = new List<Model>();
            //Audi
            list.Add(new Model { ModelGuid = new Guid("AB82DFC5-F3FB-447B-9602-F369B33E4EAA"), Code = "A3", Name = "A3" });
            list.Add(new Model { ModelGuid = new Guid("6E212EA8-B05D-4011-B094-2FC9D155F120"), Code = "A4", Name = "A4" });
            list.Add(new Model { ModelGuid = new Guid("D6C4E5DE-22D9-46F9-ADEF-1E68D7344050"), Code = "A5", Name = "A5" });
            list.Add(new Model { ModelGuid = new Guid("715CD848-6EE6-42AB-9FB8-4C820544B2D8"), Code = "A6", Name = "A6" });
            list.Add(new Model { ModelGuid = new Guid("5780B7AF-CFE9-48C1-B787-C07010AEEE3B"), Code = "A7", Name = "A7" });
            list.Add(new Model { ModelGuid = new Guid("2CA6874D-B35C-48F0-B50F-AF1A5B660D49"), Code = "A8", Name = "A8" });
            list.Add(new Model { ModelGuid = new Guid("56B2B8BF-ADBD-453E-9721-7527C1826B4C"), Code = "Allroad", Name = "Allroad" });
            list.Add(new Model { ModelGuid = new Guid("A74729D8-525A-433D-BB72-5CCD4D427DAD"), Code = "Q3", Name = "Q3" });
            list.Add(new Model { ModelGuid = new Guid("6C188635-9B69-4FAE-BA65-76F8AB35BBF0"), Code = "Q5", Name = "Q5" });
            list.Add(new Model { ModelGuid = new Guid("FC2977CD-CBF4-4B50-8BD8-A84DE38230CB"), Code = "Q5H", Name = "Q5 Hybrid" });
            list.Add(new Model { ModelGuid = new Guid("915C50CE-B8E3-47F9-8E31-E4BB08D1E3B3"), Code = "RS7", Name = "RS7" });
            list.Add(new Model { ModelGuid = new Guid("40333F66-5DE3-44DD-A930-C7F3126CC9D5"), Code = "S3", Name = "S3" });
            list.Add(new Model { ModelGuid = new Guid("05A4499B-8F49-4B5A-A20A-D871F08A9BFF"), Code = "S4", Name = "S4" });
            list.Add(new Model { ModelGuid = new Guid("5292BB24-F7FE-4BC7-9D2C-B8A74A9E1812"), Code = "S5", Name = "S5" });
            list.Add(new Model { ModelGuid = new Guid("A541CBEF-3929-401A-AFED-70FD4B3D1F1B"), Code = "S6", Name = "S6" });
            list.Add(new Model { ModelGuid = new Guid("005EC453-B3BB-4D97-B119-186C74422D5D"), Code = "S7", Name = "S7" });
            list.Add(new Model { ModelGuid = new Guid("2B9D90EF-379D-485B-B65D-9B13B2FAEB89"), Code = "S8", Name = "S8" });
            list.Add(new Model { ModelGuid = new Guid("75164C2D-6ACB-4B77-BAE1-2DE45519AE93"), Code = "SQ5", Name = "SQ5" });
            list.Add(new Model { ModelGuid = new Guid("AB04ACDD-B43E-4896-80E4-35BFA45B95CE"), Code = "TT", Name = "TTS" });
            list.Add(new Model { ModelGuid = new Guid("FB0017E6-38EF-4DF1-B6D0-1DA7958AFDA7"), Code = "RS4", Name = "RS4" });
            list.Add(new Model { ModelGuid = new Guid("3C7CAC73-414C-4B55-8C3D-188D72DFED97"), Code = "Q7", Name = "Q7" });
            list.Add(new Model { ModelGuid = new Guid("9989F326-D062-4A53-AEFB-739383470B91"), Code = "RS5", Name = "RS5" });
            list.Add(new Model { ModelGuid = new Guid("22DE8F9B-7A19-4682-86EF-679B2E968D3B"), Code = "R8", Name = "R8" });
            //Mitsubishi
            list.Add(new Model { ModelGuid = new Guid("D9A68981-9227-4B56-B7F8-AC5FCB299C06"), Code = "iMiEV", Name = "i-MiEV" });
            list.Add(new Model { ModelGuid = new Guid("367C9C9A-289F-4525-8552-6F63449B5DC6"), Code = "Outlander", Name = "Outlander" });
            list.Add(new Model { ModelGuid = new Guid("E86D8383-C80C-418E-A31B-7CE53DAA2018"), Code = "Lancer", Name = "Lancer" });
            list.Add(new Model { ModelGuid = new Guid("692F35BF-9B64-440F-AFFE-A0AFDD1E6C11"), Code = "Mirage", Name = "Mirage" });
            list.Add(new Model { ModelGuid = new Guid("18C7322B-3CD1-41E2-8E5C-7F771D37802C"), Code = "Evolution", Name = "Evolution" });
            list.Add(new Model { ModelGuid = new Guid("E9503BE1-D3A0-4F4D-B40F-3E3AFC073305"), Code = "3000GT", Name = "3000GT" });
            list.Add(new Model { ModelGuid = new Guid("27DFE8E3-5843-4737-A66A-3ACC7D9FE595"), Code = "Diamante", Name = "Diamante" });
            list.Add(new Model { ModelGuid = new Guid("D3B47011-4600-4588-BAF3-9A03A4641ADF"), Code = "Eclipse", Name = "Eclipse" });
            list.Add(new Model { ModelGuid = new Guid("EB91711C-46BC-477D-8DE1-ED1743D4FC49"), Code = "Endeavor", Name = "Endeavor" });
            list.Add(new Model { ModelGuid = new Guid("83687985-1912-4277-A5F9-B6E39FF4EB4C"), Code = "Galant", Name = "Galant" });
            list.Add(new Model { ModelGuid = new Guid("F6A1C553-BBCC-4E2D-AB47-E81A4C951086"), Code = "Montero", Name = "Montero" });
            list.Add(new Model { ModelGuid = new Guid("71684744-A4D4-4C15-A49F-FFD9B4BBAB2D"), Code = "MonteroSport", Name = "Montero Sport" });
            //Subaru
            list.Add(new Model { ModelGuid = new Guid("2BA5CE6E-9433-4815-9A09-D09B76314C67"), Code = "BRZ", Name = "BRZ" });
            list.Add(new Model { ModelGuid = new Guid("76954325-73B8-40E8-8236-49FFE4F2C1C8"), Code = "Forester", Name = "Forester" });
            list.Add(new Model { ModelGuid = new Guid("C19D6592-1F84-411D-88CE-3C2F46DD2E9D"), Code = "Legacy", Name = "Legacy" });
            list.Add(new Model { ModelGuid = new Guid("EB1EE391-AD7E-428F-9FF0-90019153F897"), Code = "Outback", Name = "Outback" });
            list.Add(new Model { ModelGuid = new Guid("35440147-01D4-4CEA-BD8D-9817A0E54A84"), Code = "WRXSTI", Name = "WRX STI" });
            list.Add(new Model { ModelGuid = new Guid("98F90674-5A17-4BE2-8419-5BB5F90EFB3C"), Code = "WRX", Name = "WRX" });
            list.Add(new Model { ModelGuid = new Guid("43F3753F-B772-4412-B51D-2A962962AC2E"), Code = "Impreza", Name = "Impreza" });
            list.Add(new Model { ModelGuid = new Guid("7B78D7C9-CB77-471B-BA74-42D53A97627B"), Code = "XVCrosstrek", Name = "XV Crosstrek" });
            list.Add(new Model { ModelGuid = new Guid("C188BD58-D6AE-4A4B-9B29-54F6C66E5DAF"), Code = "B9Tribeca", Name = "B9 Tribeca" });
            list.Add(new Model { ModelGuid = new Guid("C247A2C9-591E-4088-B9F6-341FDBE014F0"), Code = "SVX", Name = "SVX" });
            list.Add(new Model { ModelGuid = new Guid("1614BE3E-A7A2-49DC-9E9B-221A816D02E2"), Code = "ImprezaWRXSTi", Name = "Impreza WRX STi" });
            list.Add(new Model { ModelGuid = new Guid("3617B2A7-510B-472A-8100-D87211A8A41D"), Code = "Loyale", Name = "Loyale" });
            // Nissan
            list.Add(new Model { ModelGuid = new Guid("A9C085BE-40CF-468A-90F6-F1263325E9D1"), Code = "Maxima", Name = "Maxima"});
            //list.Add(new Model { ModelGuid = new Guid("667034B4-22DA-43BB-B574-56215C31F3F0"), Code = "MaximaS", Name = "Maxima S", StyleTrim = "S" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "MaximaSV", Name = "Maxima SV", StyleTrim = "SV" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "MaximaSL", Name = "Maxima SL", StyleTrim = "SL" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "MaximaSR", Name = "Maxima SR", StyleTrim = "SR" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "MaximaPlatinum", Name = "Maxima Platinum", StyleTrim = "Platinum" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "", Name = "", StyleTrim = "" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "", Name = "" });
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "", Name = "" });
            //
            //list.Add(new Model { ModelGuid = new Guid(""), Code = "", Name = "" });
        }

        public Model GetCode(string code)
        {
            foreach (Model itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    return itm;
                }
            }
            return null;
        }

        public List<string> GetModels()
        {
            List<string> models = new List<string>();
            foreach(Model itm in list)
            {
                models.Add(itm.Code);
            }
            return models;
        }


    }
}
