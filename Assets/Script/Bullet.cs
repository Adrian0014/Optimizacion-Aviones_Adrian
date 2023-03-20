using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    
    private Rigidbody rBody;

    
    void Awake()
    {
        rBody = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        rBody.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }
    
    void Update()
    {
        transform.position += transform.forward * 5 * Time.deltaTime;
    }


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Enemigo")
       {
            Debug.Log("2");
            //Destroy(gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
