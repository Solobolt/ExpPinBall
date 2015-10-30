using UnityEngine;
using System.Collections;

public class ExplotionBlast : MonoBehaviour
{

    public float radius = 5.0F;
    public float power = 10.0F;

    private int damage= 10;

    void Start()
    {
        Vector3 myPosition = transform.position;
        Collider[] markedObject = Physics.OverlapSphere(myPosition, radius);
        foreach (Collider otherObject in markedObject)
        {
            if (otherObject.gameObject.tag == "Enemy")
            {
                Rigidbody rb = otherObject.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    rb.AddExplosionForce(power, myPosition, radius, 3.0F);
                }
                otherObject.gameObject.GetComponent<EnemyController>().takeDamage(damage);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
