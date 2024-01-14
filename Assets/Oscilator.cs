using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("Oscillation Settings")]
    [Tooltip("Amplitude of the oscillation")]
    [SerializeField]
    public float amplitude = 5f;

    [Tooltip("Frequency of the oscillation in Hertz")]
    [SerializeField]
    public float frequency = 0.5f;

    [Tooltip("Delay before starting the oscillation")]
    public float delay = 0f;

    [Header("Oscillation Axis")]
    [Tooltip("Choose the axis along which the object should oscillate")]
    [SerializeField]
    public OscillationAxis oscillationAxis = OscillationAxis.X;

    private float timeElapsed;

    private void Start()
    {
        timeElapsed = delay;
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        float oscillationValue = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * timeElapsed);

        Vector3 position = transform.position;

        switch (oscillationAxis)
        {
            case OscillationAxis.X:
                position.x = oscillationValue;
                break;
            case OscillationAxis.Y:
                position.y = oscillationValue;
                break;
            case OscillationAxis.Z:
                position.z = oscillationValue;
                break;
        }

        transform.position = position;
    }
}

public enum OscillationAxis
{
    X,
    Y,
    Z
}
