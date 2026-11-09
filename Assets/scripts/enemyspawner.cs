using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
 
    public GameObject enemy;
    public float timeInterval = 2;
    
    public float enemycounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnLogic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnLogic()
    {
        while (true) 
        {
            yield return new WaitForSeconds(timeInterval);
            if (enemycounter < 5)
            {
                Instantiate(enemy, this.transform.position, Quaternion.identity);
                enemycounter++;
                Debug.Log("Enemy counter: " + enemycounter);
            }

        }

    }

}
