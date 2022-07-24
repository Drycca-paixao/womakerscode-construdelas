﻿using Biblioteca.WoMakersCode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Core.Repositories
{
    public interface IAutorRepository : IRepository<Autor>
    {
        Task Inserir(Autor obj);
    }
}
