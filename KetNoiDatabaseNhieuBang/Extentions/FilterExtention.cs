using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace KetNoiDatabaseNhieuBang.Extentions
{
    public static class FilterExtention // Extendtion class
    {
        public static ICollection<T> SapXepExp<T>(this ICollection<T> source,
            string property, string direct) // Extention method
        {

            return source.AsQueryable().OrderBy($"{property} {direct}").ToList();
        }

        public static ICollection<T> TimKiem<T>(this ICollection<T> source,
           string search) // Extention method
        {
            
            var stringProperties = typeof(T).GetProperties().Where(prop=>prop.PropertyType==typeof(string)); // lấy các thuộc tính
           

            string filterExp = string.Join(" || ", stringProperties.Select(p => $"{p.Name}.Contains(@0)"));
         

            return source.AsQueryable().Where(filterExp,search).ToList();

           
           
        }

       
    }

}
