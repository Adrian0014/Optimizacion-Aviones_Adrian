using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;
    
    private Rigidbody rBody;

    

    
    void Awake()
    {
        rBody = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        rBody.AddForce(transform.right * enemySpeed, ForceMode.Impulse);
    }
    
    void Update()
    {
        transform.position += transform.right * 5 * Time.deltaTime;
    }


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Bala")
       {
            Debug.Log("1");
            //Destroy(gameObject);
            //this.gameObject.SetActive(false);
            gameObject.SetActive(false);
        
        }
    }


}
