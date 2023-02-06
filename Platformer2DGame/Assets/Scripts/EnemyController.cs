using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platform
{
    public class EnemyController : MonoBehaviour
    {

        public int health = 40;
        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
                Destroy(gameObject);
        }
        private void Update()
        {
            transform.position -= new Vector3(0.05f, 0, 0);
        }
    }
}

