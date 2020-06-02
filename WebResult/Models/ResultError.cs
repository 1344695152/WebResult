using System;
using System.Collections.Generic;
using System.Text;

namespace WebResult.Models
{
    public class ResultError
    {
    }
    /// <summary>
    /// 业务异常
    /// </summary>
    public class BusException : Exception
    {
        public BusException(string msg) : base(msg) { }
    }
    /// <summary>
    /// 授权错误
    /// </summary>
    public class AuthorizedException : Exception
    {
        public AuthorizedException(string msg) : base(msg) { }
    }
}
