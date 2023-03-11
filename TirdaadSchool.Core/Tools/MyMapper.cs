namespace TirdaadSchool.Core.Tools;

public static class MyMapper
{
    
    public static TDto MapTo<Tentiy, TDto>(Tentiy entity)
    {
        var config = new AutoMapper.MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Tentiy, TDto>();
        });
        var mapper = config.CreateMapper();
        var dto = mapper.Map<TDto>(entity);
        return dto;
    }
    
}