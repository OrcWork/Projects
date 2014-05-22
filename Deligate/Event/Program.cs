using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    delegate void PushPrinterButton();//объявление делегада
    class Program
    {
        
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            //подписались на событие с указанием конкретного метода
            mouse.Click += new PushPrinterButton(mouse.OnMouseClick);



            mouse.DoEvent();//вызывается событие

        }
    }

    class Mouse
    {
        public event PushPrinterButton Click;//объявили событие о нажатии кнопки мыши

        public void DoEvent()//генерация события
        {
            if (Click != null)
            Click();//Запуск события
        }

        public void OnMouseClick()// обработчик события
        {
            Console.WriteLine("Произошло нажатие мыши по кнопке печати.\nНачало печати...");
            Console.ReadLine();
        }
    }
}
