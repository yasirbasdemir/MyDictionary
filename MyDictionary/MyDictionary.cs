using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T> // Generic Class
    {
        T[] array; // T tipinde array oluşturdum.
        T[] tempArray; // T tipinde geçiçi array (tempArray) oluşturdum.
        
        public MyDictionary()
        {
            array = new T[0];  //  0 elemanlı array oluşturdum.
        }

        public void Add(T item)
        {
            tempArray = array;  //  T tipin de oluşturduğum geçiçi array (tempArray)i array in referansını tutturdum.
            array = new T[array.Length + 1];  // array 'in eleman sayısını 1 arttırıyorum.
            for (int i = 0; i < tempArray.Length; i++) // geçiçi array(tempArray)in eleman sayısını döngüde arttırarak tekrar array'e aktardım .
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;  // Gönderdiğimiz yeni elemanı da arrayin son elemanına eklemiş oldum.

        }
        

        public int Count  //  Eğer ki MyDictionary den Count'u çağırırsam bu bana array in Length ini yani eleman sayısını vericek.
        {
            get { return array.Length; }
        }


    }
}
