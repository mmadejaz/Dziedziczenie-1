namespace Dziedziczenie_1
{
    class Instrument
    {
        public string name { get; private set; }
        public Instrument(string name)
        {
            this.name = name;
        }
        public virtual void graj()
        {
            ;
        }
        public override string ToString()
        {
            return name;
        }
    }
    class InstrumentStrunowy : Instrument
    {
        public InstrumentStrunowy(string name) : base(name)
        {

        }
        public override void graj()
        {
            Console.WriteLine("brzdeęk brzedek brzedęk");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class InstrumentDęty : Instrument
    {
        public InstrumentDęty(string name) : base(name)
        {

        }
        public override void graj()
        {
            Console.WriteLine("truruuuuuuutututuuuu");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            InstrumentDęty trabka = new InstrumentDęty("trąbka");
            InstrumentStrunowy gitara = new InstrumentStrunowy("gitara");
            trabka.graj();
            gitara.graj();
            Instrument[] orkiestra = new Instrument[2];
            orkiestra[0] = trabka;
            orkiestra[1] = gitara;

            for(int i=0; i<2; i++)
                orkiestra[i].graj();

            foreach (var i in orkiestra)
                i.graj();
            Console.WriteLine("W orkiestrze są:");
            foreach (var i in orkiestra)
                Console.WriteLine(i);

        }
    }
}