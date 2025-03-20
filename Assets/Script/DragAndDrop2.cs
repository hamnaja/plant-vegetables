using UnityEngine;
using TMPro;  // ใช้เพื่อเข้าถึง TextMeshPro

public class DragAndDrop2 : MonoBehaviour
{
    public GameObject cube;  // Cube ที่จะใช้เป็นตำแหน่งเป้าหมาย
    public TextMeshProUGUI feedbackText;  // UI TextMeshPro ที่จะแสดงข้อความ
    private static int totalMoveCount = 0;  // ตัวนับรวมจำนวนครั้งที่วัตถุทั้งหมดถูกย้าย
    public int targetMoveCount = 5;  // จำนวนเป้าหมายที่ต้องการให้ครบ

    private void OnMouseDown()
    {
        // เปลี่ยนตำแหน่งของวัตถุที่คลิกไปที่ตำแหน่งของ Cube
        transform.position = cube.transform.position;

        // เพิ่มตัวนับจำนวนครั้งที่วัตถุทั้งหมดถูกย้าย
        totalMoveCount++;

        // แสดงจำนวนครั้งที่วัตถุทั้งหมดถูกย้ายใน UI
        feedbackText.text = " " + totalMoveCount;

        // เช็คว่า totalMoveCount ถึงจำนวนที่ต้องการหรือยัง
        if (totalMoveCount >= targetMoveCount)
        {
            // แสดงข้อความใน Debug Console เมื่อครบจำนวน
            Debug.Log("Reached target move count: " + totalMoveCount);

        }
    }

    // ฟังก์ชันตรวจสอบสถานะการชนะ
    public bool IsWin()
    {
        return totalMoveCount >= targetMoveCount;
    }
}
