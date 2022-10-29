using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyor : MonoBehaviour
{
    [SerializeField]
    private ConveyorMove _conveyor;
    [SerializeReference]
    private GameObject[] streams;


    [Tooltip("ƒRƒ“ƒxƒA‚ÌList")]
    private List<GameObject> _conveyors = new List<GameObject>();

    private void Start()
    {
        ConveyorGenerator();
    }

    private void ConveyorGenerator()
    {
        var go = Instantiate(_conveyor.gameObject, transform.position, Quaternion.identity);
        go.GetComponent<ConveyorMove>().OnEvent += ConveyorGenerator;
        if (streams != null)
        {
            StreamGenerator(go.transform);
        }
        _conveyors.Add(go);
    }

    private void StreamGenerator(Transform parent)
    {
        int random = Random.Range(0, streams.Length);

        if(streams[random] != null)
        {
            Instantiate(streams[random]).transform.SetParent(parent, false);
        }
    }
}
