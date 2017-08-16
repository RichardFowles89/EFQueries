using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            //First, we create an instance of our DbContext - remember this is how we interact with the db
            var context = new PlutoContext();

            //The below is joining
            var query =
                from c in context.Courses
                select new { CourseName = c.Name, AuthorName = c.Author.Name };//c.Author.Name uses a navigation property to get the Author name
            //9.12



            //The below is grouping by level***************************************************
            //var query =
            //    from c in context.Courses
            //    group c by c.Level
            //    into g
            //    select g;

            //foreach (var group in query)
            //{
            //    Console.WriteLine(group.Key);

            //    foreach (var course in group)
            //    {
            //        Console.WriteLine("\t{0}", course.Name);
            //    }
            //}

            //The below is projection*************************************************
            //var query = from c in context.Courses
            //            where c.Author.Id == 1
            //            orderby c.Level descending, c.Name
            //            select new { Name = c.Name, Author = c.Author.Name };//Note we are returning a new object

            //var query = from c in context.Courses
            //            where c.Author.Id == 1
            //            orderby c.Level descending, c.Name//order by descending level, within each level order by name
            //            select c;


            //var query = from c in context.Courses
            //            where c.Level == 1 && c.Author.Id == 1
            //            select c;



            //BELOW ARE THE NOTES FROM THE 'OVERVIEW' LECTURE
            /*
            //with LINQ there are 2 ways to write queries: You can use LINQ syntax, which is like a query
            //language like SQL, or we can use extension methods.
            //=======================LINQ syntax=============================
            var query =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;

            //foreach (var course in query)
            //{
            //    Console.WriteLine(course.Name);
            //}

            //=======================Extension Methods==========================
            var courses = context.Courses.Where(c => c.Name.Contains("c#")).OrderBy(c => c.Name);

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
            }
            */
        }
    }
}
