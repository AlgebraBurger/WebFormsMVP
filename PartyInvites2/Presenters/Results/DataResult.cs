using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites2.Presenters.Results
{
    public class DataResult<T> : IResult
    {
        private T dataItem;
        public DataResult(T data)
        {
            dataItem = data;
        }
        public T DataItem
        {
            get
            {
                return dataItem;
            }
        }
    }
}
