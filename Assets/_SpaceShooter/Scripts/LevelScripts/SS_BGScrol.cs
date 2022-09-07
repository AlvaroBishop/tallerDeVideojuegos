using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_BGScrol : MonoBehaviour
{
   
    public float scrollSpeed = 10f;

    private MeshRenderer meshRenderer; //REF COMP MeshRender del BG

    private void Awake()
    {
        //Inicializar la REF meshRenderer
        meshRenderer = GetComponent<MeshRenderer>();
    }

 
    private void FixedUpdate()
    {
        Scroll();
    }

    void Scroll()
    {
        //Determinar el valor de scroll usando la velocidad y el tiempo
        float xScroll = Time.time * scrollSpeed;
        //Determina el desplazamiento
        Vector2 _offset = new Vector2(xScroll, 0f);

        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", _offset);
    }

    
}
