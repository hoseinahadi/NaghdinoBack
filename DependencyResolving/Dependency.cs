using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.IMP;
using BusinessServiceContract.Services;
using DataAccess.Repositories;
using DataAccessServicessContract.Services;
using DomainModel.Models.Context;
using Framework.Helper;
using Framework.Password;
using Framework.Token;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyResolving
{
    public static class Dependency
    {
        public static void dependency(IServiceCollection services, string connection)
        {
            
            services.Configure<CookiePolicyOptions>(option =>
            {
                option.CheckConsentNeeded = (context =>true) ;
                option.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ShikaShopContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(connection);
            }, ServiceLifetime.Scoped);
            services.AddTransient<IAccessRepository, AccessRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<ICarrierRepository, CarrierRepository>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IImageRepository, ImageRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IConnectionRepository, ConnectionRepository>();
            services.AddTransient<IContactUsRepository, ContactUsRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            services.AddTransient<IDiscountRepository, DiscountRepository>();
            services.AddTransient<IFeatureRepository, FeatureRepository>();
            services.AddTransient<IGenderRepository, GenderRepository>();
            services.AddTransient<IGuestUserRepository, GuestUserRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IOpSystemRepository, OpSystemRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderReturnRepository, OrderReturnRepository>();
            services.AddTransient<IPageRepository, PageRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProjectActionRepository, ProjectActionRepository>();
            services.AddTransient<IProjectControllerRepository, ProjectControllerRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddTransient<ITaxRepository, TaxRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IWebBrowserRepository, WebBrowserRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<ICategoryDiscountRepository, CategoryDiscountRepository>();
            services.AddTransient<IGenerateNewToken, GenerateToken>();
            services.AddTransient<ICategoryDiscountRepository, CategoryDiscountRepository>();
            services.AddTransient<ICategoryFeatureRepository, CategoryFeatureRepository>();
            services.AddTransient<ICountryDiscountRepository, CountryDiscountRepository>();
            services.AddTransient<IEmployeeDiscountRepository, EmployeeDiscountRepository>();
            services.AddTransient<IEmployeeMessageRepository, EmployeeMessageRepository>();
            services.AddTransient<IGuestUserMessageRepository, GuestUserMessageRepository>();
            services.AddTransient<IOrderDiscountRepository, OrderDiscountRepository>();
            services.AddTransient<IOrderMessageRepository, OrderMessageRepository>();
            services.AddTransient<IOrderReturnMessageRepository, OrderReturnMessageRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IProductDiscountRepository, ProductDiscountRepository>();
            services.AddTransient<IProductFeatureRepository, ProductFeatureRepository>();
            services.AddTransient<IProductOrderReturnRepository, ProductOrderReturnRepository>();
            services.AddTransient<IProductSupplierRepository, ProductSupplierRepository>();
            services.AddTransient<ISupplierImageRepository, SupplierImageRepository>();
            services.AddTransient<IUserDiscountRepository, UserDiscountRepository>();
            services.AddTransient<IUserFavoriteRepository, UserFavoriteRepository>();
            services.AddTransient<IUserMessageRepository, UserMessageRepository>();
            services.AddTransient<IProductCartRepository, ProductCartRepository>();
            services.AddTransient<IOrderProductRepository, OrderProductRepository>();



            services.AddScoped<IAccountRepository, AccountRepository>();



            services.AddHttpContextAccessor();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, option =>
            {
                option.LoginPath = new PathString("/Account/Login");
                option.LogoutPath = new PathString("/Account/Logout");
                option.AccessDeniedPath = new PathString("/Account/Login");
            });

            services.AddScoped<CustomAuthenticator>();
            services.AddScoped<IAccessBusiness, AccessBusiness>();
            services.AddScoped<IAddressBusiness, AddressBusiness>();
            services.AddScoped<ICarrierBusiness, CarrierBusiness>();
            services.AddScoped<ICartBusiness, CartBusiness>();
            services.AddScoped<ICategoryBusiness, CategoryBusiness>();
            services.AddScoped<IImageBusiness, ImageBusiness>();
            services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
            services.AddScoped<IProductBusiness, ProductBusiness>();
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IConnectionBusiness, ConnectionBusiness>();
            services.AddScoped<IAccountApplication, AccountApplication>();
            services.AddScoped<IAuthHelper, AuthHelper>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IContactUsBusiness, ContactUsBusiness>();
            services.AddScoped<ICountryBusiness, CountryBusiness>();
            services.AddScoped<ICurrencyBusiness, CurrencyBusiness>();
            services.AddScoped<IDeliveryBusiness, DeliveryBusiness>();
            services.AddScoped<IDiscountBusiness, DiscountBusiness>();
            services.AddScoped<IFeatureBusiness, FeatureBusiness>();
            services.AddScoped<IGenderBusiness, GenderBusiness>();
            services.AddScoped<IGuestUserBusiness, GuestUserBusiness>();
            services.AddScoped<ILocationBusiness, LocationBusiness>();
            services.AddScoped<IMessageBusiness, MessageBusiness>();
            services.AddScoped<IOpSystemBusiness, OpSystemBusiness>();
            services.AddScoped<IOrderBusiness, OrderBusiness>();
            services.AddScoped<IOrderReturnBusiness, OrderReturnBusiness>();
            services.AddScoped<IPageBusiness, PageBusiness>();
            services.AddScoped<IProductBusiness, ProductBusiness>();
            services.AddScoped<IProjectActionBusiness, ProjectActionBusiness>();
            services.AddScoped<IProjectControllerBusiness, ProjectControllerBusiness>();
            services.AddScoped<IRoleBusiness, RoleBusiness>();
            services.AddScoped<ISupplierBusiness, SupplierBusiness>();
            services.AddScoped<ITaxBusiness, TaxBusiness>();
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IWebBrowserBusiness, WebBrowserBusiness>();
            services.AddScoped<ICategoryDiscountBusiness, CategoryDiscountBusiness>();
            services.AddScoped<ICountryDiscountBusiness, CountryDiscountBusiness>();
            services.AddScoped<IEmployeeDiscountBusiness, EmployeeDiscountBusiness>();
            services.AddScoped<IEmployeeMessageBusiness, EmployeeMessageBusiness>();
            services.AddScoped<IGuestUserMessageBusiness, GuestUserMessageBusiness>();
            services.AddScoped<IOrderDiscountBusiness, OrderDiscountBusiness>();
            services.AddScoped<IOrderMessageBusiness, OrderMessageBusiness>();
            services.AddScoped<IOrderReturnMessageBusiness, OrderReturnMessageBusiness>();
            services.AddScoped<IProductCategoryBusiness, ProductCategoryBusiness>();
            services.AddScoped<IProductDiscountBusiness, ProductDiscountBusiness>();
            services.AddScoped<IProductFeatureBusiness, ProductFeatureBusiness>();
            services.AddScoped<IProductOrderReturnBusiness, ProductOrderReturnBusiness>();
            services.AddScoped<IProductSupplierBusiness, ProductSupplierBusiness>();
            services.AddScoped<IUserDiscountBusiness, UserDiscountBusiness>();
            services.AddScoped<IUserFavoriteBusiness, UserFavoriteBusiness>();
            services.AddScoped<IUserMessageBusiness, UserMessageBusiness>();
            services.AddScoped<ICategoryFeatureBusiness, CategoryFeatureBusiness>();
            services.AddScoped<IOrderProductBusiness, OrderProductBusiness>();







        }
    }
}
