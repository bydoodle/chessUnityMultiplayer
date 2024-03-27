using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.UI;

public class pawnWhite : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    int clicked = 0;

    public void checkPos()
    {
        if (clicked == 2)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            clicked = 0;
        }
    }

    private void Update()
    {
        Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        if (Input.GetMouseButtonDown(0))
        {
            clicked++;
            checkPos();
        }
    }
}
