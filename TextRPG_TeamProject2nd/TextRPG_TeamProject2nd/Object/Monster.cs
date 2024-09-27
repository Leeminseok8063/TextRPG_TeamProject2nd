using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_TeamProject2nd.Object
{
    internal class Monster
    {

        public Monster Clone()
        {
            Monster ret = new Monster();
            ret.id = id;
            ret.exp = exp;
            ret.gold = gold;
            ret.dropItems = dropItems;
            ret.skill = skill;
            return ret;
        }

        public int id                   { get; set; }
        public int exp                  { get; set; }
        public string name              { get; set; }
        public string gold              { get; set; }
        public List<int> dropItems      { get; set; }
        public List<int> skill          { get; set; }
        
    }
}
