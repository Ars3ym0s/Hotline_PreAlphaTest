using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100;         // Максимальное количество здоровья персонажа
    public int currentHealth;           // Текущее количество здоровья персонажа

    // Событие вызывается, когда персонаж получает урон
    public event System.Action<int> OnTakeDamage;

    void Start()
    {
        currentHealth = maxHealth;      // Устанавливаем начальное количество здоровья
    }

    // Метод, вызываемый, когда персонаж получает урон
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;        // Уменьшаем количество здоровья на значение урона

        // Если количество здоровья стало меньше или равно нулю, персонаж умирает
        if (currentHealth >= 0)
        {
            Die();
        }

        // Вызываем событие OnTakeDamage, чтобы уведомить другие объекты об уроне
        if (OnTakeDamage != null)
        {
            TakeDamage(damage);
        }
    }

    // Метод, вызываемый, когда персонаж умирает
    void Die()
    {
        Destroy(gameObject);           // Уничтожаем объект персонажа
    }
}