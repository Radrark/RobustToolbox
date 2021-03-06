namespace Robust.Shared.GameObjects.Components
{
    public class CollisionChangeMessage : EntitySystemMessage
    {
        public EntityUid Owner { get; }
        public bool CanCollide { get; }

        public CollisionChangeMessage(EntityUid owner, bool canCollide)
        {
            Owner = owner;
            CanCollide = canCollide;
        }
    }
}