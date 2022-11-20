using System;

namespace finalProject
{
    class Calculation
    {
        public static void BlingBlongGame()
        {
            for(int i=1; i<=100; i++){
                if(i%5 == 0 && i%3 == 0){
                    Console.WriteLine("BlingBlong");
                }

                else if(i%3==0){
                    Console.WriteLine("Bling");
                }

                else if(i%5==0){
                    Console.WriteLine("Blong");
                }

                else{
                    Console.WriteLine(i);
                }
            }

        }
    }
}