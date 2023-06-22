using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100;         // ������������ ���������� �������� ���������
    public int currentHealth;           // ������� ���������� �������� ���������

    // ������� ����������, ����� �������� �������� ����
    public event System.Action<int> OnTakeDamage;

    void Start()
    {
        currentHealth = maxHealth;      // ������������� ��������� ���������� ��������
    }

    // �����, ����������, ����� �������� �������� ����
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;        // ��������� ���������� �������� �� �������� �����

        // ���� ���������� �������� ����� ������ ��� ����� ����, �������� �������
        if (currentHealth >= 0)
        {
            Die();
        }

        // �������� ������� OnTakeDamage, ����� ��������� ������ ������� �� �����
        if (OnTakeDamage != null)
        {
            TakeDamage(damage);
        }
    }

    // �����, ����������, ����� �������� �������
    void Die()
    {
        Destroy(gameObject);           // ���������� ������ ���������
    }
}