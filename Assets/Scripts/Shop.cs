using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandartTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standarTurretPrefab);
    }

    public void PurchaseAnotherTurret()
    {
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
