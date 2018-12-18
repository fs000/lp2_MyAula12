using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDamage : SuperPower {

    [SerializeField]
    private float damage;

    [SerializeField]
    [Range(-1f, 1f)]
    private float speed;

    public override void Activate() {

        DealDamage(damage);
        BoostSpeed(speed);
    }
}
