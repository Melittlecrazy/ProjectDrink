using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    private Rigidbody2D rigidbody;
    public string inputAxis;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("yo what up!");
        //transform.Translate(0,5,0);

        rigidbody = GetComponent<Rigidbody2D>();
        //rigidbody.velocity = new Vector2(1, 0);   
    }

    //use fixedupdate for physics
    private void FixedUpdate()
    {
        
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
        //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);  
    }
    
}
