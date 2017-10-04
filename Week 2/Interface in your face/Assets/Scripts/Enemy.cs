using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable {
    public virtual int Health {
        get {
            return 0;
        }
        set {

        }
    }
    public Enemy() {
    }
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(Health <= 0) {
            Die();
        }

    }

    public virtual void TakeDamage(int damage) {
        Health = Health - damage;
    }

    public virtual void Die() {
        Destroy(gameObject);
    }
}
