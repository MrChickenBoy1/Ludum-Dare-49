using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject bullet_fab;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(target.transform.position, new Vector3 (0, 0, 1), -150 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(target.transform.position, new Vector3 (0, 0, 1), 150 * Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))
        {
            GameObject bullet = Instantiate(bullet_fab, new Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(-transform.right * 15, ForceMode2D.Impulse);
        }
        
        
    }
}
