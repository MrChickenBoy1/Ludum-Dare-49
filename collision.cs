using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public GameObject particle_fab;
    double timer = 0;
    public AudioClip hit;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "enemy")
        {
            StartCoroutine(stuff());

            Destroy(other.gameObject);


            
        }


        

    }

    IEnumerator stuff()
    {
            Instantiate(particle_fab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            timer += 0.1;
            audio.clip = hit;
            audio.Play();
            yield return new WaitForSeconds(1);
            Destroy(gameObject);

            

    }
}
