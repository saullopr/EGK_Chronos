using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    //EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        //enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
		var anim = GetComponent<Animator>();
		var distance = gameObject.transform.position.x + gameObject.transform.position.z - player.position.x - player.position.z;
		distance = distance < 0 ? distance * -1 : distance;
		if (distance < 1.5f) {
			anim.SetBool("running", false);
			anim.SetBool("attacking", true);
		} else if (distance < 20f) {
			anim.SetBool("running", true);
			anim.SetBool("attacking", false);
			nav.SetDestination (player.position);
		} else {
			anim.SetBool("running", false);
			anim.SetBool("attacking", false);
		}
        //if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
        //}
        //else
        //{
        //    nav.enabled = false;
        //}
    }

   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            print("Inimigo abatido!");
            this.gameObject.SetActive(false);
        }

    }
}
