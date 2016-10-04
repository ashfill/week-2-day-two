using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiders spider1 = new Spiders();
            spider1.Canswim = true;
            bool swimquestion = spider1.Canswim;
            Console.WriteLine(string.Format("A spider can swim? {0}", spider1.Canswim));

            Spiders spider2 = new Spiders();
            spider2.Carnivors = true;
            bool carnivourquestion = spider2.Carnivors;
            Console.WriteLine(string.Format("A spider is a carnivour? {0}", spider2.Carnivors));

            Spiders spider3 = new Spiders();
            spider3.Haveskin = true;
            bool skinquestion = spider3.Haveskin;
            Console.WriteLine(string.Format("A spider does have skin? {0}", spider3.Haveskin));

            Spiders spider4 = new Spiders();
            spider4.Havelegs = 8;
            int legsquestion = spider4.Havelegs;
            Console.WriteLine("A spider has {0} legs", spider4.Havelegs);

            Spiders spider5 = new Spiders();
            spider5.Bodysections = 2;
            int bodyquestion = spider5.Bodysections;
            Console.WriteLine("The body of a spider is consists of {0} sections.", spider5.Bodysections);

            Spiders spider6 = new Spiders();
            spider6.Canspinweb = true;
            bool webquestion = spider6.Canspinweb;
            Console.WriteLine(string.Format("A spider can spin a web? {0}", spider6.Canspinweb));

            Spiders spider7 = new Spiders();
            spider7.Cancrawlupwalls = true;
            bool wallquestion = spider7.Cancrawlupwalls;
            Console.WriteLine(string.Format("A spider can crawl up a wall? {0}", spider7.Cancrawlupwalls));

            Scopions scorpion1 = new Scopions();
            scorpion1.Haspincers = 2;
            int pincerquestion = scorpion1.Haspincers;
            Console.WriteLine("A scorpion has {0} pincers to catch it's prey.", scorpion1.Haspincers);
            Console.ReadLine();

        }
    }
}
