using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace RunicArcanum.Common.RASystem;

public class ModSupport : ModSystem {
    public override void PostSetupContent() {
    }

    private struct BossInfo {
        public string bossName;
        public int bossType;
        public float weight;
        public Func<bool> downed;
        public Func<bool> available;
        public List<int> collection;
        public int summonItem;
        public string spawnInfo;
        public string despawnInfo;
        public Action<SpriteBatch, Rectangle, Color> customBossPortrai;
    }

    private void BossChecklistSupport() {
        if (!ModLoader.TryGetMod("BossChecklist", out Mod bossChecklistMod)) {
            return;
        }
        
        List<BossInfo> bossInfos = new List<BossInfo>() {
            
        };
        
        foreach (BossInfo bossInfo in bossInfos) {
            bossChecklistMod.Call(bossInfo.bossName, Mod, bossInfo.bossType, bossInfo.weight, bossInfo.downed,
                bossInfo.available, bossInfo.collection, bossInfo.summonItem, bossInfo.spawnInfo, bossInfo.despawnInfo,
                bossInfo.customBossPortrai);
        }
    }
}