using System;
using System.Linq.Expressions;

namespace ERP_NEW.BLL.Infrastructure
{
    public static class PropertyCompare
    {
        public static bool Equal<T>(T x, T y)
        {
            return Cache<T>.Compare(x, y);
        }

        static class Cache<T>
        {
            internal static readonly Func<T, T, bool> Compare;

            static Cache()
            {
                var props = typeof(T).GetProperties();

                if (props.Length == 0)
                {
                    Compare = delegate { return true; };
                    return;
                }

                var x = Expression.Parameter(typeof(T), "x");
                var y = Expression.Parameter(typeof(T), "y");

                Expression body = null;

                for (int i = 0; i < props.Length; i++)
                {
                    var propEqual = Expression.Equal(Expression.Property(x, props[i]), Expression.Property(y, props[i]));

                    if (body == null)
                    {
                        body = propEqual;
                    }
                    else
                    {
                        body = Expression.AndAlso(body, propEqual);
                    }
                }

                Compare = Expression.Lambda<Func<T, T, bool>>(body, x, y).Compile();
            }
        }
    }
}
