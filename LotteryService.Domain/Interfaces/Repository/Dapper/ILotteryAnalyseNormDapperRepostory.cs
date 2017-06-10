﻿using System.Collections.Generic;
using Lottery.Entities;
using LotteryService.Common.Dependency;
using LotteryService.Common.Enums;

namespace LotteryService.Domain.Interfaces.Repository.Dapper
{
    public interface ILotteryAnalyseNormDapperRepostory : ITransientDependency
    {
        IDictionary<LotteryType, IList<LotteryAnalyseNorm>> GetAll();
    }
}