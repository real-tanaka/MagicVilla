using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDto> villaList = new List<VillaDto> {
        new VillaDto{Id=1, Name="Pool View", Occupancy=4, Sqft=100},
        new VillaDto{Id=2, Name="Beach View", Occupancy=3, Sqft=300}
    };


}