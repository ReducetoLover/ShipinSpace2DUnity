using UnityEngine;

public abstract class Singleton<T> : Singleton where T : MonoBehaviour
{
  private static T instance;
  private static readonly object Lock = new object();
  private bool persistent = true;

  public static T Instance
  {
    get
    {
      if (Quitting)
      {
        Debug.LogWarning($"[{nameof(Singleton)}<{typeof(T)}>] Instance mill not be returned bacause...");
        return null;
      }
      lock (Lock)
      {
        if (instance != null)
          return instance;
        var instances = FindObjectsOfType<T>();
        var count = instances.Length;
        if (count > 0)
        {
          if (count == 1)
            return instances[0];
          Debug.LogWarning($"[{nameof(Singleton)}<{typeof(T)}>] There should never be more than one...");
          for (int i = 0; i < instances.Length; i++)
          {
            Destroy(instances[i]);
          }
          return instance = instances[0];
        }
        Debug.LogWarning($"[{nameof(Singleton)}<{typeof(T)}>] An instance is neede in the scene and no...");
        return instance = new GameObject($"({nameof(Singleton)}){typeof(T)}").AddComponent<T>();
      }
    }
  }
  private void Awake()
  {
    if (persistent)
      DontDestroyOnLoad(gameObject);
    OnAwake();
  }

  protected virtual void OnAwake() { }

}
public abstract class Singleton : MonoBehaviour
{
  public static bool Quitting { get; private set; }
  private void OnApplicationQuit()
  {
    Quitting = true;
  }
}