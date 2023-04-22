
using EntertainmentAgencyolsenj8.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace EntertainmentAgencyolsenj8.Models
{
    //This interface object creates the IQueryable type object "Entertainers". This class will be referenced in the 
    //EFAgencyRepository class
    public interface IAgencyRepository
    {
        IQueryable<Entertainer> Entertainers { get; }

        void Update(Entertainer model);

        void Remove(Entertainer model);

        void Add(Entertainer model);
    }
    
}
