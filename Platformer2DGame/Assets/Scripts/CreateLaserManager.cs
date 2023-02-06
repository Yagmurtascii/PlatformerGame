using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platform
{
    public class CreateLaserManager : MonoBehaviour
    {
        public Transform firePoint;
        public GameObject bulletPrefab;

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
