﻿using System;
using System.Collections.Generic;

namespace UmotaWebApp.Shared.ScaffoldModels;

public partial class KullaniciDetayTalepturu
{
    public int Logref { get; set; }

    public int Parlogref { get; set; }

    public string KullaniciKodu { get; set; }

    public int? Talepturref { get; set; }

    public string Aciklama { get; set; }

    public byte? Active { get; set; }

    public int? Status { get; set; }

    public string Insuser { get; set; }

    public DateTime? Insdate { get; set; }

    public string Upduser { get; set; }

    public DateTime? Upddate { get; set; }
}