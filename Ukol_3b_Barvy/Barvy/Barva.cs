using System;

public class Barva
{
    public string Nazev { get; private set; }
    public byte R { get; private set; }
    public byte G { get; private set; }
    public byte B { get; private set; }

    public Barva(string nazev, byte r, byte g, byte b)
    {
        Nazev = nazev;
        R = r;
        G = g;
        B = b;
    }

    public override string ToString()
    {
        // Format the color as 'název barvy (#RRGGBB)'
        return $"{Nazev} (#{R:X2}{G:X2}{B:X2})";
    }
}

