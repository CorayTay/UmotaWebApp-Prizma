﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;

namespace UmotaWebApp.Server.Services.Infrastructure
{
    public interface ISisKullaniciService
    {
        public Task<List<SisKullaniciDto>> GetSisKullaniciList();

        public Task<SisKullaniciDto> GetSisKullanici(string kod);

        Task<SisKullaniciLoginResponseDto> Login(SisKullaniciLoginRequestDto request);
    }
}
