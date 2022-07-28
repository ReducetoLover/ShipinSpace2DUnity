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
      Level1.transform.position = new Vector3(-3f, -8f, 9);
      Level2.transform.position = new Vector3(3f, -4f, 9);
      Level3.transform.position = new Vector3(-3f, 0f, 9);
      Level4.transform.position = new Vector3(3f, 4f, 9);
      Level5.transform.position = new Vector3(-3f, 8f, 9);
      CloseLevel2.transform.position = new Vector3(3f, -4f, 9);
      CloseLevel3.transform.position = new Vector3(-3f, 0f, 9);
      CloseLevel4.transform.position = new Vector3(3f, 4f, 9);
      CloseLevel5.transform.position = new Vector3(-3f, 8f, 9);
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}
