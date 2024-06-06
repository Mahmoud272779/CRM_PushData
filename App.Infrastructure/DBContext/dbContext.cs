using App.Domain.Entities;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Context;
using App.Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace App.Infrastructure.DBContext
{
    public class dbContext : DbContext, IApplicationSqlDbContext
    {
        #region DBSet
        public DbSet<PermissionList> permissionLists;
        public DbSet<Rules> rules;
        public DbSet<Users> users;
        public DbSet<Employees> employees;
        public DbSet<SystemLogsHistory> systemLogsHistories;
        #endregion


        private readonly IErpInitilizerData _initilizerData;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConfiguration _configuration;
        OnModelCreatingService _onModelCreatingService;

        public dbContext(DbContextOptions<dbContext> options, IErpInitilizerData initilizerData, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(options)
        {
            _initilizerData = initilizerData;
            this.httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _onModelCreatingService = new OnModelCreatingService(_initilizerData);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (defultData.isMigration)
                base.OnModelCreating(modelBuilder);
            #region Seed Data
            _onModelCreatingService.OnModelCreating(modelBuilder);
            #endregion

        }
        public IDbConnection Connection => throw new NotImplementedException();
    }
}
