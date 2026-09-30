using NUnit.Framework;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] protected float health;
    [SerializeField] protected float damage;
    [SerializeField] protected float moveSpeed;

    [Header("Moving")]
    [SerializeField] protected Vector3 moveVector;

    [Header("Juice")]
    [SerializeField] private GameObject hitParticle;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Instantiate(hitParticle, transform.position, Quaternion.identity);
        if (health < 0) Destroy(gameObject);
    }

    protected void Patrol()
    {
        if(health > 0)
        {
            float tempfloat = Mathf.Sin(Time.time);
            moveVector = new Vector3(tempfloat * moveSpeed, 0, 0);
            transform.position = moveVector;
        }
    }
}
