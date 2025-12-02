namespace Data
{
   public interface INonQueryDataDelegate<out T> : IDataDelegate
   {
      T Translate(Command command);
   }
}