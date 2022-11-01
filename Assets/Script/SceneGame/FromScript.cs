using System.Xml.Serialization;
using UnityEngine;

namespace Reducer
{
  public class FromScript : MonoBehaviour
  {
    public static FromScript instance;
    // Start is called before the first frame update
    private void Awake()
    {
      instance = this;
    }
    void Start()
    {
      
    }
    public object NameScript([System.Runtime.CompilerServices.CallerFilePath] string fileName = null)
    {
      
      return "\nfrom " + fileName[48..^2];
    }
    
    // Update is called once per frame

  }
}
