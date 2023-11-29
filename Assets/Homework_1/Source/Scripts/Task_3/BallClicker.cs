using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallClicker : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (_camera != null)
            return;

        if (Input.GetMouseButton(0) || 
            Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out var hit))
        {
            hit.transform.TryGetComponent<Ball>(out var ball);
            ball?.Select();
        }
    }
}
