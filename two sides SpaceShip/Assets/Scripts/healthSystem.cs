using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            if (health > 0)
            {
                health -= damage;
            }
            else
            {
                die();
            }
            
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
