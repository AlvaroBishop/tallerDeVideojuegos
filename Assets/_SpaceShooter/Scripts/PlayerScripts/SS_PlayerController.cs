using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_PlayerController : MonoBehaviour
{
    //variables publicas
    [Header("Velocidad de player")]
    public float speed = 5f; //Velocidad del jugador

    [Header("Limites en Y")]
    public float minY; //limites minimos del mapa

    public float maxY; //limites maximo del mapa

    [Header("Delay de disparo")]
    public float attackTimer = 0.4f; //timepo de dispar

    //variables privadas 
    [SerializeField]
    private GameObject playerBullet; //Referencia al gameobject de la bala del jugador

    [SerializeField]
    private Transform attackPoint; //punto de origen de los disparos

    private float currentAttackTimer;//Tiempo de ataque actual 

    private bool canAttack; //para saber si el jugador puede disparar

    private void Start()
    {//start start
        //declaracion del tiempo de ataque actual
        currentAttackTimer = attackTimer;
    }//end start

    private void Update()
    {//start update
        //llamar a la funcion que mueve al jugaor
        MovePlayer();
        //llamar a la funcion de ataque
        Attack();
    }//end update

    //funcion que mueve al jugador

    void MovePlayer()
    {//start moveplayer
        //movimiento en vertical
        //checar si el valor del eje vertical es mayor a 0
        if (Input.GetAxisRaw("Vertical") > 0f)
        {//start if
            //crear variable temporal que guarda la posicion del player
            Vector3 _temp = transform.position;

            //Declara el valor en y del vector temporal para ascender
            //usaremos el valor de speed y el delta para aumentar posicion
            _temp.y += speed * Time.deltaTime;

            //Limitar el movimiento superior en Y
            if (_temp.y > maxY)
                _temp.y = maxY;

            //asignar la transformacion
            //actualizar la posicion del jugador usando los valores temporales
            transform.position = _temp;
        }//end if
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {//start else if
         //crear variable temporal que guarda la posicion del player
            Vector3 _temp = transform.position;

            //Declara el valor en y del vector temporal para decender
            //usaremos el valor de speed y el delta para aumentar posicion
            _temp.y -= speed * Time.deltaTime;

            //Limitar el movimiento superior en Y
            if (_temp.y < minY)
                _temp.y = minY;

            //asignar la transformacion
            //actualizar la posicion del jugador usando los valores temporales
            transform.position = _temp;
        }//end else if
    }//end moveplayer
    void Attack()
    {
        attackTimer += Time.deltaTime;

        if (attackTimer > currentAttackTimer)
        {
            canAttack = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttack)
            {
                canAttack = false;
                attackTimer = 0f;
                Instantiate(playerBullet, attackPoint.position, Quaternion.identity);

            }
        }
    }
}
