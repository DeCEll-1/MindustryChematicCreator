using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MindustrySchematicCreator
{
    public enum ContentType
    {
        ITEM = 0,
        BLOCK = 1,
        MECH_UNUSED = 2,
        BULLET = 3,
        LIQUID = 4,
        STATUS = 5,
        UNIT = 6,
        WEATHER = 7,
        EFFECT_UNUSED = 8,
        SECTOR = 9,
        LOADOUT_UNUSED = 10,
        TYPEID_UNUSED = 11,
        ERROR = 12,
        PLANET = 13,
        AMMO_UNUSED = 14,
        TEAM = 15,
        UNIT_COMMAND = 16,
        UNIT_STANCE = 17,
    }
}
