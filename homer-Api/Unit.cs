using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Repository.Interface;
using Data.Repository.Provider;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static HomerEndpoints.Utility.HttpCodes;

namespace HomerEndpoints
{
    public class Unit
    {
        private readonly HomerDbContext _context;
        private readonly ILogin _loginService;

        public Unit(HomerDbContext context)
        {
            _context = context;
            _loginService = new Login(_context);

        }

        #region LoginService
        public string CreateUser(Users User)
        {
            try
            {

                var _User = _loginService.Create(User);
                return JsonConvert.SerializeObject(new ErrorModel<Users>
                {
                    Code = Codes.Ok,
                    Data = _User,
                    Message = "Operation Successful"
                });
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new ErrorModel<Users>
                {
                    Code = Codes.Error,
                    Message = ex.Message,
                    Data = User
                });
            }
        }

        public string FindUser(Users User)
        {
            try
            {
                var _User = _loginService.Read(User);
                return JsonConvert.SerializeObject(new ErrorModel<Users>
                {
                    Code = Codes.Ok,
                    Data = _User,
                    Message = "Operation Successful"
                });
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new ErrorModel<Users>
                {
                    Code = Codes.Error,
                    Message = ex.Message,
                    Data = User
                });
            }
        }

        public string UpdateUser(Users User)
        {
            try
            {
                var _User = _loginService.Update(User);
                return JsonConvert.SerializeObject(new ErrorModel<Users>
                {
                    Code = Codes.Ok,
                    Data = _User,
                    Message = "Operation Successful"
                });
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new ErrorModel<Users>
                {
                    Code = Codes.Error,
                    Message = ex.Message,
                    Data = User
                });
            }
        }
        #endregion


    }
}
