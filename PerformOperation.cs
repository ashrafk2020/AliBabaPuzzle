class PerformOperation
{
    Operations[] operationArray ;
    public PerformOperation()
    {
        operationArray = new Operations[]{
                                    new Operations{firstOperation = "add", secondOperation = "sub"},
                                    new Operations{firstOperation = "sub", secondOperation = "add"},
                                    new Operations{firstOperation = "multi", secondOperation = "add"},
                                    new Operations{firstOperation = "multi", secondOperation = "sub"},
                                    new Operations{firstOperation = "sub", secondOperation = "multi"},
                                    new Operations{firstOperation = "add", secondOperation = "multi"},


                                    };
        
    }


    public struct Operations
    {
       public string firstOperation   ;
       public string secondOperation  ;
    }



    public int PerformOperationForNumbers(int operationIndex , int firstNumber, int secondNumber, int thirdNumber)
    {
       
        string firstOperation = operationArray[operationIndex].firstOperation;
        

        string secondOperation = operationArray[operationIndex].secondOperation;

        int resultOfFirstAndSecondNumbers = 0;
        int resultOfsecondAndThirdNumbers = 0;
        int totalTesult = 0;
        bool doneFirstTwoNumbers = false;
        bool doneSecondTwoNumbers = false;

        if(firstOperation =="multi")
        {
            resultOfFirstAndSecondNumbers = firstNumber * secondNumber;
            doneFirstTwoNumbers = true;
        }
        else if(secondOperation == "multi")
        {
            resultOfsecondAndThirdNumbers = secondNumber * thirdNumber;
            doneSecondTwoNumbers = true;
        }

       if(doneFirstTwoNumbers)
       {
            switch (secondOperation)
            {
                case "add":
                    totalTesult = resultOfFirstAndSecondNumbers + thirdNumber;
                  
                    break;

                case "sub":
                    totalTesult = resultOfFirstAndSecondNumbers - thirdNumber;
                  

                    break;
                default:
                    break;
            }
           

            return totalTesult;

         }
         if(doneSecondTwoNumbers)
         {
            switch (firstOperation)
            {
                case "add":
                      totalTesult = firstNumber+ resultOfsecondAndThirdNumbers ;
                    break;

                case "sub":
                      totalTesult = firstNumber - resultOfsecondAndThirdNumbers ;

                  

                    break;
                default:
                    break;
            }
           

            return totalTesult;


        }



        switch (firstOperation)
        {
            case "add":
                 resultOfFirstAndSecondNumbers = firstNumber + secondNumber;
            break;

            case "sub":
                 resultOfFirstAndSecondNumbers = firstNumber - secondNumber;

            break;
            default:
            break;
        }

       

         switch (secondOperation)
        {
            case "add":
                  totalTesult =  resultOfFirstAndSecondNumbers + thirdNumber;
                 
            break;

            case "sub":
                  totalTesult =  resultOfFirstAndSecondNumbers - thirdNumber;
                  

            break;
             default:
            break;
        }
        
        return totalTesult;
    }


    
}