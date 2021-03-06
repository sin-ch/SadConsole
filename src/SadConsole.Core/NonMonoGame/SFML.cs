﻿#if SFML
// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.


namespace SFML.Graphics
{
    public static class ColorHelper
    {
        static ColorHelper()
        {
            TransparentBlack = new Color(0);
            Transparent = new Color(0);
            AliceBlue = new Color(0xf0f8ffff);
            AntiqueWhite = new Color(0xfaebd7ff);
            Aqua = new Color(0x00ffffff);
            Aquamarine = new Color(0x7fffd4ff);
            Azure = new Color(0xf0ffffff);
            Beige = new Color(0xf5f5dcff);
            Bisque = new Color(0xffe4c4ff);
            Black = new Color(0x000000ff);
            BlanchedAlmond = new Color(0xffebcdff);
            Blue = new Color(0x0000ffff);
            BlueViolet = new Color(0x8a2be2ff);
            Brown = new Color(0xa52a2aff);
            BurlyWood = new Color(0xdeb887ff);
            CadetBlue = new Color(0x5f9ea0ff);
            Chartreuse = new Color(0x7fff00ff);
            Chocolate = new Color(0xd2691eff);
            Coral = new Color(0xff7f50ff);
            CornflowerBlue = new Color(0x6495edff);
            Cornsilk = new Color(0xfff8dcff);
            Crimson = new Color(0xdc143cff);
            Cyan = new Color(0x00ffffff);
            DarkBlue = new Color(0x00008bff);
            DarkCyan = new Color(0x008b8bff);
            DarkGoldenrod = new Color(0xb8860bff);
            DarkGray = new Color(0xa9a9a9ff);
            DarkGreen = new Color(0x006400ff);
            DarkKhaki = new Color(0xbdb76bff);
            DarkMagenta = new Color(0x8b008bff);
            DarkOliveGreen = new Color(0x556b2fff);
            DarkOrange = new Color(0xff8c00ff);
            DarkOrchid = new Color(0x9932ccff);
            DarkRed = new Color(0x8b0000ff);
            DarkSalmon = new Color(0xe9967aff);
            DarkSeaGreen = new Color(0x8fbc8bff);
            DarkSlateBlue = new Color(0x483d8bff);
            DarkSlateGray = new Color(0x2f4f4fff);
            DarkTurquoise = new Color(0x00ced1ff);
            DarkViolet = new Color(0x9400d3ff);
            DeepPink = new Color(0xff1493ff);
            DeepSkyBlue = new Color(0x00bfffff);
            DimGray = new Color(0x696969ff);
            DodgerBlue = new Color(0x1e90ffff);
            Firebrick = new Color(0xb22222ff);
            FloralWhite = new Color(0xfffaf0ff);
            ForestGreen = new Color(0x228b22ff);
            Fuchsia = new Color(0xff00ffff);
            Gainsboro = new Color(0xdcdcdcff);
            GhostWhite = new Color(0xf8f8ffff);
            Gold = new Color(0xffd700ff);
            Goldenrod = new Color(0xdaa520ff);
            Gray = new Color(0x808080ff);
            Green = new Color(0x008000ff);
            GreenYellow = new Color(0xadff2fff);
            Honeydew = new Color(0xf0fff0ff);
            HotPink = new Color(0xff69b4ff);
            IndianRed = new Color(0xcd5c5cff);
            Indigo = new Color(0x4b0082ff);
            Ivory = new Color(0xfffff0ff);
            Khaki = new Color(0xf0e68cff);
            Lavender = new Color(0xe6e6faff);
            LavenderBlush = new Color(0xfff0f5ff);
            LawnGreen = new Color(0x7cfc00ff);
            LemonChiffon = new Color(0xfffacdff);
            LightBlue = new Color(0xadd8e6ff);
            LightCoral = new Color(0xf08080ff);
            LightCyan = new Color(0xe0ffffff);
            LightGoldenrodYellow = new Color(0xfafad2ff);
            LightGray = new Color(0xd3d3d3ff);
            LightGreen = new Color(0x90ee90ff);
            LightPink = new Color(0xffb6c1ff);
            LightSalmon = new Color(0xffa07aff);
            LightSeaGreen = new Color(0x20b2aaff);
            LightSkyBlue = new Color(0x87cefaff);
            LightSlateGray = new Color(0x778899ff);
            LightSteelBlue = new Color(0xb0c4deff);
            LightYellow = new Color(0xffffe0ff);
            Lime = new Color(0x00ff00ff);
            LimeGreen = new Color(0x32cd32ff);
            Linen = new Color(0xfaf0e6ff);
            Magenta = new Color(0xff00ffff);
            Maroon = new Color(0x800000ff);
            MediumAquamarine = new Color(0x66cdaaff);
            MediumBlue = new Color(0x0000cdff);
            MediumOrchid = new Color(0xba55d3ff);
            MediumPurple = new Color(0x9370dbff);
            MediumSeaGreen = new Color(0x3cb371ff);
            MediumSlateBlue = new Color(0x7b68eeff);
            MediumSpringGreen = new Color(0x00fa9aff);
            MediumTurquoise = new Color(0x48d1ccff);
            MediumVioletRed = new Color(0xc71585ff);
            MidnightBlue = new Color(0x191970ff);
            MintCream = new Color(0xf5fffaff);
            MistyRose = new Color(0xffe4e1ff);
            Moccasin = new Color(0xffe4b5ff);
            MonoGameOrange = new Color(0xe73c00ff);
            NavajoWhite = new Color(0xffdeadff);
            Navy = new Color(0x000080ff);
            OldLace = new Color(0xfdf5e6ff);
            Olive = new Color(0x808000ff);
            OliveDrab = new Color(0x6b8e23ff);
            Orange = new Color(0xffa500ff);
            OrangeRed = new Color(0xff4500ff);
            Orchid = new Color(0xda70d6ff);
            PaleGoldenrod = new Color(0xeee8aaff);
            PaleGreen = new Color(0x98fb98ff);
            PaleTurquoise = new Color(0xafeeeeff);
            PaleVioletRed = new Color(0xdb7093ff);
            PapayaWhip = new Color(0xffefd5ff);
            PeachPuff = new Color(0xffdab9ff);
            Peru = new Color(0xcd853fff);
            Pink = new Color(0xffc0cbff);
            Plum = new Color(0xdda0ddff);
            PowderBlue = new Color(0xb0e0e6ff);
            Purple = new Color(0x800080ff);
            Red = new Color(0xff0000ff);
            RosyBrown = new Color(0xbc8f8fff);
            RoyalBlue = new Color(0x4169e1ff);
            SaddleBrown = new Color(0x8b4513ff);
            Salmon = new Color(0xfa8072ff);
            SandyBrown = new Color(0xf4a460ff);
            SeaGreen = new Color(0x2e8b57ff);
            SeaShell = new Color(0xfff5eeff);
            Sienna = new Color(0xa0522dff);
            Silver = new Color(0xc0c0c0ff);
            SkyBlue = new Color(0x87ceebff);
            SlateBlue = new Color(0x6a5acdff);
            SlateGray = new Color(0x708090ff);
            Snow = new Color(0xfffafaff);
            SpringGreen = new Color(0x00ff7fff);
            SteelBlue = new Color(0x4682b4ff);
            Tan = new Color(0xd2b48cff);
            Teal = new Color(0x008080ff);
            Thistle = new Color(0xd8bfd8ff);
            Tomato = new Color(0xff6347ff);
            Turquoise = new Color(0x40e0d0ff);
            Violet = new Color(0xee82eeff);
            Wheat = new Color(0xf5deb3ff);
            White = new Color(uint.MaxValue);
            WhiteSmoke = new Color(0xf5f5f5ff);
            Yellow = new Color(0xffff00ff);
            YellowGreen = new Color(0x9acd32ff);
        }

