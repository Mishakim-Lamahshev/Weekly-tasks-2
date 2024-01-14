using UnityEngine;
using System.Collections;


public class Show : MonoBehaviour
{
    [Header("Adjustable Settings")]
    [Tooltip("The 2D object to show/hide")]
    [SerializeField] private GameObject targetObject;

    [Tooltip("Use this to control the speed of the show/hide animation")]
    [SerializeField] private float fadeSpeed = 1.0f;

    private bool isObjectVisible = true;

    private void Start()
    {
        if (targetObject == null)
        {
            Debug.LogError("Target Object is not assigned in the Show script on GameObject: " + gameObject.name);
            enabled = false; // Disable the script if the target object is not assigned
        }
    }

    private void Update()
    {
        // Check for left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            ToggleVisibility();
        }
    }

    private void ToggleVisibility()
    {
        isObjectVisible = !isObjectVisible;

        // Toggle the visibility with a fade effect
        if (isObjectVisible)
        {
            StartCoroutine(FadeObject(targetObject, 0.0f, 1.0f));
        }
        else
        {
            StartCoroutine(FadeObject(targetObject, 1.0f, 0.0f));
        }
    }

    private IEnumerator FadeObject(GameObject obj, float startAlpha, float targetAlpha)
    {
        SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();

        if (renderer != null)
        {
            float elapsedTime = 0.0f;
            Color currentColor = renderer.color;

            while (elapsedTime < fadeSpeed)
            {
                currentColor.a = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeSpeed);
                renderer.color = currentColor;

                elapsedTime += Time.deltaTime;
                yield return null;
            }

            currentColor.a = targetAlpha;
            renderer.color = currentColor;
        }
        else
        {
            Debug.LogError("SpriteRenderer component not found on the target object: " + obj.name);
        }
    }
}
