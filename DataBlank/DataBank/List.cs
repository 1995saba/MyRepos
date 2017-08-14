using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBank
{
    class List
    {
        public Object[] _data;
        public int size;
       bool propusk;
        public List()
        {
            size = 1;
            _data = new Object[size];
            propusk = false;

        }

        public void Wide()
        {
            Object[] _newData = new Object[size + 1];
            for (int i = 0; i < size; i++)
            {
                _newData[i] = _data[i];
            }
            size++;
            _data = _newData;

        }

        public void Remove(int x)
        {

            Object[] _newData = new Object[size - 1];
            for (int i = 0; i < size - 1; i++)
            {
                if (i == x) { propusk = true; }

                if (propusk == false)
                {
                    _newData[i] = _data[i];
                }

                else if(propusk == true) {
                    _newData[i] = _data[i+1];
                }
                
            }

            size--;
            _data = _newData;
        }
        
    }
}
