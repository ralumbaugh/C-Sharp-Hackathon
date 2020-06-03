using System;

namespace Really_Fun_Game
{
    class UnhandledException : Enemy{
        int Void;

        public UnhandledException(string name, string location):base(name, location){
            Void=10;
        }
        public void Annihilate(Character target){
            Console.WriteLine($"The horror hurls {this.Void} balls of terrifying energy to your face and nether regions");
            
            target.Health-=target.Health; 
            target.MaxHealth=0;
            target.IsAlive=false;
        }
    }
}