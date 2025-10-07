using UnityEngine;

public class BobbingMovement : MonoBehaviour
{
    public float amplitude = 0.5f;    // Hoe hoog/laag (afstand tussen heen en weer)
    public float frequency = 0.25f;    // Hoe snel

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Sine wave (Sinus golf) beweging voor op-en-neer effect
        float newY = startPosition.y + amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}