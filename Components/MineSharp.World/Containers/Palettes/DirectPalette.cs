﻿namespace MineSharp.World.Containers.Palettes;

internal class DirectPalette : IPalette
{
    public DirectPalette()
    { }
    
    public int Get(int index) => index;
    
    public bool ContainsState(int minState, int maxState) => true;

    public IPalette? Set(int index, int state, IPaletteContainer container)
    {
        container.Data.Set(index, state);
        return null;
    }

    public static IPalette FromStream(Stream stream)
    {
        return new DirectPalette();
    }
}