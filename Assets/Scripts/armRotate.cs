using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class armRotate : MonoBehaviour
{
    public bool canTurn=false;
    public float angle;
    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        if (angle>=-90f && angle<=90f)
        {
            canTurn = false;
        }
        else
        {
            canTurn = true;
        }
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
}
