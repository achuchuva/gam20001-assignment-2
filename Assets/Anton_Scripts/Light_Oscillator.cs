using UnityEngine;
using System.Collections;

public class Light_Oscillator : MonoBehaviour
{
    public float minIntensity = 1f;
    public float maxIntensity = 5f;
    public float oscillationSpeed = 1f;

    private float targetIntensity;
    private Light pointLight;

    void Start()
    {
        pointLight = GetComponent<Light>();
        targetIntensity = minIntensity;
        StartCoroutine(OscillateIntensity());
    }

    IEnumerator OscillateIntensity()
    {
        while (true)
        {
            targetIntensity = (targetIntensity == minIntensity) ? maxIntensity : minIntensity;
            float step = oscillationSpeed * Time.deltaTime;
            while (Mathf.Abs(pointLight.intensity - targetIntensity) > 0.01f)
            {
                pointLight.intensity = Mathf.MoveTowards(pointLight.intensity, targetIntensity, step);
                yield return null;
            }
            pointLight.intensity = targetIntensity;
            yield return new WaitForSeconds(0.5f / oscillationSpeed);
        }
    }
}
