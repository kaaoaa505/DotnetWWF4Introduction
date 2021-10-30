using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace WorkflowConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity sequenceDelayActivity = new Workflow1();
            WorkflowInvoker.Invoke(sequenceDelayActivity);

            Console.WriteLine("----- Workflow 1 end.");

            Activity flowchartActivity = new FlowChartWorkflow();
            WorkflowInvoker.Invoke(flowchartActivity);

            Console.WriteLine("----- Workflow 2 end.");

            Activity stateMachineWorkflow = new StateMachineWorkflow();
            WorkflowInvoker.Invoke(stateMachineWorkflow);

            Console.WriteLine("----- Workflow 3 end.");

            Console.ReadLine();
        }
    }
}
