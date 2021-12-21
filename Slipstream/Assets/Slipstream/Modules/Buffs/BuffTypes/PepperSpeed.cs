﻿using Moonstorm;
using RoR2;
using R2API;

namespace Slipstream.Buffs
{
    public class PepperSpeed : BuffBase
    {
        public override BuffDef BuffDef { get; set; } = SlipAssets.Instance.MainAssetBundle.LoadAsset<BuffDef>("PepperSpeed");
        public static BuffDef buff;

        public override void Initialize()
        {
            buff = BuffDef;
        }

        public override void AddBehavior(ref CharacterBody body, int stack)
        {
            body.AddItemBehavior<PepperSpeedBehavior>(stack);
        }

        public class PepperSpeedBehavior : CharacterBody.ItemBehavior, IBodyStatArgModifier
        {
            public void ModifyStatArguments(RecalculateStatsAPI.StatHookEventArgs args)
            {
                if(body.HasBuff(buff))
                    args.moveSpeedMultAdd += Slipstream.Items.PepperSpray.speedIncrease;
            }
        }

    }

}
