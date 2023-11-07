using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Prizma.Core.Model;
using UmotaWebApp.Server.Data.Models;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;

namespace UmotaWebApp.Server.Services.Extensions
{

    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<SisKullanici, SisKullaniciDto>().ReverseMap();
            CreateMap<SisMenuler, SisMenuDto>().ReverseMap();
            CreateMap<SisFirmaDonemYetki, SisFirmaDonemYetkiDto>().ReverseMap();
            CreateMap<SisFirmaDonem, SisFirmaDonemDto>().ReverseMap();
            CreateMap<CariKart, CariKartDto>().ReverseMap();
            CreateMap<Teklif, TeklifDto>().ReverseMap();
            CreateMap<MalzKart, MalzemeKartDto>().ReverseMap();
            CreateMap<Teklifdetay, TeklifDetayDto>().ReverseMap();
            CreateMap<V002Malzemeler, VMalzemeKartDto>().ReverseMap();
            //CreateMap<V002Malzemeler, MalzemeKartDto>().ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active.HasValue ? (src.Active.Equals(1) ? byte.Parse("1") : byte.Parse("0")) : byte.Parse("0")));
            CreateMap<MalzKart, MalzKartLog>().ReverseMap();

            CreateMap<Teklif, TeklifLog>().ReverseMap();
            CreateMap<Teklifdetay, TeklifdetayLog>().ReverseMap();
            CreateMap<V001CariKart, VCariKartDto>().ReverseMap();
            //.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active.HasValue ? (src.Active.Equals(1) ? byte.Parse("1") : byte.Parse("0")) : byte.Parse("0")))
            //.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.HasValue ? (src.Status.Equals(1) ? byte.Parse("1") : byte.Parse("0")) : byte.Parse("0")));

            CreateMap<V009Teklif, TeklifDto>().ReverseMap();
            CreateMap<V020Faaliyet, FaaliyetDto>().ReverseMap();
            CreateMap<Faaliyet, FaaliyetDto>().ReverseMap();
            CreateMap<Kisiler, KisilerDto>().ReverseMap();
            CreateMap<V015Kisiler, KisilerDto>().ReverseMap();
            CreateMap<TeklifDurumDetay, TeklifDurumDetayDto>().ReverseMap();
            CreateMap<SisMenuProfil, SisMenuProfilDto>().ReverseMap();
            CreateMap<V004Sevkadre, SevkAdresDto>().ReverseMap();
            CreateMap<Takvim, TakvimDto>().ReverseMap();
            CreateMap<Vazife, VazifeDto>().ReverseMap();
            CreateMap<Servi, ServisDto>().ReverseMap();
            CreateMap<V012Servi, ServisDto>().ReverseMap();
            CreateMap<ServisMalzemeler, ServisMalzemeDto>().ReverseMap();
            CreateMap<V012ServisMalzemeler, ServisMalzemeDto>().ReverseMap();
            CreateMap<Servi, ServisLog>().ReverseMap();
            CreateMap<ServisMalzemeler, ServisMalzemelerLog>().ReverseMap();
            CreateMap<ImageData, ImageDataDto>().ReverseMap();

            CreateMap<TalepDetay, TalepDetayDTO>().ReverseMap();
            CreateMap<TalepFis, TalepFisDto>().ReverseMap();
            CreateMap<Proje,ProjeDto>().ReverseMap();
            CreateMap<Mahal, MahalDto>().ReverseMap();
            CreateMap<TalepDosya, TalepDosyaDto>().ReverseMap();
            CreateMap<Siparis, SiparisDto>().ReverseMap();
            CreateMap<SiparisDetay, SiparisDetayDto>().ReverseMap();
            CreateMap<V040_Siparis, SiparisDto>().ReverseMap();
            CreateMap<V041_SiparisDetay, SiparisDetayDto>().ReverseMap();
            CreateMap<SiparisOnay, SiparisOnayDto>().ReverseMap();
            CreateMap<V042_SiparisOnay, SiparisOnayDto>().ReverseMap();
        }
    }

}
