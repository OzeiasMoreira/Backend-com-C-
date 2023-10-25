namespace HandsOnToDo.models
{
    public class User 
    {
        public int Id {get; set;}

        public String Name {get; set;}

        public String Email {get; set;}

        public String Password {get; set;}

        public User()
        {
            this.Id = 0;
            this.Name = "";
            this.Email = "";
            this.Password = "";
            //this Role = "";

        }

        public User(int id,String name,String Email, String Password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

    }
}