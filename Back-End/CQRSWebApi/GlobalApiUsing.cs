global using MediatR;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.IdentityModel.Tokens;
global using System.Text;
global using Microsoft.AspNetCore.Mvc;


//Infrastructure


global using Infrastructure;
global using IAuthenticationService = Infrastructure.Interfaces.IAuthenticationService;


//Handler
global using Handler;
global using Handler.Extensions;
global using Handler.Dto;

//Domin
global using Domin;
global using Domin.Models;
global using Domin.SignUp;
global using Domin.Login;
global using Domin.Routing.BaseRouter;


//MediatorComman
global using Handler.MediatorHandler.MediatorCommand.Products;

//MediatorQuery
global using Handler.MediatorHandler.MediatorQuery.Products;
