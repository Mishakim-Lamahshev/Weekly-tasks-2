using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    [Header("Heartbeat Settings")]
    [Tooltip("The duration of each heartbeat cycle in seconds.")]
    [SerializeField] private float heartbeatDuration = 2.0f;

    [Tooltip("The scale factor at the peak of the heartbeat.")]
    [SerializeField] private float maxScale = 1.2f;

    [Tooltip("The minimum scale of the object.")]
    [SerializeField] private float minScale = 0.8f;

    private void Update()
    {
        // Calculate the sinusoidal scale factor based on time and heartbeat duration
        float scaleFactor = Mathf.Lerp(minScale, maxScale, Mathf.Sin(Time.time / heartbeatDuration * Mathf.PI * 2) * 0.5f + 0.5f);

        // Apply the scale to the object
        transform.localScale = new Vector3(scaleFactor, scaleFactor, 1.0f);
    }
}