        /// <summary>
        /// Performs linear interpolation of <see cref="Color"/>.
        /// </summary>
        /// <param name="value1">Source <see cref="Color"/>.</param>
        /// <param name="value2">Destination <see cref="Color"/>.</param>
        /// <param name="amount">Interpolation factor.</param>
        /// <returns>Interpolated <see cref="Color"/>.</returns>
        public static Color Lerp(Color value1, Color value2, float amount)
        {
            amount = SadConsole.MathHelper.Clamp(amount, 0, 1);
            var col = new Color(
                (byte)SadConsole.MathHelper.Lerp(value1.R, value2.R, amount),
                (byte)SadConsole.MathHelper.Lerp(value1.G, value2.G, amount),
                (byte)SadConsole.MathHelper.Lerp(value1.B, value2.B, amount),
                (byte)SadConsole.MathHelper.Lerp(value1.A, value2.A, amount));

            return col;
        }

        #region Color Bank
        /// <summary>
        /// TransparentBlack color (R:0,G:0,B:0,A:0).
        /// </summary>
        public static Color TransparentBlack
        {
            get;
            private set;
        }

        /// <summary>
        /// Transparent color (R:0,G:0,B:0,A:0).
        /// </summary>
        public static Color Transparent
        {
            get;
            private set;
        }

        /// <summary>
        /// AliceBlue color (R:240,G:248,B:255,A:255).
        /// </summary>
        public static Color AliceBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// AntiqueWhite color (R:250,G:235,B:215,A:255).
        /// </summary>
        public static Color AntiqueWhite
        {
            get;
            private set;
        }

        /// <summary>
        /// Aqua color (R:0,G:255,B:255,A:255).
        /// </summary>
        public static Color Aqua
        {
            get;
            private set;
        }

