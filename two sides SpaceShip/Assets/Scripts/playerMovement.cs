using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    [SerializeField] string inputAxis;
    private float traverse;
    private float bearing;
    [SerializeField]GameObject spaceShip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(inputAxis + " : " + Input.GetAxis(inputAxis));
        //rb.velocity += new Vector3(Input.GetAxis(inputAxis) * speed, 0, 0);
        transform.Translate(Input.GetAxis(inputAxis) * speed * Time.deltaTime, 0, 0);

            
            traverse = Input.GetAxis(inputAxis) * rotationSpeed;
            spaceShip.transform.Rotate(new Vector3(0, 0, traverse));

            bearing = spaceShip.transform.rotation.eulerAngles.z;
            bearing = Mathf.Clamp(bearing, -7f, 7f);
            spaceShip.transform.rotation = Quaternion.Euler(0.0f, 0.0f, bearing);
            
        
        
        
    }

    

}
