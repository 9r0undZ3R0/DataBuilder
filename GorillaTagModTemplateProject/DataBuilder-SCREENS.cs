using BepInEx;
using BepInEx.Configuration;
using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;
using System;
using System.Runtime;
using System.Collections.Generic;
using System.IO;
using PluginInfo = BepInEx.PluginInfo;
using System.Diagnostics;

namespace DataBuilder
{
    internal class DataBuilder_SCREEN_COLORCODE : GorillaScreen
    {
        public string Title => "Color Code";
        public string Description => "Saves your Current Color Code!";
        public static void Save() {
            var path = Directory.GetCurrentDirectory().ToString();
            if (!Directory.Exists(path + "\\Gorilla Tag_Data\\DataBuilder")) {
                Directory.CreateDirectory(path + "\\Gorilla Tag_Data\\DataBuilder");
            }
            var Color_Code = GorillaTagger.Instance.offlineVRRig.playerColor.ToColorf();
            File.WriteAllText(path + "\\Gorilla Tag_Data\\DataBuilder\\ColorCode.txt", String.Format("{0}, {1}, {2}", Math.Round(Color_Code.r*9), Math.Round(Color_Code.g*9), Math.Round(Color_Code.b*9))); // ColorCode
        }
    }
    internal class DataBuilder_SCREEN_NAME : GorillaScreen
    {
        public string Title => "Name";
        public string Description => "Saves your Current Name!";
        public static void Save()
        {
            var path = Directory.GetCurrentDirectory().ToString();
            if (!Directory.Exists(path + "\\Gorilla Tag_Data\\DataBuilder"))
            {
                Directory.CreateDirectory(path + "\\Gorilla Tag_Data\\DataBuilder");
            }
            File.WriteAllText(path + "\\Gorilla Tag_Data\\DataBuilder\\Name.txt", GorillaComputer.instance.savedName); // Name
        }
    }
    internal class DataBuilder_SCREEN_CODE : GorillaScreen
    {
        public string Title => "Code";
        public string Description => "Saves your Current Code!";
        public static void Save()
        {
            var path = Directory.GetCurrentDirectory().ToString();
            if (!Directory.Exists(path + "\\Gorilla Tag_Data\\DataBuilder"))
            {
                Directory.CreateDirectory(path + "\\Gorilla Tag_Data\\DataBuilder");
            }
            File.WriteAllText(path + "\\Gorilla Tag_Data\\DataBuilder\\Code.txt", PhotonNetwork.CurrentRoom.Name); // Code
        }
    }
}
