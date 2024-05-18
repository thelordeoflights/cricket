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
        if (Input.GetKeyDown(KeyCode.F))
        {
            rigidBody.useGravity = true;
            rigidBody.AddForce(Vector3.forward * throwforce, ForceMode.Acceleration);
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


    }
}
