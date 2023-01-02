using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace WindowsFormsApp1.Arc
{
    public static class SectionedBeam
    {
        public static Beam CreateUpperChordBeam() 
        {
            Beam upperchord = new Beam(Beam.BeamTypeEnum.BEAM);
            upperchord.Material.MaterialString = "S255";
            upperchord.Profile.ProfileString = "HEA300";
            upperchord.Class = "4";
            return upperchord;
        }
    }
}
