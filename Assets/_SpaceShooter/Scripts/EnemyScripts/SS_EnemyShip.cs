using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_EnemyShip : MonoBehaviour
{
    [Header("Velocidades de Enemigo")]
    public float speed = 5f;
    public float rotateSpeed = 50f;

    public bool canShoot;
    public bool canRotate;

    public bool canMove = true;

    [Header("Limite de Enemigo")]
    public float boundX = -10;

    [Header("Asignaciones")]
    public Transform attackPoint;
    public GameObject bulletPrefab;

    private Animator anim;
    private AudioSource explosionSound;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        explosionSound = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if(canRotate)
        {
            if(Random.Range(0, 2) > 0)
            {
                Debug.Log("a");
            }
        }
    }

}
