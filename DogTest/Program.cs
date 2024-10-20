using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogTest
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Dog pochi = new Dog();

            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            pochi.Eat();
            Console.WriteLine("空腹状態　: {0}",pochi.IsHungry());

            pochi.Run();
            Console.WriteLine("空腹状態　: {0}", pochi.IsHungry());

            Console.ReadLine();


        }
    }
}
