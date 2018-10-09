using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycmd
{
    public abstract class Animal {
        public string Type;


        public abstract void Go();
    }


    public class Borid : Animal {
        public string Name;
        public enum Days {
            星期一 = 1,
            星期二,
            星期三,
            星期四,
            星期五,
            星期六,
            星期日,
        }
        //public string 

        public Borid() {

        }

        public Borid(string Name)
        {
            this.Name = Name;
        }

        public override void Go() {
            Console.WriteLine("Fly");
        }
    }

    public delegate void EventHandler(object Sender, EventArgs e);
    interface IMyExample {
        string this[int index] { get; set; }
        string Point { get; set; }
        event EventHandler Even;

        void Find(int Value);
    }

    interface IControl {
        void Paint();
    }

    interface ITextBox : IControl {
        void SetText(string text);
    }

    public class EditBox : ITextBox {
        public void Paint() { }
        public void SetText(string text) {

        }
    }


    interface GetPower3{
        void Give3Power();
    }

    interface GetPower2
    {
        void Give2Power();
    }

    class Chapai:GetPower2,GetPower3 {

       public void Give2Power() {
            Console.WriteLine("使用3孔插座充电！");
        }
        public void Give3Power()
        {
            Console.WriteLine("使用2孔插座充电！");
        }
    }



    class Go {
        static void myGo() {
            Animal a = new Borid("asdasd");
            Borid b = new Borid();

            int state = 1;
            
        }
    } 
}
