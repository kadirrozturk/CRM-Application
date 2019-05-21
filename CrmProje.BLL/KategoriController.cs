﻿using CrmProje.BLL.IServices;
using CrmProje.BLL.Services;
using CrmProje.DAL.Repositories;
using CrmProje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProje.BLL
{
    public class KategoriController : ServiceBase<Kategori,int>,IKategoriService
    {
        public KategoriController():base(new KategoriRepository())
        {

        }
    }
}
