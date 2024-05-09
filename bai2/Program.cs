namespace bai2
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoHashSet();
            ListDemo();
        }

        static void DemoHashSet()
        {
            var dayOfWeeks=new HashSet<string>();
            dayOfWeeks.Add("Monday");
            dayOfWeeks.Add("Tues");
            dayOfWeeks.Add("Wed");
            dayOfWeeks.Add("Tues");
            foreach(var item in dayOfWeeks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("SophanTu: "+ dayOfWeeks.Count);
        }
        static void ListDemo()
        {
            var listTxt = new List<string>();
            listTxt.Add("lmht");
            listTxt.Add("genshin");
            listTxt.Add("GTA 5");
            listTxt.Add("CSGO");
            int i = 0;


            foreach (var item in listTxt)
            {
                Console.WriteLine("truoc: ");

               Console.WriteLine( item);
            }
            listTxt.Insert(i, "valorant");

            foreach (var item in listTxt)
            {
                Console.WriteLine("sau: ");
                Console.WriteLine(item);
            }

        }

    }
}
