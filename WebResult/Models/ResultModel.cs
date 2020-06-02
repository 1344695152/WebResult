using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WebResult.Models
{
    public enum EnumResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        success = 200,
        /// <summary>
        /// 失败
        /// </summary>
        failure = 300,
        /// <summary>
        /// 系统出现异常
        /// </summary>
        error = 500,
        /// <summary>
        /// 没有权限
        /// </summary>
        unAuthorized = 501,
        /// <summary>
        /// 业务异常一般用来，不满足业务时，不执行以后代码
        /// </summary>
        busError = 502
    }
    public class BaseResult
    {
        public int code { get; set; } = (int)EnumResult.success;
        public string message { get; set; }
    }
    public class ResultPage
    {
        public ResultPage(int _page, int _limit, int _count)
        {
            page = _page;
            page = _limit;
            page = _count;
            totalPages = (_count + _limit - 1) / _page;
        }
        public int page { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
        public int totalPages { get; set; }
    }
    public class ResultNoData : BaseResult
    {

    }

    public class ResultModel<T> : BaseResult
    {
        public T data { get; set; }
    }
    /// <summary>
    /// 返回集合与总数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultList<T>
    {
        public ResultList(IEnumerable<T> _data, int _count)
        {
            data = _data;
            count = _count;
        }
        public IEnumerable<T> data { get; set; }
        public int count { get; set; }
    }
    /// <summary>
    /// 返回集合与分页信息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultListAndPage<T>
    {
        public ResultListAndPage(IEnumerable<T> _data, int _page, int _limit, int _count)
        {
            data = _data;
            page = new ResultPage(_page, _limit, _count);
        }
        public IEnumerable<T> data { get; set; }
        public ResultPage page { get; set; }
    }

}
