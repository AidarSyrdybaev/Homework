using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Models.Bucket;
using HomeWorkApplication.Models.BucketModels;
using HomeWorkApplication.Models.CafeModels;
using HomeWorkApplication.Models.OrderModels;
using Newtonsoft.Json;

namespace HomeWorkApplication
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CafeToCafeModel();
            BucketToBucketModel();
            OrderToOrderModel();
        }

        private void CafeToCafeModel()
        {
            CreateMap<CafeViewModel, Cafe>();
            CreateMap<Cafe, CafeViewModel>();
            CreateMap<CafeDetailsModel, Cafe>();
            CreateMap<Cafe,CafeDetailsModel> ();
        }

        private void BucketToBucketModel()
        {
            CreateMap<Bucket, BucketViewModel>();
            CreateMap<BucketViewModel, Bucket>();
            CreateMap<Bucket, BucketDetailsModel>().
                ForMember(target => target.BucketItems, src => src.MapFrom(source => JsonConvert.DeserializeObject<List<BucketItem>>(source.JsonDishes)));
            CreateMap<BucketDetailsModel, Bucket>()
                .ForMember(target => target.JsonDishes, src => src.MapFrom(source => JsonConvert.SerializeObject(source.BucketItems)));
        }

        private void OrderToOrderModel()
        {
            CreateMap<Order, OrderViewModel>().ForMember(target => target.BucketItems,
                src => src.MapFrom(source => JsonConvert.DeserializeObject(source.JsonDishes)));
        }
    }
}
