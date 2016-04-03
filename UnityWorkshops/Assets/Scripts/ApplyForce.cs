using UnityEngine;
using System.Collections;

public class ApplyForce : MonoBehaviour
{
    public int strength = 500;
    private Rigidbody rigidbody;

	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () 
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rigidbody.AddForce(new Vector3(0, 0, 1 * strength));
        }
	}
}
