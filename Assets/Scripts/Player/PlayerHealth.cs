using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
 //   public Slider healthSlider;
//    public Image damageImage;
  //  public AudioClip deathClip;
  //  public float flashSpeed = 5f;
 //   public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public SimpleHealthBar vida;
    

    Animator anim;
    //AudioSource playerAudio;
    PlayerMovement playerMovement;
    //PlayerShooting playerShooting;
    bool isDead;
    bool damaged;

    void Start()
    {
        currentHealth = startingHealth;
    }
    void Awake ()
    {
        anim = GetComponent <Animator> ();
        //playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();
        //playerShooting = GetComponentInChildren <PlayerShooting> ();
        currentHealth = startingHealth;
        vida.UpdateBar(currentHealth, startingHealth);
    }


    void Update ()
    {
        vida.UpdateBar(currentHealth, startingHealth);
        vida.UpdateColor(new Color(250, 230, 200));
        /*if(damaged)
                {
                    damageImage.color = flashColour;
                }
                else
                {
                    damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
                }
                damaged = false;*/
    }


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;
        

        //   healthSlider.value = currentHealth;
        print("TakeDamage "+currentHealth);
       // vida.UpdateColor(Color.red);
        vida.UpdateBar(currentHealth,startingHealth);

        vida.barColor = new Color(250, 230, 200);
       // playerAudio.Play ();

        if (currentHealth <= 0 && !isDead)
        {
            vida.UpdateColor(new Color(250,230,200));
            // Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        //playerShooting.DisableEffects ();

        anim.SetTrigger ("Die");

       // playerAudio.clip = deathClip;
     //   playerAudio.Play ();

        playerMovement.enabled = false;
        //playerShooting.enabled = false;
    }


    public void RestartLevel ()
    {
        SceneManager.LoadScene (0);
    }
}
