//using static ClassRoom;

//internal class Task1
//{
//    private static void Main()
//    {
//        ExcelentPupil pupil1 = new ExcelentPupil("Петя");
//        GoodPupil pupil2 = new GoodPupil("Вася");
//        BadPupil pupil3 = new BadPupil("Коля");
//        Pupil pupil4 = new Pupil("Толя");
//        ClassRoom room = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
//        room.HowWeDoIt();
//    }
//}

//public class ClassRoom
//{
//    private Pupil[] _pupils;
//    public ClassRoom(params Pupil[] pupils) { _pupils = pupils; }

//    public Pupil[] Pupils()
//    {
//        try { if (_pupils.Length < 4) throw new ArgumentException(); else return _pupils; }
//        catch (ArgumentException) { Console.WriteLine("Маловато людей для класса"); return null; }
//    }

//    public int HowWeDoIt()
//    {
//        if (Pupils() == null) return -1;
//        for (int i = 0; i < _pupils.Length; ++i)
//        {
//            Console.WriteLine(Pupils()[i].Name);
//            Pupils()[i].Write();
//            Pupils()[i].Study();
//            Pupils()[i].Read();
//            Pupils()[i].Relax();
//            Console.WriteLine();
//        }
//        return 0;
//    }


//    public class ExcelentPupil : Pupil
//    {
//        public ExcelentPupil(string name) : base(name) { }

//        protected override void Studying()
//        {
//            Console.WriteLine("Я учусь до поздней ночи, проводя за уроками почти всё время дома");
//        }
//        protected override void Reading()
//        {
//            Console.WriteLine("Я читаю школьную и научную литературу, вникая в суть");
//        }
//        protected override void Writing()
//        {
//            Console.WriteLine("Я старательно записываю за учителем");
//        }
//        protected override void Relaxing()
//        {
//            Console.WriteLine("Не люблю отдыхать, лучший отдых - это сон");
//        }
//    }

//    public class GoodPupil : Pupil
//    {
//        public GoodPupil(string name) : base(name) { }

//        protected override void Studying()
//        {
//            Console.WriteLine("Я делаю домашку, но не всегда и не по всем предметам");
//        }
//        protected override void Reading()
//        {
//            Console.WriteLine("Я читаю школьную литературу в кратком содержжании, предпочитая более современные книги");
//        }
//        protected override void Writing()
//        {
//            Console.WriteLine("Я пишу основные моменты своими словами");
//        }
//        protected override void Relaxing()
//        {
//            Console.WriteLine("Отдохнуть после учёбы, позвниматься собой - это прекрасно");
//        }
//    }

//    public class BadPupil : Pupil
//    {
//        public BadPupil(string name) : base(name) { }
//        protected override void Reading()
//        {
//            Console.WriteLine("Кто вообще читает школьную литературу? То ли дело фанфики");
//        }
//        protected override void Studying()
//        {
//            Console.WriteLine("Принципиально делаю дз только в исключительных случаях на коленке на перемене, жить надо здесь и сейчас");
//        }
//        protected override void Writing()
//        {
//            Console.WriteLine("Я почти ничего не записываю");
//        }

//        protected override void Relaxing()
//        {
//            Console.WriteLine("Отдых - моё призвание");
//        }
//    }
//    public class Pupil
//    {
//        private string _name;
//        public Pupil(string name) { _name = name; }
//        public string Name { get { return _name; } }
//        public void Study() => Studying();

//        protected virtual void Studying()
//        {
//            Console.WriteLine("Я учусь, честно-честно");
//        }
//        public void Read() => Reading();
//        protected virtual void Reading()
//        {
//            Console.WriteLine("Активно-агрессивно читаю");
//        }
//        public void Write() => Writing();
//        protected virtual void Writing()
//        {
//            Console.WriteLine("Да пишу я, пишу");
//        }

//        public void Relax() => Relaxing();
//        protected virtual void Relaxing()
//        {
//            Console.WriteLine("Поучились, можно и в тиктоке посидеть");
//        }
//    }
//}