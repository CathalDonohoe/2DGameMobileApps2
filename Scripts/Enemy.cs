using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [SerializeField] private float rotationSpeed;
    [SerializeField] private float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
        }
        else {

            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }
    }
}
