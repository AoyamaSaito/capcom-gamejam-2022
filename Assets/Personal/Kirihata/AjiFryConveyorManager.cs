using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiFryConveyorManager : MonoBehaviour
{
    [SerializeField] Transform Belt;
    [SerializeField] GameObject originalObject;
    [SerializeField] float moveSpeed = 1;

    List<Transform> enableObjs;
    List<Transform> disableObjs;

    Transform traTmp;
    Vector3 moveVec;

    int i;

    // Start is called before the first frame update
    void Start()
    {
        enableObjs = new List<Transform>();
        disableObjs = new List<Transform>();
        moveVec = new Vector3(moveSpeed,0,0) * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        Belt.localPosition += moveVec;
        if (Belt.localPosition.x >= 1) 
        {
            Belt.localPosition = Vector3.zero;
        }

        for (i = 0; i < enableObjs.Count; i++)
        {
            traTmp = enableObjs[i];
            traTmp.localPosition += moveVec;
            if(traTmp.localPosition.x > 20) 
            {
                DisableObject(i);
            }
        }
    }

    public void AddAjifly()
    {
        if (disableObjs.Count > 0)
        {
            traTmp = disableObjs[0];
            traTmp.gameObject.SetActive(true);
            traTmp.localPosition = Vector3.zero;
            enableObjs.Add(traTmp);
            FastRemove(disableObjs, 0);
            return;
        }
        traTmp = Instantiate(originalObject, transform).transform;
        traTmp.localPosition = Vector3.zero;
        enableObjs.Add(traTmp);
        return;

    }

    void DisableObject(int index)
    {
        enableObjs[index].gameObject.SetActive(false);
        disableObjs.Add(enableObjs[index]);
        FastRemove(enableObjs, index);
    }

    void FastRemove(List<Transform> L, int index)
    {
        L[index] = L[L.Count - 1];
        L.RemoveAt(L.Count - 1);
    }
}
