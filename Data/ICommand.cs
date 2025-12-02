using Microsoft.Data.SqlClient;

namespace Data
{
   public interface ICommand
   {
      SqlParameterCollection Parameters { get; }

      T GetParameterValue<T>(string name);
   }
}
