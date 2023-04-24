using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : GiangMonoBehavior
{
    public static PlayerCtrl Instance => instance;
    private static PlayerCtrl instance;
    [SerializeField] protected GameController gameController;

    [SerializeField] protected ShipCtrl currentShip;
    public ShipCtrl CurrentShip => currentShip;

    [SerializeField] protected PlayerPickup playerPickup;
    public PlayerPickup PlayerPickup => playerPickup;

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log(" allow only 1 ship to exist ");
        instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGameController();
        this.LoadPlayerPickup();
        this.LoadCurrentShip();

    }
    protected virtual void LoadGameController()
    {
        if (gameController != null) return;
        gameController = transform.parent.GetComponent<GameController>();
        Debug.Log(transform.name + ": Load GameController", gameObject);
    }
    protected virtual void LoadPlayerPickup()
    {
        if (playerPickup != null) return;
        playerPickup = GetComponentInChildren<PlayerPickup>();
        Debug.Log(transform.name + "Load player pickup", gameObject);
    }
    protected virtual void LoadCurrentShip()
    {
        if (currentShip != null) return;
        currentShip = gameController.ShipCtrl;
        Debug.Log(transform.name + "Load current ship", gameObject);
    }





}
