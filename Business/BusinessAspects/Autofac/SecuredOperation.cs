using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Business.Constants;
using Core.Extensions;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles; // Aspect claimlerini tuttuğumuz array liste
        private IHttpContextAccessor _httpContextAccessor;
        // JWB göndererek bir istek yapıyoruz ama aynanda binlerce kiş istek atabilir
        // Her birisi için HttpContextAccessor oluşur. 
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>(); // injection IoC 

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {// Bu kullanıcının rollerini gez, eğer claim'lerinini içinde ilgili rol varsa, retrun et. Metodu çaıltırmaya devam et 
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
            // Eğer yetkisi eşleşmiyor ise, yetkin yok hatası veriyoruz.
        }
    }
}