        /// <summary>
        /// Aquamarine color (R:127,G:255,B:212,A:255).
        /// </summary>
        public static Color Aquamarine
        {
            get;
            private set;
        }

        /// <summary>
        /// Azure color (R:240,G:255,B:255,A:255).
        /// </summary>
        public static Color Azure
        {
            get;
            private set;
        }

        /// <summary>
        /// Beige color (R:245,G:245,B:220,A:255).
        /// </summary>
        public static Color Beige
        {
            get;
            private set;
        }

        /// <summary>
        /// Bisque color (R:255,G:228,B:196,A:255).
        /// </summary>
        public static Color Bisque
        {
            get;
            private set;
        }

        /// <summary>
        /// Black color (R:0,G:0,B:0,A:255).
        /// </summary>
        public static Color Black
        {
            get;
            private set;
        }

        /// <summary>
        /// BlanchedAlmond color (R:255,G:235,B:205,A:255).
        /// </summary>
        public static Color BlanchedAlmond
        {
            get;
            private set;
        }

        /// <summary>
        /// Blue color (R:0,G:0,B:255,A:255).
        /// </summary>
        public static Color Blue
        {
            get;
            private set;
        }

        /// <summary>
        /// BlueViolet color (R:138,G:43,B:226,A:255).
        /// </summary>
        public static Color BlueViolet
        {
            get;
            private set;
        }

        /// <summary>
        /// Brown color (R:165,G:42,B:42,A:255).
        /// </summary>
        public static Color Brown
        {
            get;
            private set;
        }

        /// <summary>
        /// BurlyWood color (R:222,G:184,B:135,A:255).
        /// </summary>
        public static Color BurlyWood
        {
            get;
            private set;
        }

        /// <summary>
        /// CadetBlue color (R:95,G:158,B:160,A:255).
        /// </summary>
        public static Color CadetBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// Chartreuse color (R:127,G:255,B:0,A:255).
        /// </summary>
        public static Color Chartreuse
        {
            get;
            private set;
        }

        /// <summary>
        /// Chocolate color (R:210,G:105,B:30,A:255).
        /// </summary>
        public static Color Chocolate
        {
            get;
            private set;
        }

        /// <summary>
        /// Coral color (R:255,G:127,B:80,A:255).
        /// </summary>
        public static Color Coral
        {
            get;
            private set;
        }

        /// <summary>
        /// CornflowerBlue color (R:100,G:149,B:237,A:255).
        /// </summary>
        public static Color CornflowerBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// Cornsilk color (R:255,G:248,B:220,A:255).
        /// </summary>
        public static Color Cornsilk
        {
            get;
            private set;
        }

        /// <summary>
        /// Crimson color (R:220,G:20,B:60,A:255).
        /// </summary>
        public static Color Crimson
        {
            get;
            private set;
        }

        /// <summary>
        /// Cyan color (R:0,G:255,B:255,A:255).
        /// </summary>
        public static Color Cyan
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkBlue color (R:0,G:0,B:139,A:255).
        /// </summary>
        public static Color DarkBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkCyan color (R:0,G:139,B:139,A:255).
        /// </summary>
        public static Color DarkCyan
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkGoldenrod color (R:184,G:134,B:11,A:255).
        /// </summary>
        public static Color DarkGoldenrod
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkGray color (R:169,G:169,B:169,A:255).
        /// </summary>
        public static Color DarkGray
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkGreen color (R:0,G:100,B:0,A:255).
        /// </summary>
        public static Color DarkGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkKhaki color (R:189,G:183,B:107,A:255).
        /// </summary>
        public static Color DarkKhaki
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkMagenta color (R:139,G:0,B:139,A:255).
        /// </summary>
        public static Color DarkMagenta
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkOliveGreen color (R:85,G:107,B:47,A:255).
        /// </summary>
        public static Color DarkOliveGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkOrange color (R:255,G:140,B:0,A:255).
        /// </summary>
        public static Color DarkOrange
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkOrchid color (R:153,G:50,B:204,A:255).
        /// </summary>
        public static Color DarkOrchid
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkRed color (R:139,G:0,B:0,A:255).
        /// </summary>
        public static Color DarkRed
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkSalmon color (R:233,G:150,B:122,A:255).
        /// </summary>
        public static Color DarkSalmon
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkSeaGreen color (R:143,G:188,B:139,A:255).
        /// </summary>
        public static Color DarkSeaGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkSlateBlue color (R:72,G:61,B:139,A:255).
        /// </summary>
        public static Color DarkSlateBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkSlateGray color (R:47,G:79,B:79,A:255).
        /// </summary>
        public static Color DarkSlateGray
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkTurquoise color (R:0,G:206,B:209,A:255).
        /// </summary>
        public static Color DarkTurquoise
        {
            get;
            private set;
        }

