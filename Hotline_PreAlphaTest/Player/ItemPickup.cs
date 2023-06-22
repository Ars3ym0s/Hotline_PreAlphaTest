using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Sprite newSprite; // Новый спрайт для перса

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            // Получаем доступ к компоненту персонажа
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            // Получаем спрайт с предмета при подборе
            Sprite itemSprite = other.GetComponent<SpriteRenderer>().sprite;
            spriteRenderer.sprite = newSprite;
            Destroy(other.gameObject);
        }
    }
}
