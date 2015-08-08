using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public class Package
    {
        public Guid Guid;
        public string Code;
        public string Name;
        public string Description;
        public string[] FeatureList;
        public Boolean Enabled;
        public Boolean Visible;
        public Boolean Selected;
        public float Price;
    }

    public class PackageList
    {
        List<Package> list;

        public PackageList()
        {
            list = new List<Package>();
            //
            // Generic
            //
            list.Add(new Package { Guid = new Guid("60A83108-7151-4666-8075-F7741E41C9B3"), Code = "AC", Name = "Air Condition" });
            list.Add(new Package { Guid = new Guid("7ABFC350-6C09-4654-8C3E-1F6B666E90D3"), Code = "Tint", Name = "Tinted Windows" });
            list.Add(new Package { Guid = new Guid("24328EE4-8433-4A3A-93FE-4BA96B9D6DBD"), Code = "LeatherSeats", Name = "Leather Seats" });
            list.Add(new Package { Guid = new Guid("71FD5FF6-4E1C-4D61-8B5E-FEC407173B24"), Code = "FloorMats", Name = "Floor Mats" });
            list.Add(new Package { Guid = new Guid("0445A0D7-0967-41D5-89F6-EFB44CF3A3AB"), Code = "Spoiler", Name = "Rear Air Spoiler" });
            list.Add(new Package { Guid = new Guid("2CD107A5-4FE0-4081-B32A-1AE1E0894167"), Code = "Turbo", Name = "Turbo" });
            //
            // Mitsubishi
            //
            list.Add(new Package { Guid = new Guid("AFE10715-DD32-4CCB-AB20-D19B5D175E5C"), Code = "FiveSpeedManualTransmission", Name = "5 Spead Manual Transmission" });
            list.Add(new Package { Guid = new Guid("2CD107A5-4FE0-4081-B32A-1AE1E0894167"), Code = "TwinClutchSportShiftTransmission", Name = "Automatic Transmission" });
            list.Add(new Package { Guid = new Guid("BAB86544-E6D6-4038-8E81-BCCB7711D555"), Code = "EnkieWheels", Name = "Enkei Wheels" });
            list.Add(new Package { Guid = new Guid("C2312164-ED2C-4214-9D2A-40E200787F67"), Code = "Titanium", Name = "Titanium Package" });
            list.Add(new Package { Guid = new Guid("B77D4806-CE85-4284-8D69-4FFD0ED916F4"), Code = "PremiumPackage", Name = "Premium Package", FeatureList = new string[] { "LEATHER SEATING SURFACES", "POWER GLASS SUNROOF", "HEATED FRONT SEATS", "CENTER CONSOLE UPGRADE", "SOUND DAMPENING ENHANCEMENT", "SCUFF PLATES", "HID HEADLIGHTS", "710-WATT ROCKFORD FOSGATE® PREMIUM SOUND SYSTEM W/ 9 SPEAKERS INC 10IN SUBWOOFER W/ PUNCH CONTROL®, DTS® NEURAL SURROUND,PREMIDIA- WIDE SURROUND, AND DOLBY® VOLUME", "FAST KEY ENTRY SYSTEM" } });
            list.Add(new Package { Guid = new Guid("2DC2E09E-43E6-4E8A-8B32-66278B2736EF"), Code = "SightAndSound", Name = "Sight And Sound Package", Price=2000, FeatureList = new string[] { "HID HEADLIGHTS", "710-WATT ROCKFORD FOSGATE® PREMIUM SOUND SYSTEM W/ 9 SPEAKERS INC 10IN SUBWOOFER W/ PUNCH CONTROL®, DTS® NEURAL SURROUND,PREMIDIA- WIDE SURROUND, AND DOLBY® VOLUME", "FAST KEY ENTRY SYSTEM" } });
            list.Add(new Package { Guid = new Guid("C69DBE37-B2F8-48B9-A4C0-58014E4CFB27"), Code = "TouringPackage", Name = "Touring Package", Price = 2000, FeatureList = new string[] { "LEATHER SEATING SURFACES", "POWER GLASS SUNROOF", "HEATED FRONT SEATS", "SOUND DAMPENING ENHANCEMENT", "SCUFF PLATES" } });
            list.Add(new Package { Guid = new Guid("C13A5021-7768-4B29-8972-36AAA9D6A260"), Code = "EvoGsrPremiumPackage", Name = "Premium Package", Price = 3800, FeatureList = new string[] { "LEATHER SEATING SURFACES", "POWER GLASS SUNROOF", "HEATED FRONT SEATS", "CENTER CONSOLE UPGRADE", "SOUND DAMPENING ENHANCEMENT", "SCUFF PLATES", "HID HEADLIGHTS", "710-WATT ROCKFORD FOSGATE® PREMIUM SOUND SYSTEM W/ 9 SPEAKERS INC 10IN SUBWOOFER W/ PUNCH CONTROL®, DTS® NEURAL SURROUND,PREMIDIA- WIDE SURROUND, AND DOLBY® VOLUME", "FAST KEY ENTRY SYSTEM" } });
            list.Add(new Package { Guid = new Guid("E64E0324-53CE-4EA8-94F6-BCEBD0CAB368"), Code = "EvoEngineAppearancePackage", Name = "Engine Appearance Package", Price=695, FeatureList = new string[] { "INTERCOOLER PIPE", "FRONT STRUT BRACE" } });
            list.Add(new Package { Guid = new Guid("2CD107A5-4FE0-4081-B32A-1AE1E0894167"), Code = "BlackFabric", Name = "Black Fabric" });
            list.Add(new Package { Guid = new Guid("EF420D07-84DA-47F8-9F16-83200F267664"), Code = "BlackLeather", Name = "Black Leather" });
            list.Add(new Package { Guid = new Guid("42990686-E987-44D3-9787-6ED535CB96C7"), Code = "ExteriorPackageGsr", Name = "Exterior Package", Price=1500, FeatureList = new string[] { "FRONT, SIDE, AND REAR AIRDAMS", "BRAKE AIR GUIDES", "REAR SPOILER EXTENSION" } });
            list.Add(new Package { Guid = new Guid("943052CA-3C4A-44D7-9417-18F1B34B6CB4"), Code = "InteriorPackageGsr", Name = "Interior Package (GSR)", Price=425, FeatureList = new string[] { "ALUMINUM 5MT SHIFT KNOB", "ALUMINUM / LEATHER BRAKE GRIP" } });
            list.Add(new Package { Guid = new Guid("4B03D855-DC1D-46DC-AD0F-FD7725201877"), Code = "InteriorPackageMr", Name = "Interior Package (MR)", Price = 530, FeatureList = new string[] { "ALUMINUM / LEATHER SST SHIFT KNOB", "ALUMINUM / LEATHER BRAKE GRIP" } });
            list.Add(new Package { Guid = new Guid("C2DA20AA-49A5-42E6-923B-C68FDEA732B2"), Code = "LedIlluminationPackage", Name = "LED Illumination Package", Price=335, FeatureList = new string[] { "FLOOR ILLUMINATION (BLUE LED)", "INTERIOR LIGHTS" } });
            list.Add(new Package { Guid = new Guid("BABEF812-EE76-4B3D-9171-4D6D208CD529"), Code = "MudSnowPackage", Name = "Mud & Snow Package", Price=315, FeatureList = new string[] { "FRONT AND REAR MUD FLAPS", "ALL WEATHER FLOORMATS (FRONT ONLY)" } });
            list.Add(new Package { Guid = new Guid("8C05E9F0-E2B5-48A8-B785-8526F48A3C1D"), Code = "NavigationSystemPackage", Name = "Navigation System Package", Price=2375, FeatureList = new string[] { "NAVIGATION SYSTEM WITH HIGH DEFINITION 7\" TOUCH SCREEN, REAL TIME TRAFFIC, 3D MAPPING, AND MAPCARE® INCLUDES 2 ANNUAL MAP UPDATES (REPLACES AUDIO HEAD UNIT)" } });
            list.Add(new Package { Guid = new Guid("BE3B97EE-678E-41D3-B388-EF90F2D0B37F"), Code = "RearParkAssistSensors", Name = "Rear Park Assist Package", Price = 295 });
            list.Add(new Package { Guid = new Guid("86E38622-9213-4CFF-BB96-5FC2AA4749C8"), Code = "SideWindDeflectors", Name = "Side Wind Deflectors", Price=95 });
            //
            //Nissan
            //
            list.Add(new Package { Guid = new Guid("C82CD617-7133-4A7C-914A-2ADDFC981477"), Code = "CashmereCloth", Name = "Cashmere Cloth" });
            list.Add(new Package { Guid = new Guid("132A4B1D-01B7-4CFD-8A85-40654DE59B3F"), Code = "CharcoalCloth", Name = "Charcoal Cloth" });

            list.Add(new Package { Guid = new Guid("8066BF13-E2E3-46E4-919F-0962AA2A273C"), Code = "PremiumSpoiler", Name = "Premium Spoiler", Price = 405, FeatureList = new string[] { "Heighten the style of your Maxima® with a streamlined spoiler.", "Factory Installed", "Comes pre-painted in factory-matched colors" } });
            list.Add(new Package { Guid = new Guid("7056B9E9-E764-4783-92C6-1FCD7801E561"), Code = "SplashGuards", Name = "Splash Guards (4-piece set)", Price = 190, FeatureList = new string[] { "Save your Maxima® from an unwelcome mud bath.", "Contoured to match wheel openings, Splash Guards help prevent dirt and debris from nicking and scratching the finish", "Add value and style while helping protect the sides of your vehicle", "Factory-installed" } });
            list.Add(new Package { Guid = new Guid("67B87E31-6233-48C9-9098-64E00B536A87"), Code = "RockerPanelMoldings", Name = "Rocker Panel Moldings", Price = 420, FeatureList = new string[] { "Available in body color with a touch of chrome, rocker panel moldings are a subtle styling accent." } });
            list.Add(new Package { Guid = new Guid("BA033AC2-D237-4494-96FB-9968A6772226"), Code = "ExternalGroundLighting", Name = "External Ground Lighting", Price = 240, FeatureList = new string[] { "Just click for a sense of security with lights that brighten up the area beneath and around your vehicle.", "Fades in and out with the dome light", "Goes on when you press the key fob, press the entry button or open doors", "LED lights between front and rear tires" } });
            list.Add(new Package { Guid = new Guid("28FE5352-89AD-496F-810D-68510FA9AFD7"), Code = "IllumnatedKickPlates", Name = "ILLUMINATED KICK PLATES", Price = 350, FeatureList = new string[] { "Light up your entrance and protect your front sills.", "Contoured to match door openings", "Brushed-aluminum inserts feature an illuminated Maxima® logo" } });
            list.Add(new Package { Guid = new Guid("FE0F54FB-EC07-4D8A-A32F-D9E5EAC6A56E"), Code = "CarpetedFloorTrunkNet", Name = "CARPETED FLOOR MATS, TRUNK MAT, AND TRUNK NET", Price = 220, FeatureList = new string[] { "Keep your carpets and cargo area protected and clean with Carpeted Floor Mats and a Cargo Area Protector." } });
            list.Add(new Package { Guid = new Guid("9F8D35FC-8F10-4869-927C-3A9684700283"), Code = "InteriorAccentLighting", Name = "Interior Accent Lighting", Price = 250, FeatureList = new string[] { "LED lights with 20 pre-programmed color options light up the front footwells and cup holders", "Works with the vehicle's interior lighting when the door is opened", "Easily control light color and on/off function with a single button" } });
            list.Add(new Package { Guid = new Guid("D12DA7EA-941B-44DF-AA07-BBF2DC09142D"), Code = "RearBumperDiffuser", Name = "Rear Bumper Diffuser", Price = 295, FeatureList = new string[] { "This diffuser with chrome finisher is bolted to the bottom of your rear bumper, and gives your Maxima a sportier attitude.", "Dealer-installed" } });
            list.Add(new Package { Guid = new Guid("91A94101-EF89-4A4A-A70D-6A6A13C12017"), Code = "CarpettedFloorMats", Name = "CARPETED FLOOR MATS", Price = 110, FeatureList = new string[] { "All Nissan Carpeted Floor Mats are made of high-quality material and are custom-fit", "Floor mat backing is designed to help position the mat in place", "Driver's mat secures with a grommet hole/positioning hook system", "Dealer-installed" } });
            list.Add(new Package { Guid = new Guid("DC5B6022-63C4-4177-9182-683776373129"), Code = "AllSeasonFloorMats", Name = "All Season Floor Mats", Price = 80, FeatureList = new string[] { "Stepping in from the rain, sand, or snow? You need a set of All-season Floor Mats.", "Driver's mat secures with a grommet hole/positioning hook system", "Dealer-installed", "Custom-made of durable and long-wearing material", "Floor mat backing is designed to help position the mat in place" } });

            list.Add(new Package { Guid = new Guid("E7BC8B91-54C0-4DD8-A539-2809124ED1DC"), Code = "InteriorAppliques", Name = "Interior Appliqués", Price = 235, FeatureList = new string[] { "Two trim pieces around front air conditioning vents", "Two trim pieces for rear doors’ window switch surround", "Dealer-installed", "Two trim pieces for front doors’ window switch surround", "Available in two colors: Black and Carbon-Fiber appearance" } });
            list.Add(new Package { Guid = new Guid("40B430FA-EAAA-45AB-99A1-CC4276DD0998"), Code = "ShiftKnob", Name = "Shift Knob", Price = 150, FeatureList = new string[] { "Maxima’s shift knob is available in four different finishes: sleek carbon-fiber appearance, rich wood, and a satin chrome with blue stitching (SR only) or off-white stitching.", "Dealer-installed" } });
            list.Add(new Package { Guid = new Guid("27998541-BFE8-4D25-A838-257676B5647A"), Code = "ShoppingBagHooks", Name = "Shopping Bag Hooks", Price = 45, FeatureList = new string[] { "Help keep your shopping bags in place and from falling over.", "Dealer-installed", "Capacity of up to 15 lbs" } });

            list.Add(new Package { Guid = new Guid("929B4F7F-3E7B-4398-8CA4-E4F835B85D81"), Code = "CarpetedTrunkMat", Name = "Carpeted Trunk Mat", Price = 75, FeatureList = new string[] { "Being a trunk isn't easy. Help protect it against wear and tear.", "Features Maxima® logo", "Dealer-installed", "Durable, high-density nylon carpet", "Non-slip, moisture-resistant backing" } });
            list.Add(new Package { Guid = new Guid("FC771E09-2113-4AD9-8969-8A83752D1ED1"), Code = "TrunkProtector", Name = "Trunk Protector", Price = 110, FeatureList = new string[] { "Keeps trunk area clean and dry, and helps protect it from damage.", "Water-resistant heavy-duty trunk area protection", "Dealer-installed", "Made of durable material", "Easy to remove and clean" } });
            list.Add(new Package { Guid = new Guid("85D7EEAF-DA2A-482D-B032-0EC13F4D956E"), Code = "TrunkOrganizer", Name = "Trunk Organizer", Price = 125, FeatureList = new string[] { "You can fit more than you think with dividers that let you customize the space.", "Collapsible for easy storage when not in use" } });
            list.Add(new Package { Guid = new Guid("EE0FD8D0-6070-49F6-A87D-99113EF98E75"), Code = "HideawayTrunkNet", Name = "Hideaway Trunk Net", Price = 35, FeatureList = new string[] { "Fight the forces of chaos with a Trunk Net that helps keep items in place.", "This Hideaway Trunk Net stows away neatly in its own zippered case that secures to the trunk when not in use" } });
            list.Add(new Package { Guid = new Guid("42CF5E89-12FF-441C-80BD-4F5C12433233"), Code = "EmergencyRoadKit", Name = "Emergency Road Kit", Price = 66, FeatureList = new string[] { "Everything you need for life's little uncertainties.", "Basic roadside emergency supplies in a zippered nylon bag", "Contents include: heavy-duty jumper cables, emergency reflective triangle, flashlight with batteries and hands-free stand, duct tape, two screwdrivers, battery terminal cleaner and compact thermal blanket" } });
            list.Add(new Package { Guid = new Guid("2A846E20-DFF3-45F6-8AF8-568CDAF1EDD9"), Code = "WheelLocks", Name = "Wheel Locks", Price = 65, FeatureList = new string[] { "Four Wheel Locks and coded Wheel Lock socket to help keep your wheels out of the wrong hands.", "Superior durability, corrosion-resistant" } });
            list.Add(new Package { Guid = new Guid("2E8B5323-5D7E-45C6-A118-3FA0D58E7801"), Code = "ChromeLicensePlateFrame", Name = "Nissan Chrome License Plate Frame", Price = 40, FeatureList = new string[] { "Show your Nissan pride.", "License Plate Frame features stainless steel construction and chrome finish", "Valve Stem Caps screw on and off with ease", "Valve Stem Caps do not interfere with TPMS and are designed to be hand-tightened" } });
            list.Add(new Package { Guid = new Guid("D63C51C1-9DC9-429A-BF90-A20A5F88708F"), Code = "FirstAidKit", Name = "First Aid Kit", Price = 26, FeatureList = new string[] { "Play it safe with a First Aid Kit with VELCRO® backing so it can secure to any carpeted surface. [*]", "Basic first-aid supplies in a convenient, durable, zippered vinyl pouch", "Contents include: latex-free gloves, adhesive bandages, adhesive tape, sterile gauze, elastic bandage, cleansing towelettes, large-grip super scissors, first-aid cream, tweezers/magnifier and a first-aid instruction booklet" } });
            list.Add(new Package { Guid = new Guid("6D595969-F7E5-4B0A-93CC-4D55F319E768"), Code = "SeatBeltExtender", Name = "Seat Belt Extender", Price = 46, FeatureList = new string[] { "Need a little extra breathing room? The Seat Belt Extender adds up to 8 inches of length.", "May be used for either the driver or front-passenger seating position" } });
            list.Add(new Package { Guid = new Guid("263019F2-C722-46F3-8823-8EDD1B2FF4FB"), Code = "AirBagAntitheftBolts", Name = "Air Bag Anti-theft Bolts", Price = 11, FeatureList = new string[] { "Your safety equipment helps keep you safe, so why shouldn't you return the favor?", "Unique keyed socket design provides added security", "Driver and front-passenger bolts sold separately, requires dealer installation" } });
            list.Add(new Package { Guid = new Guid("AE3021D5-BD82-4F8D-A46B-35F56DFE669A"), Code = "XTronicCVT", Name = "Xtronic CVT® (Continuously Variable Transmission)", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "Engine300hp3literDOHC24valveV6", Name = "300-hp 3.5-liter DOHC 24-valve V6 engine", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "DriveModeSelector", Name = "Drive Mode Selector (Sport and Manual Modes)", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "NissanConnectSM", Name = "NissanConnectSM Services Powered by SiriusXM®", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "AscotLeatherSeat", Name = "Premium Ascot Leather-appointed Seats with Diamond-Quilted Inserts", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "AscotLeatherSteering", Name = "Premium Ascot Leather-Wrapped Steering Wheel", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "OutsideMirrosWithReverseTilt", Name = "Outside mirrors with Reverse Tilt-Down feature", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "RainSensingWipers", Name = "Rain Sensing Wipers", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "PowerHeatedOutsideMirrorsWithLED", Name = "Power Heated Outside Mirrors with LED Turn Signal Indicators", Price = 0, FeatureList = new string[] { "Maxima's power heated dual outside mirrors are equipped with integrated LED turn signals that provide extra visibility to surrounding vehicles and pedestrians." } });
            list.Add(new Package { Guid = new Guid(""), Code = "DAA", Name = "Driver Attention Alert (DAA)", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "AroundViewMonitor", Name = "Around View® Monitor with Moving Object Detection", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "BSW", Name = "Blind Spot Warning (BSW)", Price = 0, FeatureList = new string[] { "If Maxima's BSW system detects a vehicle in the blind spot area indicators on both the Advanced Drive-Assist® Display and driver's or front passenger's front door will illuminate to let you know it's there. If you signal while the vehicle is still in the blind spot area, an audible alert and warning light will help alert you." } });

            list.Add(new Package { Guid = new Guid(""), Code = "PaddleShifters", Name = "Paddle Shifters", Price = 0, FeatureList = new string[] { "Paddle shifters allow you manual control at your fingertips." } });
            list.Add(new Package { Guid = new Guid(""), Code = "MachineFinishedAllowWheels", Name = "19\" \"Diamond-cut\" Machine-finished Aluminum-alloy Wheels", Price = 0, FeatureList = new string[] { "Maxima SR features a set of 19 inch \"diamond-cut\" aluminum-alloy wheels with a machine finish and are fitted with P245/45VR19 tires for optimal handling and traction."} });
            list.Add(new Package { Guid = new Guid(""), Code = "SignatureLEDlights", Name = "Signature LED Head Lights", Price = 0, FeatureList = new string[] { "Up front, the boomerang-shaped headlights feature a captivating LED signature line that stays illuminated at all times. In back, LEDs also accent the wraparound taillights, and “4DSC” is embossed in the lamp housings, front and rear—a subtle reminder of what the all-new Maxima is all about." } });
            list.Add(new Package { Guid = new Guid(""), Code = "RCTA", Name = "Rear Cross Traffic Alert (RCTA)", Price = 0, FeatureList = new string[] { "When you are in reverse, RCTA helps detect vehicles approaching from either side. If an approaching vehicle is detected, the system provides visual and audio warnings" } });
            list.Add(new Package { Guid = new Guid(""), Code = "PFCW", Name = "Predictive Forward Collision Warning (PFCW) with Forward Emergency Braking (FEB)", Price = 0, FeatureList = new string[] { "Predictive Forward Collision Warning can alert you to potential risks up ahead by not only monitoring the velocity and distance of the vehicle in front of you, but the vehicle in front of that one as well. Although obscured from your forward field-of-view, sensors can detect if that vehicle suddenly and unexpectedly slows, giving you time to react to the situation. If Maxima detects that you need to slow down to avoid a frontal collision, the FEB system will alert you with visual and audible cues and, if necessary, assist you by automatically applying pressure to the brakes to help avoid or mitigate a collision." } });

            list.Add(new Package { Guid = new Guid(""), Code = "Wheels18inch", Name = "18” aluminum-alloy wheels", Price = 0, FeatureList = new string[] { "Maxima performs on a set of 18” aluminum-alloy wheels with a machine-finish and are fitted with P245/45VR18 tires for optimal handling and traction." } });
            list.Add(new Package { Guid = new Guid(""), Code = "DualPanelMoonroof", Name = "Dual Panel Panoramic Moonroof", Price = 0, FeatureList = new string[] { "The panoramic moonroof is simply massive. So big that it reaches over the back seats, allowing co-pilots and navigators alike to enjoy the feeling of an open atmosphere and an unfettered view of the sky above" } });
            list.Add(new Package { Guid = new Guid(""), Code = "BosePremiumAudio", Name = "Bose® Premium Audio System", Price = 0, FeatureList = new string[] { "The 11-speaker Bose® audio system features eleven optimally placed speakers including a center channel speaker. Additionally, it features center point technology that delivers rich sound to the driver and occupants in the front and back seats. [*]" } });
            list.Add(new Package { Guid = new Guid(""), Code = "IntelligentCruiseControl", Name = "Intelligent Cruise Control (ICC)", Price = 0, FeatureList = new string[] { "Intelligent Cruise Control uses radar to maintain a set distance between you and the car in front of you, even braking to maintain that distance or bring you to a complete stop if necessary. [*]" } });

            list.Add(new Package { Guid = new Guid(""), Code = "LeatherAppointedSeats", Name = "Leather-appointed seats", Price = 0, FeatureList = new string[] { "This spacious 5-seater offers everyone comfort with refinement. Designed with special attention to detail, each leather seat is deeply bolstered and double-stitched." } });
            list.Add(new Package { Guid = new Guid(""), Code = "HeatedFrontSeats", Name = "Heated Front Seats", Price = 0, FeatureList = new string[] { "Heated front seats and other unexpected upscale touches offer you and your passengers ultimate comfort and style." } });
            list.Add(new Package { Guid = new Guid(""), Code = "DriveSeatLumbarSupport", Name = "Driver's Seat Power Lumbar Support", Price = 0, FeatureList = new string[] { "With this available feature, you can inflate or deflate the lower portion of the driver’s seatback for a personalized, supportive fit and a more comfortable ride." } });
            list.Add(new Package { Guid = new Guid(""), Code = "SonarSystemFrontRear", Name = "Front and Rear Sonar System", Price = 0, FeatureList = new string[] { "Maxima®’s parking sonar gives you an added ally in your pursuit of parking, with sensors on all four corners looking out for static objects and giving you an audible warning when you’re getting close." } });
            list.Add(new Package { Guid = new Guid(""), Code = "NissanAdvancedAirBag", Name = "Nissan Advanced Air Bag System", Price = 0, FeatureList = new string[] { "Nissan Advanced Air Bag System has front air bags with seat belt and occupant-classification sensors. In addition, Maxima features front seat-mounted side-impact supplemental air bags, and roof-mounted curtain side-impact supplemental air bags with rollover sensors. [*]" } });
            list.Add(new Package { Guid = new Guid(""), Code = "VDCTCS", Name = "Vehicle Dynamic Control (VDC) with Traction Control System (TCS)", Price = 0, FeatureList = new string[] { "Whether you need to hit the brakes hard or maneuver around an unexpected obstacle, these standard technologies help you respond to a potentially harmful situation. VDC helps you maintain your steered path. TCS helps reduce wheelspin in low traction situations." } });

            list.Add(new Package { Guid = new Guid(""), Code = "DriveAssistDisplay", Name = "7.0\" Color Advanced Drive Assist® Display", Price = 0, FeatureList = new string[] { "The 7\" display keeps key information as close as a glance so you can access the tech you need at every turn. From available turn-by-turn directions to caller ID or safety features, the Advanced Drive-Assist® Display lays it all right before your eyes - helping to minimize time looking away." } });
            list.Add(new Package { Guid = new Guid(""), Code = "RearviewMonitor", Name = "RearView Monitor", Price = 0, FeatureList = new string[] { "Backing up made easy, with the Maxima's RearView Monitor. A discreet color camera mounted on the rear of the vehicle helps you see what's directly behind you, using the screen in front of you. [*]" } });
            list.Add(new Package { Guid = new Guid(""), Code = "TaillightLEDsignature", Name = "Taillights with integrated LED signature", Price = 0, FeatureList = new string[] { "Taillights with integrated LED signature – a wraparound boomerang LED signature in the taillights gives Maxima another touch of signature style at night." } });
            list.Add(new Package { Guid = new Guid(""), Code = "TPMS", Name = "Tire Pressure Monitoring System with Easy-Fill Tire Alert", Price = 0, FeatureList = new string[] { "TPMS lets you know when a tire is low. And Easy-Fill Tire Alert takes the guesswork out of filling your tires, with a beep of the horn when you’ve reached the correct pressure." } });
            list.Add(new Package { Guid = new Guid(""), Code = "", Name = "", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "", Name = "", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "", Name = "", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "", Name = "", Price = 0, FeatureList = new string[] { } });
            list.Add(new Package { Guid = new Guid(""), Code = "", Name = "", Price = 0, FeatureList = new string[] { } });
            //list.Add(new Package { Guid = new Guid(""), Code = "", Name = "" });
        }

        public Package GetPackage(string code)
        {
            foreach (Package itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    return itm;
                }
            }
            return null;
        }

        public List<Package> GetPackages()
        {
            return list;
        }


    }

}
