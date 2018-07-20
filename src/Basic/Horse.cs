using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    //inherit
    public class Horse:Animal
    {
        public int horseSkinColor;
        public int HorseColor
        {
            get { return horseSkinColor; }
        }
        public Horse()
        {
            horseSkinColor = 12;
        }
        public Horse(int horseColor)
        {
            this.horseSkinColor = horseColor;
            Console.WriteLine("Horse skin color can be setted as {0}.",this.horseSkinColor.ToString());
        }

        public override void Voice()
        {
            //base.Voice();
            string vc = "mou";
            Console.WriteLine("{0}....{1}",vc,vc);
        }
    }
}
