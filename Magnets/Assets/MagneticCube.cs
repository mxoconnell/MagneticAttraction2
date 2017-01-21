using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MagneticCube : MonoBehaviour {
    [SerializeField] private bool isRed = true;

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Assert.IsNotNull(rb);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Move toward or away from magnet
    public void MagneticAttract(Transform magnet)
    {
        // Let it move
        //rb.constraints = RigidbodyConstraints.None;

        // Move it
        //Debug.Log("Being attracted!");
        Vector3 direction = rb.position - magnet.position;
        direction = direction * -1;

        if(direction.magnitude > 2)
        {
            //Debug.Log("dist:" + direction.magnitude);
            rb.MovePosition(transform.position + direction * Time.deltaTime);
        }

        // Don't let it move
        //rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    public void MagneticRepel(Transform magnet)
    {
        // Move it
        //Debug.Log("Being attracted!");
        Vector3 direction = rb.position - magnet.position;
        
            //Debug.Log("dist:" + direction.magnitude);
            rb.MovePosition(transform.position + direction * Time.deltaTime);
        
    }
}
