using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public float rotateSpeed = 90.0f; // graden per seconde

    void Update()
    {
        // Draai rond de Y-as
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}