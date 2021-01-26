﻿using BdCoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BdCoin.Service
{
    public interface IchainService
    {
        bool Add(chain chainobj);
        bool Delete(int id);
        List<chain> GetAll();
        chain GetById(int id);
    }
}
