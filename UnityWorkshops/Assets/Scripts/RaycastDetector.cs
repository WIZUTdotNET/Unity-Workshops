using UnityEngine;
using System.Collections;

public class RaycastDetector : MonoBehaviour
{

    private Camera cam;

	// Use this for initialization
	void Start ()
    {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray rayZ = new Ray(Vector3.zero, new Vector3(0, 0,100));
            Ray rayCamera = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(rayCamera, out hit, 10))
            {
                Debug.Log(string.Format("Hit Object: {0}", hit.collider.name));
            }
            Debug.DrawRay(rayCamera.origin, rayCamera.direction * 10, Color.cyan);   
        }
	}
}
