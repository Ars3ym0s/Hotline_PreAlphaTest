using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public int damage;
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        health = damage;
    }
    
}
//, IDamageble
//{
//    public float speed = 3f;
//    public float attackDamage = 10f;
//    public float health = 10;
//    private Rigidbody2D rb;
//    private bool facingRight = true;
//    private Transform player;

//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        player = GameObject.FindGameObjectWithTag("Player").transform;
//    }
//    public void TakeDamage(int damage)
//    {
//        health -= damage;
//        if (health <= 0)
//        {
//            Die();
//        }
//    }

//    void Die()
//    {
//        // Уничтожаем объект врага
//        Destroy(gameObject);
//    }

//    void FixedUpdate()
//    {
//        if (player != null)
//        {
//            float direction = player.position.x > transform.position.x ? 1 : -1;
//            if (direction > 0 && !facingRight)
//            {
//                Flip();
//            }
//            else if (direction < 0 && facingRight)
//            {
//                Flip();
//            }
//            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
//        }
//    }

//    void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.tag == "Bullet")
//        {
//            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
//            if (player != null)
//            {
//                Destroy(player);
//            }
//        }
//    }

//    void Flip()
//    {
//        facingRight = !facingRight;
//        Vector3 theScale = transform.localScale;
//        theScale.x *= -1;
//        transform.localScale = theScale;
//    }

//    public void Damage()
//    {
//        health -= 10;
//        if (health <= 0)
//        {
//            Die();
//        }
//    }
//}