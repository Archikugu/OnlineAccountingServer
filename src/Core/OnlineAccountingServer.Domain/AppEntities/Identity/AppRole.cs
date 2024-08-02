using Microsoft.AspNetCore.Identity;

namespace OnlineAccountingServer.Domain.AppEntities.Identity
{
    public sealed class AppRole : IdentityRole<string>
    {
        public AppRole()
        {
          
        }
        public AppRole(string title, string code, string name)
        {
            Id = Guid.NewGuid().ToString();
            Code = code;
            Name = name;
            Title = title;
        }
        public string Code { get; set; }
        public string Title { get; set; }
    }
}
