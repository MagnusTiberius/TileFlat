using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public abstract class VehicleConfig : VehicleBase
    {
        public VehicleConfig() : base()
        {

        }

        public VehicleConfig(string manufacturerCode, string modelCode, string styleTrim, int year) 
            : base( manufacturerCode,  modelCode,  styleTrim,  year)
        {
            Init();
        }

        public VehicleConfig(string manufacturerCode, string modelCode, string styleTrim)
            : base(manufacturerCode, modelCode, styleTrim)
        {
            Init();
        }

        private void Init()
        {
            ml = new ManufacturerList();
            manufacturer = ml.GetCode(ManufacturerCode);

            modelList = new ModelList();
            model = modelList.GetCode(ModelCode);

            ConfigIt();
        }

        private void ConfigIt()
        {
            ColorList colorList = new ColorList();
            PackageList packageList = new PackageList();

            if (ManufacturerCode.Equals("Mitsubishi"))
            {
                if (ModelCode.Equals("Evolution") && (Year.Equals(2013) || Year.Equals(2014) || Year.Equals(2015)))
                {
                    ColorList.Add(colorList.GetCode("WickedWhite"));
                    ColorList.Add(colorList.GetCode("RallyRed"));
                    ColorList.Add(colorList.GetCode("PhantomBlack"));
                    ColorList.Add(colorList.GetCode("OctaneBlue"));
                    ColorList.Add(colorList.GetCode("MercuryGray"));
                    ColorList.Add(colorList.GetCode("ApexSilver"));

                    optionalAccessoryPackages.Add(packageList.GetPackage("RearParkAssistSensors"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("SideWindDeflectors"));


                    if (StyleTrim.Equals("GSR"))
                    {
                        BasePrice = 34495;
                        FeatureList = new string[] { "291-horsepower turbocharged 2.0-liter DOHC MIVEC engine", "Super-All Wheel Control", "18x8.5\" Enkei® alloy wheel with 245/40 R18 93W Yokohama® ADVAN® high-performance tires", "BREMBO® high performance braking system", "Active Yaw Control (AYC)" };

                        standardPackages.Add(packageList.GetPackage("FiveSpeedManualTransmission"));
                        standardInteriorOptionalPackages.Add(packageList.GetPackage("BlackFabric"));
                        standardInteriorOptionalPackages.Add(packageList.GetPackage("BlackLeather"));

                        optionalFactoryPackages.Add(packageList.GetPackage("SightAndSound"));
                        optionalFactoryPackages.Add(packageList.GetPackage("PremiumPackage"));

                        optionalAccessoryPackages.Add(packageList.GetPackage("EvoEngineAppearancePackage"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("InteriorPackageGsr"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("LedIlluminationPackage"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("MudSnowPackage"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("NavigationSystemPackage"));
                    }

                    if (StyleTrim.Equals("MR"))
                    {
                        BasePrice = 38995;
                        FeatureList = new string[] { "291-horsepower turbocharged 2.0-liter DOHC MIVEC engine", "Twin Clutch Sportronic® Shift Transmission", "Super-All Wheel Control", "Front and rear suspension with Eibach® springs and Bilstein® shock absorbers, with stabilizer bar", "BREMBO® high performance braking system" };

                        standardPackages.Add(packageList.GetPackage("TwinClutchSportShiftTransmission"));
                        standardInteriorOptionalPackages.Add(packageList.GetPackage("BlackFabric"));
                        standardInteriorOptionalPackages.Add(packageList.GetPackage("BlackLeather"));

                        optionalFactoryPackages.Add(packageList.GetPackage("TouringPackage"));

                        optionalAccessoryPackages.Add(packageList.GetPackage("EvoEngineAppearancePackage"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("InteriorPackageMr"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("LedIlluminationPackage"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("MudSnowPackage"));
                        optionalAccessoryPackages.Add(packageList.GetPackage("NavigationSystemPackage"));
                    }

                }
            }
            //
            //
            //
            if (ManufacturerCode.Equals("Nissan"))
            {
                if (ModelCode.Equals("Maxima") && (Year.Equals(2015) || Year.Equals(2016)  ))
                {
                    ColorList.Add(colorList.GetCode("CoulisRed"));
                    ColorList.Add(colorList.GetCode("BordeuxBlack"));
                    ColorList.Add(colorList.GetCode("BrilliantSilver"));
                    ColorList.Add(colorList.GetCode("GunMetallic"));
                    ColorList.Add(colorList.GetCode("ForgedBronze"));
                    ColorList.Add(colorList.GetCode("SuperBlack"));
                    ColorList.Add(colorList.GetCode("PearlWhite"));
                    ColorList.Add(colorList.GetCode("DeepBluePearl"));
                    ColorList.Add(colorList.GetCode("StormBlue"));

                    optionalAccessoryPackages.Add(packageList.GetPackage("CashmereCloth"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("CharcoalCloth"));

                    standardPackages.Add(packageList.GetPackage("Engine300hp3literDOHC24valveV6"));
                    standardPackages.Add(packageList.GetPackage("XTronicCVT"));
                    standardInteriorOptionalPackages.Add(packageList.GetPackage("CashmereCloth"));
                    standardInteriorOptionalPackages.Add(packageList.GetPackage("CharcoalCloth"));

                    optionalFactoryPackages.Add(packageList.GetPackage("PremiumSpoiler"));
                    optionalFactoryPackages.Add(packageList.GetPackage("SplashGuards"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("RockerPanelMoldings"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("ExternalGroundLighting"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("IllumnatedKickPlates"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("CarpetedFloorTrunkNet"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("InteriorAccentLighting"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("RearBumperDiffuser"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("CarpettedFloorMats"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("AllSeasonFloorMats"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("InteriorAppliques"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("ShiftKnob"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("ShoppingBagHooks"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("CarpetedTrunkMat"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("TrunkProtector"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("TrunkOrganizer"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("HideawayTrunkNet"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("EmergencyRoadKit"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("WheelLocks"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("FirstAidKit"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("SeatBeltExtender"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("AirBagAntitheftBolts"));


                    if (StyleTrim.Equals("S"))
                    {
                        BasePrice = 32410;
                        FeatureList = new string[] { "300-hp 3.5-liter V6 engine", "NissanConnectSM with Navigation", "Remote Engine Start System [*]", "Drive Mode Selector (Sport and Normal Modes)", "RearView Monitor [*]" };

                        standardPackages.Add(packageList.GetPackage("DriveModeSelector"));
                        standardPackages.Add(packageList.GetPackage("NissanConnectSM"));
                        standardPackages.Add(packageList.GetPackage("DriveAssistDisplay"));
                        standardPackages.Add(packageList.GetPackage("RearviewMonitor"));
                        standardPackages.Add(packageList.GetPackage("TaillightLEDsignature"));
                        standardPackages.Add(packageList.GetPackage("NissanAdvancedAirBag"));
                        standardPackages.Add(packageList.GetPackage("VDCTCS"));
                        standardPackages.Add(packageList.GetPackage("TPMS"));
                    }

                    if (StyleTrim.Equals("SV"))
                    {
                        BasePrice = 34390;
                        FeatureList = new string[] { "Leather-appointed seats", "Heated front seats", "Front and Rear Sonar System", "Driver's seat power lumbar support", "Driver’s seat thigh support" };

                        standardPackages.Add(packageList.GetPackage("DriveModeSelector"));
                        standardPackages.Add(packageList.GetPackage("LeatherAppointedSeats"));
                        standardPackages.Add(packageList.GetPackage("HeatedFrontSeats"));
                        standardPackages.Add(packageList.GetPackage("DriveSeatLumbarSupport"));
                        standardPackages.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        standardPackages.Add(packageList.GetPackage("Wheels18inch"));
                        standardPackages.Add(packageList.GetPackage("SignatureLEDlights"));
                        standardPackages.Add(packageList.GetPackage("SonarSystemFrontRear"));
                        standardPackages.Add(packageList.GetPackage("NissanAdvancedAirBag"));
                        standardPackages.Add(packageList.GetPackage("VDCTCS"));
                    }

                    if (StyleTrim.Equals("SL"))
                    {
                        BasePrice = 36890;
                        FeatureList = new string[] { "Dual Panel Panoramic Moonroof", "Bose® Premium Audio System [*]", "Predictive Forward Collision Warning (PFCW)", "Blind Spot Warning (BSW)", "Intelligent Cruise Control [*]" };

                        standardPackages.Add(packageList.GetPackage("DriveModeSelector"));
                        standardPackages.Add(packageList.GetPackage("BSW"));
                        standardPackages.Add(packageList.GetPackage("RCTA"));
                        standardPackages.Add(packageList.GetPackage("PFCW"));
                        standardPackages.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        standardPackages.Add(packageList.GetPackage("SignatureLEDlights"));
                        standardPackages.Add(packageList.GetPackage("Wheels18inch"));
                        standardPackages.Add(packageList.GetPackage("DualPanelMoonroof"));
                        standardPackages.Add(packageList.GetPackage("BosePremiumAudio"));
                        standardPackages.Add(packageList.GetPackage("IntelligentCruiseControl"));

                    }

                    if (StyleTrim.Equals("SR"))
                    {
                        BasePrice = 37670;
                        FeatureList = new string[] { "Sport-tuned suspension", "Integrated Dynamics-control Module", "19\" Aluminum-alloy wheels", "Premium Ascot Leather-appointed seats with Alcantara® inserts" };

                        standardPackages.Add(packageList.GetPackage("PaddleShifters"));
                        standardPackages.Add(packageList.GetPackage("DriveModeSelector"));
                        standardPackages.Add(packageList.GetPackage("AscotLeatherSeat"));
                        standardPackages.Add(packageList.GetPackage("AscotLeatherSteering"));
                        standardPackages.Add(packageList.GetPackage("MachineFinishedAllowWheels"));
                        standardPackages.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        standardPackages.Add(packageList.GetPackage("MachineFinishedAllowWheels"));
                        standardPackages.Add(packageList.GetPackage("DAA"));
                        standardPackages.Add(packageList.GetPackage("AroundViewMonitor"));
                        standardPackages.Add(packageList.GetPackage("BSW"));
                        standardPackages.Add(packageList.GetPackage("SignatureLEDlights"));
                        standardPackages.Add(packageList.GetPackage("RCTA"));
                        standardPackages.Add(packageList.GetPackage("PFCW"));
                        
                    }

                    if (StyleTrim.Equals("Platinum"))
                    {
                        BasePrice = 39860;
                        FeatureList = new string[] { "Premium Ascot leather-appointed seats", "Around View® Monitor [*]", "Driver Attention Alert (DAA)", "Climate Controlled Front Seats (Heated and Cooled)" };

                        standardPackages.Add(packageList.GetPackage("DriveModeSelector"));
                        standardPackages.Add(packageList.GetPackage("NissanConnectSM"));
                        standardPackages.Add(packageList.GetPackage("AscotLeatherSeat"));
                        standardPackages.Add(packageList.GetPackage("AscotLeatherSteering"));
                        standardPackages.Add(packageList.GetPackage("OutsideMirrosWithReverseTilt"));
                        standardPackages.Add(packageList.GetPackage("RainSensingWipers"));
                        standardPackages.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        standardPackages.Add(packageList.GetPackage("DAA"));
                        standardPackages.Add(packageList.GetPackage("AroundViewMonitor"));
                        standardPackages.Add(packageList.GetPackage("BSW"));

                    }



                }
            }

        }

    }
}
