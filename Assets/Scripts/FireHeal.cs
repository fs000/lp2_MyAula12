using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHeal : SuperPower {

    [SerializeField]
    private float healAmount;

	public override void Activate() {

        Heal(healAmount);
        LightMyFire();
    }
}
