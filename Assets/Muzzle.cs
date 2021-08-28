using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.L))
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    void Shot()
    {
        GameObject obj;
        obj = GameObject.Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody>().AddForce(transform.forward * 3000);

        Destroy(obj, 1);
    }

    
}


