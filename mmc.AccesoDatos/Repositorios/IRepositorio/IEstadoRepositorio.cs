﻿using mmc.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmc.AccesoDatos.Repositorios.IRepositorio
{
    public interface IEstadoRepositorio: IRepositorio<estado>
    {
        void Actualizar(estado Oestado);
    }
}