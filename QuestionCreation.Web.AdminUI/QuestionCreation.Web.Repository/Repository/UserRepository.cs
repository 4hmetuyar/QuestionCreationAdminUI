﻿using QuestionCreation.Web.Data;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Repository.Repository
{


    public class UserRepository : BaseRepository<User, UserViewModel>, IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

    }
}
