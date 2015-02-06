namespace Refactoring_2
{

    class ConditionStatements
    {
        static void Main()
        {
            Potato potato;

            if (potato == null)
            {
                //..
            }
            else
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            bool inRangeX = MIN_X <= x && x <= MAX_X;
            bool inRangeY = MIN_Y <= y && y  <= MAX_Y;

            if (inRangeX && inRangeY && shouldVisitCell)
            {
                 VisitCell(); 
            }

        }
    }
}
