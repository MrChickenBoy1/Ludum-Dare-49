using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject particle_fab;

    float angle = 0;
    public Rigidbody2D rb;

    public float randx = 0;
    public float randy = 0;
    public float speed = 3;

    public AudioClip hit;
    public AudioSource audio;

    
    // Start is called before the first frame update
    void Start()
    {
        randx = Random.Range(-speed, speed);
        randy = Random.Range(-speed, speed);
 
    }

    void FixedUpdate() {
        rb.AddForce(new Vector2 (randx, randy), ForceMode2D.Impulse);
    }

    void generate()
    {
        randx = Random.Range(-speed, speed);
        randy = Random.Range(-speed, speed);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {

            StartCoroutine(stuff());
            Destroy(other.gameObject);


        }
        
    }

    IEnumerator stuff ()
    {
        Instantiate(particle_fab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        audio.clip = hit;
        audio.Play();

        yield return new WaitForSeconds(1);

            Destroy(gameObject);



    }

}
