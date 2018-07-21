using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
 * * FileName :       IMyList.cs
 * * CreationDate:    Saturday July 21,2018
 * * Original Author: Simon
 * * Description:     Interface of MyList resemble as List.
 * *************************************************************/
namespace TypeEmbeded
{
    public interface IMyList<T>
    {
        void Add(T a);
        //有点像索引器
        T this[int index]{get;}
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
