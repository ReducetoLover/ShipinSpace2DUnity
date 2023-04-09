using UnityEngine;

namespace Reducer
{
  public class StartEvents : MonoBehaviour
  {
    [SerializeField] private GameEvent startScene;
    [SerializeField] private GameEvent gameplay;
    private void Start()
    {
      startScene.Init();
      gameplay.Init();
    }
  }
}
