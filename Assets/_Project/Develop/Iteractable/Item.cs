using UnityEngine;
using UnityEngine.InputSystem;

public class Item : MonoBehaviour, IInteractable
{
    private GameControlls _input;
    private PickUpEffect _pickupEffect;
    private Health _player;
    private Material _material;

    private void Awake()
    {
        _input = new GameControlls();
        _input.Gameplay.Enable();
        _pickupEffect = new PickUpEffect();
        _material = GetComponent<Renderer>().material;
    }

    

    public void PickUp()
    {
        _player = FindObjectOfType<CharacterHealthController>();
        var playerMat = _player.gameObject.GetComponent<Renderer>().material;
        if (playerMat.color == _material.color)
        {
            _pickupEffect.HealEffect(_player, 50);
        }
        else
        {
            _pickupEffect.DamageEffect(_player, 50);
        }
        
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IteractIventManager.SendCanIteract();
            _input.Gameplay.Interact.performed += OnTryPickUp;
        }      
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IteractIventManager.SendCanNotIteract();
            _input.Gameplay.Interact.performed -= OnTryPickUp;
        }          
    }

    private void OnTryPickUp(InputAction.CallbackContext context)
    {
        PickUp();
    }

    private void OnDestroy()
    {
        IteractIventManager.SendCanNotIteract();
        _input.Gameplay.Interact.performed -= OnTryPickUp;
    }
}
