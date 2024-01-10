﻿using Gestor_Acadêmico.Models;
using Gestor_Acadêmico.Interfaces;
using Gestor_Acadêmico.Context;
using Microsoft.EntityFrameworkCore;
using Gestor_Acadêmico.Dto;

namespace Gestor_Acadêmico.Repositories
{
    public class CategoryCourseRepository : ICategoryCourseRepository
    {
        private readonly GestorAcademicoContext _context;

        public CategoryCourseRepository(GestorAcademicoContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task<IEnumerable<CategoryCourse>> GetCategoriesCourse()
        {
            return await _context.CategoriesCourse.ToListAsync();
        }

        public async Task<CategoryCourse> GetCategoryCourseById(int categoryId)
        {
            return await _context.CategoriesCourse.Where(catcou => catcou.Id == categoryId).FirstOrDefaultAsync();
        }

        public async Task<CategoryCourse> GetCategoryCourseByName(string categoryName)
        {
            return await _context.CategoriesCourse.Where(catcou => catcou.Name == categoryName).FirstOrDefaultAsync();
        }

        public async Task<bool> CreateCategory(CategoryCourseDto categoryCourse)
        {
            var category = new CategoryCourse { Name =  categoryCourse.Name };  
            await _context.AddAsync(category);
            return await Save();
        }

        public async Task<bool> DeleteCategory(CategoryCourse category)
        {
            _context.Remove(category);
            return await Save();
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0 ;
        }
    }
}
