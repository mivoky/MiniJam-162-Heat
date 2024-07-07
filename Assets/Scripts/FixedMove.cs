using UnityEngine;
using System.Collections;
using UnityEngine.Timeline;

public class FixedMove : MonoBehaviour
{

    public float Speed = 5.0f;
    public float CellSize = 1.0f;//размер ячейки, а также расстояние, на которое нужно сдвинуться, если была нажата кнопка
    private bool _isMoving = false;//находимся ли в движении
    private bool _isBlocked; //Заблокировано ли движение
    private float _distanceToObject;
    private Vector3 _direction;//направление движения
    private Vector3 _destPos;//позиция куда двигаемся

    private AudioSource _audioSource;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (_isMoving == true)
        {
            float step = Speed * Time.deltaTime;//расстояние, которое нужно пройти в текущем кадре
            transform.position = Vector3.MoveTowards(transform.position, _destPos, step);//двигаем персонажа
            if (transform.position == _destPos) _isMoving = false;//достигли нужной позиции - отключаем движение, включаем ловлю нажатых клавиш
        }

        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward * CellSize, out hit);
        if (hit.collider != null)
        {
            _distanceToObject = Vector3.Distance(transform.position, hit.collider.gameObject.transform.position);
        }
        else
        {
            _distanceToObject = CellSize;
        }

        if (Input.GetKeyDown(KeyCode.W) && _isMoving == false && _distanceToObject >= CellSize)
        {
            //move up
            _direction = transform.forward;
            _destPos = transform.position + _direction * CellSize;
            _audioSource.Play();
            _isMoving = true;
        }
        if (Input.GetKeyUp(KeyCode.E) && _isMoving == false)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 90, transform.localEulerAngles.z);  
        }
    }
}