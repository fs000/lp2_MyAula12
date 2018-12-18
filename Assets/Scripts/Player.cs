using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private IEnumerable<SuperPower> powers;

    private void Awake() => powers = GetComponents<SuperPower>();

    private void Start() => StartCoroutine(LaunchPower());

    IEnumerator LaunchPower() {

        while(true) {

            yield return new WaitForSeconds(3f);

            foreach(SuperPower sp in powers) {

                Debug.Log($"==={sp.GetType().Name}===");
                sp.Activate();
            }
        }
    }
}
