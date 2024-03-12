using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class DataList<T>
    {
        private T[] _datas = new T[0];

        public void Add(T value)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length -1] = value;
        }

        public T[] Get()
        {
            return _datas;
        }

        public T[] Delete(T value)
        {
            _datas = _datas.Where(x => !x.Equals(value)).ToArray();
            return _datas;
        }

        public void Delete2(T value)
        {
            var result = Array.IndexOf(_datas, value);

            for (int i = result; i < _datas.Length - 1; i++)
            {
                _datas[i] = _datas[i + 1];
            }
            _datas[_datas.Length - 1] = default;
            Array.Resize(ref _datas, _datas.Length - 1);
        }
    }
}
