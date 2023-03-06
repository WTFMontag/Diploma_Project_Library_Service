using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LibraryAggregator.DataLayer.Entities
{
  public class AuthOptions
  {
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
    public SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new(Encoding.UTF8.GetBytes(SecretKey));
  }
}
