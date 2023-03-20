using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airship : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform gunPosition;

    public int ammoType;

    public float velocidad = 3f;

    private Rigidbody rBody;


    // Start is called before the first frame update
    void Awake()
    {
        rBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalVelocity = new Vector3(horizontalInput * velocidad, 0f, 0f);
        rBody.velocity = horizontalVelocity;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(ammoType, gunPosition.position, gunPosition.rotation);
            bullet.SetActive(true);
        }
        
    }
}
