using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class management : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("enemy") == null) 
        {
            timer += 1 * Time.deltaTime;

            if (timer > 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        if (GameObject.FindWithTag("Player") == null) 
        {
            timer += 1 * Time.deltaTime;

            if (timer > 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            
        }
        
        
    }
}
