using RunicArcanum.Util;
using Terraria.ModLoader;

namespace RunicArcanum.Common.RASystem; 

public class Keyband : ModSystem{
    public static ModKeybind OpenMindRunicInterfaceKeybind { get; private set; }

    public override void Load() {
        // Registers a new keybind
        OpenMindRunicInterfaceKeybind = KeybindLoader.RegisterKeybind(Mod, StringTool.TextInLoc("config.OpenMindRunicInterfaceKeybind"), "L");
    }

    // Please see ExampleMod.cs' Unload() method for a detailed explanation of the unloading process.
    public override void Unload() {
        // Not required if your AssemblyLoadContext is unloading properly, but nulling out static fields can help you figure out what's keeping it loaded.
        OpenMindRunicInterfaceKeybind = null;
    }
}