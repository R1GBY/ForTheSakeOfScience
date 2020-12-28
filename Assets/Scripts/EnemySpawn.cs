using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    private Transform tr;
    private float a = 0f;
    public bool canspawn2 = true;
    public bool canSpawn = false;

    private float spawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = UnityEngine.Random.Range(0, 4);
        tr = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length>=15)
        {
            canSpawn = false;
        }
        else
        {
            canSpawn = true;
        }
        
        spawnTime += Time.deltaTime;
        if (spawnTime>=5f && canSpawn && canspawn2)
        {
            a = UnityEngine.Random.Range(0, 4);

            if (a==0)
            {
                Instantiate(enemy, tr.position,Quaternion.Euler(transform.rotation.x,transform.rotation.y-180f,transform.rotation.z));
            }
            else if (a == 1)
            {
                Instantiate(enemy2, tr.position,Quaternion.Euler(transform.rotation.x,transform.rotation.y-180f,transform.rotation.z));
            }else if (a == 2)
            {
                Instantiate(enemy3, tr.position,Quaternion.Euler(transform.rotation.x,transform.rotation.y-180f,transform.rotation.z));
            }
            spawnTime = 0f;
        }
    }
}
