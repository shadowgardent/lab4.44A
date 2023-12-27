using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._44
{
    public class coffeemachine
    {
        public int water;
        public int coffee;
        public int milk;
        public int chocolate;
        public coffeemachine()
        {

            water = 4000;
            coffee = 2000;
            milk = 2000;
            chocolate = 2000;

        }



        public bool makecoffee()
        {

            if (water >= 300 && coffee >= 20)
            {
                water = water - 300;
                coffee = coffee - 20;

                Console.WriteLine($"ทำกาแฟสำเร็จ น้ำที่เหลือ: {water} มิลลิลิตร, กาแฟที่เหลือ: {coffee} กรัม");
                return true;
            }


            else
            {
                Console.WriteLine("ไม่สามารถทำกาแฟได้ เนื่องจากน้ำ หรือ กาแฟไม่เพียงพอ");
                return false;
            }

        }


        public bool makeLatte()
        {


            if (water >= 300 && coffee >= 20 && milk >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                milk = milk - 10;


                return true;
            }


            else
            {

                return false;
            }


        }


        public bool makemocha()
        {


            if (water >= 300 && coffee >= 20 && chocolate >= 20)
            {
                water = water - 300;
                coffee = coffee - 20;
                chocolate = chocolate - 20;


                return true;
            }


            else
            {

                return false;
            }


        }


        public bool makechocolate()
        {


            if (water >= 300 && chocolate >= 20)
            {
                water = water - 300;
                chocolate = chocolate - 20;


                return true;
            }


            else
            {

                return false;
            }


        }
        public bool Replenish()
        {


            if (water <= 1000 || chocolate <= 1000 || milk <= 1000 || coffee <= 1000)
            {
                water = water += 2000;
                chocolate = chocolate += 500;
                milk = milk += 500;
                coffee = coffee += 500;


                return true;
            }


            else
            {

                return false;
            }


        }



    }
}

