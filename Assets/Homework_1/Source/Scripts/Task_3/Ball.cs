using System;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Ball : MonoBehaviour, IDestroyable
{
    public Material Material { get; private set; }

    public event Action<Ball> Destroyed;

    private void Awake()
    {
        Material = GetComponent<MeshRenderer>().material;
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        Destroyed?.Invoke(this);
        Destroy();
    }
}
