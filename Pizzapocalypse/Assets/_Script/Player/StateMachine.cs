 public class StateMachine
{
   public PlayerController controller;
  
   public BaseState currentState;

   public void Initialize(PlayerController controller)
    {
        this.controller = controller;
        currentState = new Idle();
        currentState.EnterState(controller);

    }
    public void Update()
    {
        currentState.UpdateState();
        
    }

    public void FixUpdateState()
    {

        currentState.FixedUpdateState();
    }

    public void changeState(BaseState newState)
    {
        currentState.ExitState();
        currentState = newState;
        currentState.EnterState(controller);

    }

}
