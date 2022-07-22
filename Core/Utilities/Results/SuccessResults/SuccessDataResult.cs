using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.SuccessResults
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data, bool success) : base(data, true)
        {

        }

        public SuccessDataResult(T data, bool success, string message) : base(data, true, message)
        {

        }
    }
}
