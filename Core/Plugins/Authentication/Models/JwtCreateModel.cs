namespace Core.Plugins.Authentication.Models
{
    public class JwtCreateModel
    {
   
        public int Id { get; set; }
        public string FullName { get; set; }
     

        // generate code - constructor - propları seç
        public JwtCreateModel(int id, string fullName)
        {
            Id = id;
            FullName = fullName;            
        }
    }
}