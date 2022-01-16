using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody thisRB;
    Vector3 lastVelosity;
    float bulletSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<IDamage>(out var character))
        {
            character.Damage();

            FindObjectOfType<GameManager>().CheckTextChang();
        }
        else
        {
            bulletSpeed = lastVelosity.magnitude;
            var direction = Vector3.Reflect(lastVelosity.normalized, collision.contacts[0].normal);
            bulletSpeed -= 7.5f;
            if (bulletSpeed < 7.5f)
                Destroy(this.gameObject);
            thisRB.velocity = direction * Mathf.Max(bulletSpeed, 0f);
        }
    }
    private void Update()
    {
        lastVelosity = thisRB.velocity;      
    }
}
