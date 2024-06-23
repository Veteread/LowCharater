using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] weaponPrefabs;
    [SerializeField] private Transform weaponSlotTransform;
    private Animator animator;

    private int currentWeaponIndex = 0;
    private int currentAnim = 5;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
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
        if (Input.GetKey(KeyCode.Alpha1))
        {
            animator.SetInteger("NumberAnim", 1);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            animator.SetInteger("NumberAnim", 2);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            animator.SetInteger("NumberAnim", 3);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            animator.SetInteger("NumberAnim", 4);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            animator.SetInteger("NumberAnim", 5);
        }
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
            Debug.Log(currentAnim);
        }
    }
}