using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MainApp5
{
    class Triad
    {
        int first;  //первый элемент
        int second;  //второй элемент
        int third;  //третий элемент


        public static bool Compare(in int OO, in int OTw, in int  OThr, in int TO, in int TTw, in int TThr) //метод для сравнения элементов двух триад на равенство
        {
            bool rez;
            if (OO == TO && OTw == TTw && OThr == TThr)
            {
                rez = true;
            }
            else
            {
                rez = false;
            }

            return rez;
        }

        public static void Compare(in int OO, in int OTw, in int OThr, in int TO, in int TTw, in int TThr, in int ThrO, in int ThrTw, in int ThrThr, out bool rezf, out bool rezl) //метод для сравнения элементов трех триад на равенство
        {
            
            if (OO == TO && OTw == TTw && OThr == TThr) // сравнение первых двух
            {
                rezf = true;
            }
            else
            {
                rezf = false;
            }

            if (TO == ThrO && TTw == ThrTw && TThr == ThrThr) //сравнение 2-3 триады
            {
                rezl = true;
            }
            else
            {
                rezl = false;
            }
        }

        public static void Nechet() //предупреждение что число нечетное
        {
            MessageBox.Show("Число четное, введите нечетное");
        }

        public int First //свойства для полей с проверкой на четность
        {
            get
            {
                return first;
            }

            set
            {
                if (value % 2 == 1)
                {
                    first = value;
                }
                else
                {
                    Triad.Nechet();
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                if (value % 2 == 1)
                {
                    second = value;
                }
                else
                {
                    Triad.Nechet();
                }
            }
        }

        public int Third
        {
            get
            {
                return third;
            }

            set
            {
                if (value % 2 == 1)
                {
                    third = value;
                }
                else
                {
                    Triad.Nechet();
                }
            }
        }

    }
}




