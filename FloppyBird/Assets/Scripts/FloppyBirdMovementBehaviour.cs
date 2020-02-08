using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FloppyBirdMovementBehaviour : MonoBehaviour
{
    public float flapForce;
    private Rigidbody rb;
    private Transform childT;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        childT = GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * flapForce, ForceMode.VelocityChange);
            childT.localScale = new Vector3(.75f,1.25f,1f);
        }
        childT.localScale = Vector3.Lerp(transform.localScale, Vector3.one, Time.deltaTime * 5f);
    }
}
