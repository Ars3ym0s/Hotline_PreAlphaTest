using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // ������ ������� ����
    public float bulletSpeed = 10f; // �������� ����

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ������� ���� � ������� ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // ��������� �������� ����
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
        }
    }
}