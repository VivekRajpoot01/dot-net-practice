namespace LPU_Exceptions
{
    ///<summary>
    ///Custom Exception Class Created for LPU Project 
    ///By Vivek on Date 29/12/2025 at 11:45AM 
    ///</summary>

    public class LpuException:Exception
    {
        public LpuException()
        {
            
        }

        public LpuException(string errorMsg):base(errorMsg)
        {
            
        }
    }
}
