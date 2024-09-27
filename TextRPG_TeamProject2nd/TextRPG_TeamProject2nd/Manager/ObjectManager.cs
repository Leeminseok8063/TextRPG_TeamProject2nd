using System.Security.Cryptography;
using TextRPG_TeamProject2nd.Object;
using TextRPG_TeamProject2nd.Utils;

namespace TextRPG_TeamProject2nd.Manager
{
    internal class ObjectManager
    {

        void Init()
        {
            //TODO
        }

        public Item GetItem(string _input)
        {
            foreach(Item item in itemPool )
            { 
                if(item.name == _input)
                {
                    return item.Clone();
                }
            }

            return null;
        }
        public Item GetItem(int _id)
        {
            foreach (Item item in itemPool)
            {
                if (item.id == _id)
                {
                    return item.Clone();
                }
            }

            return null;
        }

        public Monster GetMonster(string _input)
        {
            foreach (Monster mob in monsterPool)
            {
                if (mob.name == _input)
                {
                    return mob.Clone();
                }
            }

            return null;
        }
        public Monster GetMonster(int _id)
        {
            foreach (Monster mob in monsterPool)
            {
                if (mob.id == _id)
                {
                    return mob.Clone();
                }
            }

            return null;
        }

        private List<Item>        itemPool  = new List<Item>();
        private List<Monster>   monsterPool = new List<Monster>();
    }
}
