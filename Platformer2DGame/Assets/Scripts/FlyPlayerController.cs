using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platform
{
    public class FlyPlayerController : MonoBehaviour
    {
        [Header("Speed")]
        public float moveSpeed;
        public Rigidbody2D rb;
        public int health = 100;

        [Header("Bool Expression")]
        public bool isGameOver = false;

        [Header("Game Over Pane")]
        public GameObject pane;

        private void Start()
        {
            Time.timeScale = 1f;
        }

        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector2 moveDirection = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
            rb.velocity = moveDirection;
        }
        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Destroy(this.gameObject);
                pane.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("enemy"))
                TakeDamage(50);


            if (collision.collider.CompareTag("gameOver"))
            {
                isGameOver = true;
                health -= 10;
                pane.SetActive(true);
                Time.timeScale = 0f;
            }
            else
                isGameOver = false;
        }
    }
}

