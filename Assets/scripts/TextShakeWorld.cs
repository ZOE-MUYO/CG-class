using UnityEngine;

public class TextShake : MonoBehaviour
{
    public float shakeAmount = 2f;
    public float shakeSpeed = 25f;

    private Vector3 originalPos;

    void OnEnable()
    {
        originalPos = transform.localPosition;
    }

    void Update()
    {
        float x = (Mathf.PerlinNoise(Time.time * shakeSpeed, 0) - 0.5f) * shakeAmount;
        float y = (Mathf.PerlinNoise(0, Time.time * shakeSpeed) - 0.5f) * shakeAmount;

        transform.localPosition = originalPos + new Vector3(x, y, 0);
    }

    void OnDisable()
    {
        transform.localPosition = originalPos;
    }
}