        /// <summary>
        /// DarkViolet color (R:148,G:0,B:211,A:255).
        /// </summary>
        public static Color DarkViolet
        {
            get;
            private set;
        }

        /// <summary>
        /// DeepPink color (R:255,G:20,B:147,A:255).
        /// </summary>
        public static Color DeepPink
        {
            get;
            private set;
        }

        /// <summary>
        /// DeepSkyBlue color (R:0,G:191,B:255,A:255).
        /// </summary>
        public static Color DeepSkyBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// DimGray color (R:105,G:105,B:105,A:255).
        /// </summary>
        public static Color DimGray
        {
            get;
            private set;
        }

        /// <summary>
        /// DodgerBlue color (R:30,G:144,B:255,A:255).
        /// </summary>
        public static Color DodgerBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// Firebrick color (R:178,G:34,B:34,A:255).
        /// </summary>
        public static Color Firebrick
        {
            get;
            private set;
        }

        /// <summary>
        /// FloralWhite color (R:255,G:250,B:240,A:255).
        /// </summary>
        public static Color FloralWhite
        {
            get;
            private set;
        }

        /// <summary>
        /// ForestGreen color (R:34,G:139,B:34,A:255).
        /// </summary>
        public static Color ForestGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// Fuchsia color (R:255,G:0,B:255,A:255).
        /// </summary>
        public static Color Fuchsia
        {
            get;
            private set;
        }

        /// <summary>
        /// Gainsboro color (R:220,G:220,B:220,A:255).
        /// </summary>
        public static Color Gainsboro
        {
            get;
            private set;
        }

        /// <summary>
        /// GhostWhite color (R:248,G:248,B:255,A:255).
        /// </summary>
        public static Color GhostWhite
        {
            get;
            private set;
        }
        /// <summary>
        /// Gold color (R:255,G:215,B:0,A:255).
        /// </summary>
        public static Color Gold
        {
            get;
            private set;
        }

        /// <summary>
        /// Goldenrod color (R:218,G:165,B:32,A:255).
        /// </summary>
        public static Color Goldenrod
        {
            get;
            private set;
        }

        /// <summary>
        /// Gray color (R:128,G:128,B:128,A:255).
        /// </summary>
        public static Color Gray
        {
            get;
            private set;
        }

        /// <summary>
        /// Green color (R:0,G:128,B:0,A:255).
        /// </summary>
        public static Color Green
        {
            get;
            private set;
        }

        /// <summary>
        /// GreenYellow color (R:173,G:255,B:47,A:255).
        /// </summary>
        public static Color GreenYellow
        {
            get;
            private set;
        }

        /// <summary>
        /// Honeydew color (R:240,G:255,B:240,A:255).
        /// </summary>
        public static Color Honeydew
        {
            get;
            private set;
        }

        /// <summary>
        /// HotPink color (R:255,G:105,B:180,A:255).
        /// </summary>
        public static Color HotPink
        {
            get;
            private set;
        }

        /// <summary>
        /// IndianRed color (R:205,G:92,B:92,A:255).
        /// </summary>
        public static Color IndianRed
        {
            get;
            private set;
        }

        /// <summary>
        /// Indigo color (R:75,G:0,B:130,A:255).
        /// </summary>
        public static Color Indigo
        {
            get;
            private set;
        }

        /// <summary>
        /// Ivory color (R:255,G:255,B:240,A:255).
        /// </summary>
        public static Color Ivory
        {
            get;
            private set;
        }

        /// <summary>
        /// Khaki color (R:240,G:230,B:140,A:255).
        /// </summary>
        public static Color Khaki
        {
            get;
            private set;
        }

        /// <summary>
        /// Lavender color (R:230,G:230,B:250,A:255).
        /// </summary>
        public static Color Lavender
        {
            get;
            private set;
        }

        /// <summary>
        /// LavenderBlush color (R:255,G:240,B:245,A:255).
        /// </summary>
        public static Color LavenderBlush
        {
            get;
            private set;
        }

        /// <summary>
        /// LawnGreen color (R:124,G:252,B:0,A:255).
        /// </summary>
        public static Color LawnGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// LemonChiffon color (R:255,G:250,B:205,A:255).
        /// </summary>
        public static Color LemonChiffon
        {
            get;
            private set;
        }

        /// <summary>
        /// LightBlue color (R:173,G:216,B:230,A:255).
        /// </summary>
        public static Color LightBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// LightCoral color (R:240,G:128,B:128,A:255).
        /// </summary>
        public static Color LightCoral
        {
            get;
            private set;
        }

        /// <summary>
        /// LightCyan color (R:224,G:255,B:255,A:255).
        /// </summary>
        public static Color LightCyan
        {
            get;
            private set;
        }

