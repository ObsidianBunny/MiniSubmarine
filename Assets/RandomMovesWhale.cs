using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovesWhale : MonoBehaviour
{

    public float vitesse_translation;
    public float vitesse_rotation;
    private float angleX, angleY;
    private Vector3 targetDir;
    private Vector3 newDir;

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


        //Debug.DrawRay(this.transform.position, transform.forward*50);

        fwd = transform.TransformDirection(Vector3.forward);

        //collisionneur.Raycast(ray, out hit, 200.00f))
        if (Physics.Raycast(this.transform.position, fwd, out hit, 100.0f))
        {

            // if (hit.distance < 150.0f) {
            //Vector3 newPosition = Random.insideUnitCircle * 5;
            angleX = Mathf.Lerp(angleX, Random.Range(-60.0f, 60.0f), Time.deltaTime);
            angleY = Mathf.Lerp(angleY, Random.Range(-50.0f, 0), Time.deltaTime);
            //transform.position.Set(newPosition.x, newPosition.y, newPosition.z);
            //var desiredRot = Quaternion.Euler(new Vector3(transform.eulerAngles.x + angleX * Time.deltaTime, transform.eulerAngles.y + angleY * Time.deltaTime,0));
            //Debug.Log(angleX + ": angleX "+angleY+": AngleY "+desiredRot);
            //transform.rotation = Quaternion.LookRotation(new Vector3(vitesse_rotation * angleX * Time.deltaTime, vitesse_rotation * angleY * Time.deltaTime, 0));
            //transform.rotation = Quaternion.Lerp(transform.rotation, desiredRot, vitesse_translation * Time.deltaTime);
            transform.Rotate(0, vitesse_rotation * angleY * Time.deltaTime, 0);

            // }
        }

        transform.Translate(Vector3.forward * vitesse_translation * Time.deltaTime);


        /*if (transform.rotation.z != 0)
        {

            if (transform.rotation.z < 0)
            {
                angle = Mathf.Lerp(angle, Random.Range(10.0f, 5.0f), Time.deltaTime);
            }
            else
            {
                angle = Mathf.Lerp(angle, Random.Range(-10.0f, 0), Time.deltaTime);
            }
            transform.Rotate(0, 0, vitesse_rotation * angle * Time.deltaTime);
            targetDir = new Vector3(0, 0, 0);
            float step = vitesse_translation * Time.deltaTime;
            newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
            Quaternion q = transform.rotation;
            q.eulerAngles = new Vector3(q.eulerAngles.x, q.eulerAngles.y, 0);
            transform.rotation = q;
        }*/
    }

}
