using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // префаб объекта пули
    public float bulletSpeed = 10f; // скорость пули

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Создаем пулю в игровом мире
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Добавляем скорость пули
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
        }
    }
}