using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen.Config.Platforms
{
    public class TPlatform
    {
        private string pl;
        public TPlatform(string platform) { pl = platform; }

        public int enable
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.enable", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.enable", pl), value); }
        }
        public int scanlines
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.scanlines", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.scanlines", pl), value); }
        }
        public Shader shader
        {
            get { return TCfg.ReadValue<Shader>(string.Format("{0}.shader", pl)); }
            set { TCfg.WriteValue<Shader>(string.Format("{0}.shader", pl), value); }
        }
        public int shader_goat_fprog
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.shader.goat.fprog", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.shader.goat.fprog", pl), value); }
        }
        public float shader_goat_hdiv
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.shader.goat.hdiv", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.shader.goat.hdiv", pl), value); }
        }
        public ShaderGoatPat shader_goat_pat
        {
            get { return TCfg.ReadValue<ShaderGoatPat>(string.Format("{0}.shader.goat.pat", pl)); }
            set { TCfg.WriteValue<ShaderGoatPat>(string.Format("{0}.shader.goat.pat", pl), value); }
        }
        public int shader_goat_slen
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.shader.goat.slen", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.shader.goat.slen", pl), value); }
        }
        public float shader_goat_tp
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.shader.goat.tp", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.shader.goat.tp", pl), value); }
        }
        public float shader_goat_vdiv
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.shader.goat.vdiv", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.shader.goat.vdiv", pl), value); }
        }
        public Special special
        {
            get { return TCfg.ReadValue<Special>(string.Format("{0}.special", pl)); }
            set { TCfg.WriteValue<Special>(string.Format("{0}.special", pl), value); }
        }
        public MStretch stretch
        {
            get { return TCfg.ReadValue<MStretch>(string.Format("{0}.stretch", pl)); }
            set { TCfg.WriteValue<MStretch>(string.Format("{0}.stretch", pl), value); }
        }
        public int tblur
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.tblur", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.tblur", pl), value); }
        }
        public int tblur_accum
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.tblur.accum", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.tblur.accum", pl), value); }
        }
        public float tblur_accum_amount
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.tblur.accum.amount", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.tblur.accum.amount", pl), value); }
        }
        public Videoip videoip
        {
            get { return TCfg.ReadValue<Videoip>(string.Format("{0}.videoip", pl)); }
            set { TCfg.WriteValue<Videoip>(string.Format("{0}.videoip", pl), value); }
        }
        public int xres
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.xres", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.xres", pl), value); }
        }
        public float xscale
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.xscale", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.xscale", pl), value); }
        }
        public float xscalefs
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.xscalefs", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.xscalefs", pl), value); }
        }
        public int yres
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.yres", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.yres", pl), value); }
        }
        public float yscale
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.yscale", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.yscale", pl), value); }
        }
        public float yscalefs
        {
            get { return TCfg.ReadValue<float>(string.Format("{0}.yscalefs", pl)); }
            set { TCfg.WriteValue<float>(string.Format("{0}.yscalefs", pl), value); }
        }
        public int forcemono
        {
            get { return TCfg.ReadValue<int>(string.Format("{0}.forcemono", pl)); }
            set { TCfg.WriteValue<int>(string.Format("{0}.forcemono", pl), value); }
        }
    }
}
