using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MenuInputController : MonoBehaviour
{
    private GameControlls _input;
    private MenuController _controller;

    [SerializeField] Button _buttonNext;
    [SerializeField] Button _buttonPrev;
    [SerializeField] Button _buttonStart;
    [SerializeField] ScenesController _scenesController;

    private void Awake()
    {
        _controller = GetComponent<MenuController>();
        _input = new GameControlls();
        _input.Gameplay.Disable();
        _input.Menu.Enable();
    }

    private void OnEnable()
    {
        _input.Menu.NextCharacter.performed += OnNextCharacterPerformed;
        _input.Menu.PrevCharacter.performed += OnPrevCharacterPerformed;
        _input.Menu.StartGame.performed += OnStartGamePerformed;
    }

    private void Start()
    {
        _buttonNext.onClick.AddListener(_controller.NextCharacter);
        _buttonPrev.onClick.AddListener(_controller.PrevCharacter);
        _buttonStart.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        _input.Menu.NextCharacter.performed -= OnNextCharacterPerformed;
        _input.Menu.PrevCharacter.performed -= OnPrevCharacterPerformed;
        _input.Menu.StartGame.performed -= OnStartGamePerformed;
    }

    private void OnNextCharacterPerformed(InputAction.CallbackContext context)
    {
        _controller.NextCharacter();
    }

    private void OnPrevCharacterPerformed(InputAction.CallbackContext context)
    {
        _controller.PrevCharacter();
    }
    private void OnStartGamePerformed(InputAction.CallbackContext context)
    {
        StartGame();
    }

    private void StartGame()
    {
        _controller.SelectCharacter();
        _scenesController.CallLoadScene("Game");
    }
}
