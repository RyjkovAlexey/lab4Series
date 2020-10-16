using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4Series
{
    class Exponential:Series
    {
        /// <summary>
        /// Поиск N-go члена прогрессии
        /// </summary>
        /// <param name="startProgression">Первое значение прогрессии</param>
        /// <param name="stepProgression">Шаг прогрессии</param>
        /// <param name="elements">Номер члена прогрессии</param>
        /// <returns>Значение N-го члена прогрессии</returns>
        public override int memberProgression(int startProgression, int stepProgression, int elements)
        {
            if (elements > 0)
            {
                return startProgression * Convert.ToInt32(Math.Pow(stepProgression, elements - 1));
            }
            else
            {
                throw new ArgumentException("Элемент последовательности который ищем должен быть по счету больше нуля");
            }
        }
        /// <summary>
        /// Сумма первых N-ых членов прогресии
        /// </summary>
        /// <param name="startProgresion">Первое значение прогрессии</param>
        /// <param name="stepProgression">Шаг прогрессии</param>
        /// <param name="amountElements">Количество элементов</param>
        /// <returns>Сумма первых N-ых членов прогрессии</returns>
        public override int sumMemberProgression(int startProgresion, int stepProgression, int amountElements)
        {
            if (stepProgression > 0 && amountElements>0)
            {
                return (memberProgression(startProgresion, stepProgression, amountElements) * stepProgression - startProgresion) / (stepProgression - 1);
            }
            else
            {
                throw new ArgumentException("Шаг должен быть больше нуля");
            }
        }
    }
}
