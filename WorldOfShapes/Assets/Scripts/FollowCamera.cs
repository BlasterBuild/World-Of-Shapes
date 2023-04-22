using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform Transform;
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.position = new Vector3(Transform.position.x, transform.position.y, transform.position.z);
    }
}
