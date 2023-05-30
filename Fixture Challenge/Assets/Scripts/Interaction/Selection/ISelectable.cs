namespace IWD.FixtureChallenge.Interaction
{

    public interface ISelectable 
    {
        bool IsSelected { get; }
        void Select();
        void Deselect();
    }

}