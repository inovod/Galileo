using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.oAuth.DTO
{
    public class UserInfo_Dto
    {
        public UserInfo_Dto()
        {

        }
        public UserInfo_Dto(string id,bool bloquedo)
        {
            this.Id = id;
            this.LockOutEnabled = bloquedo;
        }
        public string Id { get; set; }
        public bool LockOutEnabled { get; set; }

        

    }
}
