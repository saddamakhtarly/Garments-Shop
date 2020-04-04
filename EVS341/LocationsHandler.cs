using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS341
{
    public class LocationsHandler
    {

        #region countries

        public List<Country> GetCountries()
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                return (from c in context.Countries
                        select c).ToList();
            }
        }

        public Country GetCountry(int id)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                return (from c in context.Countries
                        where c.Id == id
                        select c).First();
            }
        }

        public void AddCountry(Country country)
        {
            using (GarmentsContext context=new GarmentsContext())
            {
                context.Countries.Add(country);
                context.SaveChanges();
            }
        }

        public void UpdateCountry(int idToSearch,Country country)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                Country found = context.Countries.Find(idToSearch);
                found.Name = country.Name;
                if (country.Code.HasValue)
                {
                    found.Code = country.Code;
                }
                context.SaveChanges();
            }
        }

        public void DeleteCountry(int idToSearch)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                Country found = context.Countries.Find(idToSearch);
                context.Countries.Remove(found);
                context.SaveChanges();
            }
        }

        #endregion

        #region provinces
        public List<Province> GetProvinces()
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                return (from p in context.Provinces
                        .Include(o=>o.Country)
                        select p).ToList();
            }
        }

        public Province GetProvince(int id)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                return (from p in context.Provinces
                       .Include(o => o.Country)
                        select p).First();
            }
        }

        public void AddCountry(Province province)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                context.Entry(province.Country).State = EntityState.Unchanged;
                context.Provinces.Add(province);
                context.SaveChanges();
            }
        }

      
        #endregion

    }






}
