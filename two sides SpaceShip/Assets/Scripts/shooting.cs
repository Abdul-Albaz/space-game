using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField]GameObject rocketPrefab;
    [SerializeField]Transform spawnPos;
    [SerializeField]float shootSpeed;
    [SerializeField] string fireButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fireButton))
        {
            GameObject instance =  Instantiate(rocketPrefab, spawnPos.position,Quaternion.identity);
            Rigidbody instanceRb = instance.GetComponent<Rigidbody>();

            
            //instanceRb.velocity += new Vector3(0, 0, shootSpeed);

            instanceRb.AddForce(Vector3.forward * shootSpeed);
        }
    }
}
