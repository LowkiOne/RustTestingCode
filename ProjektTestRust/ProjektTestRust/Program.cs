public class AllItemsInRust
{
    public string WeaponsNames { get; set; }
    public string AmmoNames { get; set; }
    public string ArmorNames { get; set; }
    public string FarmingResorcesNames { get; set;}
    public string CraftingResorcesNames { get; set;}
    public string ComponentNames { get; set; }
    public string ItemsCraftedNames { get; set;}
    public string ElectronicItemsNames { get; set;}
    public string BuildingNames { get; set;}

}

public class DamageNumbers
{
    public double RangedWeaponDamgage { get; set; }
    public double MeleeWeaponDamage { get; set; }  
    public double ExplosiveDamage { get; set; }

}

public class HealthOnAll
{
    public double BaseBuildingHealth { get; set; }
    public double PlayerHealth { get; set; }
    public double VehicleHealh { get; set; }
    public double PlaceableItemsHealth { get; set; }

}