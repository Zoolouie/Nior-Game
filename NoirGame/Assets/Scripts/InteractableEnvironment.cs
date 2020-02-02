using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableEnvironment : MonoBehaviour
{
    public Item item;

    void OnMouseDown() {
        Inventory i = GameObject.Find("Canvas").GetComponent<Inventory>();
        i.AddItem(item);
        //TODO ZL probably add an animation here instead of just destroying it.
        Destroy(gameObject);
    }
}
