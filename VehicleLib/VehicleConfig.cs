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

        protected void Init()
        {
            ml = new ManufacturerList();
            manufacturer = ml.GetCode(ManufacturerCode);

            modelList = new ModelList();
            model = modelList.GetCode(ModelCode);

            ConfigIt();
        }

        public ColorSet GetColorOptionsFactoryPackage()
        {
            return colorSet;
        }

        public PackageSet GetInteriorOptionsFactoryPackage()
        {
            return interiorSet;
        }
        
        public PackageSet GetAccessories()
        {
            return optionalAccessories;
        }
        
        public PackageSet GetOptionalFactoryPackage()
        {
            return optionalFactoryPackage;
        }

        public VehicleSummary GenerateSummary()
        {
            VehicleSummary summary = new VehicleSummary();

            summary.FactoryPackages = optionalFactoryPackage.GetTotal();
            summary.Accessories = optionalAccessories.GetTotal();
            summary.DestinationAndHandlingFees = DestinationAndHandling;
            summary.BasePrice = BasePrice;
            summary.MSRP = summary.FactoryPackages + summary.Accessories + summary.DestinationAndHandlingFees + summary.BasePrice;
            return summary;
        }

        protected void ConfigIt()
        {
            ColorList colorList = new ColorList();
            PackageList packageList = new PackageList();

            if (ManufacturerCode.Equals("Mitsubishi"))
            {
                if (ModelCode.Equals("Evolution") && (Year.Equals(2013) || Year.Equals(2014) || Year.Equals(2015)))
                {
                    colorSet.Add(colorList.GetCode("WickedWhite"));
                    colorSet.Add(colorList.GetCode("RallyRed"));
                    colorSet.Add(colorList.GetCode("PhantomBlack"));
                    colorSet.Add(colorList.GetCode("OctaneBlue"));
                    colorSet.Add(colorList.GetCode("MercuryGray"));
                    colorSet.Add(colorList.GetCode("ApexSilver"));

                    optionalAccessoryPackages.Add(packageList.GetPackage("RearParkAssistSensors"));
                    optionalAccessoryPackages.Add(packageList.GetPackage("SideWindDeflectors"));

                    warranty.Add(packageList.GetPackage("Warranty"));

                    interiorSet.Add(packageList.GetPackage("BlackFabric"));
                    interiorSet.Add(packageList.GetPackage("BlackLeather"));

                    DestinationAndHandling = 810;

                    if (StyleTrim.Equals("GSR"))
                    {
                        BasePrice = 34495;
                        FeatureList = new string[] { "291-horsepower turbocharged 2.0-liter DOHC MIVEC engine", "Super-All Wheel Control", "18x8.5\" Enkei® alloy wheel with 245/40 R18 93W Yokohama® ADVAN® high-performance tires", "BREMBO® high performance braking system", "Active Yaw Control (AYC)" };

                        factoryFeatureSet.Add(packageList.GetPackage("FiveSpeedManualTransmission"));

                        optionalFactoryPackage.Add(packageList.GetPackage("SightAndSound"));
                        optionalFactoryPackage.Add(packageList.GetPackage("PremiumPackage"));

                        optionalAccessories.Add(packageList.GetPackage("EvoEngineAppearancePackage"));
                        optionalAccessories.Add(packageList.GetPackage("InteriorPackageGsr"));
                        optionalAccessories.Add(packageList.GetPackage("LedIlluminationPackage"));
                        optionalAccessories.Add(packageList.GetPackage("MudSnowPackage"));
                        optionalAccessories.Add(packageList.GetPackage("NavigationSystemPackage"));
                    }

                    if (StyleTrim.Equals("MR"))
                    {
                        BasePrice = 38995;
                        FeatureList = new string[] { "291-horsepower turbocharged 2.0-liter DOHC MIVEC engine", "Twin Clutch Sportronic® Shift Transmission", "Super-All Wheel Control", "Front and rear suspension with Eibach® springs and Bilstein® shock absorbers, with stabilizer bar", "BREMBO® high performance braking system" };

                        factoryFeatureSet.Add(packageList.GetPackage("TwinClutchSportShiftTransmission"));

                        optionalFactoryPackage.Add(packageList.GetPackage("TouringPackage"));

                        optionalAccessories.Add(packageList.GetPackage("EvoEngineAppearancePackage"));
                        optionalAccessories.Add(packageList.GetPackage("InteriorPackageMr"));
                        optionalAccessories.Add(packageList.GetPackage("LedIlluminationPackage"));
                        optionalAccessories.Add(packageList.GetPackage("MudSnowPackage"));
                        optionalAccessories.Add(packageList.GetPackage("NavigationSystemPackage"));
                    }

                }
            }
            //
            //
            //
            if (ManufacturerCode.Equals("Subaru"))
            {
                if (ModelCode.Equals("BRZ") && (Year.Equals(2013) || Year.Equals(2014) || Year.Equals(2015)))
                {
                    colorSet.Add(colorList.GetCode("WrBluePearl"));
                    colorSet.Add(colorList.GetCode("CrystalWhitePearl"));
                    colorSet.Add(colorList.GetCode("DarkGrayMetallic"));
                    colorSet.Add(colorList.GetCode("LightningRed"));
                    colorSet.Add(colorList.GetCode("CrystalBlackSilica"));

                    factoryFeatureSet.Add(packageList.GetPackage("BlackCloth"));

                    DestinationAndHandling = 795;

                    optionalAccessories.Add(packageList.GetPackage("SubWoofer10inch"));
                    optionalAccessories.Add(packageList.GetPackage("StiAlloyWheels"));
                    optionalAccessories.Add(packageList.GetPackage("BrzBatteryWarmer"));
                    optionalAccessories.Add(packageList.GetPackage("BrzCarCover"));
                    optionalAccessories.Add(packageList.GetPackage("BrzChromeFenderTrim"));
                    optionalAccessories.Add(packageList.GetPackage("BrzChromeFuelDoorCover"));
                    optionalAccessories.Add(packageList.GetPackage("BrzEngineBlockHeater"));
                    optionalAccessories.Add(packageList.GetPackage("BrzFogLightKit"));
                    optionalAccessories.Add(packageList.GetPackage("BrzRearBumperApplique"));
                    optionalAccessories.Add(packageList.GetPackage("BrzRearBumperDiffuser"));
                    optionalAccessories.Add(packageList.GetPackage("BrzDeckLidSpoiler"));
                    optionalAccessories.Add(packageList.GetPackage("BrzWheelLocks"));
                    optionalAccessories.Add(packageList.GetPackage("BrzAshTray"));
                    optionalAccessories.Add(packageList.GetPackage("BrzAshTrayMountingSleeve"));
                    optionalAccessories.Add(packageList.GetPackage("BrzAutoDimmingMirrorwithCompass"));
                    optionalAccessories.Add(packageList.GetPackage("BrzAutoDimMirrorAndHL"));
                    optionalAccessories.Add(packageList.GetPackage("BrzCargoTray"));
                    optionalAccessories.Add(packageList.GetPackage("BrzInteriorIlluminationKit"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSunshade"));
                    optionalAccessories.Add(packageList.GetPackage("BrzBRZKeyFob"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSlimLicensePlateFrameMatteBlack"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSlimLicensePlateFrameMatteBlackBRZ"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSlimLicensePlateFramePolishedStainlessSteel"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSlimLicensePlateFramePolishedStainlessSteel2"));
                    optionalAccessories.Add(packageList.GetPackage("BrzLicensePlateFramePolishedStainlessSteelSubaru"));
                    optionalAccessories.Add(packageList.GetPackage("BrzParkingOnlySign"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSPTBatteryHoldDownBlue"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSPTBatteryHoldDownSteel"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSPTOilCapBlue"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSPTOilCapSteel"));
                    optionalAccessories.Add(packageList.GetPackage("BrzValveStemCapsSubaru"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSTIUnderSpoilerRearQuarter"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSTIUnderSpoilerSide"));
                    optionalAccessories.Add(packageList.GetPackage("BrzStiUnderSpoiler"));
                    optionalAccessories.Add(packageList.GetPackage("BrzSPTOilCapBlue"));


                    if (StyleTrim.Equals("BrzPremium"))
                    {
                        BasePrice = 25695;
                        FeatureList = new string[] { "Direct-injected SUBARU BOXER® engine", "Bluetooth® hands-free connectivity", "Torsen® limited-slip differential" };

                        factoryFeatureSet.Add(packageList.GetPackage("ManualShift6Speed"));

                    }

                    if (StyleTrim.Equals("BrzLimited"))
                    {
                        BasePrice = 27695;
                        FeatureList = new string[] { "Alcantara® and leather-trimmed upholstery", "Rear spoiler", "Keyless Entry and Start" };

                        optionalFactoryPackage.Add(packageList.GetPackage("ManualShift6Speed"));
                        optionalFactoryPackage.Add(packageList.GetPackage("AutomaticShift6Speed"));

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
                    colorSet.Add(colorList.GetCode("CoulisRed"));
                    colorSet.Add(colorList.GetCode("BordeuxBlack"));
                    colorSet.Add(colorList.GetCode("BrilliantSilver"));
                    colorSet.Add(colorList.GetCode("GunMetallic"));
                    colorSet.Add(colorList.GetCode("ForgedBronze"));
                    colorSet.Add(colorList.GetCode("SuperBlack"));
                    colorSet.Add(colorList.GetCode("PearlWhite"));
                    colorSet.Add(colorList.GetCode("DeepBluePearl"));
                    colorSet.Add(colorList.GetCode("StormBlue"));

                    factoryFeatureSet.Add(packageList.GetPackage("Engine300hp3literDOHC24valveV6"));
                    factoryFeatureSet.Add(packageList.GetPackage("XTronicCVT"));

                    interiorSet.Add(packageList.GetPackage("CashmereCloth"));
                    interiorSet.Add(packageList.GetPackage("CharcoalCloth"));

                    optionalAccessories.Add(packageList.GetPackage("PremiumSpoiler"));
                    optionalAccessories.Add(packageList.GetPackage("SplashGuards"));
                    optionalAccessories.Add(packageList.GetPackage("RockerPanelMoldings"));
                    optionalAccessories.Add(packageList.GetPackage("ExternalGroundLighting"));
                    optionalAccessories.Add(packageList.GetPackage("IllumnatedKickPlates"));
                    optionalAccessories.Add(packageList.GetPackage("CarpetedFloorTrunkNet"));
                    optionalAccessories.Add(packageList.GetPackage("InteriorAccentLighting"));
                    optionalAccessories.Add(packageList.GetPackage("RearBumperDiffuser"));
                    optionalAccessories.Add(packageList.GetPackage("CarpettedFloorMats"));
                    optionalAccessories.Add(packageList.GetPackage("AllSeasonFloorMats"));
                    optionalAccessories.Add(packageList.GetPackage("InteriorAppliques"));
                    optionalAccessories.Add(packageList.GetPackage("ShiftKnob"));
                    optionalAccessories.Add(packageList.GetPackage("ShoppingBagHooks"));
                    optionalAccessories.Add(packageList.GetPackage("CarpetedTrunkMat"));
                    optionalAccessories.Add(packageList.GetPackage("TrunkProtector"));
                    optionalAccessories.Add(packageList.GetPackage("TrunkOrganizer"));
                    optionalAccessories.Add(packageList.GetPackage("HideawayTrunkNet"));
                    optionalAccessories.Add(packageList.GetPackage("EmergencyRoadKit"));
                    optionalAccessories.Add(packageList.GetPackage("WheelLocks"));
                    optionalAccessories.Add(packageList.GetPackage("FirstAidKit"));
                    optionalAccessories.Add(packageList.GetPackage("SeatBeltExtender"));
                    optionalAccessories.Add(packageList.GetPackage("AirBagAntitheftBolts"));


                    if (StyleTrim.Equals("S"))
                    {
                        BasePrice = 32410;
                        FeatureList = new string[] { "300-hp 3.5-liter V6 engine", "NissanConnectSM with Navigation", "Remote Engine Start System [*]", "Drive Mode Selector (Sport and Normal Modes)", "RearView Monitor [*]" };

                        factoryFeatureSet.Add(packageList.GetPackage("DriveModeSelector"));
                        factoryFeatureSet.Add(packageList.GetPackage("NissanConnectSM"));
                        factoryFeatureSet.Add(packageList.GetPackage("DriveAssistDisplay"));
                        factoryFeatureSet.Add(packageList.GetPackage("RearviewMonitor"));
                        factoryFeatureSet.Add(packageList.GetPackage("TaillightLEDsignature"));
                        factoryFeatureSet.Add(packageList.GetPackage("NissanAdvancedAirBag"));
                        factoryFeatureSet.Add(packageList.GetPackage("VDCTCS"));
                        factoryFeatureSet.Add(packageList.GetPackage("TPMS"));
                    }

                    if (StyleTrim.Equals("SV"))
                    {
                        BasePrice = 34390;
                        FeatureList = new string[] { "Leather-appointed seats", "Heated front seats", "Front and Rear Sonar System", "Driver's seat power lumbar support", "Driver’s seat thigh support" };

                        factoryFeatureSet.Add(packageList.GetPackage("DriveModeSelector"));
                        factoryFeatureSet.Add(packageList.GetPackage("LeatherAppointedSeats"));
                        factoryFeatureSet.Add(packageList.GetPackage("HeatedFrontSeats"));
                        factoryFeatureSet.Add(packageList.GetPackage("DriveSeatLumbarSupport"));
                        factoryFeatureSet.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        factoryFeatureSet.Add(packageList.GetPackage("Wheels18inch"));
                        factoryFeatureSet.Add(packageList.GetPackage("SignatureLEDlights"));
                        factoryFeatureSet.Add(packageList.GetPackage("SonarSystemFrontRear"));
                        factoryFeatureSet.Add(packageList.GetPackage("NissanAdvancedAirBag"));
                        factoryFeatureSet.Add(packageList.GetPackage("VDCTCS"));
                    }

                    if (StyleTrim.Equals("SL"))
                    {
                        BasePrice = 36890;
                        FeatureList = new string[] { "Dual Panel Panoramic Moonroof", "Bose® Premium Audio System [*]", "Predictive Forward Collision Warning (PFCW)", "Blind Spot Warning (BSW)", "Intelligent Cruise Control [*]" };

                        factoryFeatureSet.Add(packageList.GetPackage("DriveModeSelector"));
                        factoryFeatureSet.Add(packageList.GetPackage("BSW"));
                        factoryFeatureSet.Add(packageList.GetPackage("RCTA"));
                        factoryFeatureSet.Add(packageList.GetPackage("PFCW"));
                        factoryFeatureSet.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        factoryFeatureSet.Add(packageList.GetPackage("SignatureLEDlights"));
                        factoryFeatureSet.Add(packageList.GetPackage("Wheels18inch"));
                        factoryFeatureSet.Add(packageList.GetPackage("DualPanelMoonroof"));
                        factoryFeatureSet.Add(packageList.GetPackage("BosePremiumAudio"));
                        factoryFeatureSet.Add(packageList.GetPackage("IntelligentCruiseControl"));

                    }

                    if (StyleTrim.Equals("SR"))
                    {
                        BasePrice = 37670;
                        FeatureList = new string[] { "Sport-tuned suspension", "Integrated Dynamics-control Module", "19\" Aluminum-alloy wheels", "Premium Ascot Leather-appointed seats with Alcantara® inserts" };

                        factoryFeatureSet.Add(packageList.GetPackage("PaddleShifters"));
                        factoryFeatureSet.Add(packageList.GetPackage("DriveModeSelector"));
                        factoryFeatureSet.Add(packageList.GetPackage("AscotLeatherSeat"));
                        factoryFeatureSet.Add(packageList.GetPackage("AscotLeatherSteering"));
                        factoryFeatureSet.Add(packageList.GetPackage("MachineFinishedAllowWheels"));
                        factoryFeatureSet.Add(packageList.GetPackage("PowerHeatedOutsideMirrorsWithLED"));
                        factoryFeatureSet.Add(packageList.GetPackage("MachineFinishedAllowWheels"));
                        factoryFeatureSet.Add(packageList.GetPackage("DAA"));
                        factoryFeatureSet.Add(packageList.GetPackage("AroundViewMonitor"));
                        factoryFeatureSet.Add(packageList.GetPackage("BSW"));
                        factoryFeatureSet.Add(packageList.GetPackage("SignatureLEDlights"));
                        factoryFeatureSet.Add(packageList.GetPackage("RCTA"));
                        factoryFeatureSet.Add(packageList.GetPackage("PFCW"));
                        
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
