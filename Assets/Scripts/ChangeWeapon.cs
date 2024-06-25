using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    [SerializeField] private GameObject[] weaponPrefabs;
    [SerializeField] private Transform weaponSlotTransform;

    private int currentWeaponIndex = 0;

    private void Update()
    {
    float scrollDelta = Input.GetAxis("Mouse ScrollWheel");

        if (scrollDelta > 0)
        {
            currentWeaponIndex++;
            if (currentWeaponIndex >= weaponPrefabs.Length)
            {
                currentWeaponIndex = 0;
            }
        }
        else if (scrollDelta < 0)
        {
            currentWeaponIndex--;
            if (currentWeaponIndex < 0)
            {
                currentWeaponIndex = weaponPrefabs.Length - 1;
            }
        }
        SwitchWeapon(currentWeaponIndex);
    }

    public void SwitchWeapon(int index)
    {
        if (index >= 0 && index < weaponPrefabs.Length)
        {
            if (weaponSlotTransform.childCount > 0)
            {
                Destroy(weaponSlotTransform.GetChild(0).gameObject);
            }
            Instantiate(weaponPrefabs[index], weaponSlotTransform);
            currentWeaponIndex = index;
        }
    }
}