using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public Rigidbody rigidBody;
    float throwforce;
    [SerializeField] Transform target;
    public float curveStrength = 600f;
    float direction = 1;
    bool checkCurve = false;

    void Start()
    {
        rigidBody.useGravity = false;
        target = GameObject.FindWithTag("BatWickets").transform;
    }
    void Update()
    {
        throwforce = Random.Range(350, 500);
        if (Input.GetKeyDown(KeyCode.F))
        {
            rigidBody.useGravity = true;
            rigidBody.AddForce(Vector3.forward * throwforce, ForceMode.Acceleration);
            rigidBody.AddTorque(Vector3.right * direction * throwforce);
            checkCurve = true;
        }
    }
    public void setDirection(float value)
    {
        direction = value;
    }
    void FixedUpdate()
    {
        if (checkCurve)
        {
            MagnusEffect();
            //    Curve();
        }
    }
    void MagnusEffect()
    {
        float radius = transform.localScale.x;
        float airDensity = Random.Range(100, 200);

        var direction = rigidBody.angularVelocity;
        var magnitude = 4 / 3 * Mathf.PI * airDensity * Mathf.Pow(radius, 3);
        rigidBody.AddForce(direction * magnitude);
    }
    void Curve()
    {


        float maxForce = Random.Range(-5, 5);

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
