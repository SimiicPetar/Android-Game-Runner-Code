using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPlayer : MonoBehaviour
{
public GameObject JetPack;
    public GameObject JetParticles;


    public GameObject legs1;
    public GameObject legs2;
        public GameObject leg1Particles;
    public GameObject leg2Particles;



    public GameObject Hand1;
    public GameObject Hand2;

public bool Idle;
public bool Swim;
 public bool Run;
 public bool Climb;
 public bool ClimbUP;
 public bool HitObstacle;
 public bool Fly;
 public bool Helmet;
 public bool Wall;

        public float MoveleftPower;
        public float MoverightPower;



    public float r_Speed;
    public float ClimbSpeed;
    public float SwimSpeed;
    public float FlySpeed;
    public Animator PlayerAnims;



    public Rigidbody r;
void Start() 
    {
        Run = false;
        Climb = false;
        Fly = false;
        Swim = false;
    }

void FixedUpdate() 
    {
        if (Helmet == true & Wall == true)
        {
            r.velocity = transform.forward * 2;   
            PlayerAnims.SetBool("ShootLaser", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("ClimbUp", false);
        }

        if (Helmet == false & Wall == true)
        {
            r.velocity = transform.forward * 2;   
            PlayerAnims.SetBool("HitWall", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("ClimbUp", false);
            Run = false;
            Climb = false;
            Fly = false;
            Swim = false;
            HitObstacle = false;
        }


        if (ClimbUP == true)
        {
            r.velocity = transform.up * ClimbSpeed;  
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("ClimbUp", true);
        }
        
        if (Climb == true & ClimbSpeed == 2)
        {
            r.velocity = transform.up * ClimbSpeed;  
            PlayerAnims.SetBool("Climb", true);
            PlayerAnims.SetBool("RunningAnimation", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("FastClimb", false);

        }
        
        if (Climb == true & ClimbSpeed == 3)
        {
            r.velocity = transform.up * ClimbSpeed;  
            PlayerAnims.SetBool("FastClimb", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            PlayerAnims.SetBool("Swim", false);

        }
        if (SwimSpeed == 3 & Swim == true)
        {
            r.velocity = transform.forward * SwimSpeed;
            PlayerAnims.SetBool("Swim", true);
            PlayerAnims.SetBool("RunningAnimation", false);
        }
            
            
            if (FlySpeed == 3)
        {
            JetPack.SetActive(true);
        } 

            if (SwimSpeed == 4)
        {
            legs1.SetActive(true);
            legs2.SetActive(true);

        } 

        if (ClimbSpeed == 3)
        {
            Hand1.SetActive(true);
            Hand2.SetActive(true);

        } 

            if (FlySpeed == 3 & Fly == true)
        {
            r.velocity = transform.forward * FlySpeed;
            PlayerAnims.SetBool("JetPack", true);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            JetParticles.SetActive(true);

        }

            if (SwimSpeed == 4 & Swim == true)
        {
            r.velocity = transform.forward * SwimSpeed;
            PlayerAnims.SetBool("FastSwim", true);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            leg1Particles.SetActive(true);
            leg2Particles.SetActive(true);
        }
        if (Fly == false)
        {
            JetParticles.SetActive(false);
        }
          if (FlySpeed == 2 & Fly == true)
        {
            r.velocity = transform.forward * FlySpeed;
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("Walk", true);
            PlayerAnims.SetBool("RunningAnimation", false);
            
        }
        if (Idle == true)
        {
            r.velocity = transform.forward * 0;  
            PlayerAnims.SetBool("Idle", true);
            PlayerAnims.SetBool("RunningAnimation", false);
        }
        
        if (Run == true)
        {
            r.velocity = transform.forward * r_Speed;
            PlayerAnims.SetBool("RunningAnimation", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("HitObstacle", false);
            PlayerAnims.SetBool("HitWall", false);
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("FastSwim", false);
            PlayerAnims.SetBool("FastClimb", false);
            leg1Particles.SetActive(false);
            leg2Particles.SetActive(false);

        }
               
        if (FlySpeed == 3 & Fly == true)
        {
            r.velocity = transform.forward * FlySpeed;
            PlayerAnims.SetBool("JetPack", true);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            
        }
        if (FlySpeed == 2 & Fly == true)
        {
            r.velocity = transform.forward * FlySpeed;
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("Walk", true);
            PlayerAnims.SetBool("RunningAnimation", false);
            
        }
        if (HitObstacle == true)
        {
            r.velocity = transform.forward * 0;
            PlayerAnims.SetBool("HitObstacle", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("RunningAnimation", false);

        }
    }


void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Damage"))
            {
              HitObstacle = true;
              StartCoroutine(LateCall());

            }

        if (other.gameObject.CompareTag("ClimbUp"))
            {
              ClimbUP = true;
              Climb = false;
              StartCoroutine(LateCall());

            }

        if (other.gameObject.CompareTag("Climb"))
            {
                Climb = true;
                Run = false;
            }
       
        if (other.gameObject.CompareTag("Swim"))
            {
                Swim = true;
                Run = false;
            }
        
        if (other.gameObject.CompareTag("Fly"))
            {
                Fly = true;
                Run = false;
            }
        
        if (other.gameObject.CompareTag("Run"))
            {
                Run = true;
            }
        
        if (other.gameObject.CompareTag("MoveLeft"))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, MoveleftPower));
            }
        
        if (other.gameObject.CompareTag("MoveRight"))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, MoverightPower));
            }
       
        if (other.gameObject.CompareTag("Damage"))
            {
                Run = false;
                StartCoroutine(LateCall());
            }
        
        if (other.gameObject.CompareTag("Finish"))
            {
                Run = false;
                Idle = true;

            }
        if (other.gameObject.CompareTag("Wall"))
            {
                Run = false;
                Wall = true;
            }
        }
    
void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Climb"))
            {
                Climb = false;
                Run = true;
            }
        if (other.gameObject.CompareTag("Swim"))
            {
                Swim = false;
                Run = true;
            }
        if (other.gameObject.CompareTag("Fly"))
            {
                Fly = false;
                Run = true;
            }
        if (other.gameObject.CompareTag("Wall"))
            {
                Run = true;
                Wall = false;
                Run = false;
                Climb = false;
                Fly = false;
                Swim = false;
                HitObstacle = false;
                Idle = false;
                PlayerAnims.SetBool("RunningAnimation", true);
                PlayerAnims.SetBool("HitWall", false);
                PlayerAnims.SetBool("HitObstacle", false);


            }
    }
IEnumerator LateCall()
    {
        yield return new WaitForSeconds(2);
        HitObstacle = false;
        Run = true;
    }
}
