// Decompiled with JetBrains decompiler
// Type: SharpDX.Color
// Assembly: SharpDX.Mathematics, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 4A855504-AAAB-4FF4-A38C-44A47D7C4372

using SharpDX.Mathematics.Interop;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using SharpDX;

namespace FadeGE
{
    /// <summary>
    /// Represents a 32-bit color (4 bytes) in the form of RGBA (in byte order: R, G, B, A).
    /// 
    /// </summary>
    /// 
    /// <summary>
    /// List of predefined <see cref="T:SharpDX.Color"/>.
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct Color : IEquatable<Color>, IFormattable
    {
        /// <summary>
        /// Zero color.
        /// 
        /// </summary>
        public static readonly Color Zero = Color.FromBgra(0);
        /// <summary>
        /// Transparent color.
        /// 
        /// </summary>
        public static readonly Color Transparent = Color.FromBgra(0);
        /// <summary>
        /// AliceBlue color.
        /// 
        /// </summary>
        public static readonly Color AliceBlue = Color.FromBgra(4293982463U);
        /// <summary>
        /// AntiqueWhite color.
        /// 
        /// </summary>
        public static readonly Color AntiqueWhite = Color.FromBgra(4294634455U);
        /// <summary>
        /// Aqua color.
        /// 
        /// </summary>
        public static readonly Color Aqua = Color.FromBgra(4278255615U);
        /// <summary>
        /// Aquamarine color.
        /// 
        /// </summary>
        public static readonly Color Aquamarine = Color.FromBgra(4286578644U);
        /// <summary>
        /// Azure color.
        /// 
        /// </summary>
        public static readonly Color Azure = Color.FromBgra(4293984255U);
        /// <summary>
        /// Beige color.
        /// 
        /// </summary>
        public static readonly Color Beige = Color.FromBgra(4294309340U);
        /// <summary>
        /// Bisque color.
        /// 
        /// </summary>
        public static readonly Color Bisque = Color.FromBgra(4294960324U);
        /// <summary>
        /// Black color.
        /// 
        /// </summary>
        public static readonly Color Black = Color.FromBgra(4278190080U);
        /// <summary>
        /// BlanchedAlmond color.
        /// 
        /// </summary>
        public static readonly Color BlanchedAlmond = Color.FromBgra(4294962125U);
        /// <summary>
        /// Blue color.
        /// 
        /// </summary>
        public static readonly Color Blue = Color.FromBgra(4278190335U);
        /// <summary>
        /// BlueViolet color.
        /// 
        /// </summary>
        public static readonly Color BlueViolet = Color.FromBgra(4287245282U);
        /// <summary>
        /// Brown color.
        /// 
        /// </summary>
        public static readonly Color Brown = Color.FromBgra(4289014314U);
        /// <summary>
        /// BurlyWood color.
        /// 
        /// </summary>
        public static readonly Color BurlyWood = Color.FromBgra(4292786311U);
        /// <summary>
        /// CadetBlue color.
        /// 
        /// </summary>
        public static readonly Color CadetBlue = Color.FromBgra(4284456608U);
        /// <summary>
        /// Chartreuse color.
        /// 
        /// </summary>
        public static readonly Color Chartreuse = Color.FromBgra(4286578432U);
        /// <summary>
        /// Chocolate color.
        /// 
        /// </summary>
        public static readonly Color Chocolate = Color.FromBgra(4291979550U);
        /// <summary>
        /// Coral color.
        /// 
        /// </summary>
        public static readonly Color Coral = Color.FromBgra(4294934352U);
        /// <summary>
        /// CornflowerBlue color.
        /// 
        /// </summary>
        public static readonly Color CornflowerBlue = Color.FromBgra(4284782061U);
        /// <summary>
        /// Cornsilk color.
        /// 
        /// </summary>
        public static readonly Color Cornsilk = Color.FromBgra(4294965468U);
        /// <summary>
        /// Crimson color.
        /// 
        /// </summary>
        public static readonly Color Crimson = Color.FromBgra(4292613180U);
        /// <summary>
        /// Cyan color.
        /// 
        /// </summary>
        public static readonly Color Cyan = Color.FromBgra(4278255615U);
        /// <summary>
        /// DarkBlue color.
        /// 
        /// </summary>
        public static readonly Color DarkBlue = Color.FromBgra(4278190219U);
        /// <summary>
        /// DarkCyan color.
        /// 
        /// </summary>
        public static readonly Color DarkCyan = Color.FromBgra(4278225803U);
        /// <summary>
        /// DarkGoldenrod color.
        /// 
        /// </summary>
        public static readonly Color DarkGoldenrod = Color.FromBgra(4290283019U);
        /// <summary>
        /// DarkGray color.
        /// 
        /// </summary>
        public static readonly Color DarkGray = Color.FromBgra(4289309097U);
        /// <summary>
        /// DarkGreen color.
        /// 
        /// </summary>
        public static readonly Color DarkGreen = Color.FromBgra(4278215680U);
        /// <summary>
        /// DarkKhaki color.
        /// 
        /// </summary>
        public static readonly Color DarkKhaki = Color.FromBgra(4290623339U);
        /// <summary>
        /// DarkMagenta color.
        /// 
        /// </summary>
        public static readonly Color DarkMagenta = Color.FromBgra(4287299723U);
        /// <summary>
        /// DarkOliveGreen color.
        /// 
        /// </summary>
        public static readonly Color DarkOliveGreen = Color.FromBgra(4283788079U);
        /// <summary>
        /// DarkOrange color.
        /// 
        /// </summary>
        public static readonly Color DarkOrange = Color.FromBgra(4294937600U);
        /// <summary>
        /// DarkOrchid color.
        /// 
        /// </summary>
        public static readonly Color DarkOrchid = Color.FromBgra(4288230092U);
        /// <summary>
        /// DarkRed color.
        /// 
        /// </summary>
        public static readonly Color DarkRed = Color.FromBgra(4287299584U);
        /// <summary>
        /// DarkSalmon color.
        /// 
        /// </summary>
        public static readonly Color DarkSalmon = Color.FromBgra(4293498490U);
        /// <summary>
        /// DarkSeaGreen color.
        /// 
        /// </summary>
        public static readonly Color DarkSeaGreen = Color.FromBgra(4287609995U);
        /// <summary>
        /// DarkSlateBlue color.
        /// 
        /// </summary>
        public static readonly Color DarkSlateBlue = Color.FromBgra(4282924427U);
        /// <summary>
        /// DarkSlateGray color.
        /// 
        /// </summary>
        public static readonly Color DarkSlateGray = Color.FromBgra(4281290575U);
        /// <summary>
        /// DarkTurquoise color.
        /// 
        /// </summary>
        public static readonly Color DarkTurquoise = Color.FromBgra(4278243025U);
        /// <summary>
        /// DarkViolet color.
        /// 
        /// </summary>
        public static readonly Color DarkViolet = Color.FromBgra(4287889619U);
        /// <summary>
        /// DeepPink color.
        /// 
        /// </summary>
        public static readonly Color DeepPink = Color.FromBgra(4294907027U);
        /// <summary>
        /// DeepSkyBlue color.
        /// 
        /// </summary>
        public static readonly Color DeepSkyBlue = Color.FromBgra(4278239231U);
        /// <summary>
        /// DimGray color.
        /// 
        /// </summary>
        public static readonly Color DimGray = Color.FromBgra(4285098345U);
        /// <summary>
        /// DodgerBlue color.
        /// 
        /// </summary>
        public static readonly Color DodgerBlue = Color.FromBgra(4280193279U);
        /// <summary>
        /// Firebrick color.
        /// 
        /// </summary>
        public static readonly Color Firebrick = Color.FromBgra(4289864226U);
        /// <summary>
        /// FloralWhite color.
        /// 
        /// </summary>
        public static readonly Color FloralWhite = Color.FromBgra(4294966000U);
        /// <summary>
        /// ForestGreen color.
        /// 
        /// </summary>
        public static readonly Color ForestGreen = Color.FromBgra(4280453922U);
        /// <summary>
        /// Fuchsia color.
        /// 
        /// </summary>
        public static readonly Color Fuchsia = Color.FromBgra(4294902015U);
        /// <summary>
        /// Gainsboro color.
        /// 
        /// </summary>
        public static readonly Color Gainsboro = Color.FromBgra(4292664540U);
        /// <summary>
        /// GhostWhite color.
        /// 
        /// </summary>
        public static readonly Color GhostWhite = Color.FromBgra(4294506751U);
        /// <summary>
        /// Gold color.
        /// 
        /// </summary>
        public static readonly Color Gold = Color.FromBgra(4294956800U);
        /// <summary>
        /// Goldenrod color.
        /// 
        /// </summary>
        public static readonly Color Goldenrod = Color.FromBgra(4292519200U);
        /// <summary>
        /// Gray color.
        /// 
        /// </summary>
        public static readonly Color Gray = Color.FromBgra(4286611584U);
        /// <summary>
        /// Green color.
        /// 
        /// </summary>
        public static readonly Color Green = Color.FromBgra(4278222848U);
        /// <summary>
        /// GreenYellow color.
        /// 
        /// </summary>
        public static readonly Color GreenYellow = Color.FromBgra(4289593135U);
        /// <summary>
        /// Honeydew color.
        /// 
        /// </summary>
        public static readonly Color Honeydew = Color.FromBgra(4293984240U);
        /// <summary>
        /// HotPink color.
        /// 
        /// </summary>
        public static readonly Color HotPink = Color.FromBgra(4294928820U);
        /// <summary>
        /// IndianRed color.
        /// 
        /// </summary>
        public static readonly Color IndianRed = Color.FromBgra(4291648604U);
        /// <summary>
        /// Indigo color.
        /// 
        /// </summary>
        public static readonly Color Indigo = Color.FromBgra(4283105410U);
        /// <summary>
        /// Ivory color.
        /// 
        /// </summary>
        public static readonly Color Ivory = Color.FromBgra(4294967280U);
        /// <summary>
        /// Khaki color.
        /// 
        /// </summary>
        public static readonly Color Khaki = Color.FromBgra(4293977740U);
        /// <summary>
        /// Lavender color.
        /// 
        /// </summary>
        public static readonly Color Lavender = Color.FromBgra(4293322490U);
        /// <summary>
        /// LavenderBlush color.
        /// 
        /// </summary>
        public static readonly Color LavenderBlush = Color.FromBgra(4294963445U);
        /// <summary>
        /// LawnGreen color.
        /// 
        /// </summary>
        public static readonly Color LawnGreen = Color.FromBgra(4286381056U);
        /// <summary>
        /// LemonChiffon color.
        /// 
        /// </summary>
        public static readonly Color LemonChiffon = Color.FromBgra(4294965965U);
        /// <summary>
        /// LightBlue color.
        /// 
        /// </summary>
        public static readonly Color LightBlue = Color.FromBgra(4289583334U);
        /// <summary>
        /// LightCoral color.
        /// 
        /// </summary>
        public static readonly Color LightCoral = Color.FromBgra(4293951616U);
        /// <summary>
        /// LightCyan color.
        /// 
        /// </summary>
        public static readonly Color LightCyan = Color.FromBgra(4292935679U);
        /// <summary>
        /// LightGoldenrodYellow color.
        /// 
        /// </summary>
        public static readonly Color LightGoldenrodYellow = Color.FromBgra(4294638290U);
        /// <summary>
        /// LightGray color.
        /// 
        /// </summary>
        public static readonly Color LightGray = Color.FromBgra(4292072403U);
        /// <summary>
        /// LightGreen color.
        /// 
        /// </summary>
        public static readonly Color LightGreen = Color.FromBgra(4287688336U);
        /// <summary>
        /// LightPink color.
        /// 
        /// </summary>
        public static readonly Color LightPink = Color.FromBgra(4294948545U);
        /// <summary>
        /// LightSalmon color.
        /// 
        /// </summary>
        public static readonly Color LightSalmon = Color.FromBgra(4294942842U);
        /// <summary>
        /// LightSeaGreen color.
        /// 
        /// </summary>
        public static readonly Color LightSeaGreen = Color.FromBgra(4280332970U);
        /// <summary>
        /// LightSkyBlue color.
        /// 
        /// </summary>
        public static readonly Color LightSkyBlue = Color.FromBgra(4287090426U);
        /// <summary>
        /// LightSlateGray color.
        /// 
        /// </summary>
        public static readonly Color LightSlateGray = Color.FromBgra(4286023833U);
        /// <summary>
        /// LightSteelBlue color.
        /// 
        /// </summary>
        public static readonly Color LightSteelBlue = Color.FromBgra(4289774814U);
        /// <summary>
        /// LightYellow color.
        /// 
        /// </summary>
        public static readonly Color LightYellow = Color.FromBgra(4294967264U);
        /// <summary>
        /// Lime color.
        /// 
        /// </summary>
        public static readonly Color Lime = Color.FromBgra(4278255360U);
        /// <summary>
        /// LimeGreen color.
        /// 
        /// </summary>
        public static readonly Color LimeGreen = Color.FromBgra(4281519410U);
        /// <summary>
        /// Linen color.
        /// 
        /// </summary>
        public static readonly Color Linen = Color.FromBgra(4294635750U);
        /// <summary>
        /// Magenta color.
        /// 
        /// </summary>
        public static readonly Color Magenta = Color.FromBgra(4294902015U);
        /// <summary>
        /// Maroon color.
        /// 
        /// </summary>
        public static readonly Color Maroon = Color.FromBgra(4286578688U);
        /// <summary>
        /// MediumAquamarine color.
        /// 
        /// </summary>
        public static readonly Color MediumAquamarine = Color.FromBgra(4284927402U);
        /// <summary>
        /// MediumBlue color.
        /// 
        /// </summary>
        public static readonly Color MediumBlue = Color.FromBgra(4278190285U);
        /// <summary>
        /// MediumOrchid color.
        /// 
        /// </summary>
        public static readonly Color MediumOrchid = Color.FromBgra(4290401747U);
        /// <summary>
        /// MediumPurple color.
        /// 
        /// </summary>
        public static readonly Color MediumPurple = Color.FromBgra(4287852763U);
        /// <summary>
        /// MediumSeaGreen color.
        /// 
        /// </summary>
        public static readonly Color MediumSeaGreen = Color.FromBgra(4282168177U);
        /// <summary>
        /// MediumSlateBlue color.
        /// 
        /// </summary>
        public static readonly Color MediumSlateBlue = Color.FromBgra(4286277870U);
        /// <summary>
        /// MediumSpringGreen color.
        /// 
        /// </summary>
        public static readonly Color MediumSpringGreen = Color.FromBgra(4278254234U);
        /// <summary>
        /// MediumTurquoise color.
        /// 
        /// </summary>
        public static readonly Color MediumTurquoise = Color.FromBgra(4282962380U);
        /// <summary>
        /// MediumVioletRed color.
        /// 
        /// </summary>
        public static readonly Color MediumVioletRed = Color.FromBgra(4291237253U);
        /// <summary>
        /// MidnightBlue color.
        /// 
        /// </summary>
        public static readonly Color MidnightBlue = Color.FromBgra(4279834992U);
        /// <summary>
        /// MintCream color.
        /// 
        /// </summary>
        public static readonly Color MintCream = Color.FromBgra(4294311930U);
        /// <summary>
        /// MistyRose color.
        /// 
        /// </summary>
        public static readonly Color MistyRose = Color.FromBgra(4294960353U);
        /// <summary>
        /// Moccasin color.
        /// 
        /// </summary>
        public static readonly Color Moccasin = Color.FromBgra(4294960309U);
        /// <summary>
        /// NavajoWhite color.
        /// 
        /// </summary>
        public static readonly Color NavajoWhite = Color.FromBgra(4294958765U);
        /// <summary>
        /// Navy color.
        /// 
        /// </summary>
        public static readonly Color Navy = Color.FromBgra(4278190208U);
        /// <summary>
        /// OldLace color.
        /// 
        /// </summary>
        public static readonly Color OldLace = Color.FromBgra(4294833638U);
        /// <summary>
        /// Olive color.
        /// 
        /// </summary>
        public static readonly Color Olive = Color.FromBgra(4286611456U);
        /// <summary>
        /// OliveDrab color.
        /// 
        /// </summary>
        public static readonly Color OliveDrab = Color.FromBgra(4285238819U);
        /// <summary>
        /// Orange color.
        /// 
        /// </summary>
        public static readonly Color Orange = Color.FromBgra(4294944000U);
        /// <summary>
        /// OrangeRed color.
        /// 
        /// </summary>
        public static readonly Color OrangeRed = Color.FromBgra(4294919424U);
        /// <summary>
        /// Orchid color.
        /// 
        /// </summary>
        public static readonly Color Orchid = Color.FromBgra(4292505814U);
        /// <summary>
        /// PaleGoldenrod color.
        /// 
        /// </summary>
        public static readonly Color PaleGoldenrod = Color.FromBgra(4293847210U);
        /// <summary>
        /// PaleGreen color.
        /// 
        /// </summary>
        public static readonly Color PaleGreen = Color.FromBgra(4288215960U);
        /// <summary>
        /// PaleTurquoise color.
        /// 
        /// </summary>
        public static readonly Color PaleTurquoise = Color.FromBgra(4289720046U);
        /// <summary>
        /// PaleVioletRed color.
        /// 
        /// </summary>
        public static readonly Color PaleVioletRed = Color.FromBgra(4292571283U);
        /// <summary>
        /// PapayaWhip color.
        /// 
        /// </summary>
        public static readonly Color PapayaWhip = Color.FromBgra(4294963157U);
        /// <summary>
        /// PeachPuff color.
        /// 
        /// </summary>
        public static readonly Color PeachPuff = Color.FromBgra(4294957753U);
        /// <summary>
        /// Peru color.
        /// 
        /// </summary>
        public static readonly Color Peru = Color.FromBgra(4291659071U);
        /// <summary>
        /// Pink color.
        /// 
        /// </summary>
        public static readonly Color Pink = Color.FromBgra(4294951115U);
        /// <summary>
        /// Plum color.
        /// 
        /// </summary>
        public static readonly Color Plum = Color.FromBgra(4292714717U);
        /// <summary>
        /// PowderBlue color.
        /// 
        /// </summary>
        public static readonly Color PowderBlue = Color.FromBgra(4289781990U);
        /// <summary>
        /// Purple color.
        /// 
        /// </summary>
        public static readonly Color Purple = Color.FromBgra(4286578816U);
        /// <summary>
        /// Red color.
        /// 
        /// </summary>
        public static readonly Color Red = Color.FromBgra(4294901760U);
        /// <summary>
        /// RosyBrown color.
        /// 
        /// </summary>
        public static readonly Color RosyBrown = Color.FromBgra(4290547599U);
        /// <summary>
        /// RoyalBlue color.
        /// 
        /// </summary>
        public static readonly Color RoyalBlue = Color.FromBgra(4282477025U);
        /// <summary>
        /// SaddleBrown color.
        /// 
        /// </summary>
        public static readonly Color SaddleBrown = Color.FromBgra(4287317267U);
        /// <summary>
        /// Salmon color.
        /// 
        /// </summary>
        public static readonly Color Salmon = Color.FromBgra(4294606962U);
        /// <summary>
        /// SandyBrown color.
        /// 
        /// </summary>
        public static readonly Color SandyBrown = Color.FromBgra(4294222944U);
        /// <summary>
        /// SeaGreen color.
        /// 
        /// </summary>
        public static readonly Color SeaGreen = Color.FromBgra(4281240407U);
        /// <summary>
        /// SeaShell color.
        /// 
        /// </summary>
        public static readonly Color SeaShell = Color.FromBgra(4294964718U);
        /// <summary>
        /// Sienna color.
        /// 
        /// </summary>
        public static readonly Color Sienna = Color.FromBgra(4288696877U);
        /// <summary>
        /// Silver color.
        /// 
        /// </summary>
        public static readonly Color Silver = Color.FromBgra(4290822336U);
        /// <summary>
        /// SkyBlue color.
        /// 
        /// </summary>
        public static readonly Color SkyBlue = Color.FromBgra(4287090411U);
        /// <summary>
        /// SlateBlue color.
        /// 
        /// </summary>
        public static readonly Color SlateBlue = Color.FromBgra(4285160141U);
        /// <summary>
        /// SlateGray color.
        /// 
        /// </summary>
        public static readonly Color SlateGray = Color.FromBgra(4285563024U);
        /// <summary>
        /// Snow color.
        /// 
        /// </summary>
        public static readonly Color Snow = Color.FromBgra(4294966010U);
        /// <summary>
        /// SpringGreen color.
        /// 
        /// </summary>
        public static readonly Color SpringGreen = Color.FromBgra(4278255487U);
        /// <summary>
        /// SteelBlue color.
        /// 
        /// </summary>
        public static readonly Color SteelBlue = Color.FromBgra(4282811060U);
        /// <summary>
        /// Tan color.
        /// 
        /// </summary>
        public static readonly Color Tan = Color.FromBgra(4291998860U);
        /// <summary>
        /// Teal color.
        /// 
        /// </summary>
        public static readonly Color Teal = Color.FromBgra(4278222976U);
        /// <summary>
        /// Thistle color.
        /// 
        /// </summary>
        public static readonly Color Thistle = Color.FromBgra(4292394968U);
        /// <summary>
        /// Tomato color.
        /// 
        /// </summary>
        public static readonly Color Tomato = Color.FromBgra(4294927175U);
        /// <summary>
        /// Turquoise color.
        /// 
        /// </summary>
        public static readonly Color Turquoise = Color.FromBgra(4282441936U);
        /// <summary>
        /// Violet color.
        /// 
        /// </summary>
        public static readonly Color Violet = Color.FromBgra(4293821166U);
        /// <summary>
        /// Wheat color.
        /// 
        /// </summary>
        public static readonly Color Wheat = Color.FromBgra(4294303411U);
        /// <summary>
        /// White color.
        /// 
        /// </summary>
        public static readonly Color White = Color.FromBgra(uint.MaxValue);
        /// <summary>
        /// WhiteSmoke color.
        /// 
        /// </summary>
        public static readonly Color WhiteSmoke = Color.FromBgra(4294309365U);
        /// <summary>
        /// Yellow color.
        /// 
        /// </summary>
        public static readonly Color Yellow = Color.FromBgra(4294967040U);
        /// <summary>
        /// YellowGreen color.
        /// 
        /// </summary>
        public static readonly Color YellowGreen = Color.FromBgra(4288335154U);
        private const string toStringFormat = "A:{0} R:{1} G:{2} B:{3}";
        /// <summary>
        /// The red component of the color.
        /// 
        /// </summary>
        public byte R;
        /// <summary>
        /// The green component of the color.
        /// 
        /// </summary>
        public byte G;
        /// <summary>
        /// The blue component of the color.
        /// 
        /// </summary>
        public byte B;
        /// <summary>
        /// The alpha component of the color.
        /// 
        /// </summary>
        public byte A;

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The value of the alpha, red, green, or blue component, depending on the index.
        /// </value>
        /// <param name="index">The index of the component to access. Use 0 for the alpha component, 1 for the red component, 2 for the green component, and 3 for the blue component.</param>
        /// <returns>
        /// The value of the component at the specified index.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Thrown when the <paramref name="index"/> is out of the range [0, 3].</exception>
        public byte this[int index] {
            get {
                switch (index) {
                    case 0:
                        return this.R;
                    case 1:
                        return this.G;
                    case 2:
                        return this.B;
                    case 3:
                        return this.A;
                    default:
                        throw new ArgumentOutOfRangeException("index", "Indices for Color run from 0 to 3, inclusive.");
                }
            }
            set {
                switch (index) {
                    case 0:
                        this.R = value;
                        break;
                    case 1:
                        this.G = value;
                        break;
                    case 2:
                        this.B = value;
                        break;
                    case 3:
                        this.A = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("index", "Indices for Color run from 0 to 3, inclusive.");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Color(byte value) {
            this.A = this.R = this.G = this.B = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Color(float value) {
            this.A = this.R = this.G = this.B = Color.ToByte(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="red">The red component of the color.</param><param name="green">The green component of the color.</param><param name="blue">The blue component of the color.</param><param name="alpha">The alpha component of the color.</param>
        public Color(byte red, byte green, byte blue, byte alpha) {
            this.R = red;
            this.G = green;
            this.B = blue;
            this.A = alpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.  Alpha is set to 255.
        /// 
        /// </summary>
        /// <param name="red">The red component of the color.</param><param name="green">The green component of the color.</param><param name="blue">The blue component of the color.</param>
        public Color(byte red, byte green, byte blue) {
            this.R = red;
            this.G = green;
            this.B = blue;
            this.A = byte.MaxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.  Passed values are clamped within byte range.
        /// 
        /// </summary>
        /// <param name="red">The red component of the color.</param><param name="green">The green component of the color.</param><param name="blue">The blue component of the color.</param>
        public Color(int red, int green, int blue, int alpha) {
            this.R = Color.ToByte(red);
            this.G = Color.ToByte(green);
            this.B = Color.ToByte(blue);
            this.A = Color.ToByte(alpha);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.  Alpha is set to 255.  Passed values are clamped within byte range.
        /// 
        /// </summary>
        /// <param name="red">The red component of the color.</param><param name="green">The green component of the color.</param><param name="blue">The blue component of the color.</param>
        public Color(int red, int green, int blue) {
            this = new Color(red, green, blue, (int)byte.MaxValue);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="red">The red component of the color.</param><param name="green">The green component of the color.</param><param name="blue">The blue component of the color.</param><param name="alpha">The alpha component of the color.</param>
        public Color(float red, float green, float blue, float alpha) {
            this.R = Color.ToByte(red);
            this.G = Color.ToByte(green);
            this.B = Color.ToByte(blue);
            this.A = Color.ToByte(alpha);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.  Alpha is set to 255.
        /// 
        /// </summary>
        /// <param name="red">The red component of the color.</param><param name="green">The green component of the color.</param><param name="blue">The blue component of the color.</param>
        public Color(float red, float green, float blue) {
            this.R = Color.ToByte(red);
            this.G = Color.ToByte(green);
            this.B = Color.ToByte(blue);
            this.A = byte.MaxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="value">The red, green, blue, and alpha components of the color.</param>
        public Color(Vector4 value) {
            this.R = Color.ToByte(value.X);
            this.G = Color.ToByte(value.Y);
            this.B = Color.ToByte(value.Z);
            this.A = Color.ToByte(value.W);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="value">The red, green, and blue components of the color.</param><param name="alpha">The alpha component of the color.</param>
        public Color(Vector3 value, float alpha) {
            this.R = Color.ToByte(value.X);
            this.G = Color.ToByte(value.Y);
            this.B = Color.ToByte(value.Z);
            this.A = Color.ToByte(alpha);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct. Alpha is set to 255.
        /// 
        /// </summary>
        /// <param name="value">The red, green, and blue components of the color.</param>
        public Color(Vector3 value) {
            this.R = Color.ToByte(value.X);
            this.G = Color.ToByte(value.Y);
            this.B = Color.ToByte(value.Z);
            this.A = byte.MaxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color(uint rgba) {
            this.A = (byte)(rgba >> 24 & (uint)byte.MaxValue);
            this.B = (byte)(rgba >> 16 & (uint)byte.MaxValue);
            this.G = (byte)(rgba >> 8 & (uint)byte.MaxValue);
            this.R = (byte)(rgba & (uint)byte.MaxValue);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color(int rgba) {
            this.A = (byte)(rgba >> 24 & (int)byte.MaxValue);
            this.B = (byte)(rgba >> 16 & (int)byte.MaxValue);
            this.G = (byte)(rgba >> 8 & (int)byte.MaxValue);
            this.R = (byte)(rgba & (int)byte.MaxValue);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="values">The values to assign to the red, green, and blue, alpha components of the color. This must be an array with four elements.</param><exception cref="T:System.ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception><exception cref="T:System.ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than four elements.</exception>
        public Color(float[] values) {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 4)
                throw new ArgumentOutOfRangeException("values", "There must be four and only four input values for Color.");
            this.R = Color.ToByte(values[0]);
            this.G = Color.ToByte(values[1]);
            this.B = Color.ToByte(values[2]);
            this.A = Color.ToByte(values[3]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.Color"/> struct.
        /// 
        /// </summary>
        /// <param name="values">The values to assign to the alpha, red, green, and blue components of the color. This must be an array with four elements.</param><exception cref="T:System.ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception><exception cref="T:System.ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than four elements.</exception>
        public Color(byte[] values) {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 4)
                throw new ArgumentOutOfRangeException("values", "There must be four and only four input values for Color.");
            this.R = values[0];
            this.G = values[1];
            this.B = values[2];
            this.A = values[3];
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Color"/> to <see cref="T:SharpDX.Color3"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color3(Color value) {
            return value.ToColor3();
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Color"/> to <see cref="T:SharpDX.Vector3"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Vector3(Color value) {
            return new Vector3((float)value.R / (float)byte.MaxValue, (float)value.G / (float)byte.MaxValue, (float)value.B / (float)byte.MaxValue);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Color"/> to <see cref="T:SharpDX.Vector4"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Vector4(Color value) {
            return new Vector4((float)value.R / (float)byte.MaxValue, (float)value.G / (float)byte.MaxValue, (float)value.B / (float)byte.MaxValue, (float)value.A / (float)byte.MaxValue);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="T:SharpDX.Color"/> to <see cref="T:SharpDX.Color4"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Color4(Color value) {
            return value.ToColor4();
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="T:SharpDX.Color"/> to <see cref="T:SharpDX.Mathematics.Interop.RawColor4"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator RawColor4(Color value) {
            return (RawColor4)value.ToColor4();
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="T:SharpDX.Color"/> to <see cref="T:SharpDX.Mathematics.Interop.RawColor4"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator RawColorBGRA(Color value) {
            return new RawColorBGRA(value.B, value.G, value.R, value.A);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="T:SharpDX.Color"/> to nullable <see cref="T:SharpDX.Mathematics.Interop.RawColor4"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator RawColor4?(Color value) {
            return new RawColor4?((RawColor4)value.ToColor4());
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Vector3"/> to <see cref="T:SharpDX.Color"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color(Vector3 value) {
            return new Color(value.X, value.Y, value.Z, 1f);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Color3"/> to <see cref="T:SharpDX.Color"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color(Color3 value) {
            return new Color(value.Red, value.Green, value.Blue, 1f);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Vector4"/> to <see cref="T:SharpDX.Color"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color(Vector4 value) {
            return new Color(value.X, value.Y, value.Z, value.W);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:SharpDX.Color4"/> to <see cref="T:SharpDX.Color"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color(Color4 value) {
            return new Color(value.Red, value.Green, value.Blue, value.Alpha);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:System.Int32"/> to <see cref="T:SharpDX.Color"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// 
        /// </returns>
        public static explicit operator int(Color value) {
            return value.ToRgba();
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="T:System.Int32"/> to <see cref="T:SharpDX.Color"/>.
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// 
        /// </returns>
        public static explicit operator Color(int value) {
            return new Color(value);
        }

        /// <summary>
        /// Adds two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to add.</param><param name="right">The second color to add.</param>
        /// <returns>
        /// The sum of the two colors.
        /// </returns>
        public static Color operator +(Color left, Color right) {
            return new Color((int)left.R + (int)right.R, (int)left.G + (int)right.G, (int)left.B + (int)right.B, (int)left.A + (int)right.A);
        }

        /// <summary>
        /// Assert a color (return it unchanged).
        /// 
        /// </summary>
        /// <param name="value">The color to assert (unchanged).</param>
        /// <returns>
        /// The asserted (unchanged) color.
        /// </returns>
        public static Color operator +(Color value) {
            return value;
        }

        /// <summary>
        /// Subtracts two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to subtract.</param><param name="right">The second color to subtract.</param>
        /// <returns>
        /// The difference of the two colors.
        /// </returns>
        public static Color operator -(Color left, Color right) {
            return new Color((int)left.R - (int)right.R, (int)left.G - (int)right.G, (int)left.B - (int)right.B, (int)left.A - (int)right.A);
        }

        /// <summary>
        /// Negates a color.
        /// 
        /// </summary>
        /// <param name="value">The color to negate.</param>
        /// <returns>
        /// A negated color.
        /// </returns>
        public static Color operator -(Color value) {
            return new Color((int)-value.R, (int)-value.G, (int)-value.B, (int)-value.A);
        }

        /// <summary>
        /// Scales a color.
        /// 
        /// </summary>
        /// <param name="scale">The factor by which to scale the color.</param><param name="value">The color to scale.</param>
        /// <returns>
        /// The scaled color.
        /// </returns>
        public static Color operator *(float scale, Color value) {
            return new Color((byte)((double)value.R * (double)scale), (byte)((double)value.G * (double)scale), (byte)((double)value.B * (double)scale), (byte)((double)value.A * (double)scale));
        }

        /// <summary>
        /// Scales a color.
        /// 
        /// </summary>
        /// <param name="value">The factor by which to scale the color.</param><param name="scale">The color to scale.</param>
        /// <returns>
        /// The scaled color.
        /// </returns>
        public static Color operator *(Color value, float scale) {
            return new Color((byte)((double)value.R * (double)scale), (byte)((double)value.G * (double)scale), (byte)((double)value.B * (double)scale), (byte)((double)value.A * (double)scale));
        }

        /// <summary>
        /// Modulates two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to modulate.</param><param name="right">The second color to modulate.</param>
        /// <returns>
        /// The modulated color.
        /// </returns>
        public static Color operator *(Color left, Color right) {
            return new Color((byte)((double)((int)left.R * (int)right.R) / (double)byte.MaxValue), (byte)((double)((int)left.G * (int)right.G) / (double)byte.MaxValue), (byte)((double)((int)left.B * (int)right.B) / (double)byte.MaxValue), (byte)((double)((int)left.A * (int)right.A) / (double)byte.MaxValue));
        }

        /// <summary>
        /// Tests for equality between two objects.
        /// 
        /// </summary>
        /// <param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="left"/> has the same value as <paramref name="right"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(Color left, Color right) {
            return left.Equals(right);
        }

        /// <summary>
        /// Tests for inequality between two objects.
        /// 
        /// </summary>
        /// <param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="left"/> has a different value than <paramref name="right"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(Color left, Color right) {
            return !left.Equals(right);
        }

        /// <summary>
        /// Converts the color into a packed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A packed integer containing all four color components.
        /// </returns>
        public int ToBgra() {
            return (int)this.B | (int)this.G << 8 | (int)this.R << 16 | (int)this.A << 24;
        }

        /// <summary>
        /// Converts the color into a packed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A packed integer containing all four color components.
        /// </returns>
        public int ToRgba() {
            return (int)this.R | (int)this.G << 8 | (int)this.B << 16 | (int)this.A << 24;
        }

        /// <summary>
        /// Converts the color into a packed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A packed integer containing all four color components.
        /// </returns>
        public int ToAbgr() {
            return (int)this.A | (int)this.B << 8 | (int)this.G << 16 | (int)this.R << 24;
        }

        /// <summary>
        /// Converts the color into a three component vector.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A three component vector containing the red, green, and blue components of the color.
        /// </returns>
        public Vector3 ToVector3() {
            return new Vector3((float)this.R / (float)byte.MaxValue, (float)this.G / (float)byte.MaxValue, (float)this.B / (float)byte.MaxValue);
        }

        /// <summary>
        /// Converts the color into a three component color.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A three component color containing the red, green, and blue components of the color.
        /// </returns>
        public Color3 ToColor3() {
            return new Color3((float)this.R / (float)byte.MaxValue, (float)this.G / (float)byte.MaxValue, (float)this.B / (float)byte.MaxValue);
        }

        /// <summary>
        /// Converts the color into a four component vector.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A four component vector containing all four color components.
        /// </returns>
        public Vector4 ToVector4() {
            return new Vector4((float)this.R / (float)byte.MaxValue, (float)this.G / (float)byte.MaxValue, (float)this.B / (float)byte.MaxValue, (float)this.A / (float)byte.MaxValue);
        }

        /// <summary>
        /// Creates an array containing the elements of the color.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A four-element array containing the components of the color in RGBA order.
        /// </returns>
        public byte[] ToArray() {
            return new byte[4]
      {
        this.R,
        this.G,
        this.B,
        this.A
      };
        }

        /// <summary>
        /// Gets the brightness.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Hue-Saturation-Brightness (HSB) saturation for this <see cref="T:SharpDX.Color"/>
        /// </returns>
        public float GetBrightness() {
            float num1 = (float)this.R / (float)byte.MaxValue;
            float num2 = (float)this.G / (float)byte.MaxValue;
            float num3 = (float)this.B / (float)byte.MaxValue;
            float num4 = num1;
            float num5 = num1;
            if ((double)num2 > (double)num4)
                num4 = num2;
            if ((double)num3 > (double)num4)
                num4 = num3;
            if ((double)num2 < (double)num5)
                num5 = num2;
            if ((double)num3 < (double)num5)
                num5 = num3;
            return (float)(((double)num4 + (double)num5) / 2.0);
        }

        /// <summary>
        /// Gets the hue.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Hue-Saturation-Brightness (HSB) saturation for this <see cref="T:SharpDX.Color"/>
        /// </returns>
        public float GetHue() {
            if ((int)this.R == (int)this.G && (int)this.G == (int)this.B)
                return 0.0f;
            float num1 = (float)this.R / (float)byte.MaxValue;
            float num2 = (float)this.G / (float)byte.MaxValue;
            float num3 = (float)this.B / (float)byte.MaxValue;
            float num4 = 0.0f;
            float num5 = num1;
            float num6 = num1;
            if ((double)num2 > (double)num5)
                num5 = num2;
            if ((double)num3 > (double)num5)
                num5 = num3;
            if ((double)num2 < (double)num6)
                num6 = num2;
            if ((double)num3 < (double)num6)
                num6 = num3;
            float num7 = num5 - num6;
            if ((double)num1 == (double)num5)
                num4 = (num2 - num3) / num7;
            else if ((double)num2 == (double)num5)
                num4 = (float)(2.0 + ((double)num3 - (double)num1) / (double)num7);
            else if ((double)num3 == (double)num5)
                num4 = (float)(4.0 + ((double)num1 - (double)num2) / (double)num7);
            float num8 = num4 * 60f;
            if ((double)num8 < 0.0)
                num8 += 360f;
            return num8;
        }

        /// <summary>
        /// Gets the saturation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The Hue-Saturation-Brightness (HSB) saturation for this <see cref="T:SharpDX.Color"/>
        /// </returns>
        public float GetSaturation() {
            float num1 = (float)this.R / (float)byte.MaxValue;
            float num2 = (float)this.G / (float)byte.MaxValue;
            float num3 = (float)this.B / (float)byte.MaxValue;
            float num4 = 0.0f;
            float num5 = num1;
            float num6 = num1;
            if ((double)num2 > (double)num5)
                num5 = num2;
            if ((double)num3 > (double)num5)
                num5 = num3;
            if ((double)num2 < (double)num6)
                num6 = num2;
            if ((double)num3 < (double)num6)
                num6 = num3;
            if ((double)num5 != (double)num6)
                num4 = ((double)num5 + (double)num6) / 2.0 > 0.5 ? (float)(((double)num5 - (double)num6) / (2.0 - (double)num5 - (double)num6)) : (float)(((double)num5 - (double)num6) / ((double)num5 + (double)num6));
            return num4;
        }

        /// <summary>
        /// Adds two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to add.</param><param name="right">The second color to add.</param><param name="result">When the method completes, completes the sum of the two colors.</param>
        public static void Add(ref Color left, ref Color right, out Color result) {
            result.A = (byte)((uint)left.A + (uint)right.A);
            result.R = (byte)((uint)left.R + (uint)right.R);
            result.G = (byte)((uint)left.G + (uint)right.G);
            result.B = (byte)((uint)left.B + (uint)right.B);
        }

        /// <summary>
        /// Adds two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to add.</param><param name="right">The second color to add.</param>
        /// <returns>
        /// The sum of the two colors.
        /// </returns>
        public static Color Add(Color left, Color right) {
            return new Color((int)left.R + (int)right.R, (int)left.G + (int)right.G, (int)left.B + (int)right.B, (int)left.A + (int)right.A);
        }

        /// <summary>
        /// Subtracts two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to subtract.</param><param name="right">The second color to subtract.</param><param name="result">WHen the method completes, contains the difference of the two colors.</param>
        public static void Subtract(ref Color left, ref Color right, out Color result) {
            result.A = (byte)((uint)left.A - (uint)right.A);
            result.R = (byte)((uint)left.R - (uint)right.R);
            result.G = (byte)((uint)left.G - (uint)right.G);
            result.B = (byte)((uint)left.B - (uint)right.B);
        }

        /// <summary>
        /// Subtracts two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to subtract.</param><param name="right">The second color to subtract</param>
        /// <returns>
        /// The difference of the two colors.
        /// </returns>
        public static Color Subtract(Color left, Color right) {
            return new Color((int)left.R - (int)right.R, (int)left.G - (int)right.G, (int)left.B - (int)right.B, (int)left.A - (int)right.A);
        }

        /// <summary>
        /// Modulates two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to modulate.</param><param name="right">The second color to modulate.</param><param name="result">When the method completes, contains the modulated color.</param>
        public static void Modulate(ref Color left, ref Color right, out Color result) {
            result.A = (byte)((double)((int)left.A * (int)right.A) / (double)byte.MaxValue);
            result.R = (byte)((double)((int)left.R * (int)right.R) / (double)byte.MaxValue);
            result.G = (byte)((double)((int)left.G * (int)right.G) / (double)byte.MaxValue);
            result.B = (byte)((double)((int)left.B * (int)right.B) / (double)byte.MaxValue);
        }

        /// <summary>
        /// Modulates two colors.
        /// 
        /// </summary>
        /// <param name="left">The first color to modulate.</param><param name="right">The second color to modulate.</param>
        /// <returns>
        /// The modulated color.
        /// </returns>
        public static Color Modulate(Color left, Color right) {
            return new Color((int)left.R * (int)right.R, (int)left.G * (int)right.G, (int)left.B * (int)right.B, (int)left.A * (int)right.A);
        }

        /// <summary>
        /// Scales a color.
        /// 
        /// </summary>
        /// <param name="value">The color to scale.</param><param name="scale">The amount by which to scale.</param><param name="result">When the method completes, contains the scaled color.</param>
        public static void Scale(ref Color value, float scale, out Color result) {
            result.A = (byte)((double)value.A * (double)scale);
            result.R = (byte)((double)value.R * (double)scale);
            result.G = (byte)((double)value.G * (double)scale);
            result.B = (byte)((double)value.B * (double)scale);
        }

        /// <summary>
        /// Scales a color.
        /// 
        /// </summary>
        /// <param name="value">The color to scale.</param><param name="scale">The amount by which to scale.</param>
        /// <returns>
        /// The scaled color.
        /// </returns>
        public static Color Scale(Color value, float scale) {
            return new Color((byte)((double)value.R * (double)scale), (byte)((double)value.G * (double)scale), (byte)((double)value.B * (double)scale), (byte)((double)value.A * (double)scale));
        }

        /// <summary>
        /// Negates a color.
        /// 
        /// </summary>
        /// <param name="value">The color to negate.</param><param name="result">When the method completes, contains the negated color.</param>
        public static void Negate(ref Color value, out Color result) {
            result.A = (byte)((uint)byte.MaxValue - (uint)value.A);
            result.R = (byte)((uint)byte.MaxValue - (uint)value.R);
            result.G = (byte)((uint)byte.MaxValue - (uint)value.G);
            result.B = (byte)((uint)byte.MaxValue - (uint)value.B);
        }

        /// <summary>
        /// Negates a color.
        /// 
        /// </summary>
        /// <param name="value">The color to negate.</param>
        /// <returns>
        /// The negated color.
        /// </returns>
        public static Color Negate(Color value) {
            return new Color((int)byte.MaxValue - (int)value.R, (int)byte.MaxValue - (int)value.G, (int)byte.MaxValue - (int)value.B, (int)byte.MaxValue - (int)value.A);
        }

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// 
        /// </summary>
        /// <param name="value">The value to clamp.</param><param name="min">The minimum value.</param><param name="max">The maximum value.</param><param name="result">When the method completes, contains the clamped value.</param>
        public static void Clamp(ref Color value, ref Color min, ref Color max, out Color result) {
            byte num1 = value.A;
            byte num2 = (int)num1 > (int)max.A ? max.A : num1;
            byte alpha = (int)num2 < (int)min.A ? min.A : num2;
            byte num3 = value.R;
            byte num4 = (int)num3 > (int)max.R ? max.R : num3;
            byte red = (int)num4 < (int)min.R ? min.R : num4;
            byte num5 = value.G;
            byte num6 = (int)num5 > (int)max.G ? max.G : num5;
            byte green = (int)num6 < (int)min.G ? min.G : num6;
            byte num7 = value.B;
            byte num8 = (int)num7 > (int)max.B ? max.B : num7;
            byte blue = (int)num8 < (int)min.B ? min.B : num8;
            result = new Color(red, green, blue, alpha);
        }

        /// <summary>
        /// Computes the premultiplied value of the provided color.
        /// 
        /// </summary>
        /// <param name="value">The non-premultiplied value.</param><param name="result">The premultiplied result.</param>
        public static void Premultiply(ref Color value, out Color result) {
            float num = (float)value.A / 65025f;
            result.A = value.A;
            result.R = Color.ToByte((float)value.R * num);
            result.G = Color.ToByte((float)value.G * num);
            result.B = Color.ToByte((float)value.B * num);
        }

        /// <summary>
        /// Computes the premultiplied value of the provided color.
        /// 
        /// </summary>
        /// <param name="value">The non-premultiplied value.</param>
        /// <returns>
        /// The premultiplied result.
        /// </returns>
        public static Color Premultiply(Color value) {
            Color result;
            Color.Premultiply(ref value, out result);
            return result;
        }

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// 
        /// </summary>
        /// <param name="color">A packed integer containing all four color components in BGRA order</param>
        /// <returns>
        /// A color.
        /// </returns>
        public static Color FromBgra(int color) {
            return new Color((byte)(color >> 16 & (int)byte.MaxValue), (byte)(color >> 8 & (int)byte.MaxValue), (byte)(color & (int)byte.MaxValue), (byte)(color >> 24 & (int)byte.MaxValue));
        }

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// 
        /// </summary>
        /// <param name="color">A packed integer containing all four color components in BGRA order</param>
        /// <returns>
        /// A color.
        /// </returns>
        public static Color FromBgra(uint color) {
            return Color.FromBgra((int)color);
        }

        /// <summary>
        /// Converts the color from a packed ABGR integer.
        /// 
        /// </summary>
        /// <param name="color">A packed integer containing all four color components in ABGR order</param>
        /// <returns>
        /// A color.
        /// </returns>
        public static Color FromAbgr(int color) {
            return new Color((byte)(color >> 24), (byte)(color >> 16), (byte)(color >> 8), (byte)color);
        }

        /// <summary>
        /// Converts the color from a packed ABGR integer.
        /// 
        /// </summary>
        /// <param name="color">A packed integer containing all four color components in ABGR order</param>
        /// <returns>
        /// A color.
        /// </returns>
        public static Color FromAbgr(uint color) {
            return Color.FromAbgr((int)color);
        }

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// 
        /// </summary>
        /// <param name="color">A packed integer containing all four color components in RGBA order</param>
        /// <returns>
        /// A color.
        /// </returns>
        public static Color FromRgba(int color) {
            return new Color(color);
        }

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// 
        /// </summary>
        /// <param name="color">A packed integer containing all four color components in RGBA order</param>
        /// <returns>
        /// A color.
        /// </returns>
        public static Color FromRgba(uint color) {
            return new Color(color);
        }

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// 
        /// </summary>
        /// <param name="value">The value to clamp.</param><param name="min">The minimum value.</param><param name="max">The maximum value.</param>
        /// <returns>
        /// The clamped value.
        /// </returns>
        public static Color Clamp(Color value, Color min, Color max) {
            Color result;
            Color.Clamp(ref value, ref min, ref max, out result);
            return result;
        }

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// 
        /// </summary>
        /// <param name="start">Start color.</param><param name="end">End color.</param><param name="amount">Value between 0 and 1 indicating the weight of <paramref name="end"/>.</param><param name="result">When the method completes, contains the linear interpolation of the two colors.</param>
        /// <remarks>
        /// Passing <paramref name="amount"/> a value of 0 will cause <paramref name="start"/> to be returned; a value of 1 will cause <paramref name="end"/> to be returned.
        /// 
        /// </remarks>
        public static void Lerp(ref Color start, ref Color end, float amount, out Color result) {
            result.R = MathUtil.Lerp(start.R, end.R, amount);
            result.G = MathUtil.Lerp(start.G, end.G, amount);
            result.B = MathUtil.Lerp(start.B, end.B, amount);
            result.A = MathUtil.Lerp(start.A, end.A, amount);
        }

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// 
        /// </summary>
        /// <param name="start">Start color.</param><param name="end">End color.</param><param name="amount">Value between 0 and 1 indicating the weight of <paramref name="end"/>.</param>
        /// <returns>
        /// The linear interpolation of the two colors.
        /// </returns>
        /// 
        /// <remarks>
        /// Passing <paramref name="amount"/> a value of 0 will cause <paramref name="start"/> to be returned; a value of 1 will cause <paramref name="end"/> to be returned.
        /// 
        /// </remarks>
        public static Color Lerp(Color start, Color end, float amount) {
            Color result;
            Color.Lerp(ref start, ref end, amount, out result);
            return result;
        }

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// 
        /// </summary>
        /// <param name="start">Start color.</param><param name="end">End color.</param><param name="amount">Value between 0 and 1 indicating the weight of <paramref name="end"/>.</param><param name="result">When the method completes, contains the cubic interpolation of the two colors.</param>
        public static void SmoothStep(ref Color start, ref Color end, float amount, out Color result) {
            amount = MathUtil.SmoothStep(amount);
            Color.Lerp(ref start, ref end, amount, out result);
        }

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// 
        /// </summary>
        /// <param name="start">Start color.</param><param name="end">End color.</param><param name="amount">Value between 0 and 1 indicating the weight of <paramref name="end"/>.</param>
        /// <returns>
        /// The cubic interpolation of the two colors.
        /// </returns>
        public static Color SmoothStep(Color start, Color end, float amount) {
            Color result;
            Color.SmoothStep(ref start, ref end, amount, out result);
            return result;
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// 
        /// </summary>
        /// <param name="left">The first source color.</param><param name="right">The second source color.</param><param name="result">When the method completes, contains an new color composed of the largest components of the source colors.</param>
        public static void Max(ref Color left, ref Color right, out Color result) {
            result.A = (int)left.A > (int)right.A ? left.A : right.A;
            result.R = (int)left.R > (int)right.R ? left.R : right.R;
            result.G = (int)left.G > (int)right.G ? left.G : right.G;
            result.B = (int)left.B > (int)right.B ? left.B : right.B;
        }

        /// <summary>
        /// Returns a color containing the largest components of the specified colorss.
        /// 
        /// </summary>
        /// <param name="left">The first source color.</param><param name="right">The second source color.</param>
        /// <returns>
        /// A color containing the largest components of the source colors.
        /// </returns>
        public static Color Max(Color left, Color right) {
            Color result;
            Color.Max(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// 
        /// </summary>
        /// <param name="left">The first source color.</param><param name="right">The second source color.</param><param name="result">When the method completes, contains an new color composed of the smallest components of the source colors.</param>
        public static void Min(ref Color left, ref Color right, out Color result) {
            result.A = (int)left.A < (int)right.A ? left.A : right.A;
            result.R = (int)left.R < (int)right.R ? left.R : right.R;
            result.G = (int)left.G < (int)right.G ? left.G : right.G;
            result.B = (int)left.B < (int)right.B ? left.B : right.B;
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// 
        /// </summary>
        /// <param name="left">The first source color.</param><param name="right">The second source color.</param>
        /// <returns>
        /// A color containing the smallest components of the source colors.
        /// </returns>
        public static Color Min(Color left, Color right) {
            Color result;
            Color.Min(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Adjusts the contrast of a color.
        /// 
        /// </summary>
        /// <param name="value">The color whose contrast is to be adjusted.</param><param name="contrast">The amount by which to adjust the contrast.</param><param name="result">When the method completes, contains the adjusted color.</param>
        public static void AdjustContrast(ref Color value, float contrast, out Color result) {
            result.A = value.A;
            result.R = Color.ToByte((float)(0.5 + (double)contrast * ((double)value.R / (double)byte.MaxValue - 0.5)));
            result.G = Color.ToByte((float)(0.5 + (double)contrast * ((double)value.G / (double)byte.MaxValue - 0.5)));
            result.B = Color.ToByte((float)(0.5 + (double)contrast * ((double)value.B / (double)byte.MaxValue - 0.5)));
        }

        /// <summary>
        /// Adjusts the contrast of a color.
        /// 
        /// </summary>
        /// <param name="value">The color whose contrast is to be adjusted.</param><param name="contrast">The amount by which to adjust the contrast.</param>
        /// <returns>
        /// The adjusted color.
        /// </returns>
        public static Color AdjustContrast(Color value, float contrast) {
            return new Color(Color.ToByte((float)(0.5 + (double)contrast * ((double)value.R / (double)byte.MaxValue - 0.5))), Color.ToByte((float)(0.5 + (double)contrast * ((double)value.G / (double)byte.MaxValue - 0.5))), Color.ToByte((float)(0.5 + (double)contrast * ((double)value.B / (double)byte.MaxValue - 0.5))), value.A);
        }

        /// <summary>
        /// Adjusts the saturation of a color.
        /// 
        /// </summary>
        /// <param name="value">The color whose saturation is to be adjusted.</param><param name="saturation">The amount by which to adjust the saturation.</param><param name="result">When the method completes, contains the adjusted color.</param>
        public static void AdjustSaturation(ref Color value, float saturation, out Color result) {
            float num = (float)((double)value.R / (double)byte.MaxValue * 0.212500005960464 + (double)value.G / (double)byte.MaxValue * 0.715399980545044 + (double)value.B / (double)byte.MaxValue * 0.0720999985933304);
            result.A = value.A;
            result.R = Color.ToByte(num + saturation * ((float)value.R / (float)byte.MaxValue - num));
            result.G = Color.ToByte(num + saturation * ((float)value.G / (float)byte.MaxValue - num));
            result.B = Color.ToByte(num + saturation * ((float)value.B / (float)byte.MaxValue - num));
        }

        /// <summary>
        /// Adjusts the saturation of a color.
        /// 
        /// </summary>
        /// <param name="value">The color whose saturation is to be adjusted.</param><param name="saturation">The amount by which to adjust the saturation.</param>
        /// <returns>
        /// The adjusted color.
        /// </returns>
        public static Color AdjustSaturation(Color value, float saturation) {
            float num = (float)((double)value.R / (double)byte.MaxValue * 0.212500005960464 + (double)value.G / (double)byte.MaxValue * 0.715399980545044 + (double)value.B / (double)byte.MaxValue * 0.0720999985933304);
            return new Color(Color.ToByte(num + saturation * ((float)value.R / (float)byte.MaxValue - num)), Color.ToByte(num + saturation * ((float)value.G / (float)byte.MaxValue - num)), Color.ToByte(num + saturation * ((float)value.B / (float)byte.MaxValue - num)), value.A);
        }

        /// <summary>
        /// Convert this instance to a <see cref="T:SharpDX.Color4"/>
        /// </summary>
        /// 
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public Color4 ToColor4() {
            return new Color4((float)this.R / (float)byte.MaxValue, (float)this.G / (float)byte.MaxValue, (float)this.B / (float)byte.MaxValue, (float)this.A / (float)byte.MaxValue);
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </returns>
        public override string ToString() {
            return this.ToString((IFormatProvider)CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </summary>
        /// <param name="format">The format to apply to each channel element (byte).</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </returns>
        public string ToString(string format) {
            return this.ToString(format, (IFormatProvider)CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </returns>
        public string ToString(IFormatProvider formatProvider) {
            return string.Format(formatProvider, "A:{0} R:{1} G:{2} B:{3}", (object)this.A, (object)this.R, (object)this.G, (object)this.B);
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </summary>
        /// <param name="format">The format to apply to each channel element (byte).</param><param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents this instance.
        /// 
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider) {
            if (format == null)
                return this.ToString(formatProvider);
            return string.Format(formatProvider, "A:{0} R:{1} G:{2} B:{3}", (object)this.A.ToString(format, formatProvider), (object)this.R.ToString(format, formatProvider), (object)this.G.ToString(format, formatProvider), (object)this.B.ToString(format, formatProvider));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// 
        /// </returns>
        public override int GetHashCode() {
            return ((this.R.GetHashCode() * 397 ^ this.G.GetHashCode()) * 397 ^ this.B.GetHashCode()) * 397 ^ this.A.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:SharpDX.Color"/> is equal to this instance.
        /// 
        /// </summary>
        /// <param name="other">The <see cref="T:SharpDX.Color"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="T:SharpDX.Color"/> is equal to this instance; otherwise, <c>false</c>.
        /// 
        /// </returns>
        public bool Equals(Color other) {
            if ((int)this.R == (int)other.R && (int)this.G == (int)other.G && (int)this.B == (int)other.B)
                return (int)this.A == (int)other.A;
            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to this instance.
        /// 
        /// </summary>
        /// <param name="value">The <see cref="T:System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="T:System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// 
        /// </returns>
        public override bool Equals(object value) {
            if (value == null || !object.ReferenceEquals((object)value.GetType(), (object)typeof(Color)))
                return false;
            return this.Equals((Color)value);
        }

        private static byte ToByte(float component) {
            return Color.ToByte((int)((double)component * (double)byte.MaxValue));
        }

        public static byte ToByte(int value) {
            return value < 0 ? (byte)0 : (value > (int)byte.MaxValue ? byte.MaxValue : (byte)value);
        }
    }
}
