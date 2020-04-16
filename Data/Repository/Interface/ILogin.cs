using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository.Interface
{
    public interface ILogin
    {
        public Users Create(Users User);
        public Users Read(Users User);
        public Users Update(Users User);
        public bool Delete(int Id);
    }
}
