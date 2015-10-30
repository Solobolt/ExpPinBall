using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public int enemyNumb = 0;

    public GameObject enemyObject;

    private Transform myTransform;
    public int rand;

    // Use this for initialization
    void Start () {
        myTransform = this.transform;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (enemyNumb < 20)
        {
            Instantiate(enemyObject,myTransform.position,myTransform.rotation);
        }
        rand = Random.Range(0, 3);
    }

    public void addEnemy()
    {
        enemyNumb++;
    }

    public void removeEnemy()
    {
        enemyNumb--;
    }

}
