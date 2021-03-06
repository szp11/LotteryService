﻿namespace LotteryService.Common.Enums
{
    public enum ResultCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 200,

        /// <summary>
        /// 失败
        /// </summary>
        Fail = 400,

        /// <summary>
        /// 未被允许的请求
        /// </summary>
        NotAllowed = 401,

        /// <summary>
        /// 服务器内部错误
        /// </summary>
        ServiceError = 500,

        /// <summary>
        /// 校验输入参数失败
        /// </summary>
        VerifyInputError = 501,
    }
}