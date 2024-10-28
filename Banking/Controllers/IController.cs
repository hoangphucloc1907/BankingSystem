﻿using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Controllers
{
    internal interface IController
    {
        List<IModel> Items { get; }
        bool Create(IModel model);
        bool Update(IModel model);
        bool Delete(object id);
        IModel Read(object id);
        bool Load();
        bool Load(object id);
        bool IsExist(object id);
        bool IsExist(IModel model);
    }
}
