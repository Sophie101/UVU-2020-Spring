using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    public Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.depth = 1f;
    }

    void Update()
    {
        
    }
}
