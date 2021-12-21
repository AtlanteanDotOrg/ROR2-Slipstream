﻿using Moonstorm;
using RoR2.ContentManagement;
using UnityEngine;

namespace Slipstream.Modules
{
    public class ItemDisplays : ItemDisplayModuleBase
    {
        public static ItemDisplays Instance { get; set; }
        public override AssetBundle AssetBundle { get; set; } = SlipAssets.Instance.MainAssetBundle;
        public override SerializableContentPack ContentPack { get; set; } = SlipContent.Instance.SerializableContentPack;

        public override void Init()
        {
            Instance = this;
            base.Init();
            PopulateKeyAssetsAndDisplaysFromAssetbundle();
            PopulateMSIDRSFromAssetBundle();
            PopulateSingleItemDisplayRuleFromAssetBundle();
        }
    }

}