﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Lottery.Entities
{
    public class LotteryNorm 
    {
        public string Version { get; set; }

        public string FeatureId { get; set; }

        public string LotteryType { get; set; }
    
    }
}