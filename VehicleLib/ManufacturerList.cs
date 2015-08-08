using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public class ManufacturerList
    {
        
        
        private List<Manufacturer> list;

        public ManufacturerList()
        {
            list = new List<Manufacturer>();

            list.Add(new Manufacturer { manufacturerID = new Guid("0acb2b4a-885b-46a9-b567-10cf0696eb90"), Code="Ford", Name="Ford" });
            list.Add(new Manufacturer { manufacturerID = new Guid("169958af-f2a2-4b86-8798-0ddd941eccb2"), Code = "Dodge", Name = "Dodge" });
            list.Add(new Manufacturer { manufacturerID = new Guid("dcc397b3-a421-482b-b3a3-d18d56841354"), Code = "Tesla", Name = "Tesla" });
            list.Add(new Manufacturer { manufacturerID = new Guid("e2fdaa34-2a13-4379-9b4e-f3e90d2a147f"), Code = "Jeep", Name = "Jeep" });
            list.Add(new Manufacturer { manufacturerID = new Guid("fd0ed72d-e152-4aec-bb07-e1c9607273d7"), Code = "Chevrolet", Name = "Chevrolet" });
            list.Add(new Manufacturer { manufacturerID = new Guid("63a49b7e-4e7c-4d24-8023-a57141d4326c"), Code = "GMC", Name = "GMC" });
            list.Add(new Manufacturer { manufacturerID = new Guid("10b81c25-43b4-4097-a6c4-4c5ce0955883"), Code = "Buick", Name = "Buick" });
            list.Add(new Manufacturer { manufacturerID = new Guid("afc9d369-4f10-41e7-8246-d3fe3d7f7f46"), Code = "Mitsubishi", Name = "Mitsubishi" });
            list.Add(new Manufacturer { manufacturerID = new Guid("3e974e96-dd81-4505-869f-7aa809f8623a"), Code = "Toyota", Name = "Toyota" });
            list.Add(new Manufacturer { manufacturerID = new Guid("e2ddb557-405f-4c0a-bfc6-a77a2103f46f"), Code = "Subaru", Name = "Subaru" });
            list.Add(new Manufacturer { manufacturerID = new Guid("2915d22e-cb37-434e-9574-e0d398d04569"), Code = "Honda", Name = "Honda" });
            list.Add(new Manufacturer { manufacturerID = new Guid("791a4f6a-062d-4a66-a3eb-204d977170df"), Code = "Nissan", Name = "Nissan" });
            list.Add(new Manufacturer { manufacturerID = new Guid("051686a9-06ce-49ac-b67f-7121792effe7"), Code = "Lexus", Name = "Lexus" });
            list.Add(new Manufacturer { manufacturerID = new Guid("3ba34dd9-f77b-4826-9f2c-c40f8ea0e2a4"), Code = "Acura", Name = "Acura" });
            list.Add(new Manufacturer { manufacturerID = new Guid("646bfaa6-21b3-40ab-93ef-8fbb1dfb6824"), Code = "Mazda", Name = "Mazda" });
            list.Add(new Manufacturer { manufacturerID = new Guid("4c2a70c3-8036-4745-87db-d4acb9c8e314"), Code = "Kawasaki", Name = "Kawasaki" });
            list.Add(new Manufacturer { manufacturerID = new Guid("088ea55f-b6cd-40cd-86bf-f49ff64f29b5"), Code = "Suzuki", Name = "Suzuki" });
            list.Add(new Manufacturer { manufacturerID = new Guid("ea468df6-b84a-4dee-ad32-baff81a503e0"), Code = "Infiniti", Name = "Infiniti" });
            list.Add(new Manufacturer { manufacturerID = new Guid("1ed0afe2-dea4-4ca8-9a44-eeb20fe8ef72"), Code = "Isuzu", Name = "Isuzu" });
            list.Add(new Manufacturer { manufacturerID = new Guid("9fddbea0-979a-4e77-8a7b-477248094404"), Code = "Fiat", Name = "Fiat" });
            list.Add(new Manufacturer { manufacturerID = new Guid("59698e4c-8388-4a40-85ca-e8d8620ffb4b"), Code = "Abarth", Name = "Abarth" });
            list.Add(new Manufacturer { manufacturerID = new Guid("e9128b70-dd72-456b-8637-5939e7cd37d7"), Code = "Audi", Name = "Audi" });
            list.Add(new Manufacturer { manufacturerID = new Guid("7066dac9-5bd6-48af-aeaa-b81195c2a925"), Code = "BMW", Name = "BMW" });
            list.Add(new Manufacturer { manufacturerID = new Guid("c0276570-1b72-4e91-952f-99163680f3ff"), Code = "Benz", Name = "Mercedes Benz" });
            list.Add(new Manufacturer { manufacturerID = new Guid("139f37cd-bb38-4fd0-bec9-222202114b95"), Code = "Porsche", Name = "Porsche" });
            list.Add(new Manufacturer { manufacturerID = new Guid("0086afb3-acbb-4756-b0c9-002f86fb13ea"), Code = "Volkswagen", Name = "Volkswagen" });
            list.Add(new Manufacturer { manufacturerID = new Guid("2f0576d6-212f-4a58-9c10-44727874e589"), Code = "Renault", Name = "Renault" });
            list.Add(new Manufacturer { manufacturerID = new Guid("ed6b58a9-509d-4941-90bc-92976d1b9831"), Code = "Hyundai", Name = "Hyundai" });
            list.Add(new Manufacturer { manufacturerID = new Guid("ac46d88d-1aff-402a-9127-00b90200c276"), Code = "Kia", Name = "Kia" });
            //list.Add(new Manufacturer { manufacturerID = new Guid(""), Code = "", Name = "" });
            //list.Add(new Manufacturer { manufacturerID = new Guid(""), Code = "", Name = "" });
            //list.Add(new Manufacturer { manufacturerID = new Guid(""), Code = "", Name = "" });
            //list.Add(new Manufacturer { manufacturerID = new Guid(""), Code = "", Name = "" });
        }

        public Manufacturer GetCode(string code)
        {
            foreach (Manufacturer itm in list)
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
