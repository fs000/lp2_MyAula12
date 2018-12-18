using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        SelectTarget();
        Move();
        TryEat();
        TryReproduce();
	}

    protected virtual void SelectTarget() { }
    protected abstract void Move();
    protected abstract void TryEat();
    protected abstract void TryReproduce();
}
