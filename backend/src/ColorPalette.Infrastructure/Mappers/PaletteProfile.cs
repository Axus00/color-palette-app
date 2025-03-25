using AutoMapper;
using ColorPalette.Application.DTOs;
using ColorPalette.Domain.Entities;

namespace ColorPalette.Infrastructure.Mappers;

public class PaletteProfile : Profile
{
    public PaletteProfile()
    {
        CreateMap<Palette, PaletteDto>();
    }
}