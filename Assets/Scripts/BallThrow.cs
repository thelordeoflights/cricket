using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public Rigidbody rigidBody;
    float throwforce;
    float fudgeFactor = 25;
    [SerializeField] Transform target;
    public float curveStrength = 600f;
    Vector3 lateralDirection;
    bool checkCurve = false;

    void Start()
    {
        rigidBody.useGravity = false;
        target = GameObject.FindWithTag("BatWickets").transform;
    }
    void Update()
    {
        throwforce = Random.Range(350, 500);
        fudgeFactor = Random.Range(-fudgeFactor, fudgeFactor);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.useGravity = true;
            rigidBody.AddForce(Vector3.forward * throwforce, ForceMode.Acceleration);
            // rigidBody.AddForce(fudgeFactor * Vector3.Cross(rigidBody.velocity, rigidBody.angularVelocity), ForceMode.Acceleration);
            // rigidBody.AddForce(Vector3.right * fudgeFactor, ForceMode.Acceleration);
            checkCurve = true;
        }
    }
    void FixedUpdate()
    {
        if (checkCurve)
        {

            Curve();
        }
    }
    void Curve()
    {


        float maxForce = 5f;

        var diffPositionX = target.position.x - transform.position.x;

        var multi = 0;

        if (diffPositionX > 0)
        {
            multi = +1;
        }
        else if (diffPositionX < 0)
        {
            multi = -1;
        }


        rigidBody.AddForce(Vector3.right * multi * maxForce, ForceMode.Force);



        // Vector3 velocity = rigidBody.velocity;
        // Vector3 lateralVelocity = new Vector3(velocity.x, velocity.y, velocity.z);
        // float speed = lateralVelocity.magnitude;
        // lateralDirection = lateralVelocity.normalized;

        // Debug.Log("LATD" + lateralDirection + ", CROSS:" + Vector3.Cross(lateralDirection * 100f, Physics.gravity.normalized));

        // Vector3 curveForce = Vector3.Cross(lateralDirection * 100f, Physics.gravity.normalized) * curveStrength * speed * 1000f;
        // if (target.position.x > 0.1)
        // {
        //     Debug.Log("HERE 1" + curveForce);
        //     rigidBody.AddForce(-curveForce, ForceMode.Impulse);
        // }
        // if (target.position.x < -0.1)
        // {
        //     Debug.Log("HERE 2" + curveForce);
        //     rigidBody.AddForce(curveForce, ForceMode.Impulse);
        // }
    }
}
