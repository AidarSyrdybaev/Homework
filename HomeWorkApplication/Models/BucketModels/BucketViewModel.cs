using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWorkApplication.DAL.Entities;

namespace HomeWorkApplication.Models.Bucket
{
    public class BucketViewModel
    {
        public int Id { get; set; }



        public Cafe Cafe { get; set; }
    }
}
