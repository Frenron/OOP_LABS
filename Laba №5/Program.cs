using System;

namespace Laba__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ren4L = new Human(true, "Влад", 2003);
            Human MSTkrut2 = new Human(true, "Антон", 1994);
            Human Dantey = new Human(true, "Илья", 2012);
            Transformer Optimus = new Transformer(true, "Optimus", "Autobot", 1000,"Peugeot", "Blue", 2003, true, Transformer.Position.Cybertron);
            Transformer Bambalby = new Transformer(true, "Bambalby", "Autobot", 1200, "Жук", "yellow", 2007, true, Transformer.Position.Earth);

            Optimus.GetEnum();

            

            Army arm = new Army(Ren4L, Optimus, MSTkrut2, Dantey);
            arm.Add(Bambalby);
            arm.Delete(3);
            ArmyController.SearchByYear(arm, 2003);
            ArmyController.ArmyLength(arm);
            ArmyController.SearchByPower(arm, 1000);

        }
    }
}
