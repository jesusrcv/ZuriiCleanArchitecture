namespace Zurii_Core.Models;

public class User
{
    public string email { get; set; }
        
    public string password { get; set; }

    public string FirstName { get; set; }
           
    public string FirstLastName { get; set; }
            
    public string SecondLastName { get; set; }
           
    public string Area { get; set; }

    public virtual Organization Organization { get; set; }
}