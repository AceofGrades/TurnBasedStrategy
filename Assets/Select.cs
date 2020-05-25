using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public bool selected = false;
    public Transform player;
    public Transform selector;

    private void Update()
    {
        if (selected == false && Input.GetKeyDown(KeyCode.E))
        {
            selected = true;
            player.parent = selector;
            Debug.Log("It is now selected!");
        }
        else if (selected == true && Input.GetKeyDown(KeyCode.E))
        {
            selected = false;
            player.parent = null;
            Debug.Log("It is now de-selected!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("This is a selector.");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("There is no selector.");
    }
}
