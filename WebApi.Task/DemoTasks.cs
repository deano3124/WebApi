using WebApi.Interfaces;
using WebApi.Interfaces.Models;

namespace WebApi.Task
{
    public class DemoTasks : IDemoTasks
    {
        //private readonly INumbers Numbers;

        //public DemoTasks( INumbers numbers )
        //{
        //    Numbers = numbers;
        //}

        public ApiResultModel Number1()
        {
            var resultModel = new ApiResultModel();

            var number1 = "2";

            if ( number1 != "1" )
            {
                resultModel.Errors.Add( "WebConfig setting number1 != 1" );

                return resultModel;
            }

            resultModel.Details.Add( "WebConfig setting number1 = 1" );

            return resultModel;
        }

    }
}
