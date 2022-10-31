namespace Abstracts
{
    public interface IMovable
    {
        float MoveSpeed { get; set; }

        void PlayerMovement();
    }
}
