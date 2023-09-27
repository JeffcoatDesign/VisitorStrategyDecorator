namespace Chapter.Visitor
{
    public interface IVisitor
    {
        void Visit(BikeShield bikeshield);
        void Visit(BikeEngine bikeEngine);
        void Visit(BikeWeapon bikeWeapon);
    }
}