using Business.Model.common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Business.Model.Surtido
{
    public class SurtidoMaximoModel : BaseModel
    {
       public IFormFile file { get; set; }

      
      
    }
}
