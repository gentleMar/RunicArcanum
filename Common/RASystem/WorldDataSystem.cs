using System.Collections.Generic;
using System.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace RunicArcanum.Common.RASystem;

public class WorldDataSystem : ModSystem {
    public bool modIntroAnnounced;

    //add a new value then do 5 changes
    private void Reset() {
        modIntroAnnounced = false;
    }

    public override void SaveWorldData(TagCompound tag) {
        foreach (KeyValuePair<string, object> keyValuePair in new TagCompound {
                     { "modIntroAnnounced", modIntroAnnounced }
                 }) {
            tag.Add(keyValuePair.Key, keyValuePair.Value);
        }

        base.SaveWorldData(tag);
    }


    public override void LoadWorldData(TagCompound tag) {
        modIntroAnnounced = tag.GetBool("modIntroAnnounced");
    }


    public override void NetSend(BinaryWriter writer) {
        writer.Write(modIntroAnnounced);
    }

    public override void NetReceive(BinaryReader reader) {
        modIntroAnnounced = reader.ReadBoolean();
    }

    public override void OnWorldLoad() => Reset();
    public override void OnWorldUnload() => Reset();
}