using System.ServiceModel;

namespace ConceptArchitect.Services
{
    [ServiceContract]
    public interface IBasicGreetService
    {
        [OperationContract]
        string Welcome(string name);

    }

    [ServiceContract]
    public interface IGreetService
    {

        [OperationContract]
        string Welcome(string name);


        [OperationContract]
        string GoodBye(string name);

        // [OperationContract] <------- NOT a operation contract
        string GetOut(string name);
        
        
    }
    [ServiceContract]
    public interface ITimedGreetService
    {
        [OperationContract]
        string TimedGreet(string name);
    }
}