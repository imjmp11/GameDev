using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer: MonoBehaviour {

    public float damageAmount = 25;

    void OnTriggerEnter2D(Collider2D col)
    {
        Health bh = col.gameObject.GetComponent<Health>();
        if (bh != null)
            bh.ChangeHealth(-damageAmount);
    }
}
