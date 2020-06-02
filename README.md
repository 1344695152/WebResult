## 使用说明

1. 引入WebResult.dll

2. ResultUtil.Run(()=>{});无数据返回

   ```c#
   return ResultUtil.Run(() =>
    {
         ResultNoData result = new ResultNoData();
       //someting code
        return result;
    });
   ```

    

3. 示例

   ```c#
    		/// <summary>
           /// 心跳检测 或者新增 删除 修改 等返回成功失败
           /// </summary>
           /// <param name="input"></param>
           /// <returns></returns>
           [Route("Heartbeat")]
           [HttpGet]
           public ResultNoData Heartbeat()
           {
               return ReturnFun(() =>
               {
                   ResultNoData result = new ResultNoData();
                   //someting code
                   return ret;
               });
           }
   ```

4. ResultUtil.RunModel(()=>{});有数据返回

   ```c#
   return ResultUtil.RunModel(() =>
    {
         ResultModel<string> result = new ResultModel<string>();
       //someting code
        return result;
    });
   ```

5. 示例

   ```c#
   		/// <summary>
           /// 导出execl
           /// </summary>
           /// <param name="input"></param>
           /// <returns></returns>
           [Route("Export")]
           [HttpGet]
           public ResultModel<string> Export()
           {
               return ReturnFun(() =>
               {
                   ResultModel<string> ret = new ResultModel<string>();
                   ret.data= Guid.NewGuid().ToString();
                   return ret;
               });
           }
   ```

6. 内置了两种集合返回方式WebResult.Models.ResultList<T>与WebResult.Models.ResultListAndPage<T>

7. 异常类型:WebResult.Models.BusException(业务错误)和WebResult.Models.AuthorizedException(授权错误)，业务错误一般用于断言，当判断某个条件不满足业务时使用，例如新增用户时，某字段需要去数据库查找是否存在不存在则应该在此提示未找到数据，这是使用 throw new BusException(“XXX不存在，不允许新增”);

8. WebResult.Models.EnumResult是返回值Code的专用代码。

