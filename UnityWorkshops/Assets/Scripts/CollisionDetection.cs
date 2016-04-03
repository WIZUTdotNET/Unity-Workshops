using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Debug.Log(string.Format("Collision: {0}", "Enter!"));
    }
}
