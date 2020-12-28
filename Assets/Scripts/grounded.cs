using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
  public bool isGrounded = false;

  private void OnCollisionEnter2D(Collision2D other)
  {
      isGrounded = true;
  }
}
