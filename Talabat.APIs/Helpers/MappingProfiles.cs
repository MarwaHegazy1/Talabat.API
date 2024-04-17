using AutoMapper;
using Talabat.APIs.Dtos;
using Talabat.Core.Entities;

namespace Talabat.APIs.Helpers
{
	public class MappingProfiles:Profile
	{
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d=>d.Brand, O=>O.MapFrom(S=>S.Brand.Name))
				.ForMember(d => d.Category, O => O.MapFrom(S => S.Category.Name));
        }
    }
}
