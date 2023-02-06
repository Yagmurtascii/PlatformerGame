using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platform
{
    public class EnemySpawn : MonoBehaviour
    {
        public FlyPlayerController player; 
        public GameObject columns;
        public float heightTop, heightBottom;
        int count = 0;
                                     
        void Start()
        {
            StartCoroutine(CopyColumns());
            
        }
        private void Update()
        {
            if(count==15)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load next scene

        }
        public IEnumerator CopyColumns()
        {
            while (player.health !=0 && count<20)
            {
                yield return new WaitForSeconds(1f); 
                Instantiate(columns, new Vector3(13f, Random.Range(heightTop, heightBottom), 0), Quaternion.identity);
                count++;
            }
        }
    }
}