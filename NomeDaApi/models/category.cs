namespace HandsOnToDo.models
{

    public class CategoryId
    {
        public int Id{get;set}

        public String Name{get; set;}

        public String Color{get;set}

        public int UserId{get; set;}

        public Category()
        {
            this.Id = 0;
            this.Name = "";
            this.Color = "";
        }

        public Category(int Id,String Name,String Color)
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;

        }
    }
}