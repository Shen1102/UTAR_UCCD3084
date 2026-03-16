using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds it takes for one full in-game day to pass.")]
    public float dayDurationInSeconds = 120f; // Default is 2 minutes per day

    void Update()
    {
        // Prevent division by zero if the duration is set to 0 in the Inspector
        if (dayDurationInSeconds <= 0) return;

        // A full day is 360 degrees. Divide by the duration to get degrees per second.
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate the light around its X-axis (Vector3.right) to simulate the sun rising and setting.
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}