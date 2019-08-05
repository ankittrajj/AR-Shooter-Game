using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnObject;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject me = Instantiate(bullet, spawnObject.position, spawnObject.rotation) as GameObject;
            me.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
        }
        
    }
    
}
