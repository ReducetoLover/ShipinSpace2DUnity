using UnityEngine;
[RequireComponent(typeof(Camera))]
public class CameraWidth : MonoBehaviour
{
  private const float Width = 1280f;
  private const float HalfSizeInPixels = 200f;
  private void Awake()
  {
    Application.targetFrameRate = 144;
    GetComponent<Camera>().orthographicSize = Width * Screen.height / Screen.width / HalfSizeInPixels;
  }
}
