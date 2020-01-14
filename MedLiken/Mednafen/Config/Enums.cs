using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen.Config
{
    public static class CurrentPlatform
    {
        public static string MD { get { return "md"; } }
        public static string NES { get { return "nes"; } }
        public static string SNES { get { return "snes"; } }
    }

    public enum Deinterlacer
    {
        weave, bob, bob_offset, blend, blend_rg
    }
    public enum VideoDriver
    {
        _default, opengl, softfb
    }
    public enum AudioDriver
    {
        _default, wasapish, dsound, wasapi
    }
    public enum MDRegion
    {
        game, overseas_ntsc, overseas_pal, domestic_ntsc, domestic_pal
    }
    public enum MDReportedRegion
    {
        same, game, overseas_ntsc, overseas_pal, domestic_ntsc, domestic_pal
    }
    public enum Shader
    {
        none, autoip, autoipsharper, scale2x, sabr, ipsharper, ipxnoty, ipynotx,
        ipxnotysharper, ipynotxsharper, goat
    }
    public enum ShaderGoatPat
    {
        goatron, borg, slenderman
    }
    public enum Special
    {
        none, hq2x, hq3x, hq4x, scale2x, scale3x, scale4x, _2xsai, super2xsai, supereagle,
        nn2x, nn3x, nn4x, nny2x, nny3x, nny4x
    }
    public enum MStretch
    {
        _0, full, aspect, aspect_int, aspect_mult2
    }
    public enum Videoip
    {
        _0, _1, x, y
    }
}
