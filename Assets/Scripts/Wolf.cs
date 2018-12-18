using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Animal {

    protected override void SelectTarget() {

        Debug.Log("Wolf selected the Sheep.");
    }

    protected override void Move() {

        Debug.Log("Wolf moved.");
    }

    protected override void TryEat() {

        Debug.Log("Wolf is eating.");
    }

    protected override void TryReproduce() {

        Debug.Log("Wolf tried to reproduce.");
    }
}
