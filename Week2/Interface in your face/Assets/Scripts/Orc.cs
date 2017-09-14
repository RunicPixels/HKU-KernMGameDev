using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Orc : Enemy, IDamagable {
    Orc() {
        Health = 1;
    }
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(3 * Mathf.Sin(Time.time), 0, 3 * Mathf.Cos(Time.time)));

    }
}

