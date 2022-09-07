using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_Bullet : MonoBehaviour
{
   [Header("Velocidad de Bala")]
   public float speed = 6f;

   [Header("Tiempo de Destruccion de Bala")]
   public float destroyTimer = 3f;

    void Start()
    {
        Invoke("DestroyGameObject", destroyTimer);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 _temp = transform.position;

        _temp.x += speed * Time.deltaTime;

        transform.position = _temp;
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}







