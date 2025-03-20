using UnityEngine;
using TMPro;  // ใช้เพื่อเข้าถึง TextMeshPro

public class DragAndDropChecker : MonoBehaviour
{
    public DragAndDrop dragAndDrop1;  // อ้างอิงถึงสคริปต์ DragAndDrop
    public DragAndDrop2 dragAndDrop2;  // อ้างอิงถึงสคริปต์ DragAndDrop2
    public TextMeshProUGUI feedbackText;  // UI TextMeshPro ที่จะแสดงข้อความ

    private void Update()
    {
        // ตรวจสอบว่าเงื่อนไขครบทั้งสองสคริปต์หรือยัง
        if (dragAndDrop1 != null && dragAndDrop2 != null)
        {
            if (dragAndDrop1.IsWin() && dragAndDrop2.IsWin())
            {
                // เมื่อทั้งสองครบเงื่อนไข แสดงข้อความ "You Win!"
                feedbackText.text = "You Win!";
            }
        }
    }
}
