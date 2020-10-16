using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Series
{
    /// <summary>
    /// Абстрактный класс для прогрессиий
    /// </summary>
    abstract class Series
    {
        public abstract int memberProgression(int startProgression, int stepProgression, int elements); //Метод для поиска N-го члена
        public abstract int sumMemberProgression(int startProgresion, int stepProgression, int amountElements);//Метод для суммы N-ых членов
    }
}
