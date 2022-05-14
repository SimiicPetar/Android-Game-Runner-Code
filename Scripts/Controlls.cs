using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{

    public GameObject JetPack;
    public GameObject JetParticles;


    public GameObject legs1;
    public GameObject legs2;
        public GameObject leg1Particles;
    public GameObject leg2Particles;



    public GameObject Hand1;
    public GameObject Hand2;

    //BOOL TRIGGERS
 public bool Swim;
 public bool Run;
 public bool Climb;
 public bool ClimbUP;
 public bool HitObstacle;
 public bool Fly;
 public bool Idle;
  public bool Helmet;
 public bool Wall;


    public Camera cam;
    public Transform sphere;
    public float distanceFromCamera;
    public Rigidbody r;
    public float dragSpeed;
    Vector3 lastMousePos;
    public float r_Speed;
    public float ClimbSpeed;
    public float SwimSpeed;
    public float FlySpeed;    
    
    public float climbUpSpeed;

public GameObject RunningAudio;
public GameObject SwimAudio;
public GameObject ClimbAudio;
public GameObject ObstacleAudio;
public GameObject jetpackAudio;



    public Animator PlayerAnims;


    Vector3 lastPos;
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

        if (Climb == true & ClimbSpeed == 2)
        {
            r.velocity = transform.up * ClimbSpeed;  
            PlayerAnims.SetBool("Climb", true);
            PlayerAnims.SetBool("RunningAnimation", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("FastClimb", false);
            PlayerAnims.SetBool("ClimbUp", false);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(true);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

        }
        
        if (Climb == true & ClimbSpeed == 3)
        {
            r.velocity = transform.up * ClimbSpeed;  
            PlayerAnims.SetBool("FastClimb", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("ClimbUp", false);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(true);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

        }
        
        if (Idle == true)
        {
            r.velocity = transform.forward * 0;  
            PlayerAnims.SetBool("Idle", true);
            PlayerAnims.SetBool("RunningAnimation", false);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

        }
        
        if (ClimbUP == true)
        {
            r.velocity = transform.up * ClimbSpeed;  
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("ClimbUp", true);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

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
            PlayerAnims.SetBool("FastSwim", false);
            PlayerAnims.SetBool("FastClimb", false);
            PlayerAnims.SetBool("ClimbUp", false);
            leg1Particles.SetActive(false);
            leg2Particles.SetActive(false);
            PlayerAnims.SetBool("HitWall", false);
            RunningAudio.SetActive(true);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

        }

        if (SwimSpeed == 3 & Swim == true)
        {
            r.velocity = transform.forward * SwimSpeed;
            PlayerAnims.SetBool("Swim", true);
            PlayerAnims.SetBool("RunningAnimation", false);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(true);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

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
            RunningAudio.SetActive(false);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(true);
        }

            if (SwimSpeed == 4 & Swim == true)
        {
            r.velocity = transform.forward * SwimSpeed;
            PlayerAnims.SetBool("FastSwim", true);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            leg1Particles.SetActive(true);
            leg2Particles.SetActive(true);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(true);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

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
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(false);
            jetpackAudio.SetActive(false);

        }
        if (HitObstacle == true)
        {
            PlayerAnims.SetBool("HitObstacle", true);
            PlayerAnims.SetBool("Climb", false);
            PlayerAnims.SetBool("Swim", false);
            PlayerAnims.SetBool("Walk", false);
            PlayerAnims.SetBool("JetPack", false);
            PlayerAnims.SetBool("RunningAnimation", false);
            RunningAudio.SetActive(false);
            SwimAudio.SetActive(false);
            ClimbAudio.SetActive(false);
            ObstacleAudio.SetActive(true);
            jetpackAudio.SetActive(false);

        }
        if (Wall == true)
        {
            RunningAudio.SetActive(false);
        }
    }
            
     
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Run"))
            {
                Run = true;
            }

    }
    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }
    void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.position;
        pos.z += delta.x * dragSpeed;
        transform.position = pos;
        lastMousePos = Input.mousePosition; 
                
                if (transform.position.z > 2.9f)
                transform.position = new Vector3(transform.position.x, transform.position.y , 2.9f);
                if (transform.position.z < -1.5f)
                transform.position = new Vector3(transform.position.x, transform.position.y , -1.5f);
    }
    //void OnCollisionEnter(Collision other) 
    //{
        //transform.position = new Vector3(transform.position.x, transform.position.y , 0);
    //}
    
}