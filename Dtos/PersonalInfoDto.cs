namespace HngWebApiProject.Dtos
{
    public class PersonalInfoDto
    {
        public string status { get; set; }
        public User user { get; set; }
        public string timestamp { get; set; }
        public string fact { get; set; }
    }

    public class User 
    {
        public string email { get; set; }
        public string name { get; set; }
        public string stack { get; set; }
    }

}
