﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public interface ICrud<T>
    {
       string Registrar(T entity);
    }
}