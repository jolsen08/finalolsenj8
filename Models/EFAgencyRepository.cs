using EntertainmentAgencyolsenj8.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace EntertainmentAgencyolsenj8.Models
{
    public class EFAgencyRepository : IAgencyRepository
    {
        //Taking in the context
        private AgencyDbContext context { get; set; }

        public EFAgencyRepository(AgencyDbContext temp)
        {
            context = temp;
        }
        public IQueryable<Entertainer> Entertainers => context.Entertainers;


        //Writing my own update and remove functions for the controller
        public void Update(Entertainer model)
        {
            context.Update(model);
            context.SaveChanges();
        }

        public void Remove(Entertainer model)
        {
            context.Remove(model);
            context.SaveChanges();
            
        }

        public void Add(Entertainer model)
        {
            context.Add(model);
            context.SaveChanges();
        }

    }
}
