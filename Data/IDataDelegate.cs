namespace Data
{
   public interface IDataDelegate
   {
      string ProcedureName { get; }

      void PrepareCommand(Command command);
   }
}