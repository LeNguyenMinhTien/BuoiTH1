using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    public interface IDataObject<T>
    {
        void NextRecord();
        void PriorRecord();
        void AddRecord(T t);
        void DeleteRecord(T t);
        T GetCurrentRecord();
        void ShowRecord();
        void ShowAllRecords();
    }


}
