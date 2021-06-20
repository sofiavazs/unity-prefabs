using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

  public float shootingForce = 10f;
  public Vector3 shootingDirection;
  public float lifetime = 3f;

  void Start () {
    GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
  }

  // Update is called once per frame
  void Update () {
    lifetime -= Time.deltaTime;
    if (lifetime <= 0) {
      Destroy(gameObject);
    }
        
  }
}
