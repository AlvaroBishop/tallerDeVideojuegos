using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_BGScrol : MonoBehaviour
{
    public float scrollSpeed = 0.1f;

    private MeshRenderer meshRenderer;

    private float xScroll;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
}
