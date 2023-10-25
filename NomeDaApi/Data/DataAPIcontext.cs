namespace HandsOnToDo.Data 
{
    public class ApiDbContext : DbContext
    {
         public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public Dbset<Category> Categorias {get;set;}

        public Dbset<ToDo> ToDos{get;set;}

        public Dbset<User> Users{get;set;}
    }
}