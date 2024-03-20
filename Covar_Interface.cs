namespace Covariation
{
    public interface IZoo<out dType>
    {
        dType ZooAnimal { get; }
    }

    public class Zoo<dType> : IZoo<dType>
    {
        private dType zooAnimal;

        public Zoo(dType zooAnimal)
        {
            this.zooAnimal = zooAnimal;
        }

        public dType ZooAnimal
        {
            get {  return this.zooAnimal; } 
        }
    }
}
