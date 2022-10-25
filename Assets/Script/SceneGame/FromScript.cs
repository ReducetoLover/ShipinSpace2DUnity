using System.Xml.Serialization;
using UnityEngine;

namespace Reducer
{
  public class FromScript : MonoBehaviour
  {
    public static FromScript instance;
    // Start is called before the first frame update
    void Start()
    {
      instance = this;
    }
    public object NameScript([System.Runtime.CompilerServices.CallerFilePath] string fileName = null)
    {
      
      return "\nfrom " + fileName[65..^2];
    }
    
    // Update is called once per frame

  }
}
