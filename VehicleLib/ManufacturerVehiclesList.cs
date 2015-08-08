using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public class ManufacturerVehiclesList
    {
        internal class ManufacturerVehicles
        {
            public Guid Guid;
            public string ManufacturerCode;
            public string ModelCode;
        }

        List<ManufacturerVehicles> list;

        public ManufacturerVehiclesList()
        {
            list.Add(new ManufacturerVehicles { Guid = new Guid("822DC618-9490-4D5F-A541-232FB93E0A12"), ManufacturerCode = "Audi", ModelCode = "A3" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("093722DD-548B-4E23-84CD-DA96EBF19542"), ManufacturerCode = "Audi", ModelCode = "A4" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("A398875B-9545-4A27-AEDB-12C8A4D90519"), ManufacturerCode = "Audi", ModelCode = "A5" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("280AABDD-C78E-4983-92BE-E04227D470BE"), ManufacturerCode = "Audi", ModelCode = "A6" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("0CA3EFC8-C57D-4115-8DDB-D2A0B1076CF0"), ManufacturerCode = "Audi", ModelCode = "A7" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("3C123D8F-0FCA-4D24-AE73-C478BB7E6594"), ManufacturerCode = "Audi", ModelCode = "A8" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("46DDD8FC-EA7B-4F9E-9FF1-6C69BD0A5E38"), ManufacturerCode = "Audi", ModelCode = "Allroad" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("1A5960BB-C465-40DE-9E68-B9CECE9751CF"), ManufacturerCode = "Audi", ModelCode = "Q3" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("B1192EA0-5509-440A-8312-2765F48314C4"), ManufacturerCode = "Audi", ModelCode = "Q5" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("C8878961-EF24-43F9-BD81-CECAEA1B45C0"), ManufacturerCode = "Audi", ModelCode = "Q5H" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("DE751059-7FC1-42C5-AA4D-9D618FC01762"), ManufacturerCode = "Audi", ModelCode = "RS7" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("08942374-F98F-4720-83A4-ECCD82C35121"), ManufacturerCode = "Audi", ModelCode = "S3" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("58B8B13B-C9A1-4293-8D9E-F080C1D7B956"), ManufacturerCode = "Audi", ModelCode = "S4" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("49DC6730-5D4A-4604-9535-943537815F8F"), ManufacturerCode = "Audi", ModelCode = "S5" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("75D530A4-64DA-4DD1-915F-B8D185431F46"), ManufacturerCode = "Audi", ModelCode = "S6" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("6B920425-FEEF-4A5C-B442-5B9630629A85"), ManufacturerCode = "Audi", ModelCode = "S7" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("D4C9DE73-15CE-41EC-9660-7D0318042A3C"), ManufacturerCode = "Audi", ModelCode = "S8" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("9B236CE4-63C1-4578-A8B9-E34E9D288C62"), ManufacturerCode = "Audi", ModelCode = "SQ5" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("F96EDB78-EC99-4959-BE03-826B5A8CD069"), ManufacturerCode = "Audi", ModelCode = "R8" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("DCA50904-856C-4F12-830A-7A1080E16214"), ManufacturerCode = "Mitsubishi", ModelCode = "Lancer" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("FBD2E493-864D-43E6-82AB-5EFBF9D37A83"), ManufacturerCode = "Mitsubishi", ModelCode = "iMiEV" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("FBCFBA70-FDCD-4C6C-944B-116AE449B6A4"), ManufacturerCode = "Mitsubishi", ModelCode = "Outlander" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("58D01A57-3C4C-4FA2-A855-90DAAACB9BB3"), ManufacturerCode = "Mitsubishi", ModelCode = "Mirage" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("00C4E231-11D7-4307-AAE0-7E7D1457310D"), ManufacturerCode = "Mitsubishi", ModelCode = "3000GT" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("EFE26410-8105-4119-8688-02E68A1FEF77"), ManufacturerCode = "Mitsubishi", ModelCode = "Diamante" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("446776B7-2ADC-4123-8A85-7AF26DC02604"), ManufacturerCode = "Mitsubishi", ModelCode = "Eclipse" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("5A0A0948-D168-4484-9897-695EC1D8866E"), ManufacturerCode = "Mitsubishi", ModelCode = "Endeavor" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("9FE11CF2-BA43-4796-8D42-3F617C84F41B"), ManufacturerCode = "Mitsubishi", ModelCode = "Galant" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("6A1196B5-ADE4-42E8-B7A0-13080B948663"), ManufacturerCode = "Mitsubishi", ModelCode = "Montero" });
            list.Add(new ManufacturerVehicles { Guid = new Guid("CDEE243B-64CD-4DF0-BF02-23DBB249AEAD"), ManufacturerCode = "Mitsubishi", ModelCode = "MonteroSport" });
            //list.Add(new ManufacturerVehicles { ManufacturerCode = "", ModelCode = "" });
        }



    }

    

}
