using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public interface IArray<T>
    {
        /// <summary>
        /// Метод добавления и удаления элементов
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        void Add(T item, int index);
        /// <summary>
        /// Возвращает удаляемый элемент по индексу
        /// </summary>
        /// <returns></returns>
        T Remove(int index);
    }
}
