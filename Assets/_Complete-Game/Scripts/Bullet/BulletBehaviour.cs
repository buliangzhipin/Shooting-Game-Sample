using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
    public class BulletBehaviour : MonoBehaviour
    {
        private int damagePerShot;
        private Vector3 direction;
        public float speed;
        public void Initial(Vector3 start, Vector3 direction, int damagePerShot)
        {
            this.direction = direction.normalized;
            this.damagePerShot = damagePerShot;
        }

        void Update()
        {
            this.transform.position += direction * Time.deltaTime * speed;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Enemy")
            {
                EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();

                // If the EnemyHealth component exist...
                if (enemyHealth != null)
                {
                    // ... the enemy should take damage.
                    enemyHealth.TakeDamage(damagePerShot, this.transform.position);
                }
            }
            var hitParticles = Instantiate(DataManager.Ins.hitParticles, transform.position, other.transform.rotation);
            hitParticles.Play();
            Destroy(hitParticles, 2f);
            Destroy(this.gameObject);

        }
    }
}
