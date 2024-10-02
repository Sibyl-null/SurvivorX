namespace SurvivorX.Global.ResLoaders
{
    public interface IResLoader
    {
        T Load<T>(string path) where T : UnityEngine.Object;
        void Unload(string path);
    }
}
