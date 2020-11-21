﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Bombero))]
    public interface IArchivos<X>
    {
        void Guardar(X info);
        X Leer();
    }
}