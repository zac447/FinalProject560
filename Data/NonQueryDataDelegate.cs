namespace Data
{
   public abstract class NonQueryDataDelegate<T>(string procedureName)
      : DataDelegate(procedureName), INonQueryDataDelegate<T>
   {
      public abstract T Translate(Command command);
   }
}