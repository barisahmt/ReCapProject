﻿using Business.Constants;
using Castle.DynamicProxy;
using Core.Extantions;
using Core.Utilites.İntercaptors;
using Core.Utilites.IoS;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac;

//JWT
public class SecuredOperation : MethodInterception
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly string[] _roles;

    public SecuredOperation(string roles)
    {
        _roles = roles.Split(',');
        _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
    }

    protected override void OnBefore(IInvocation invocation)
    {
        var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
        foreach (var role in _roles)
            if (roleClaims.Contains(role)) // burası false dönüyor true dönmesi lazım
                return;
        throw new Exception(Messages.AuthorizationDenied);
    }
}