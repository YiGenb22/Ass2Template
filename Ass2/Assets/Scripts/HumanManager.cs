using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveRight()
    {
        value = value + 10;
        human.transform.position = new Vector3(value-345.7387f, -7.999969f, 550.442f);
    }

    public void ResetPosition()
    {
        human.transform.position = new Vector3(-345.7387f, -7.999969f, 550.442f);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 20f, 0f);
    }

    public void Grow()
    {
        human.transform.localScale += sizeChange;
    }
  
    public void GetSmall()
    {
        human.transform.localScale -= sizeChange;
    }



}
