using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds it takes for a full 24-hour cycle to pass")]
    public float secondsPerDay = 60f;

    void Update()
    {
        // Calculate the rotation speed: 360 degrees divided by the total seconds in a day
        float degreesPerSecond = 360f / secondsPerDay;

        // Rotate the Directional Light around the X-axis (simulating sun rising/setting)
        // We use Time.deltaTime to ensure the rotation is smooth and independent of frame rate
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
    }
}