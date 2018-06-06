using AutoMapper;

namespace CleanArch.CoreLibrary.AutoMapperProfiles
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingsProfile>();
            });
        }
    }
}