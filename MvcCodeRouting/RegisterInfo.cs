﻿// Copyright 2011 Max Toro Q.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace MvcCodeRouting {
   
   class RegisterInfo {

      CodeRoutingSettings _Settings;

      public Assembly Assembly { get; private set; }
      public string RootNamespace { get; set; }
      public string BaseRoute { get; set; }
      
      public CodeRoutingSettings Settings {
         get {
            if (_Settings == null) 
               _Settings = new CodeRoutingSettings();
            return _Settings;
         }
         set { _Settings = value; }
      }

      public RegisterInfo(Assembly assembly) {

         if (assembly == null) throw new ArgumentNullException("assembly");

         this.Assembly = assembly;
      }
   }
}
