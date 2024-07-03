using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Camera mainCamera;
    public ParticleSystem particleSystem;

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.0f; 
        
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePos);
        particleSystem.transform.position = worldPosition;
    }
}
