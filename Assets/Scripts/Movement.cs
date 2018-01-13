using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("hey");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0,0,ForwardForce*Time.deltaTime);
        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
