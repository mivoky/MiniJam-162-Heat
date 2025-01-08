using UnityEngine;
using System.Collections;
using UnityEngine.Timeline;

public class FixedMove : MonoBehaviour
{

    public float Speed = 5.0f;
    public float CellSize = 1.0f;//размер ячейки, а также расстояние, на которое нужно сдвинуться, если была нажата кнопка
    public float DistanceBlockMove = 1.0f;

    private Vector3 _moveVector;

    private AudioSource _audioSource;
    private CharacterController _characterController;
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        _moveVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        _moveVector += transform.forward;

        if (Input.GetKeyUp(KeyCode.E))
        {
            _audioSource.Play();
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 90, transform.localEulerAngles.z);  
        }
    }
    private void FixedUpdate()
    {
        _characterController.Move(_moveVector * Speed * Time.fixedDeltaTime);
    }
}