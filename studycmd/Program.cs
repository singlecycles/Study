using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycmd
{
    class Program
    {
        static void Main(string[] args)
        {
            //喝酒问题
            #region
            //int jiu = 5;
            //Getjiu(jiu, yuping, yugai);
            //Console.WriteLine("可以喝{0}瓶酒,剩余{1}个空瓶和{2}个瓶盖", sum, yuping, yugai);
            #endregion

            //装箱拆箱
            #region
            //mycl a = new mycl();
            //a.name = "11";
            //mycl b = a;
            //b.name = "22";


            //string c = "asd";
            //string d = c;
            //d = "aaa";


            //int n = 4;
            //object o = n;
            //int j = (int)o;
            //o = 10;

            //Console.WriteLine("a:{0},b:{1}",a.name,b.name);
            //Console.WriteLine("c:{0},d:{1}",c,d);
            //Console.WriteLine("o:{0},j:{1}",o,j);
            #endregion

            #region

            //var a = Enum.GetName(typeof(myenum), 2);
            //var b = Enum.GetValues(typeof(myenum));
            //Console.WriteLine(b.GetValue(0));
            //Console.WriteLine(typeof(myenum));
            #endregion


            int row = 12;
            int column = 2;

            int rowval = 0;
            int colval = 0;

            for (int i = 0; i <= 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("row:{0},col:{1}", row, column);
                }
                else if(i < 3)
                {
                    row += rowval;
                    column += colval;
                    Console.WriteLine("row:{0},col:{1}",row,column);
                }
                else
                {
                    row += rowval;
                    column += colval;
                }
            }
            



        }

        public class mycl
        {
            public string name;
        }

        public enum myenum
        {
            星期一 = 1,
            星期二,
            星期三,
            星期四,
            星期五,
            星期六,
            星期日,
        }

        public struct mystruect
        {
            public string Name;
            public string Pwd;
        }

        //喝酒问题
        #region 
        public static int sum = 5;
        public static int yuping = 0;
        public static int yugai = 0;

        public static void Getjiu(int jiu, int sping, int sgai)
        {


            if (jiu <= 0)
                return;

            int ping = jiu + yuping;  //喝完酒剩下的空瓶
            int gai = jiu + yugai;    //喝完酒剩下的瓶盖
            int phj = 0;
            int ghj = 0;
            Console.WriteLine("喝酒:{0},剩空瓶:{1},剩瓶盖:{2}", jiu, ping, gai);

            sping = ping;
            sgai = gai;

            if (ping >= 2)
            {
                phj = ping / 2;    //空瓶换酒

                sping = ping % 2;  //剩余的空瓶
            }
            if (gai >= 4)
            {
                ghj = gai / 4;     //瓶盖换酒
                sgai = gai % 4;     //剩余的瓶盖
            }

            yuping = sping;
            yugai = sgai;

            jiu = phj + ghj;  //瓶盖换的酒

            sum = sum + jiu;

            Getjiu(jiu, sping, sgai);
        }
        #endregion
    }
}
