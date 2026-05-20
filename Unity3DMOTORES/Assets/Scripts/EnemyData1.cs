using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData1", menuName = "Scriptable Objects/EnemyData1")]
public class EnemyData1 : ScriptableObject
{


    [SerializeField] float MaxHealth;
    [SerializeField] float Damage;


    public float GetMaxHealth() {  return MaxHealth; }
    public float GetDamage() { return Damage; }
}
