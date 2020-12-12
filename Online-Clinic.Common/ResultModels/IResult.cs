using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Clinic.Common.ResultModels
{
    public interface IResult
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
    }
}
