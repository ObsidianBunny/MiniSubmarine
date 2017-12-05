using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniSubController : MonoBehaviour {

    [SerializeField] private GameObject cam;
    private Rigidbody r;
    [SerializeField] private float speed = 2f;
    Vector3 dirForward, dirStrafe;

    private void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        float step = Time.deltaTime * speed;
        dirForward = transform.position - cam.transform.position.normalized;

        r.AddForce(100 * dirForward * Input.GetAxis("Vertical"));

        //Vector3.RotateTowards(submarine.transform.rotation, dirForward, step, 0.0F);

        //r.AddForce(100 * Vector3.right * Input.GetAxis("Horizontal"));
    }
}
