using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animal {

    protected override void Move() {

        Debug.Log("Sheep moved.");
    }

    protected override void TryEat() {

        Debug.Log("Sheep is eating.");
    }

    protected override void TryReproduce() {

        Debug.Log("Sheep tried to reproduce.");
    }
}
