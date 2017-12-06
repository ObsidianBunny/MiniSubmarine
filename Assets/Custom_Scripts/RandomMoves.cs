using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoves : MonoBehaviour
{
    public float vitesse_translation;
    public float vitesse_rotation;
    float angle;

    Collider collisionneur;

    Vector3 fwd;
    RaycastHit hit;

    // Use this for initialization
    void Start()
    {
        collisionneur = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Ray ray = new Ray(transform.position, transform.forward);

        //Debug.Log(collisionneur.Raycast(ray, out hit, 200.00f));
        //Debug.DrawRay(this.transform.position, transform.forward*50);

        fwd = transform.TransformDirection(Vector3.forward);

        //collisionneur.Raycast(ray, out hit, 200.00f))

        if (Physics.Raycast(this.transform.position, fwd, out hit)) 
        {
            if (hit.distance < 200.0f) {
                Vector3 newPosition = Random.insideUnitCircle * 5;
                angle = Mathf.Lerp(angle, Random.Range(-30.0f, 30.0f), Time.deltaTime);
                //transform.position.Set(newPosition.x, newPosition.y, newPosition.z);
                transform.Rotate(0, vitesse_rotation * angle * Time.deltaTime, 0);
                transform.Rotate(vitesse_rotation * angle * Time.deltaTime, 0, 0);
            }
        }

        /*if (transform.rotation.z != 0)
        {

            if (transform.rotation.z < 0)
            {
                angle = Mathf.Lerp(angle, Random.Range(10.0f, 0), Time.deltaTime);
            }
            else
            {
                angle = Mathf.Lerp(angle, Random.Range(-10.0f, 0), Time.deltaTime);
            }
            transform.Rotate(0, 0, vitesse_rotation * angle * Time.deltaTime);
        }*/

        transform.Translate(Vector3.forward * vitesse_translation * Time.deltaTime);
        

    }
}

