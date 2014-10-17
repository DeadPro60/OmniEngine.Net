﻿// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
{
    public class audioEnviroments
    {
        public static void initialize()
        {
            SingletonCreator ts = new SingletonCreator("SFXEnvironment", "AudioEnvOff");
            ts["envSize"] = 7.5;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -10000;
            ts["roomHF"] = -10000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.0;
            ts["decayHFRatio"] = 1.0;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -2602;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 200;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 0.0;
            ts["density"] = 0.0;
            ts["flags"] = "0x33";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvGeneric");
            ts["envSize"] = 7.5;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -100;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.83;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -2602;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 200;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvRoom");
            ts["envSize"] = 1.9;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -454;
            ts["roomLF"] = 0;
            ts["decayTime"] = 0.4;
            ts["decayHFRatio"] = 0.83;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1646;
            ts["reflectionsDelay"] = 0.002;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 53;
            ts["reverbDelay"] = 0.003;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvPaddedCell");
            ts["envSize"] = 1.4;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -6000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 0.17;
            ts["decayHFRatio"] = 0.1;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1204;
            ts["reflectionsDelay"] = 0.001;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 207;
            ts["reverbDelay"] = 0.002;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvBathroom");
            ts["envSize"] = 1.4;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -1200;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.54;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -370;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 1030;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 60.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvLivingRoom");
            ts["envSize"] = 2.5;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -6000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 0.5;
            ts["decayHFRatio"] = 0.1;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1376;
            ts["reflectionsDelay"] = 0.003;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -1104;
            ts["reverbDelay"] = 0.004;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvStoneRoom");
            ts["envSize"] = 11.6;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = 300;
            ts["roomLF"] = 0;
            ts["decayTime"] = 2.31;
            ts["decayHFRatio"] = 0.64;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -711;
            ts["reflectionsDelay"] = 0.012;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 83;
            ts["reverbDelay"] = 0.017;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = -5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvAuditorium");
            ts["envSize"] = 21.6;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -476;
            ts["roomLF"] = 0;
            ts["decayTime"] = 4.32;
            ts["decayHFRatio"] = 0.59;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = 0.789;
            ts["reflectionsDelay"] = 0.02;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -289;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvConcertHall");
            ts["envSize"] = 19.6;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -500;
            ts["roomLF"] = 0;
            ts["decayTime"] = 3.92;
            ts["decayHFRatio"] = 0.7;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1230;
            ts["reflectionsDelay"] = 0.02;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -2;
            ts["reverbDelay"] = 0.029;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvCave");
            ts["envSize"] = 14.6;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = 0;
            ts["roomLF"] = 0;
            ts["decayTime"] = 2.91;
            ts["decayHFRatio"] = 1.3;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -602;
            ts["reflectionsDelay"] = 0.015;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -302;
            ts["reverbDelay"] = 0.022;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x1f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvArena");
            ts["envSize"] = 36.2f;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -698;
            ts["roomLF"] = 0;
            ts["decayTime"] = 7.24;
            ts["decayHFRatio"] = 0.33;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1166;
            ts["reflectionsDelay"] = 0.02;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 16;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvHangar");
            ts["envSize"] = 50.3;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -1000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 10.05;
            ts["decayHFRatio"] = 0.23;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -602;
            ts["reflectionsDelay"] = 0.02;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 198;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvCarpettedHallway");
            ts["envSize"] = 1.9;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -4000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 0.3;
            ts["decayHFRatio"] = 0.1;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1831;
            ts["reflectionsDelay"] = 0.002;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -1630;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvHallway");
            ts["envSize"] = 1.8;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -300;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.59;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1219;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 441;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvStoneCorridor");
            ts["envSize"] = 13.5;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -237;
            ts["roomLF"] = 0;
            ts["decayTime"] = 2.7;
            ts["decayHFRatio"] = 0.79;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1214;
            ts["reflectionsDelay"] = 0.013;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 395;
            ts["reverbDelay"] = 0.02;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvAlley");
            ts["envSize"] = 7.5;
            ts["envDiffusion"] = 0.3;
            ts["room"] = -1000;
            ts["roomHF"] = -270;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.86;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1204;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -4;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.125;
            ts["echoDepth"] = 0.95;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvForest");
            ts["envSize"] = 38.0;
            ts["envDiffusion"] = 0.3;
            ts["room"] = -1000;
            ts["roomHF"] = -3300;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.54;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -2560;
            ts["reflectionsDelay"] = 0.162;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -229;
            ts["reverbDelay"] = 0.088;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.125;
            ts["echoDepth"] = 1.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 79.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvCity");
            ts["envSize"] = 7.5;
            ts["envDiffusion"] = 0.5;
            ts["room"] = -1000;
            ts["roomHF"] = -800;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.67;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -2273;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -1691;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 50.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvMountains");
            ts["envSize"] = 100.0;
            ts["envDiffusion"] = 0.27;
            ts["room"] = -1000;
            ts["roomHF"] = -2500;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.21;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -2780;
            ts["reflectionsDelay"] = 0.3;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -1434;
            ts["reverbDelay"] = 0.1;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 1.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 27.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x1f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvQuary");
            ts["envSize"] = 17.5;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -1000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.83;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -10000;
            ts["reflectionsDelay"] = 0.061;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 500;
            ts["reverbDelay"] = 0.025;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.125;
            ts["echoDepth"] = 0.7;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvPlain");
            ts["envSize"] = 42.5;
            ts["envDiffusion"] = 0.21;
            ts["room"] = -1000;
            ts["roomHF"] = -2000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.5;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -2466;
            ts["reflectionsDelay"] = 0.179;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -1926;
            ts["reverbDelay"] = 0.1;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 1.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 21.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvParkingLot");
            ts["envSize"] = 8.3;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = 0;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.65;
            ts["decayHFRatio"] = 1.5;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1363;
            ts["reflectionsDelay"] = 0.008;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -1153;
            ts["reverbDelay"] = 0.012;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x1f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvSewerPipe");
            ts["envSize"] = 1.7;
            ts["envDiffusion"] = 0.8;
            ts["room"] = -1000;
            ts["roomHF"] = -1000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 2.81;
            ts["decayHFRatio"] = 0.14;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = 429;
            ts["reflectionsDelay"] = 0.014;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 1023;
            ts["reverbDelay"] = 0.21;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 0.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 80.0;
            ts["density"] = 60.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvUnderwater");
            ts["envSize"] = 1.8;
            ts["envDiffusion"] = 1.0;
            ts["room"] = -1000;
            ts["roomHF"] = -4000;
            ts["roomLF"] = 0;
            ts["decayTime"] = 1.49;
            ts["decayHFRatio"] = 0.1;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -449;
            ts["reflectionsDelay"] = 0.007;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 1700;
            ts["reverbDelay"] = 0.011;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 1.18;
            ts["modulationDepth"] = 0.348;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x3f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvDrugged");
            ts["envSize"] = 1.9;
            ts["envDiffusion"] = 0.5;
            ts["room"] = -1000;
            ts["roomHF"] = 0;
            ts["roomLF"] = 0;
            ts["decayTime"] = 8.39;
            ts["decayHFRatio"] = 1.39;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -115;
            ts["reflectionsDelay"] = 0.002;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 985;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 0.25;
            ts["modulationDepth"] = 1.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x1f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvDizzy");
            ts["envSize"] = 1.8;
            ts["envDiffusion"] = 0.6;
            ts["room"] = -1000.0;
            ts["roomHF"] = -400;
            ts["roomLF"] = 0;
            ts["decayTime"] = 17.23;
            ts["decayHFRatio"] = 0.56;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -1713;
            ts["reflectionsDelay"] = 0.02;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = -613;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 1.0;
            ts["modulationTime"] = 0.81;
            ts["modulationDepth"] = 0.31;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x1f";
            ts.Create();

            ts = new SingletonCreator("SFXEnvironment", "AudioEnvPsychotic");
            ts["envSize"] = 1.0;
            ts["envDiffusion"] = 0.5;
            ts["room"] = -1000;
            ts["roomHF"] = -151;
            ts["roomLF"] = 0;
            ts["decayTime"] = 7.56;
            ts["decayHFRatio"] = 0.91;
            ts["decayLFRatio"] = 1.0;
            ts["reflections"] = -626;
            ts["reflectionsDelay"] = 0.02;
            ts["reflectionsPan[0]"] = 0.0;
            ts["reflectionsPan[1]"] = 0.0;
            ts["reflectionsPan[2]"] = 0.0;
            ts["reverb"] = 774;
            ts["reverbDelay"] = 0.03;
            ts["reverbPan[0]"] = 0.0;
            ts["reverbPan[1]"] = 0.0;
            ts["reverbPan[2]"] = 0.0;
            ts["echoTime"] = 0.25;
            ts["echoDepth"] = 0.0;
            ts["modulationTime"] = 4.0;
            ts["modulationDepth"] = 1.0;
            ts["airAbsorptionHF"] = -5.0;
            ts["HFReference"] = 5000.0;
            ts["LFReference"] = 250.0;
            ts["roomRolloffFactor"] = 0.0;
            ts["diffusion"] = 100.0;
            ts["density"] = 100.0;
            ts["flags"] = "0x1f";
            ts.Create();
        }
    }
}