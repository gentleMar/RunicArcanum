using System.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace RunicArcanum.Common.RASystem; 

public abstract class ArchmageSystem : ModSystem {
    public override void PreUpdateWorld() {
        
        base.PreUpdateWorld();
    }

    public void Reset() {
        
    }

    public override void SaveWorldData(TagCompound tag) {
    }

    public override void LoadWorldData(TagCompound tag) {
    }

    public override void NetSend(BinaryWriter writer) {
    }

    public override void NetReceive(BinaryReader reader) {
    }

    public override void OnWorldLoad() => Reset();
    public override void OnWorldUnload() => Reset();
}