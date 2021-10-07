using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
   // public GameObject Balloon;

    public Rigidbody rb;

    public float upforce =100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,upforce * Time.deltaTime , 0);
        //Instantiate(Balloon);
        
    }
}
