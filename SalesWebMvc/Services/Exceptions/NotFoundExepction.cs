using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions {
    public class NotFoundExepction : ApplicationException{

        public NotFoundExepction(string message) : base(message) {

        }
    }
}
