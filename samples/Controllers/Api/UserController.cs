﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samples.Controllers.Admin {
   
   public class UserController : CrudController<User, int> { }

   public class User { }
}