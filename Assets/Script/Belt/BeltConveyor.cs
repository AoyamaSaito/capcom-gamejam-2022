using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO Resetä÷êîÇçÏÇÈ

public class BeltConveyor : MonoBehaviour
{
    [SerializeField]
    private ConveyorMove _conveyor;
    [SerializeReference]
    private GameObject[] streams;
    [SerializeField]
    private float _speedChangeTime = 15f;


    [Tooltip("ÉRÉìÉxÉAÇÃList"), HideInInspector]
    public List<GameObject> _conveyors = new List<GameObject>();
    private int _count = 0;
    private float _timer = 0;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        ConveyorGenerator();
        _count = 0;
        _timer = 0;
    }

    private void Update()
    {
        Timer();
    }

    private void ConveyorGenerator()
    {
        var go = Instantiate(_conveyor.gameObject, transform.position, Quaternion.identity);
        ConveyorMove conveyorMove = go.GetComponent<ConveyorMove>();

        conveyorMove.OnEvent += ConveyorGenerator;
        conveyorMove.SpeedMag = _speedList[_count];
        conveyorMove.BeltConveyor = this;

        if (streams != null)
        {
            StreamGenerator(conveyorMove.transform, conveyorMove.Positions[Random.Range(0, conveyorMove.Positions.Length)].localPosition);
        }

        _conveyors.Add(go);
    }

    private void StreamGenerator(Transform parent, Vector3 position)
    {
        int random = Random.Range(0, streams.Length);

        if(streams[random] != null)
        {
            var go = Instantiate(streams[random], position, Quaternion.identity);
            go.transform.SetParent(parent, false);
        }
    }

    public void Pause()
    {
        _conveyors.ForEach(i => i.GetComponent<ConveyorMove>().Pause());
    }

    public void Resume()
    {
        _conveyors.ForEach(i => i.GetComponent<ConveyorMove>().Resume());
    }

    public void ConveyorReset()
    {
        _conveyors.ForEach(i => Destroy(i));
        Init();
    }

    private List<float> _speedList = new List<float>()
    {
        1,
        1.5f,
        2,
        2.5f,
        3,
        3.5f,
        4,
        4.5f,
        5,
        5.5f,
        6,
        6.5f
    };

    private void Timer()
    {
        _timer += Time.deltaTime;

        if (_timer >= _speedChangeTime)
        {
            _timer = 0;

            if (_count + 1 == _speedList.Count)
            {
                return;
            }

            _count++;
            _conveyors.ForEach(i => i.GetComponent<ConveyorMove>().SpeedMag = _speedList[_count]);
        }
    }
}
