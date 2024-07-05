using UnityEngine;
using UnityEngine.InputSystem;

public class Item : InteractableItem
{
    [SerializeField] private int effectValue;

    private GameControlls _input;
    private PickUpEffect _pickupEffect;
    private Material _material;

    private void Awake()
    {
        _input = new GameControlls();
        _input.Gameplay.Enable();
        _pickupEffect = new PickUpEffect();
        _material = GetComponent<Renderer>().material;
    }

    

    public override void Interacte()
    {
        var _player = FindObjectOfType<CharacterController>();
        _pickupEffect.ApplyEffect(_player, _material, effectValue);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractEventManager.SendCanInteract();
            InteractEventManager.OnInteract += Interacte;
            _input.Gameplay.Interact.performed += OnTryPickUp;
        }      
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractEventManager.SendCanNotInteract();
            InteractEventManager.OnInteract -= Interacte;
            _input.Gameplay.Interact.performed -= OnTryPickUp;
        }          
    }

    private void OnTryPickUp(InputAction.CallbackContext context)
    {
        Interacte();
    }

    private void OnDestroy()
    {
        InteractEventManager.SendCanNotInteract();
        _input.Gameplay.Interact.performed -= OnTryPickUp;
        InteractEventManager.OnInteract -= Interacte;
    }
}
