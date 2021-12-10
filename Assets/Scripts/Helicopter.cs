using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private bool called = false;
    private new Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void OnDispatchHelicopter()
    {
        Debug.Log("Вертолет вызван");
        rigidbody.velocity = new Vector3(0, 0, 50f);
        called = true;
    }
}   
