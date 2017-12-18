using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniSubController : MonoBehaviour {

    [SerializeField] private GameObject cam;
    private Rigidbody r;
    [SerializeField] private float speed = 4f;
    [SerializeField] private float step = 5f;

    private float rtSpeed;
    Vector3 dirForward, dirStrafe;

    private void Start()
    {
        r = GetComponent<Rigidbody>();
        rtSpeed = speed;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetAxis("Turbo") > 0 & rtSpeed < 5*speed* Input.GetAxis("Turbo"))
            rtSpeed += 0.1f;
        else
        {
            rtSpeed -= 0.1f;
            if (rtSpeed < speed) rtSpeed = speed;
        }

        r.AddForce(50 * rtSpeed * (transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal") * 0.5f));
        r.AddForce(30 * rtSpeed * transform.up * Input.GetAxis("UpDown"));

        Vector3 dir = 2*Vector3.RotateTowards(transform.forward, cam.transform.forward, step*Time.deltaTime, 0.0F);

        transform.rotation = Quaternion.LookRotation(dir);
    }

    public Rigidbody R
    {
        get { return r; }
    }
}
