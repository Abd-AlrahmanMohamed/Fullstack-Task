global using Microsoft.EntityFrameworkCore.Infrastructure;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Infrastructure.Interfaces;
global using System.Collections;
global using Microsoft.EntityFrameworkCore.Migrations;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


//Domin
global using Domin;
global using Domin.Models;
global using Domin.Login;
global using Domin.SignUp;


global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
global using Microsoft.Extensions.Options;


global using IAuthenticationService = Infrastructure.Interfaces.IAuthenticationService;
global using AuthenticationService = Infrastructure.Implementations.AuthenticationService;