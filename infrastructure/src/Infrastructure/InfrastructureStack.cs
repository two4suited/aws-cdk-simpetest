using Amazon.CDK;
using Amazon.CDK.AWS.SQS;

namespace Infrastructure
{
    public class InfrastructureStack : Stack
    {
        internal InfrastructureStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var queue = new Queue(this,"test",new QueueProps()
                {
                    QueueName = "TestQueue"
                });
        }
    }
}
