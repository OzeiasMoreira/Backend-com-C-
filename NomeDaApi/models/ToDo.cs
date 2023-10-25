namespace HandsOnToDo.models
{

    public class ToDo
    {

        public int Id{get; set;}

        public String Task{get;set;}

        public bool IsCompleted{get;set;} = false;

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public int CategoryId{get; set;}

        public Category Category{get;set;}

        public int UserId{get; set;}

        public ToDo()
        {
            this.Id = 0;
            this.Task ="";
            this.IsCompleted;
            this.CreatedAt;
        }

        public ToDo(int id,string task,Category? category)
        {
        
            this.Task = task;
            this.Category = category;

        }

        public ToDo(int id,string task, bool IsCompleted,DateTime createdAt)
        {
            this.Id = id;
            this.Task = task;
            this.IsCompleted = isCompleted;
            this.createdAt = createdAt;

        }
        
    }
}