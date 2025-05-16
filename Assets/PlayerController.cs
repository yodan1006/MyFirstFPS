using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]float speed = 5.0f;
    Camera cam;
    private CharacterController characterController;
    private Vector2 _inputValue;

    private void Start()
    {
        cam = Camera.main;
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //LookRotation();
        var lookThis = cam.transform.forward;
        lookThis.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookThis);
        //var moveVector = _inputValue.x * transform.right+_inputValue.y*transform.forward;
        var moveVector = transform.TransformDirection(new Vector3(_inputValue.x, 0, _inputValue.y));
        characterController.SimpleMove(moveVector * speed);
        transform.rotation = rotation;
    }

    private void LookRotation()
    {
        var lookThis = cam.transform.forward;
        lookThis.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookThis);
        characterController.Move(Vector3.zero);
        transform.rotation = rotation;
    }

    public void Move(InputAction.CallbackContext context)
    {
        _inputValue = context.ReadValue<Vector2>();
    }
}
