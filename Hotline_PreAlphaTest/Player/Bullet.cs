using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    private void Update()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitinfo.collider != null)
        {
            if (hitinfo.collider.CompareTag("Enemy"))
            {
                hitinfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
//    void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.gameObject.GetType().GetInterfaces().Contains(typeof(IDamageble))) (other as IDamageble).Damage();
//    }
//    public void Update()
//    {
//        if (!GetComponent<Renderer>().isVisible)
//        {
//            Destroy(gameObject);
//        }
//    }
//}