        /// <summary>
        /// LightGoldenrodYellow color (R:250,G:250,B:210,A:255).
        /// </summary>
        public static Color LightGoldenrodYellow
        {
            get;
            private set;
        }

        /// <summary>
        /// LightGray color (R:211,G:211,B:211,A:255).
        /// </summary>
        public static Color LightGray
        {
            get;
            private set;
        }

        /// <summary>
        /// LightGreen color (R:144,G:238,B:144,A:255).
        /// </summary>
        public static Color LightGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// LightPink color (R:255,G:182,B:193,A:255).
        /// </summary>
        public static Color LightPink
        {
            get;
            private set;
        }

        /// <summary>
        /// LightSalmon color (R:255,G:160,B:122,A:255).
        /// </summary>
        public static Color LightSalmon
        {
            get;
            private set;
        }

        /// <summary>
        /// LightSeaGreen color (R:32,G:178,B:170,A:255).
        /// </summary>
        public static Color LightSeaGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// LightSkyBlue color (R:135,G:206,B:250,A:255).
        /// </summary>
        public static Color LightSkyBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// LightSlateGray color (R:119,G:136,B:153,A:255).
        /// </summary>
        public static Color LightSlateGray
        {
            get;
            private set;
        }

        /// <summary>
        /// LightSteelBlue color (R:176,G:196,B:222,A:255).
        /// </summary>
        public static Color LightSteelBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// LightYellow color (R:255,G:255,B:224,A:255).
        /// </summary>
        public static Color LightYellow
        {
            get;
            private set;
        }

        /// <summary>
        /// Lime color (R:0,G:255,B:0,A:255).
        /// </summary>
        public static Color Lime
        {
            get;
            private set;
        }

        /// <summary>
        /// LimeGreen color (R:50,G:205,B:50,A:255).
        /// </summary>
        public static Color LimeGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// Linen color (R:250,G:240,B:230,A:255).
        /// </summary>
        public static Color Linen
        {
            get;
            private set;
        }

        /// <summary>
        /// Magenta color (R:255,G:0,B:255,A:255).
        /// </summary>
        public static Color Magenta
        {
            get;
            private set;
        }

        /// <summary>
        /// Maroon color (R:128,G:0,B:0,A:255).
        /// </summary>
        public static Color Maroon
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumAquamarine color (R:102,G:205,B:170,A:255).
        /// </summary>
        public static Color MediumAquamarine
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumBlue color (R:0,G:0,B:205,A:255).
        /// </summary>
        public static Color MediumBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumOrchid color (R:186,G:85,B:211,A:255).
        /// </summary>
        public static Color MediumOrchid
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumPurple color (R:147,G:112,B:219,A:255).
        /// </summary>
        public static Color MediumPurple
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumSeaGreen color (R:60,G:179,B:113,A:255).
        /// </summary>
        public static Color MediumSeaGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumSlateBlue color (R:123,G:104,B:238,A:255).
        /// </summary>
        public static Color MediumSlateBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumSpringGreen color (R:0,G:250,B:154,A:255).
        /// </summary>
        public static Color MediumSpringGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumTurquoise color (R:72,G:209,B:204,A:255).
        /// </summary>
        public static Color MediumTurquoise
        {
            get;
            private set;
        }

        /// <summary>
        /// MediumVioletRed color (R:199,G:21,B:133,A:255).
        /// </summary>
        public static Color MediumVioletRed
        {
            get;
            private set;
        }

        /// <summary>
        /// MidnightBlue color (R:25,G:25,B:112,A:255).
        /// </summary>
        public static Color MidnightBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// MintCream color (R:245,G:255,B:250,A:255).
        /// </summary>
        public static Color MintCream
        {
            get;
            private set;
        }

        /// <summary>
        /// MistyRose color (R:255,G:228,B:225,A:255).
        /// </summary>
        public static Color MistyRose
        {
            get;
            private set;
        }

        /// <summary>
        /// Moccasin color (R:255,G:228,B:181,A:255).
        /// </summary>
        public static Color Moccasin
        {
            get;
            private set;
        }

        /// <summary>
        /// MonoGame orange theme color (R:231,G:60,B:0,A:255).
        /// </summary>
        public static Color MonoGameOrange
        {
            get;
            private set;
        }

        /// <summary>
        /// NavajoWhite color (R:255,G:222,B:173,A:255).
        /// </summary>
        public static Color NavajoWhite
        {
            get;
            private set;
        }

        /// <summary>
        /// Navy color (R:0,G:0,B:128,A:255).
        /// </summary>
        public static Color Navy
        {
            get;
            private set;
        }

        /// <summary>
        /// OldLace color (R:253,G:245,B:230,A:255).
        /// </summary>
        public static Color OldLace
        {
            get;
            private set;
        }

        /// <summary>
        /// Olive color (R:128,G:128,B:0,A:255).
        /// </summary>
        public static Color Olive
        {
            get;
            private set;
        }

