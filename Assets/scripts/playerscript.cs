using Unity.VisualScripting;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float playerSpeed = 3;
    public GameObject laserShot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(0, -4);  

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }
        if (transform.position.x > 11 )
        {
            transform.position = new Vector2( -11, -4);
        } 
        else if (transform.position.x < -11)
        {
            transform.position = new Vector2(11, -4);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserShot, this.transform.position, Quaternion.identity);
            
        }



    }
}
    
    

