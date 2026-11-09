using UnityEngine;

public class enemyscript : MonoBehaviour
{
    float movespeed = 1;
    public int enemyHP = 1;
    public enemyspawner enemyspawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       float randomPosition = Random.Range(-9, 9);
        transform.position = new Vector2(randomPosition, 6);
        //Hitta enemyspawner-objektet | GameObject.Find("")
        //Spara enemyspawner-skriptet från det objektet i enemyspawner | GetComponent<komponent>();
        enemyspawner = GameObject.Find("EnemySpawner").GetComponent<enemyspawner>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * movespeed * Time.deltaTime);
        
        if (transform.position.y > 8)
        {
            float randomPosition = Random.Range(-9, 9);
            transform.position = new Vector2(randomPosition, -8);
        }

        else if (transform.position.y < -8)
        {
            float randomPosition = Random.Range(-9, 9);
            transform.position = new Vector2(randomPosition, 8);
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            enemyHP -= 1;
            Debug.Log("Laser hit enemy");
            Destroy(other.gameObject);

            if (enemyHP <= 0)
            {
               
                if (enemyspawner != null)
                {
                    enemyspawner.enemycounter--;
                }
            }
            Destroy(gameObject);
        }
    }
}


