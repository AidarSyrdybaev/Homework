﻿using HomeWorkApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Repositories.Contracts
{
    public interface ICafeRepository: IRepository<Cafe>
    {
        Cafe GetCafeAllDish(int Id);
    }
}
