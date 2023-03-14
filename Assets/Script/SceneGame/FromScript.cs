using System.Xml.Serialization;
using UnityEngine;

namespace Reducer
{
  public class FromScript: MonoBehaviour
  {
    public object NameScript([System.Runtime.CompilerServices.CallerFilePath] string fileName = null)
    {   
      return "\nfrom " + fileName[48..^2];
    }
  }
}
