using System;

namespace aula01.Model
{
    class Local
    {
        public int Size { get; set; }

        public string Code { get; set; }
    }


    class Sector: Local
    {
        public Farm[] Farms { get; set; }
    }


    class Farm : Local
    {
        public Block[] Blocks { get; set; }
    }

    class Block: Local
    {
        public Field[] Fields { get; set; }
    }

    class Field: Local
    {
        public string Culture { get; set; }

        public void Plant(string culture)
        {
            Culture = culture;
        }
    }
}
