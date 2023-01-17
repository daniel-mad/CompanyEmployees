using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Responses;
public abstract class ApiBaseResponse
{
    public bool Succsess { get; set; }
    public ApiBaseResponse(bool success) => Succsess = success;
}
