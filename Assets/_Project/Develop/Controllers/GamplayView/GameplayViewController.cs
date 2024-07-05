using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameplayViewController : GameplayViewControllerBase
{
    [SerializeField] GameObject canIteractText;
    [SerializeField] TextMeshProUGUI healthText;

    protected override void GetMouseControll(InputAction.CallbackContext context)
    {
        _view.ToggleCursor();
    }


    

    private void Start()
    {
        _view.ToggleCursor();
    }

    private void OnEnable()
    {
        _input.Gameplay.ESC.performed += GetMouseControll;
        InteractEventManager.CanInteract += ShowCanIteractText;
        InteractEventManager.CanNotInteract += HideCanIteractText;
        HealthEventManager.OnHealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _input.Gameplay.ESC.performed -= GetMouseControll;
        InteractEventManager.CanInteract -= ShowCanIteractText;
        InteractEventManager.CanNotInteract -= HideCanIteractText;
        HealthEventManager.OnHealthChanged -= OnHealthChanged;
    }


    private void ShowCanIteractText()
    {
        _view.ShowObject(canIteractText);
    }

    private void HideCanIteractText()
    {
        _view.HideObject(canIteractText);
    }

    public void OnHealthChanged(int health)
    {
        healthText.text = health.ToString();
    }
}
