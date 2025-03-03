namespace Code.Infrastructure.View.Registrars
{
  public abstract class EntityComponentRegistrar : IEntityComponentRegistrar
  {
    public abstract void RegisterComponent();
    public abstract void UnregisterComponent();
  }
}