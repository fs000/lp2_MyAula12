using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SuperPower : MonoBehaviour {

    private Player p;

    public float Cooldown { get; set; }

    public abstract void Activate();

    protected void DealDamage(float damage) {

        Debug.Log("Dealt " + damage + " damage.");
    }

    protected void Heal(float healAmount) {

        Debug.Log("Healed " + healAmount + " points.");
    }

    protected void BoostSpeed(float pace) {

        Debug.Log("Player's speed was increased to " + pace);
    }

    protected void LightMyFire() {

        Debug.Log("Flame On!");
    }
}
