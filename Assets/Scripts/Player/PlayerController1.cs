using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{

    [SerializeField]
    private float speedRotation;
    [SerializeField]
    private float _moveSpeed;
    private Rigidbody _rigidBody;
    private Vector2 direction;
    private Vector3 _direction;
    private Vector3 lastDirection;
    private NewControls _input;
    private Collider _Collider;
    private AltarScript _altar;
    
    private void Awake()
    {
        _rigidBody = this.GetComponent<Rigidbody>();
        _input = new NewControls();
        _input.Player.Intraction.performed += context => _Interaction();
        Debug.Log("ахо");
    }

    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }

    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation(lastDirection);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speedRotation * Time.deltaTime);

        direction = _input.Player.Move.ReadValue<Vector2>();
        _direction.Set(direction.x, 0, direction.y);
        _direction = _direction.normalized;
        if ((_direction.x != 0) || (_direction.z != 0))
        {
            lastDirection = _direction;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        _Collider = other;
    }
    private void OnTriggerExit(Collider other)
    {
        _Collider = default;
    }

    private void _Interaction()
    {
        if (_Collider != default)
        {
            if (_Collider.gameObject.tag == "Altar")
            {
                _altar = _Collider.GetComponent<AltarScript>();
                _altar.activate();

            };
        };
    }
    private void FixedUpdate()
    {
        _rigidBody.MovePosition(_rigidBody.position + _moveSpeed * Time.fixedDeltaTime * _direction);
    }
}
