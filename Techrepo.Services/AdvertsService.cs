﻿using System;
using System.Linq;
using Techrepo.Data;
using Techrepo.Models;

namespace Techrepo.Services
{
    public class AdvertsService : IAdvertsService
    {
        private readonly ITechrepoDbContext techrepoContext;

        public AdvertsService(ITechrepoDbContext techrepoContext)
        {
            this.techrepoContext = techrepoContext;
        }

        public IQueryable<Advert> GetAllAdverts()
        {
            return this.techrepoContext.Adverts;
        }

        public void CreateAdvert(Advert advert)
        {
            this.techrepoContext.Adverts.Add(advert);
            this.techrepoContext.SaveChanges();
        }

        public Advert GetById(int? id)
        {
            return id.HasValue ? this.techrepoContext.Adverts.Find(id) : null;
        }


        public IQueryable<Advert> GetAdvertByTitleOrDescription(string searchTerm)
        {
            return string.IsNullOrEmpty(searchTerm) ? this.techrepoContext.Adverts
                : this.techrepoContext.Adverts.Where(a =>
                 (string.IsNullOrEmpty(a.Title) ? false : a.Title.Contains(searchTerm))
                 ||
                 (string.IsNullOrEmpty(a.Description) ? false : a.Description.Contains(searchTerm)));
        }

        public void DeleteAdvert(int id)
        {
            Advert advertToBeDeleted = this.GetById(id);
            this.techrepoContext.Adverts.Remove(advertToBeDeleted);

            this.techrepoContext.SaveChanges();

        }

        public void UpdateAdvert(Advert advert)
        {
            Advert advertToBeUpdated = this.GetById(advert.Id);

            advertToBeUpdated = advert;

            this.techrepoContext.SaveChanges();
        }
    }
}
