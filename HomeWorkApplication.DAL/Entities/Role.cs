using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HomeWorkApplication.DAL.Entities
{
    public class Role: IdentityRole<int>, Entity
    {
    }
}
