using UnityEngine;
using UnityEngine.UIElements;

public class laserbehaviour : MonoBehaviour
{
    public int laserSpeed = 3;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.transform.position = new Vector3(0, -4);
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
      this.transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
       

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        } */
    }
}
