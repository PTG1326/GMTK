using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Pentagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject anchor;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Rotate()
    {
            Vector3 axis = new Vector3(0, 0, 1);
            rb.transform.RotateAround(anchor.transform.localPosition, Vector3.back, (float)72);
    }
    
    
}