        /// <summary>
        /// OliveDrab color (R:107,G:142,B:35,A:255).
        /// </summary>
        public static Color OliveDrab
        {
            get;
            private set;
        }

        /// <summary>
        /// Orange color (R:255,G:165,B:0,A:255).
        /// </summary>
        public static Color Orange
        {
            get;
            private set;
        }

        /// <summary>
        /// OrangeRed color (R:255,G:69,B:0,A:255).
        /// </summary>
        public static Color OrangeRed
        {
            get;
            private set;
        }

        /// <summary>
        /// Orchid color (R:218,G:112,B:214,A:255).
        /// </summary>
        public static Color Orchid
        {
            get;
            private set;
        }

        /// <summary>
        /// PaleGoldenrod color (R:238,G:232,B:170,A:255).
        /// </summary>
        public static Color PaleGoldenrod
        {
            get;
            private set;
        }

        /// <summary>
        /// PaleGreen color (R:152,G:251,B:152,A:255).
        /// </summary>
        public static Color PaleGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// PaleTurquoise color (R:175,G:238,B:238,A:255).
        /// </summary>
        public static Color PaleTurquoise
        {
            get;
            private set;
        }
        /// <summary>
        /// PaleVioletRed color (R:219,G:112,B:147,A:255).
        /// </summary>
        public static Color PaleVioletRed
        {
            get;
            private set;
        }

        /// <summary>
        /// PapayaWhip color (R:255,G:239,B:213,A:255).
        /// </summary>
        public static Color PapayaWhip
        {
            get;
            private set;
        }

        /// <summary>
        /// PeachPuff color (R:255,G:218,B:185,A:255).
        /// </summary>
        public static Color PeachPuff
        {
            get;
            private set;
        }

        /// <summary>
        /// Peru color (R:205,G:133,B:63,A:255).
        /// </summary>
        public static Color Peru
        {
            get;
            private set;
        }

        /// <summary>
        /// Pink color (R:255,G:192,B:203,A:255).
        /// </summary>
        public static Color Pink
        {
            get;
            private set;
        }

        /// <summary>
        /// Plum color (R:221,G:160,B:221,A:255).
        /// </summary>
        public static Color Plum
        {
            get;
            private set;
        }

        /// <summary>
        /// PowderBlue color (R:176,G:224,B:230,A:255).
        /// </summary>
        public static Color PowderBlue
        {
            get;
            private set;
        }

        /// <summary>
        ///  Purple color (R:128,G:0,B:128,A:255).
        /// </summary>
        public static Color Purple
        {
            get;
            private set;
        }

        /// <summary>
        /// Red color (R:255,G:0,B:0,A:255).
        /// </summary>
        public static Color Red
        {
            get;
            private set;
        }

        /// <summary>
        /// RosyBrown color (R:188,G:143,B:143,A:255).
        /// </summary>
        public static Color RosyBrown
        {
            get;
            private set;
        }

        /// <summary>
        /// RoyalBlue color (R:65,G:105,B:225,A:255).
        /// </summary>
        public static Color RoyalBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// SaddleBrown color (R:139,G:69,B:19,A:255).
        /// </summary>
        public static Color SaddleBrown
        {
            get;
            private set;
        }

        /// <summary>
        /// Salmon color (R:250,G:128,B:114,A:255).
        /// </summary>
        public static Color Salmon
        {
            get;
            private set;
        }

        /// <summary>
        /// SandyBrown color (R:244,G:164,B:96,A:255).
        /// </summary>
        public static Color SandyBrown
        {
            get;
            private set;
        }

        /// <summary>
        /// SeaGreen color (R:46,G:139,B:87,A:255).
        /// </summary>
        public static Color SeaGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// SeaShell color (R:255,G:245,B:238,A:255).
        /// </summary>
        public static Color SeaShell
        {
            get;
            private set;
        }

        /// <summary>
        /// Sienna color (R:160,G:82,B:45,A:255).
        /// </summary>
        public static Color Sienna
        {
            get;
            private set;
        }

        /// <summary>
        /// Silver color (R:192,G:192,B:192,A:255).
        /// </summary>
        public static Color Silver
        {
            get;
            private set;
        }

        /// <summary>
        /// SkyBlue color (R:135,G:206,B:235,A:255).
        /// </summary>
        public static Color SkyBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// SlateBlue color (R:106,G:90,B:205,A:255).
        /// </summary>
        public static Color SlateBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// SlateGray color (R:112,G:128,B:144,A:255).
        /// </summary>
        public static Color SlateGray
        {
            get;
            private set;
        }

        /// <summary>
        /// Snow color (R:255,G:250,B:250,A:255).
        /// </summary>
        public static Color Snow
        {
            get;
            private set;
        }

