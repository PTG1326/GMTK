using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_trigger : MonoBehaviour
{
    public Collider2D cd;
    
       // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D cd)
    {
        FindObjectOfType<Rotate_Pentagon>().Rotate();
        FindObjectOfType<PlayerController>().transform.position = new Vector2(-2959, 1851);
        Debug.Log("hello");
        
    }
}
