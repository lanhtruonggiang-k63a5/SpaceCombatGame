using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager sInstance { get => instance; }
    private static InputManager instance;


    public Vector3 MousePos { get => mousePos; }
    private Vector3 mousePos;

    public float Mouse0 { get => mouse0; }
    private float mouse0;

    private void Start()
    {
        if (sInstance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("has more than 1 InputManger exist");
        }
    }
    private void Update()
    {
        GetMousePos();
        GetMouse0Hold();
    }
    private void GetMousePos()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
    private void GetMouse0Hold()
    {
        mouse0 = Input.GetAxis("Fire1");
    }
}