        /// <summary>
        /// SpringGreen color (R:0,G:255,B:127,A:255).
        /// </summary>
        public static Color SpringGreen
        {
            get;
            private set;
        }

        /// <summary>
        /// SteelBlue color (R:70,G:130,B:180,A:255).
        /// </summary>
        public static Color SteelBlue
        {
            get;
            private set;
        }

        /// <summary>
        /// Tan color (R:210,G:180,B:140,A:255).
        /// </summary>
        public static Color Tan
        {
            get;
            private set;
        }

        /// <summary>
        /// Teal color (R:0,G:128,B:128,A:255).
        /// </summary>
        public static Color Teal
        {
            get;
            private set;
        }

        /// <summary>
        /// Thistle color (R:216,G:191,B:216,A:255).
        /// </summary>
        public static Color Thistle
        {
            get;
            private set;
        }

        /// <summary>
        /// Tomato color (R:255,G:99,B:71,A:255).
        /// </summary>
        public static Color Tomato
        {
            get;
            private set;
        }

        /// <summary>
        /// Turquoise color (R:64,G:224,B:208,A:255).
        /// </summary>
        public static Color Turquoise
        {
            get;
            private set;
        }

        /// <summary>
        /// Violet color (R:238,G:130,B:238,A:255).
        /// </summary>
        public static Color Violet
        {
            get;
            private set;
        }

        /// <summary>
        /// Wheat color (R:245,G:222,B:179,A:255).
        /// </summary>
        public static Color Wheat
        {
            get;
            private set;
        }

        /// <summary>
        /// White color (R:255,G:255,B:255,A:255).
        /// </summary>
        public static Color White
        {
            get;
            private set;
        }

        /// <summary>
        /// WhiteSmoke color (R:245,G:245,B:245,A:255).
        /// </summary>
        public static Color WhiteSmoke
        {
            get;
            private set;
        }

        /// <summary>
        /// Yellow color (R:255,G:255,B:0,A:255).
        /// </summary>
        public static Color Yellow
        {
            get;
            private set;
        }

        /// <summary>
        /// YellowGreen color (R:154,G:205,B:50,A:255).
        /// </summary>
        public static Color YellowGreen
        {
            get;
            private set;
        }
        #endregion
    }

    public static class RectHelper
    {
        public static bool Contains(this IntRect rect, IntRect value)
        {
            return ((((rect.Left <= value.Left) && ((value.Left + value.Width) <= (rect.Left + rect.Width))) && (rect.Top <= value.Top)) && ((value.Top + value.Height) <= (rect.Top + rect.Height)));
        }
    }
    

    //namespace SFML.Utils
    //    {
    //        using System;
    //        using SFML.Graphics;
    //        using SFML.Window;
    //        /// <summary>
    //        /// Functions that provides color/texture rectangle data from tile map (or other source)
    //        /// </summary>
    //        public delegate void TileProvider(int x, int y, int layer, out Color color, out IntRect rec);

    //        /// <summary>
    //        /// Fast and universal renderer of tilemaps
    //        /// </summary>
    //        class MapRenderer : Drawable
    //        {
    //            private readonly float TileSize;
    //            public readonly int Layers;

    //            private int height;
    //            private int width;

    //            /// <summary>
    //            /// Points to the tile in the top left corner
    //            /// </summary>
    //            private Vector2i offset;
    //            private Vertex[] vertices;

    //            /// <summary>
    //            /// Provides Color and Texture Source from tile map
    //            /// </summary>
    //            private TileProvider provider;

    //            /// <summary>
    //            /// Holds spritesheet
    //            /// </summary>
    //            private Texture texture;

    //            /// <param name="texture">Spritesheet</param>
    //            /// <param name="provider">Accesor to tilemap data</param>
    //            /// <param name="tileSize">Size of one tile</param>
    //            /// <param name="layers">Numbers of layers</param>
    //            public MapRenderer(Texture texture, TileProvider provider, float tileSize = 16, int layers = 1)
    //            {
    //                if (provider == null || layers <= 0) throw new ArgumentException();
    //                this.provider = provider;

    //                TileSize = tileSize;
    //                Layers = layers;

    //                vertices = new Vertex[0];
    //                this.texture = texture;

    //            }

    //            /// <summary>
    //            /// Redraws whole screen
    //            /// </summary>
    //            public void Refresh()
    //            {
    //                RefreshLocal(0, 0, width, height);
    //            }

    //            private void RefreshLocal(int left, int top, int right, int bottom)
    //            {
    //                for (var y = top; y < bottom; y++)
    //                    for (var x = left; x < right; x++)
    //                    {
    //                        Refresh(x + offset.X, y + offset.Y);
    //                    }
    //            }

