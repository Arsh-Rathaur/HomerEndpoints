using Data.Models;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data.Repository.Provider
{
    public class Login : ILogin
    {
        public HomerDbContext context = null;


        public Login(HomerDbContext _context)
        {
            context = _context;
        }

        public Users Create(Users User)
        {
            context.Users.Add(User);
            context.SaveChanges();

            return User;
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Users Read(Users User)
        {
            var data = context
                        .Users
                            .Where(x => x.UserId == User.UserId && x.UserName == User.UserName)
                                .FirstOrDefault();

            if (data != null)
                return data;
            else
                return new Users();
        }

        public Users Update(Users User)
        {
            context.Users.Update(User);
            return Read(User);
        }
    }
}
