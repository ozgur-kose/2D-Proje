using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    
    public LayerMask enemyLayers;

  
    //Attack 1 için
    public float attack1Rate = 2f;
    private float nextAttackTime1 = 0f;
    public Transform attack1Point;
    public float attack1Range = 0.5f;

    void Update()
    {
        if (Time.time >= nextAttackTime1)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Attack1();
                nextAttackTime1 = Time.time + 1f / attack1Rate;
            }
        }
    }
    void Attack1()
    {
        animator.SetTrigger("Attack1");

        //Belirlenen bölgede belirlenen çapta daire oluþturur ve dairenin çarptýðý bütün nesneleri toplar
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attack1Point.position,attack1Range,enemyLayers);

        //Vurulan düþmanlarý tutan listedeki herkese hasar uygulama
        foreach (var enemy in hitEnemies)
        {
            //Vurulan hasar buraya girilecek
        }

    }

   

    void OnDrawGizmosSelected()
    {
        if (attack1Point== null) return;
        Gizmos.DrawSphere(attack1Point.position, attack1Range);   
    }
}
