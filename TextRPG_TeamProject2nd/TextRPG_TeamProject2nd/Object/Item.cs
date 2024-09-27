using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_TeamProject2nd.Utils;

namespace TextRPG_TeamProject2nd.Object
{
    enum eITEMTYPE
    {
        WEAPON,
        ARMOR,
        CONSUMABLE
    }

    internal class Item
    {
        public Item Clone()
        {
            Item ret = new Item();
            ret.damage = damage;
            ret.defence = defence;
            ret.value = value;
            ret.effect = effect;
            ret.desc = desc;
            ret.name = name;
            ret.type = type;
            return ret;
        }

        public int id             { get; set; }
        public int damage         { get; set; }
        public int defence        { get; set; }
        public int value          { get; set; }
        public int effect         { get; set; }
        public string desc        { get; set; }
        public string name        { get; set; }
        public eITEMTYPE type     { get; set; }
    }
}
