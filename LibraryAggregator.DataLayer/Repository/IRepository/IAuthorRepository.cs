﻿using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IAuthorRepository : IRepository<Author>
    {
         Task<List<Author>> GetAllFullInfoAuthorsAsync();
    }
}
