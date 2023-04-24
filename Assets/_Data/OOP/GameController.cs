using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : GiangMonoBehavior
{
       
    [SerializeField] protected ShipCtrl shipCtrl;
    public ShipCtrl ShipCtrl => shipCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadShipController();
    }
    public virtual void LoadShipController(){
        if(shipCtrl != null) return;
        shipCtrl = transform.GetComponentInChildren<ShipCtrl>();
        Debug.Log(transform.name + ": load ship controller", gameObject);
    }
}
