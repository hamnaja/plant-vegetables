using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float movementSpeed = 5f;

    private void Update()
    {
        // หมุนกล้อง
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // เดินหน้า/ถอยหลัง
        float moveForward = 0;
        if (Input.GetKey(KeyCode.W))
        {
            moveForward = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveForward = -1;
        }

        Vector3 moveDirection = transform.forward * moveForward * movementSpeed * Time.deltaTime;
        transform.position += moveDirection;

        // เดินซ้าย/ขวา
        float moveSide = 0;
        if (Input.GetKey(KeyCode.A))
        {
            moveSide = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveSide = 1;
        }

        Vector3 moveSideDirection = transform.right * moveSide * movementSpeed * Time.deltaTime;
        transform.position += moveSideDirection;

        // เดินขึ้น/ลง
        float moveUpDown = 0;
        if (Input.GetKey(KeyCode.Space)) // ปุ่ม Space สำหรับเคลื่อนที่ขึ้น
        {
            moveUpDown = 1;
        }
        if (Input.GetKey(KeyCode.LeftControl)) // ปุ่ม LeftControl สำหรับเคลื่อนที่ลง
        {
            moveUpDown = -1;
        }

        Vector3 moveUpDownDirection = transform.up * moveUpDown * movementSpeed * Time.deltaTime;
        transform.position += moveUpDownDirection;
    }
}
