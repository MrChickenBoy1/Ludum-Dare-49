using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    float timer = 0;
    public GameObject bullet_prefab;
    public float rand = 0 ;

    void Start()
    {
        rand = Random.Range(30, 50);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;


        if (timer > rand)
        {
            GameObject bullet = Instantiate(bullet_prefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            randtime();
            timer = 0;

        }
    }

    void randtime()
    {
        rand = Random.Range(30, 50);

    }
}
