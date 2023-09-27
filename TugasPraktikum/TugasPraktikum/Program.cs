using VGA;
using LAPTOP;
using PROCESSOR;


namespace PROCESSOR
{
    public class Processor
    {
        public string merk;
        public string tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RAYZEN";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}

namespace VGA
{
    public class Vga
    {
        public string merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }
    public class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
}

namespace LAPTOP
{
    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop {0} {1} menyala", this.merk, this.tipe);

        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop {0} {1} mati", this.merk, this.tipe);
        }

    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "ASUS";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class ACER : Laptop
    {
        public ACER()
        {
            merk = "ACER";
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }
    public class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop {0} {1} sedang memainkan game", this.merk, this.tipe);
        }

    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}
public class mainProgram
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Laptop(); 
        laptop1 = new Vivobook();
        laptop1.vga = new VGA.Nvidia();
        laptop1.processor = new CoreI5();

        Laptop laptop2 = new Laptop();
        laptop2 = new IdeaPad();
        laptop2.vga = new VGA.AMD();
        laptop2.processor = new Ryzen();

        Predator predator = new Predator();
        predator = new Predator();
        predator.vga = new VGA.AMD();
        predator.processor = new CoreI7();

        Console.WriteLine("Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("Soal 2");
        //laptop1.Ngoding();

        Console.WriteLine("Soal 3");
        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.processor.merk);
        Console.WriteLine(laptop1.processor.tipe);

        Console.WriteLine("soal 4");
        predator.BermainGame();

        Console.WriteLine("Soal 5");
        //ACER acer = new ACER();
        //acer = new Predator();
        //acer.BermainGame();

    }

}