    //            /// <summary>
    //            /// Ensures that vertex array has enough space
    //            /// </summary>
    //            /// <param name="v">Size of the visible area</param>
    //            private void SetSize(Vector2f v)
    //            {
    //                var w = (int)(v.X / TileSize) + 2;
    //                var h = (int)(v.Y / TileSize) + 2;
    //                if (w == width && h == height) return;

    //                width = w;
    //                height = h;

    //                vertices = new Vertex[width * height * 4 * Layers];
    //                Refresh();
    //            }

    //            /// <summary>
    //            /// Sets offset
    //            /// </summary>
    //            /// <param name="v">World position of top left corner of the screen</param>
    //            private void SetCorner(Vector2f v)
    //            {
    //                var tile = GetTile(v);
    //                var dif = tile - offset;
    //                if (dif.X == 0 && dif.Y == 0) return;
    //                offset = tile;

    //                if (Math.Abs(dif.X) > width / 4 || Math.Abs(dif.Y) > height / 4)
    //                {
    //                    //Refresh everyting if difference is too big
    //                    Refresh();
    //                    return;
    //                }

    //                //Refresh only tiles that appeared since last update

    //                if (dif.X > 0) RefreshLocal(width - dif.X, 0, width, height);
    //                else RefreshLocal(0, 0, -dif.X, height);

    //                if (dif.Y > 0) RefreshLocal(0, height - dif.Y, width, height);
    //                else RefreshLocal(0, 0, width, -dif.Y);
    //            }

    //            /// <summary>
    //            /// Transforms from world size to to tile that is under that position
    //            /// </summary>
    //            private Vector2i GetTile(Vector2f pos)
    //            {
    //                var x = (int)(pos.X / TileSize);
    //                var y = (int)(pos.Y / TileSize);
    //                if (pos.X < 0) x--;
    //                if (pos.Y < 0) y--;
    //                return new Vector2i(x, y);
    //            }

    //            /// <summary>
    //            /// Redraws one tile
    //            /// </summary>
    //            /// <param name="x">X coord of the tile</param>
    //            /// <param name="y">Y coord of the tile</param>
    //            public void Refresh(int x, int y)
    //            {
    //                if (x < offset.X || x >= offset.X + width || y < offset.Y || y >= offset.Y + height)
    //                    return; //check if tile is visible

    //                //vertices works like 2d ring buffer
    //                var vx = x % width;
    //                var vy = y % height;
    //                if (vx < 0) vx += width;
    //                if (vy < 0) vy += height;

    //                var index = (vx + vy * width) * 4 * Layers;
    //                var rec = new FloatRect(x * TileSize, y * TileSize, TileSize, TileSize);

    //                for (int i = 0; i < Layers; i++)
    //                {
    //                    Color color;
    //                    IntRect src;
    //                    provider(x, y, i, out color, out src);

    //                    Draw(index, rec, src, color);
    //                    index += 4;
    //                }
    //            }

    //            /// <summary>
    //            /// Inserts color and texture data into vertex array
    //            /// </summary>
    //            private unsafe void Draw(int index, FloatRect rec, IntRect src, Color color)
    //            {
    //                fixed (Vertex* fptr = vertices)
    //                {
    //                    //use pointers to avoid array bound checks (optimization)

    //                    var ptr = fptr + index;

    //                    ptr->Position.X = rec.Left;
    //                    ptr->Position.Y = rec.Top;
    //                    ptr->TexCoords.X = src.Left;
    //                    ptr->TexCoords.Y = src.Top;
    //                    ptr->Color = color;
    //                    ptr++;

    //                    ptr->Position.X = rec.Left + rec.Width;
    //                    ptr->Position.Y = rec.Top;
    //                    ptr->TexCoords.X = src.Left + src.Width;
    //                    ptr->TexCoords.Y = src.Top;
    //                    ptr->Color = color;
    //                    ptr++;

    //                    ptr->Position.X = rec.Left + rec.Width;
    //                    ptr->Position.Y = rec.Top + rec.Height;
    //                    ptr->TexCoords.X = src.Left + src.Width;
    //                    ptr->TexCoords.Y = src.Top + src.Height;
    //                    ptr->Color = color;
    //                    ptr++;

    //                    ptr->Position.X = rec.Left;
    //                    ptr->Position.Y = rec.Top + rec.Height;
    //                    ptr->TexCoords.X = src.Left;
    //                    ptr->TexCoords.Y = src.Top + src.Height;
    //                    ptr->Color = color;
    //                }
    //            }

    //            /// <summary>
    //            /// Update offset (based on Target's position) and draw it
    //            /// </summary>
    //            public void Draw(RenderTarget rt, RenderStates states)
    //            {
    //                var view = rt.GetView();
    //                states.Texture = texture;
    //                SetSize(view.Size);
    //                SetCorner(rt.MapPixelToCoords(new Vector2i()));

    //                rt.Draw(vertices, PrimitiveType.Quads, states);
    //            }
    //        }
    //    }
}
#endif