using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour 
{
    private Rigidbody rb;
    private Animator anim;


  


    [Header("Input Actions")]

    public StateMachine stateMachine;

    public InputActionAsset InputActions;
    private InputAction m_Movement;
    private InputAction m_Attack;
    private InputAction m_Interact;

    [Header("Player Movement Variables")]
    [SerializeField] private float pSpeed = 5f;
    [SerializeField] private float rotateSpeed = 10f;




    private Vector2 moveAmt;
    private bool isAttacking;
    public bool isMoving;




    public Vector2 GetMovementInput() => m_Movement.ReadValue<Vector2>();
    public bool GetHoldingAttackInput() => m_Attack.WasPerformedThisFrame();
    public bool GetReleasedAttackInput() => m_Attack.WasReleasedThisFrame();

    public Rigidbody RB => rb;
    public Animator Anim => anim;
    public float MoveSpeed => pSpeed;
    public float RotateSpeed => rotateSpeed;




    void Awake()
    {


        ICharacter pelayr = new Pelayr();
        ICharacter Enamy = new Pelayr();

        IPowerUpPickup powerUp = new PowerUP();

        pelayr.Accept(powerUp);



        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        //Initialize State Machine

        stateMachine = new StateMachine();
        stateMachine.Initialize(this);

        //Assign input actions

        var movementMap = InputActions.FindActionMap("Movement");
        m_Movement = movementMap.FindAction("Move");
        m_Attack = movementMap.FindAction("Attack");
        m_Interact = movementMap.FindAction("Intract");
    }

    void OnEnable()
    {
        InputActions.FindActionMap("Movement").Enable();

    }

    void OnDisable()
    {
        InputActions.FindActionMap("Movement").Disable();
    }

    void Update()
    {
        GetIntraction();
    }
    void FixedUpdate()
    {
        stateMachine.FixUpdateState();
    }



    public void GetIntraction()
    {

        if (m_Interact.WasPressedThisFrame())
        {

            Debug.Log("E is Pressed");
            stateMachine.changeState(new Intraction());
        }


    }

    public void Accept(IPowerUpPickup pickup)
    {
       
    }
}

