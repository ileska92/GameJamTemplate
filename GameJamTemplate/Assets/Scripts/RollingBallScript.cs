using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallScript : MonoBehaviour
{
    public Rigidbody myRB;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        print(hor);

        // myRB.AddForce(new Vector3(0, 0, 5));
        myRB.AddForce(Vector3.forward * hor*speed);
        myRB.AddForce(Vector3.left * ver * speed);
    }
}
