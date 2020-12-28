using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketscr : MonoBehaviour
{
    private Transform target;
    private float speed = 7f;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("pl").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(target.position) - transform.position;
        angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("pl"))
        {
            FindObjectOfType<movement>().healthBar -= 25f;
        }
        Destroy(this.gameObject);
    }
}
