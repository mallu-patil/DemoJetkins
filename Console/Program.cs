using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public delegate void Handle(string msg);
	// Added comments
    class Hash
    {
        public Func<string> Add { get; set; }
        public Handle MyHandle { get; set; }

        public event Action<string> MyAction;

        public void StartAction()
        {
            MyAction("Hello Hi Dear and how are you");
        }
	public void StartActionNew()
        {
            MyAction("Hello Hi Dear I am fine.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Action<string,int> action = new Action<string,int>((msg,var) => { System.Console.WriteLine(msg); });
            action("Hello",1);

            Func<Hash> fun = () => new Hash();

            Func<int> fun1 = () => 1;

            System.Console.WriteLine(fun1());

            Hash h = new Hash();
            h.MyAction +=   (msg)=>{System.Console.WriteLine(msg);};

            h.StartAction(); 
        }


        public static void PrintHandle(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}
