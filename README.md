﻿MvcCodeRouting — Namespace-based Modularity for ASP.NET MVC and Web API
=======================================================================

- Break your application into as many parts as you want, using namespaces and projects
- URL generation and Views location are relative to the module
- Embed your views which can be overridden by files views in the host application
- Create reusable portable modules

Convention over configuration Automatic Routing
-----------------------------------------------
- Routes are automatically created for you using convention over configuration
- Break away from the convention using attribute routes
- Default constraints for primitive types that can be overridden on a per-parameter or per-module basis
- Intelligent grouping of similar routes for efficient matching
- Formatting of routes (e.g. to lowercase, hyphen-separated, underscore-separated, etc)

MvcCodeRouting is an alternative to
-----------------------------------
- Conventional routing
- Custom routing
- Attribute routing
- Areas

Motivation
----------
- [Why ASP.NET MVC Routing sucks](http://maxtoroq.github.io/2014/02/why-aspnet-mvc-routing-sucks.html)
- [Rethinking ASP.NET MVC: Workflow per Controller](http://maxtoroq.github.io/2013/02/aspnet-mvc-workflow-per-controller.html)

Resources
---------
- [Documentation](docs/README.md)
- [Ask for help](http://maxtoroq.github.io/MvcCodeRouting/discussions/)
- [Report an issue](http://maxtoroq.github.io/MvcCodeRouting/issues/)
