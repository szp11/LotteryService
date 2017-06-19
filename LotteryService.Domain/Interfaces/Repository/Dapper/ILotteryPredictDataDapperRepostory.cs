﻿using Lottery.Entities;
using LotteryService.Common.Dependency;

namespace LotteryService.Domain.Interfaces.Repository.Dapper
{
    public interface ILotteryPredictDataDapperRepostory : ITransientDependency
    {
        LotteryPredictData GetCurrentLotteryPredictData(string normId, int currentPredictPeriod);

        bool Update(LotteryPredictData lotteryPredictData);

        bool Insert(LotteryPredictData lotteryPredictData);
    }
}