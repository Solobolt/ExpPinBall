using UnityEngine;
using System.Collections;

public class ExplotionBlast : MonoBehaviour
{

    public float radius = 5.0F;
    public float power = 10.0F;

    void Start()
    {
        Vector3 myPosition = transform.position;
        Collider[] markedObject = Physics.OverlapSphere(myPosition, radius);
        foreach (Collider otherObject in markedObject)
        {
            if (otherObject.gameObject.tag != "Ball")
            {
                Rigidbody rb = otherObject.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(power, myPosition, radius, 3.0F);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
