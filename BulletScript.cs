using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float bulletDamage;

    private void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<EnemyParent>();
        if (enemy != null) enemy.TakeDamage(bulletDamage);

        Destroy(gameObject);
    }
}
