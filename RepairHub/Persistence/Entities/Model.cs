namespace ConsoleServiceTool.RepairHub.Persistence.Entities
{
    public abstract class Model<TIdType> 
    {
        protected Model()
        {

        }
        protected Model(TIdType id) {
            Id = id;
        }
        public TIdType? Id { get; init; }

    }
}
