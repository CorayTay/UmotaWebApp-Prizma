﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;

namespace UmotaWebApp.Server.Services.Infrastructure
{
    public interface ITakvimService
    {
        public Task<List<TakvimDto>> GetTakvimInformation(TakvimRequestDto request);
    }
}
