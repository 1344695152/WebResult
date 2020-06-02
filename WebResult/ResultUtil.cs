using System;
using WebResult.Models;

namespace WebResult
{
    public class ResultUtil
    {
        /// <summary>
        /// 返回没有无数据
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public static ResultNoData Run(Func<ResultNoData> func)
        {
            ResultNoData result = new ResultNoData();
            try
            {
                result = func();
            }
            catch (BusException ex)
            {
                if (ResultSetting.ShowException)
                    throw ex;
                result.code = (int)EnumResult.busError;
                result.message = ex.Message;
            }
            catch (AuthorizedException ex)
            {
                if (ResultSetting.ShowException)
                    throw ex;
                result.code = (int)EnumResult.unAuthorized;
                result.message = ex.Message;
            }
            catch (Exception ex)
            {
                if (ResultSetting.ShowException)
                    throw ex;
                result.code = (int)EnumResult.error;
                result.message = ResultSetting.ShowExceptionStr;
            }
            return result;
        }
        /// <summary>
        /// 返回含数据部分
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static ResultModel<T> RunModel<T>(Func<ResultModel<T>> func)
        {
            ResultModel<T> result = new ResultModel<T>();
            try
            {
                result = func();
            }
            catch (BusException ex)
            {
                if (ResultSetting.ShowException)
                    throw ex;
                result.code = (int)EnumResult.busError;
                result.message = ex.Message;
            }
            catch (AuthorizedException ex)
            {
                if (ResultSetting.ShowException)
                    throw ex;
                result.code = (int)EnumResult.unAuthorized;
                result.message = ex.Message;
            }
            catch (Exception ex)
            {
                if (ResultSetting.ShowException)
                    throw ex;
                result.code = (int)EnumResult.error;
                result.message = ResultSetting.ShowExceptionStr;
            }
            return result;
        }
    }
}
