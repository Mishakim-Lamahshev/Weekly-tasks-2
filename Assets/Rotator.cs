using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("Rotation speed in degrees per second")]
    [SerializeField]
    public float rotationSpeed = 30f;

    [Header("Rotation Axis")]
    [Tooltip("Choose the axis around which the object should rotate")]
    [SerializeField]
    public RotationAxis rotationAxis = RotationAxis.X;

    private void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;

        switch (rotationAxis)
        {
            case RotationAxis.X:
                transform.Rotate(Vector3.right, rotationAmount);
                break;
            case RotationAxis.Y:
                transform.Rotate(Vector3.up, rotationAmount);
                break;
            case RotationAxis.Z:
                transform.Rotate(Vector3.forward, rotationAmount);
                break;
        }
    }
}

public enum RotationAxis
{
    X,
    Y,
    Z
}
