using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Sprite newSprite; // ����� ������ ��� �����

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            // �������� ������ � ���������� ���������
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            // �������� ������ � �������� ��� �������
            Sprite itemSprite = other.GetComponent<SpriteRenderer>().sprite;
            spriteRenderer.sprite = newSprite;
            Destroy(other.gameObject);
        }
    }
}
