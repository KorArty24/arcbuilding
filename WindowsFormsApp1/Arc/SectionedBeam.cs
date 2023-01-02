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

         public static Beam CreateLowerChordBeam() 
         {
            Beam lowerChord = new Beam(Beam.BeamTypeEnum.BEAM);
            lowerChord.Material.MaterialString = "S255";
            lowerChord.Profile.ProfileString = "HEA300";
            lowerChord.Class = "4";
            return lowerChord;
         }

         public static Beam CreateWeb() 
         {
            Beam web_tie = new Beam(Beam.BeamTypeEnum.BEAM);
            web_tie.Material.MaterialString = "S255";
            web_tie.Profile.ProfileString = "HEA100";
            web_tie.Class = "11";
            
            return web_tie;
         }
        public static Beam CreateInnerOuterTies() 
         {
            Beam web_tie = new Beam(Beam.BeamTypeEnum.BEAM);
            web_tie.Material.MaterialString = "S255";
            web_tie.Profile.ProfileString = "HEA300";
            web_tie.Class = "12";
            
            return web_tie;
         }
    }
}
