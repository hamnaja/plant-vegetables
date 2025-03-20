using UnityEngine;
using System.Collections;

public class ScaleOnWin : MonoBehaviour
{
    public GameObject objectToScale;  // วัตถุที่จะขยายขนาด
    public DragAndDropChecker dragAndDropChecker;  // อ้างอิงถึง DragAndDropChecker
    private bool isGameWon = false;  // ตรวจสอบว่าเกมชนะแล้วหรือยัง
    public float duration = 5f;  // เวลาที่ต้องการให้การขยายใช้ (5 วินาที)
    private Vector3 targetScale = new Vector3(150f, 150f, 150f);  // ขนาดเป้าหมาย
    private Vector3 initialScale = new Vector3(100f, 100f, 100f);  // ขนาดเริ่มต้น

    private void Start()
    {
        // กำหนดขนาดเริ่มต้นของวัตถุ
        objectToScale.transform.localScale = initialScale;
    }

    private void Update()
    {
        // ตรวจสอบว่าเกมชนะแล้วหรือยัง
        if (dragAndDropChecker.feedbackText.text == "You Win!" && !isGameWon)
        {
            // เริ่มขยายขนาด
            StartCoroutine(ScaleOverTime());
            isGameWon = true;  // ตั้งค่าว่าเกมชนะแล้ว
        }
    }

    // Coroutine ที่จะขยายขนาดอย่างราบรื่น
    private IEnumerator ScaleOverTime()
    {
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            // คำนวณการขยายขนาดตามเวลา
            float scaleFactor = timeElapsed / duration;

            // ขยายขนาดจากขนาดเริ่มต้นไปยังขนาดเป้าหมาย
            objectToScale.transform.localScale = Vector3.Lerp(initialScale, targetScale, scaleFactor);

            // เพิ่มเวลาที่ผ่านไป
            timeElapsed += Time.deltaTime;

            // รอจนกว่าเฟรมถัดไป
            yield return null;
        }

        // สุดท้ายให้ขนาดเป็นขนาดเป้าหมาย
        objectToScale.transform.localScale = targetScale;
        Debug.Log("Final Scale: " + objectToScale.transform.localScale);  // แสดงขนาดสุดท้าย
    }
}
