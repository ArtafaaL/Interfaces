namespace Contrvariation
{
    public interface IZoo<in dType>
    {
        dType ZooAnimal { set; }
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
            set { this.zooAnimal = value; }
        }
    }
}
