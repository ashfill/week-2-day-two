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
            scorpion1.Canswim = false;
            bool swimmingquestion = scorpion1.Canswim;
            Console.WriteLine(string.Format("Can a scorpion swim in water? {0}", scorpion1.Canswim));
            Scopions scorpion2 = new Scopions();
            scorpion2.Carnivors = true;
            bool foodquestion = scorpion2.Carnivors;
            Console.WriteLine(string.Format("Are scorpions carnivours? {0}", scorpion2.Carnivors));
            Scopions scorpion3 = new Scopions();
            scorpion3.Haveskin = true;
            bool skinquestion2 = scorpion3.Haveskin;
            Console.WriteLine(string.Format("Scorpions have skin? {0}", scorpion3.Haveskin));
            Scopions scorpion4 = new Scopions();
            scorpion4.Havelegs = 8;
            int legquestion2 = scorpion4.Havelegs;
            Console.WriteLine("Just like the spider the scorpion also has {0} legs.", scorpion4.Havelegs);
            Scopions scorpion5 = new Scopions();
            scorpion5.Bodysections = 2;
            int Bodyquestion2 = scorpion5.Bodysections;
            Console.WriteLine("A scorpion has {0} main body regions.", scorpion5.Bodysections);
            Scopions scorpion6 = new Scopions();
            scorpion6.Haspincers = 2;
            int pincerquestion = scorpion6.Haspincers;
            Console.WriteLine("A scorpion has {0} pincers to catch it's prey.", scorpion6.Haspincers);
            Scopions scorpion7 = new Scopions();
            scorpion7.Canbepoisonous = true;
            bool Poisonquestion = scorpion7.Canbepoisonous;
            Console.WriteLine(string.Format("Can a scorpions tail inject poison into whatever it stings? {0}", scorpion7.Canbepoisonous));

            iguana iguana1 = new iguana();
            iguana1.Canswim = true;
            bool swim = iguana1.Canswim;
            Console.WriteLine(string.Format("Can an iguana swim? {0}", iguana1.Canswim));
            iguana iguana2 = new iguana();
            iguana2.Carnivors = true;
            bool food = iguana2.Carnivors;
            Console.WriteLine(string.Format("Are iguanas carnivours? {0}", iguana2.Carnivors));
            iguana iguana3 = new iguana();
            iguana3.Haveskin = true;
            bool skin = iguana3.Haveskin;
            Console.WriteLine(string.Format("Iguana's have skin? {0}", iguana3.Haveskin));
            iguana iguana4 = new iguana();
            iguana4.Haveclaws = true;
            bool claws = iguana4.Haveclaws;
            Console.WriteLine(string.Format("All iguana's have claws? {0}", iguana4.Haveclaws));
            iguana iguana5 = new iguana();
            iguana5.Havetails = true;
            bool tail = iguana5.Havetails;
            Console.WriteLine(string.Format("All iguana's have tails? {0}", iguana5.Havetails));
            iguana iguana6 = new iguana();
            iguana6.Canregrowtail = true;
            bool regrow = iguana6.Canregrowtail;
            Console.WriteLine(string.Format("An iguana can regrow it's tail? {0}", iguana6.Canregrowtail));
            iguana iguana7 = new iguana();
            iguana7.Coldblooded = true;
            bool cold = iguana7.Coldblooded;
            Console.WriteLine(string.Format("An iguana is cold blooded? {0}", iguana7.Coldblooded));
            snake snake1 = new snake();
            snake1.Canswim = true;
            bool swimming = snake1.Canswim;
            Console.WriteLine(string.Format("A snake can swim on water? {0}", snake1.Canswim));
            snake snake6 = new snake();
            snake6.Numberoflegs = 0;
            int leg = snake6.Numberoflegs;
            Console.WriteLine("A snake has {0} legs.", snake6.Numberoflegs);
            snake snake7 = new snake();
            snake7.Hasbones = 400;
            int bones = snake7.Hasbones;
            Console.WriteLine("A snake has aprox. {0} bones in it's body.", snake7.Hasbones);
            snake snake3 = new snake();

            Console.ReadLine();

        }
    }
}
