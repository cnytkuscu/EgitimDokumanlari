namespace ActionDelegeler
{
    public class ActionDelegeler
    {

        public ActionDelegeler()
        {
            Action action = new Action(SelamVer);
            action.Invoke();

            Action<string> action2 = new Action<string>(SelamVerByName);
            action2.Invoke("Cuneyt");
        }

        private void SelamVerByName(string name)
        {
            Console.WriteLine($"Merhaba {name}");
        }

        private static void SelamVer()
        {
            Console.WriteLine("Merhaba Cuneyt");
        }
    }
}

//Func, Action, predicate 3 farklı delegeler vardır.