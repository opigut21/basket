﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>При использовании алгоритма увеличения резкости подчеркиваются различия между цветами смежных пикселей и выделяются незаметные детали. В ядре резкости центральный коэффициент больше 1, а окружен он отрицательными числами, сумма которых на единицу меньше центрального коэффициента. Таким образом, увеличивается любой существующий контраст между цветом пикселя и цветами его соседей.При использовании алгоритма размытия в изображении перераспределяются цвета и смягчаются резкие границы. Ядро сглаживания состоит из совокупности коэффициентов, каждый из которых меньше 1, а их сумма составляет 1. Это означает, что после фильтрации каждый пиксель поглотит что-то из цветов соседей, но полная яркость изображения останется неизменной.При использовании алгоритма увеличения резкости подчеркиваются различия между цветами смежных пикселей и выделяются незаметные детали. В ядре резкости центральный коэффициент больше 1, а окружен он отрицательными числами, сумма которых на единицу меньше центрального коэффициента. Таким образом, увеличивается любой существующий контраст между цветом пикселя и цветами его соседей.При использовании алгоритма размытия в изображении перераспределяются цвета и смягчаются резкие границы. Ядро сглаживания состоит из совокупности коэффициентов, каждый из которых меньше 1, а их сумма составляет 1. Это означает, что после фильтрации каждый пиксель поглотит что-то из цветов соседей, но полная яркость изображения останется неизменной.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
