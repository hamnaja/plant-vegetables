using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RandomBlinkingLight : MonoBehaviour
{
    public List<Light> lights = new List<Light>(); // รายการหลอดไฟ
    public float minBlinkInterval = 0.2f; // เวลาต่ำสุดที่ไฟจะกระพริบ
    public float maxBlinkInterval = 1.5f; // เวลาสูงสุดที่ไฟจะกระพริบ

    private void Start()
    {
        StartCoroutine(BlinkLights());
    }

    IEnumerator BlinkLights()
    {
        while (true)
        {
            bool isOn = lights.Count > 0 && lights[0].enabled; // เช็คสถานะของหลอดแรก

            foreach (Light light in lights)
            {
                if (light != null)
                    light.enabled = !isOn; // เปิด-ปิดไฟทุกดวงพร้อมกัน
            }

            float randomInterval = Random.Range(minBlinkInterval, maxBlinkInterval); // กำหนดจังหวะสุ่ม
            yield return new WaitForSeconds(randomInterval);
        }
    }
}