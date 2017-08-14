using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBank
{
         public class CleverMas
        {
            private List top;
            private int count;
           


        public CleverMas()
            {
                top = new List();
                count = 0;
               
        }

            public void Add(User x)
            {
                if (count == top.size)
                {
                    top.Wide();
                }

                top._data[count] = x;
                count++;
            }

            public object Get(int i)
            { return top._data[i]; }

        public int GetSize()
        {
            return top.size;
        }

        public void Show()
        {
            for(int i = 0; i < top.size; i++)
            {

                Console.WriteLine(" Пользователь № {0}", i);
                Console.WriteLine(" Логин: {0}", ((User)top._data[i]).GetLogin());
                Console.WriteLine(" Имя: {0}", ((User)top._data[i]).GetName());
                Console.WriteLine(" Фамилия: {0}", ((User)top._data[i]).GetSurname());
                Console.WriteLine(" Телефон: {0}", ((User)top._data[i]).GetTel());
            }
            
        }

        public void Remove(int i)
        {
            if (count != 0)
            {
                top.Remove(i);
            }
        }
    }
}
