namespace EFCoreRelationships
{
    public class CreateWeaponDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
    }
}