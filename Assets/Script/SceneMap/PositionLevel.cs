using UnityEngine;

namespace Reducer
{
  public class PositionLevel : MonoBehaviour
  {
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject CloseLevel2;
    public GameObject CloseLevel3;
    public GameObject CloseLevel4;
    public GameObject CloseLevel5;
    void Start()
    {
      Level1.transform.position = new Vector2(-3f, -12f);
      Level2.transform.position = new Vector2(3f, -6f);
      Level3.transform.position = new Vector2(-3f, 0f);
      Level4.transform.position = new Vector2(3f, 6f);
      Level5.transform.position = new Vector2(-3f, 12f);
      CloseLevel2.transform.position = new Vector2(3f, -6f);
      CloseLevel3.transform.position = new Vector2(-3f, 0f);
      CloseLevel4.transform.position = new Vector2(3f, 6f);
      CloseLevel5.transform.position = new Vector2(-3f, 12f);
    }


  }
}
