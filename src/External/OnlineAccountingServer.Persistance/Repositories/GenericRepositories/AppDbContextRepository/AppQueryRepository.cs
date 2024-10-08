﻿using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstractions;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContextRepository;
using OnlineAccountingServer.Persistance.Context;
using System.Linq.Expressions;

namespace OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContextRepository
{
    public class AppQueryRepository<T> : IAppQueryRepository<T> where T : Entity
    {
        private static readonly Func<AppDbContext, string, bool, Task<T>> GetByIdCompiled = EF.CompileAsyncQuery((AppDbContext context, string id, bool isTracking) => isTracking == true ? context.Set<T>().FirstOrDefault(p => p.Id == id) : context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

        private static readonly Func<AppDbContext, bool, Task<T>> GetFirstCompiled = EF.CompileAsyncQuery((AppDbContext context, bool isTracking) => isTracking == true ? context.Set<T>().FirstOrDefault() : context.Set<T>().AsNoTracking().FirstOrDefault());

        //private static readonly Func<AppDbContext, Expression<Func<T, bool>>, bool, Task<T>> GetFirstByExpressionCompiled = EF.CompileAsyncQuery((AppDbContext context, Expression<Func<T, bool>> expression, bool isTracking) => isTracking == true ? context.Set<T>().FirstOrDefault(expression) : context.Set<T>().AsNoTracking().FirstOrDefault(expression));

        private AppDbContext _context;

        public AppQueryRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (AppDbContext)context;
            Entity = _context.Set<T>();
        }

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            var result = Entity.AsQueryable();
            if (!isTracking)
                result = result.AsNoTracking();
            return result;
        }

        public async Task<T> GetById(string id, bool isTracking = true)
        {
            return await GetByIdCompiled(_context, id, isTracking);
        }

        public async Task<T> GetFirst(bool isTracking = true)
        {
            return await GetFirstCompiled(_context, isTracking);
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            //return await GetFirstByExpressionCompiled(_context, expression, isTracking);

            T entity = null;

            if (!isTracking)
                entity = await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync();
            else
                entity = await Entity.Where((expression)).FirstOrDefaultAsync();

            return entity;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            var result = Entity.Where(expression);
            if (!isTracking)
                result = result.AsNoTracking();
            return result;
        }
    }
}
